create table #table1 (Q varchar(200), choice varchar(50))

insert into #table1
exec Exam_v2_generation 'C#', 1, 2

create table #table2 (q_id int, row_num int identity)

insert into #table2 (q_id)
select distinct Q_id from Questions
where Question in (select Q from #table1)

--select * from #table1
--select * from #table2
--drop table #table1
--drop table #table2
create proc ExamAnswers_v2_sp @exam_id int, @std_id int, @answer varchar(50)
as
begin
	if @exam_id in (select exam_id from Exam)
		begin
			if @std_id in (select std_id from Student)
				begin
					declare @q_id int = (select top(1) q_id from #table2)

					insert into exam_Q_std
					(std_id, exam_id, Q_ID, std_answer)
					values(@std_id, @exam_id, @q_id, @answer)

					delete from #table2 where q_id = @q_id
				end
			else
			print 'You have entered student that does not exist'
		end
	else
		print 'You have entered exam that does not exist'
end


