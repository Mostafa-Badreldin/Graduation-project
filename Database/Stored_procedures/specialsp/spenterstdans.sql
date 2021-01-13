
create procedure ExamAnswer_sp @exam_id int ,@std_id int  ,@std_answer nvarchar(50)
as 
begin
declare @q_id int = (select top(1)Q_id from	Questions where flag=1)
update Questions
set flag=0
where Q_id=@q_id

if @exam_id in (select max(exam_id) from Exam)
	begin
		if @std_id in (select std_id from Student)
			
			begin
			insert into exam_Q_std(std_id,exam_id,Q_ID,std_answer)
			values (@std_id,@exam_id,@q_id,@std_answer)
			end
		else
		print'you enter student that not exist'
	end
else
print 'you enter exam id that not exist'

end 
