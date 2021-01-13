create PROCEDURE ExamGeneration_sp @Crs_name nvarchar(50), @MCQ int, @T_F int,@exam_duration int
AS
BEGIN
   declare @exam_check int
	set  @exam_check = (select max(exam_id) from Exam)
	if @exam_check in (select exam_id from exam_Q_std)
		begin
			update Questions
			set flag =0
			 if @Crs_name in (select crs_name from Course)
								BEGIN

									if @MCQ >=0 and @MCQ<=(select count(Q_type) from Questions q ,Course c where c.crs_id=q.crs_id and c.crs_name=@Crs_name and q.Q_type='MCQ') AND
										  @T_F >=0 and @T_F<=(select count(Q_type) from Questions q ,Course c where c.crs_id=q.crs_id and c.crs_name=@Crs_name and q.Q_type='T/F')
											begin
													update Questions
													set flag =1
													where Q_id in (
													Select * From (
													SELECT TOP (@MCQ) Q_id FROM Questions q , Course c WHERE Q_type = 'MCQ' and crs_name = @Crs_name and q.crs_id = c.crs_id ORDER BY NEWID()
													UNION all
													SELECT TOP (@T_F) Q_id FROM Questions q ,Course c WHERE Q_type = 'T/F' and crs_name = @Crs_name and q.crs_id = c.crs_id ORDER BY NEWID()) X)
											
													--this part must be here not in the other gene out because it must make sure the above contions is true to generate examid
													declare @x int
													set @x = (select max(exam_id)+1 from Exam)
													insert into Exam
													values ( @x ,@exam_duration)
											end
									else 
									print'you enter number of question wrong'
								END			
			else 
			print'you enter course name that does not exist'
		end
	else
	print 'first solve the ceated exam then generate another one'
END


create procedure Examshow_sp @exam_id int
as 

begin 
if @exam_id in (select exam_id from exam_Q_std) and  @exam_id in (select exam_id from Exam)
		begin
				select e.exam_id ,e.Q_ID ,q.Question ,qc.choice
				from exam_Q_std e , Questions q ,Question_choices qc
				where e.Q_ID =q.Q_id and e.exam_id=@exam_id and e.Q_ID=qc.Q_id
		end 
else
		begin
				if @exam_id not in (select exam_id from exam_Q_std) and  @exam_id in (select exam_id from Exam)
						begin
						    select e.exam_id ,q.Q_id,q.Question ,qc.choice
							from Exam e , Questions q ,Question_choices qc
							where e.exam_id =@exam_id and q.flag=1 and q.Q_id=qc.Q_id
						end 
                else
				  if @exam_id not in (select exam_id from exam_Q_std) and  @exam_id not in (select exam_id from Exam)
				  print'error'
				  else
				  if @exam_id  in (select exam_id from exam_Q_std) and  @exam_id  not in (select exam_id from Exam)
				  print'error'
		end
end









