CREATE DATABASE examination_system

create table Instructor
  (Ins_id int primary key,
  Ins_name nvarchar(50),
  salary int ,
  dept_id int,
  );

alter table Instructor 
add constraint FK_dept_id FOREIGN KEY (dept_id) REFERENCES Department(dept_id)
on update no action  on delete set null;

create table Department 
( dept_id int primary key,
  dept_name nvarchar(50) NOT NULL UNIQUE,
  dept_location nvarchar(50),
  dept_manager int ,
  FOREIGN KEY (dept_manager) REFERENCES Instructor(Ins_id)
  on update no action  on delete set null);

create table Course
  ( crs_id int primary key,
  crs_name nvarchar(50) UNIQUE,
  crs_duration int,
  course_grade int default 100);

create table Topic
  ( topic_id int primary key,
     topic_name nvarchar(50) UNIQUE,
	 crs_id int ,
	 FOREIGN KEY (crs_id) REFERENCES Course(crs_id)
	 on update no action on delete cascade);

create table Instructor_Course
	 (ins_id int ,
	  crs_id int,
	  evaluation nvarchar(50),
	  FOREIGN KEY (ins_id) REFERENCES Instructor (Ins_id)
	  on update no action on delete cascade,
	  FOREIGN KEY (crs_id) REFERENCES Course(crs_id)
	  on update no action on delete cascade,
	  primary key (ins_id, crs_id));

create table Student
	  (std_id int primary key,
	  std_fname nvarchar(50),
	  std_lname nvarchar(50),
	  std_age int ,
	  dept_id int,
	  FOREIGN KEY (dept_id) REFERENCES Department(dept_id)
	  on update no action  on delete set null);

create table student_course
	  (std_id int ,
	  crs_id int ,
	  grade_overall int ,
	  student_status nvarchar(50) default 'no exam yet',
	  FOREIGN KEY (std_id) REFERENCES Student(std_id)
	  on update no action on delete cascade,
	  FOREIGN KEY (crs_id) REFERENCES Course(crs_id)
	  on update no action on delete cascade,
	  primary key (std_id, crs_id) );

create table Questions
	  (Q_id int primary key,
		Question nvarchar(50) UNIQUE,
		model_answer nvarchar(200),
		Q_type nvarchar(50),
		Q_grade int ,
		crs_id int,
		flag int default 0,
		FOREIGN KEY (crs_id) REFERENCES Course(crs_id)
		on update no action on delete cascade);

create table Question_choices
			( Q_id int,
			  choice_id int,
			  choice nvarchar(200),
			  FOREIGN KEY (Q_id) REFERENCES Questions(Q_id)
			  on update no action on delete cascade,
			  primary key (Q_id, choice) );

create table Exam 
		(exam_id int primary key ,
		exam_duration int);

create table exam_Q_std
(std_id int ,
 exam_id int,
 Q_ID int,
 std_Q_grade int ,
 std_answer nvarchar(200),
 exam_corrected int default 0,
 FOREIGN KEY (std_id) REFERENCES Student(std_id)
 on update no action on delete cascade,
 FOREIGN KEY (exam_id) REFERENCES Exam(exam_id)
 on update no action on delete cascade,
 FOREIGN KEY (Q_ID) REFERENCES Questions(Q_id)
 on update no action on delete cascade,
 primary key (std_id, exam_id,Q_ID)
 );