create proc student_course_update_sp @std_id int, @crs_id int, @grade int
as
begin
		if @std_id in (select std_id from Student)
			begin
				  if @crs_id in (select crs_id from Course)
					  begin
						  if @std_id not in (select std_id from student_course where crs_id = @crs_id) and @crs_id not in (select crs_id from student_course where std_id = @std_id)
							  begin
							  insert into student_course
							  values (@std_id,@crs_id,@grade)
							  end
                         else
						 update student_course
						 set grade_overall = @grade
						 where std_id=@std_id and crs_id= @crs_id
					  end
				else
				print 'Course does not exist' 
			end
		else
		print 'Student does not exist'
end
/*-----------------------------------------------------------------*/
create proc instructor_update_sp @ins_id int, @ins_name nvarchar(50), @salary int, @dept_id int
as 
begin  
if @dept_id in (select dept_id from Department)
	begin
			if @ins_id not  in (select ins_id from Instructor)
			insert into Instructor
			values (@ins_id, @ins_name, @salary, @dept_id)
			else
			update Instructor
			set Ins_name=@ins_name, salary=@salary, dept_id=@dept_id
			where Ins_id=@ins_id
	end
else
print 'Department does not exist'
end
/*--------------------------------------------------------------*/
create proc exam_q_std_update_sp @std_id int,@exam_id int, @q_id int , @std_q_grade int,@std_answer nvarchar(50) 
as
begin 
if @std_id in (select std_id from Student) and @exam_id in (select exam_id from Exam) and @q_id in (select Q_id from Questions)
	begin
			if @std_answer not in (select std_answer from exam_Q_std where exam_id=@exam_id and std_id=@std_id and Q_ID=@q_id)
			insert into exam_Q_std
			values (@std_id, @exam_id, @q_id, @std_q_grade, @std_answer)
			else
			update exam_q_std
			set  std_q_grade=@std_q_grade
			where std_id=@std_id and exam_id=@exam_id and q_id=@q_id
	end
else
print 'You entered wrong data'
end
/*--------------------------------------------------------------*/
create proc exam_update_sp @exam_id int, @exam_duration int
as
begin
if @exam_id in (select exam_id from Exam)
BEGIN
		update Exam
		set exam_duration=@exam_duration
		where exam_id=@exam_id
END 
else
print 'Exam does not exist'
end
/*--------------------------------------------------------------*/
create proc question_update_sp @q_id int, @question nvarchar(200), @model_answer nvarchar(50), @q_type nvarchar(50), @q_grade int, @crs_id int
as
begin
if @crs_id in (select crs_id from Course)
		begin
		       if @q_id not in (select Q_id from Questions)
					begin
						if @question not in (select question from questions)
							insert into questions
							values (@q_id, @question, @model_answer, @q_type, @q_grade, @crs_id,0)
                        else
							begin
							print 'Question already exists'
							end
					end
				else
				begin
						if @question in (select question from questions where q_id = @q_id)
							begin
							update Questions
							set model_answer=@model_answer, Q_type=@q_type, Q_grade=@q_grade, crs_id=@crs_id
							where Q_id=@q_id
							end
                       else 
					   begin
							update Questions
							set Question=@question,model_answer=@model_answer, Q_type=@q_type, Q_grade=@q_grade, crs_id=@crs_id
							where Q_id=@q_id
							end
				end
		end
else 
print 'Course does not exist'
end
/*--------------------------------------------------------------*/
create proc instructor_course_update_sp @ins_id int, @crs_id int, @evaluation nvarchar(50)
as 
begin
if @ins_id in (select Ins_id from Instructor)
	begin
			if @crs_id in (select crs_id from Course)
				begin
					if @ins_id not in (select ins_id from Instructor_Course where crs_id = @crs_id) and @crs_id not in (select crs_id from Instructor_Course where ins_id = @ins_id)
						begin
						insert into Instructor_Course
						values (@ins_id, @crs_id, @evaluation)
						end
						else
						update Instructor_Course
						set evaluation=@evaluation
						where ins_id=@ins_id and crs_id=@crs_id
					end
				 else
		   print 'Course does not exist'
	end
