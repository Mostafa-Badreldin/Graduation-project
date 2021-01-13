---- select procedures

--- 1) course table

create proc course_select_sp
as
begin
	select * 
	from Course
end

--- 2) Department table

create proc department_select_sp
as
begin
	select *
	from Department
end

--- 3) Exam table

create proc exam_select_sp
as
begin
	select *
	from Exam
end

--- 4) Exam_Q_std table

create proc exam_Q_std_select_sp
as
begin
	select *
	from exam_Q_std
end

--- 5) Instructor table

create proc instructor_select_sp
as
begin
	select *
	from Instructor
end



--- 6) Instructor_course table

create proc instructor_Course_select_sp
as
begin
	select *
	from Instructor_Course
end



--- 7) Question_choices table

create proc question_choices_select_sp
as
begin
	select * 
	from Question_choices
end



--- 8) Questions table

create proc questions_select_sp
as
begin
	select *
	from Questions
end



--- 9) Student table

create proc student_select_sp
as 
begin
	select *
	from Student
end


--- 10) Student_course table

create proc student_course_select_sp
as
begin
	select *
	from student_course
end

--- 11) Topic table

create proc topic_select_sp
as
begin
	select *
	from Topic
end



-----------------------------------------------------------------