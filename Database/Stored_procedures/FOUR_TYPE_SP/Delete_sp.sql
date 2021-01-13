/*DELETE*/

/*1*/
CREATE PROCEDURE course_delete_sp @Crs_name varchar(50)
AS
BEGIN
DELETE FROM Course WHERE crs_name = @Crs_name
END 

/*2*/
CREATE PROCEDURE instructor_delete_sp @Ins_ID varchar(50)
AS
BEGIN
DELETE FROM Instructor WHERE Ins_id = @Ins_ID
END

/*3*/
CREATE PROCEDURE exam_delete_sp @Exam_ID int
AS
BEGIN
DELETE FROM Exam WHERE exam_id = @Exam_ID
END

/*4*/
CREATE PROCEDURE department_delete_sp @Dept_name int
AS
BEGIN
DELETE FROM Department WHERE dept_name = @Dept_name
END

/*5*/
CREATE PROCEDURE student_delete_sp @Std_ID int
AS
BEGIN
DELETE FROM Student WHERE std_id = @Std_ID
END

/*6*/
CREATE PROCEDURE topic_delete_sp @Topic_name int
AS
BEGIN
DELETE FROM Topic WHERE topic_name = @Topic_name
END

/*7*/
CREATE PROCEDURE questions_delete_sp @Q_ID int
AS
BEGIN
DELETE FROM Questions WHERE Q_id = @Q_ID
END

/*8*/
CREATE PROCEDURE question_choices_delete_sp @Q_ID int
AS
BEGIN
DELETE FROM Question_choices WHERE Q_id = @Q_ID
END

/*9*/
CREATE PROCEDURE student_course_delete_sp @Std_ID int, @crs_ID int
AS
BEGIN
DELETE FROM student_course WHERE crs_id = @crs_ID and std_id = @Std_ID
END	

/*10*/
CREATE PROCEDURE exam_Q_std_delete_sp @Std_ID int, @Exam_ID int, @Q_ID int
AS
BEGIN
DELETE FROM exam_Q_std WHERE Q_ID = @Q_ID and std_id = @Std_ID and exam_ID = @Exam_ID
END

/*11*/
CREATE PROCEDURE Instructor_course_delete_sp @Ins_ID int, @Crs_ID int
AS
BEGIN
DELETE FROM Instructor_course WHERE crs_id = @Crs_ID and ins_id = @Ins_ID
END
