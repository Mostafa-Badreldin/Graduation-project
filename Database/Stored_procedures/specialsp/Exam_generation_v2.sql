create proc Exam_v2_generate_exid @crs_name varchar(50), @t_f int, @mcq int, @exam_duration int
as
begin
	if exists (select crs_name from Course where crs_name = @crs_name)
		begin
			if (@t_f >= 0) and @t_f < (select COUNT(q.Q_id) from Questions q, Course c where q.Q_type = 't/f' and q.crs_id = c.crs_id and c.crs_name = @crs_name)
				begin
					if (@mcq > 0) and @mcq < (select COUNT(q.Q_id) from Questions q, Course c where q.Q_type = 'mcq' and q.crs_id = c.crs_id and c.crs_name = @crs_name)
						begin
							exec Exam_v2_generation @crs_name , @t_f, @mcq
	
							declare @exam_id int = (select MAX(exam_id)+1 from Exam)

							insert into Exam
							values(@exam_id, @exam_duration)
						end
					else
						print 'Please enter a valid MCQ question number'
				end
			else
				print 'Please enter a vild T/F question number'
		end
	else
		print 'You have entered course name that does not exist'
end

create proc Exam_v2_generation @crs_name varchar(50), @t_f int, @mcq int
as
begin
if exists (select crs_name from Course where crs_name = @crs_name)
	begin
		if (@t_f >= 0) and @t_f < (select COUNT(q.Q_id) from Questions q, Course c where q.Q_type = 't/f' and q.crs_id = c.crs_id and c.crs_name = @crs_name)
			begin
				if (@mcq > 0) and @mcq < (select COUNT(q.Q_id) from Questions q, Course c where q.Q_type = 'mcq' and q.crs_id = c.crs_id and c.crs_name = @crs_name)
					begin
						declare @table table (Q_ID int)
	
						insert into @table
						select * from
						(select top(@t_f) q.Q_id
						from Questions q, Course c
						where q.crs_id = c.crs_id and q.Q_type = 't/f'
						and c.crs_name = @crs_name
						order by NEWID()
						union
						select top(@mcq) q.Q_id
						from Questions q, Course c
						where q.crs_id = c.crs_id and q.Q_type = 'mcq'
						and c.crs_name = @crs_name
						order by NEWID()) x
	
						select q.Question, qc.choice
						from Questions q, Question_choices qc
						where q.Q_id = qc.Q_id and q.Q_id in(select * from @table)
					end
				else
					print 'Please enter a valid MCQ question number'
			end
		else
			print 'Please enter a vild T/F question number'
	end
else
	print 'You have entered course name that does not exist'
end

create table #tmpID (Q_ID int)
create proc Exam_v3_generation @crs_name varchar(50), @t_f int, @mcq int
as
begin
if exists (select crs_name from Course where crs_name = @crs_name)
	begin
		if (@t_f >= 0) and @t_f < (select COUNT(q.Q_id) from Questions q, Course c where q.Q_type = 't/f' and q.crs_id = c.crs_id and c.crs_name = @crs_name)
			begin
				if (@mcq > 0) and @mcq < (select COUNT(q.Q_id) from Questions q, Course c where q.Q_type = 'mcq' and q.crs_id = c.crs_id and c.crs_name = @crs_name)
					begin
						truncate table #tmpID

						insert into #tmpID
						select * from
						(select top(@t_f) q.Q_id
						from Questions q, Course c
						where q.crs_id = c.crs_id and q.Q_type = 't/f'
						and c.crs_name = @crs_name
						order by NEWID()
						union
						select top(@mcq) q.Q_id
						from Questions q, Course c
						where q.crs_id = c.crs_id and q.Q_type = 'mcq'
						and c.crs_name = @crs_name
						order by NEWID()) x

						select q.Question, qc.choice
						from Questions q, Question_choices qc
						where q.Q_id = qc.Q_id and q.Q_id in (select * from #tmpID)
					end
				else
					print 'Please enter a valid MCQ question number'
			end
		else
			print 'Please enter a vild T/F question number'
	end
else
	print 'You have entered course name that does not exist'
end


