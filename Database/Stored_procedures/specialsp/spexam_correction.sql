
create proc ExamCorrection_sp @exam_id int ,@std_id int
as 
begin
if (select top(1) exam_corrected from exam_Q_std where exam_id=@exam_id and std_id=@std_id)=0
begin

		DECLARE exam_ans CURSOR FOR     
		select q.model_answer,q.Q_grade ,e.std_answer ,e.Q_ID
		from Questions q ,exam_Q_std e 
		where e.Q_ID=q.Q_id and exam_id=@exam_id and std_id=@std_id 

		declare @qs nvarchar(50)
		declare @stan nvarchar(50)
		declare @g int
		declare @qid int


		OPEN exam_ans    
		FETCH NEXT FROM exam_ans     
		INTO @qs, @g,@stan,@qid 
		WHILE @@FETCH_STATUS = 0    
		BEGIN    
			if trim(' ' from lower(@qs) )=trim(' ' from lower(@stan))
				UPDATE exam_Q_std 
				set std_Q_grade = @g
				where exam_id=@exam_id and std_id=@std_id and Q_ID=@qid
		   else
		   UPDATE exam_Q_std 
				set std_Q_grade = 0
				where exam_id=@exam_id and std_id=@std_id and Q_ID=@qid
      
			FETCH NEXT FROM exam_ans     
			INTO @qs, @g,@stan ,@qid 
		END     
		CLOSE exam_ans;    
		DEALLOCATE exam_ans; 

		update exam_Q_std
		set exam_corrected=1
		where exam_id=@exam_id and std_id=@std_id

		exec ExamCorrection_calc_std_garde_sp @std_id,@exam_id --after exam is corrected we need to sum std_q_grade in that exam accoding to crs_id and put result in studet_course table
end
else 
print 'exam for this student is already corrected'
end




create proc ExamCorrection_calc_std_garde_sp @std_id int,@exam_id int
as 
begin
declare  @crs_id int 
declare @grade int 

set @crs_id=(select top(1)crs_id 
from Questions q,exam_Q_std e
WHERE q.Q_id=e.Q_ID and e.std_id=@std_id and e.exam_id=@exam_id)
set @grade = ( select sum(std_Q_grade) from exam_Q_std  where std_id=@std_id and exam_id=@exam_id)
update student_course
set grade_overall=grade_overall+@grade
where std_id=@std_id and crs_id=@crs_id

if (select grade_overall from student_course where std_id=@std_id and crs_id=@crs_id)> 0 and 
(select grade_overall from student_course where std_id=@std_id and crs_id=@crs_id) >=0.25*(select course_grade from Course where crs_id=@crs_id)
		begin 
		update student_course
		set student_status='passed'
		where std_id=@std_id and crs_id=@crs_id

		end 
else
begin 
        update student_course
		set student_status='failed'
		where std_id=@std_id and crs_id=@crs_id
end


end



   