else 
print 'Instructor does not exist'
end
/*-----------------------------------------------------------------------*/
create proc question_choices_update_sp @q_id int,@choice_id int , @choice nvarchar(50)
as
begin
if @q_id in (select Q_id from Questions)
	begin
		if @q_id in (select q_id from Question_choices)
		begin
			if @choice_id in (select choice_ID from Question_choices)
			begin
				if @choice not in (select choice from Question_choices where Q_id = @q_id)
				update Question_choices 
				set choice = @choice where Q_id = @q_id and choice_id = @choice_id
				else
				print 'Choice already exists'
			end
			else
			insert into Question_choices values (@q_id, @choice, @choice_id)
		end
		else
		insert into Question_choices values (@q_id, @choice, @choice_id)
	end
	else
	print 'Question does not exist'
end
/*-----------------------------------------------------------------------*/
create proc department_update_sp @dept_id int, @dept_name nvarchar(50), @dept_location nvarchar(50), @dept_manager int
as 
begin

if @dept_manager in (select Ins_id from Instructor)
		begin
			 if @dept_id in (select dept_id from Department)
					begin
						if @dept_name not in (select dept_name from Department)
						
								update Department
								set dept_name=@dept_name,dept_location=@dept_location,dept_manager=@dept_manager
								where dept_id=@dept_id  
                        else
								update Department
								set  dept_location=@dept_location,dept_manager=@dept_manager
								where dept_id=@dept_id  and dept_name=@dept_name
					end
			 else
			 insert into department
			 values (@dept_id,@dept_name,@dept_location,@dept_manager)
		end
else
print'Manager does not exist'
end
/*-----------------------------------------------------------------------*/
create  proc course_update_sp @crs_id int, @crs_name nvarchar(50), @crs_duration int 
as
begin
	if @crs_id not in (select crs_id from Course)
		begin
			if @crs_name not in (select crs_name from Course)
			insert into course 
			values (@crs_id,@crs_name,@crs_duration)
			else
			print 'Course name already exists'
		end
    else
	begin
		if @crs_name not in (select crs_name from Course)
			update Course
			set crs_name = @crs_name , crs_duration=@crs_duration
			where crs_id=@crs_id
		else
			update Course
			set crs_duration=@crs_duration
			where crs_id=@crs_id and crs_name = @crs_name
		end
end
/*-----------------------------------------------------------------------*/
create proc topic_update_sp @topic_id int, @topic_name nvarchar(50), @crs_id int
as
begin
	 if @crs_id in (select crs_id from Course)
	 begin
		if @topic_id not in (select topic_id from Topic)
		begin
			if @topic_name not in (select topic_name from Topic where topic_id = @topic_id)
			begin
				insert into Topic values (@topic_id, @topic_name, @crs_id)
			end
			else
			print 'Topic name already exists'
		end
		else
			begin
				if @topic_name in (select topic_name from Topic where topic_id = @topic_id)
				update Topic 
				set crs_id = @crs_id where topic_id = @topic_id and topic_name = @topic_name
				else
				update Topic 
				set topic_name = @topic_name ,crs_id = @crs_id where topic_id = @topic_id
			end
	 end
	 else
	 print 'Course does not exist'
end
/*-----------------------------------------------------------------------*/
create proc student_update_sp @std_id int, @std_fname nvarchar(50), @std_lname nvarchar(50), @std_age int, @dept_id int
as
begin
   if @dept_id in (select dept_id from Department)
	   begin
		if @std_id not in (select std_id from student)
				begin
					insert into student
					values (@std_id, @std_fname, @std_lname, @std_age, @dept_id)
				end
		else
				begin
					update student
					set std_fname=@std_fname, std_lname=@std_lname, std_age=@std_age, dept_id=@dept_id
					where std_id=@std_id
				end
	   end
       else
       print 'Department does not exist'
end