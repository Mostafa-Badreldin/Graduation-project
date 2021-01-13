create procedure course_insert_sp  @crs_name nvarchar(50),@crs_duration int
as 
begin

if @crs_name not in (select crs_name from Course)
    begin
	insert into   Course 
	values((select max(crs_id)+1 from Course) ,@crs_name,@crs_duration)
	end


else
	begin
		print 'row already exist '
	 end

end;


/*///////////////////////////////////////////////////////////////////////////////////////////////////////////////////\*/

create procedure department_insert_sp @dept_name nvarchar(50) ,@dept_location nvarchar(50) ,@dept_manager int
as 
begin
if @dept_manager in (select  Ins_id from Instructor)
	 begin
		if @dept_name not in (select dept_name from Department)
			begin
			insert into   Department (dept_id,dept_name,dept_location,dept_manager)
			values((select max(dept_id)+1 from Department),@dept_name,@dept_location,@dept_manager)
			end
			else
			print  'row already exist'
	 end
else 
begin
print 'department_manager_id you try to enter is not exist'
end
end;
/*///////////////////////////////////////////////////////////////////////////////////////////////////////////////////\*/

create  procedure exam_insert_sp  @exam_id int ,@exam_duration int
as 
begin
	if @exam_id not in (select exam_id from Exam) /*we can delete this condition cause it is applied by PK constraint*/
		begin
			if @exam_id = (select max(exam_id)+1 from Exam)/*this row to ensure that @exam_id is going in sequence of pk of exam not dropping number from sequence'*/
				begin
					insert into   Exam (exam_id,exam_duration)
					values(@exam_id,@exam_duration)
				end
           else 
		   print 'you try to enter wrong exam id'
		end
	else
	print  'row already exist'
end;

/*///////////////////////////////////////////////////////////////////////////////////////////////////////////////////\*/

create procedure instructor_insert_sp  @ins_name nvarchar(50),@ins_salary int,@dept_id int
as 
begin
if @dept_id in (select  dept_id from Department)
	 begin
		
			insert into Instructor (Ins_id,Ins_name,salary,dept_id)
			values((select max(Ins_id)+1 from Instructor),@ins_name,@ins_salary,@dept_id)
			end
			
	 
else 
begin
print 'department_id you try to enter is not exist'
end
end;
/*///////////////////////////////////////////////////////////////////////////////////////////////////////////////////\*/
 
 create procedure exam_q_std_insert_sp  @std_id int ,@exam_id int,@q_id int,@std_q_grade int,@std_answer nvarchar(200)
as 
begin 
     if @std_id  in (select std_id from Student) and @exam_id  in (select exam_id from Exam) and @q_id  in (select	Q_id from Questions)
	 begin 
	        insert into  exam_Q_std(std_id,exam_id,Q_ID,std_Q_grade,std_answer)
			values(@std_id,@exam_id,@q_id,@std_q_grade,@std_answer)
	
	 end

	 else 
	 begin
	 print 'you try to enter wrong data'
	 end
end;
/*///////////////////////////////////////////////////////////////////////////////////////////////////////////////////\*/
create procedure instructor_course_insert_sp @ins_id int ,@crs_id int , @evaluation nvarchar(50)
as
begin
if @ins_id in (select Ins_id from Instructor)
	begin 
		if @crs_id in (select crs_id from Course)
			begin 
			insert into Instructor_Course(ins_id,crs_id,evaluation)
			values(@ins_id,@crs_id,@evaluation)
			end
		else
		print 'course you try to enter is not exist'
	end
else 
print 'instructor id you try to enter is not exist'
end 
/*///////////////////////////////////////////////////////////////////////////////////////////////////////////////////\*/

create procedure question_choices_insert_sp @q_id int ,@choice nvarchar(200), @choice_id int
as 
begin 
if @q_id in (select Q_id from Questions)
	begin	
			insert into Question_choices (Q_id,choice,choice_id)
			values(@q_id,@choice,@choice_id)
	end
else 
print 'you try to enter answer that does not relate to an existing question'
end
/*///////////////////////////////////////////////////////////////////////////////////////////////////////////////////\*/

create procedure questions_insert_sp @q_id int ,@question nvarchar(200) ,@model_answer nvarchar(200) ,@q_type nvarchar(50),@q_grade int,@crs_id int
as 
begin 
if @crs_id in (select crs_id from Course)
	begin 
		if  @question not in (select Question from Questions)
			begin
			insert into Questions (Q_id,Question,model_answer,Q_type,Q_grade,crs_id,flag)
			values(@q_id,@question,@model_answer,@q_type,@q_grade,@crs_id,0)
			end
       else 
	   print 'you try to enter already existing question'
	end
else 
print' you try to enter question for not existing course'
end
/*///////////////////////////////////////////////////////////////////////////////////////////////////////////////////\*/

create procedure student_insert_sp @std_fname nvarchar(50), @std_lname nvarchar(50) ,@std_age int ,@dept_id int
as 
begin 
if @dept_id in (select dept_id from Department)
	begin 
		
			insert into Student(std_id,std_fname,std_lname,std_age,dept_id)
			values((select max(std_id)+1 from Student),@std_fname,@std_lname,@std_age,@dept_id)

			
	end
else 
print 'you try to enter not existing department'
end 
/*///////////////////////////////////////////////////////////////////////////////////////////////////////////////////\*/
create procedure student_course_insert_sp @std_id int , @crs_id int ,@grade_overall int
as 
begin 
if @std_id in (select std_id from Student)
	begin
		if @crs_id in (select crs_id from Course)
			begin 
			insert into student_course (std_id,crs_id,grade_overall)
			values(@std_id,@crs_id,@grade_overall)
			end
		else 
		print ' you try to enter not existing course'

	end
else
print'you try not existing student'
end 
/*///////////////////////////////////////////////////////////////////////////////////////////////////////////////////\*/
create procedure topic_insert_sp  @topic_name nvarchar(50) , @crs_id int
as
begin 
	if @crs_id in (select crs_id from Course)
		BEGIN 
		insert into Topic (topic_id,topic_name,crs_id)
		values((select max(topic_id)+1 from Topic),@topic_name,@crs_id)

		END
	else 
	print 'you try enter topic that does not relate to any course'
end 
/*///////////////////////////////////////////////////////////////////////////////////////////////////////////////////\*/

