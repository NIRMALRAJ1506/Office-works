
1.	create a fresh database titled "university_db" or any other appropriate name.


create database university_db;


Table Creation:

1. Create a "students" table with the following fields:

CREATE TABLE students (
student_id SERIAL PRIMARY KEY,
student_name VARCHAR(100),
age INTEGER,
email VARCHAR(100),
frontend_mark INTEGER,
backend_mark INTEGER,
status VARCHAR(50);

CREATE TABLE

2.	Create a "courses" table with the following fields:

CREATE TABLE courses (
course_id SERIAL PRIMARY KEY,
course_name VARCHAR(100),
 credits INTEGER);

CREATE TABLE

3. Create an "enrollment" table with the following fields:

CREATE TABLE enrollment (
enrollment_id SERIAL PRIMARY KEY,
student_id INTEGER REFERENCES students(student_id),
course_id INTEGER REFERENCES courses(course_id));

CREATE TABLE


4.	Insert the data into the "students" table:

INSERT INTO students (student_name, age, email, frontend_mark, backend_mark, status)
VALUES
('Nirmal Raj', 24, 'nirmal@gmail.com', 95, 90, NULL),
('Ikfan', 23, 'ikfan@gmail.com', 99, 98, NULL),
('Sanjai', 23, 'sanjai@gmail.com', 100, 100, NULL),
('Kamalesh', 23, 'saala@gmail.com', 98, 89, NULL),
('Hamsavanan', 23, 'hamsa@gmail.com', 88, 98, NULL),
('Gokul', 23, 'gokul@gmail.com', 90, 80, NULL);

INSERT 0 6

5.	Insert the following data into the "courses" table:


INSERT INTO courses (course_name, credits)
VALUES
('Html Css', 3),
('React.js', 4),
('Databases', 3),
('Python', 3);

INSERT 0 4

6.	Insert the following data into the "enrollment" table:

INSERT INTO enrollment (student_id, course_id)
VALUES
(1, 1),
(1, 2),
(2, 1),
(3, 2);

INSERT 0 4


Query 1:
	Insert a new student record with the following details:
		•	Name: Sandhya Suresh
		•	Age: 23
		•	Email: sandhya@gmail.com
		•	Frontend-Mark: 85
		•	Backend-Mark: 90
		•	Status: NULL

INSERT INTO students (student_name, age, email, frontend_mark, backend_mark, status)
VALUES ('Sandhya Suresh', 23, 'sandhya@gmail.com', 85, 90, NULL);

INSERT 0 1

Query 2:
	Retrieve the names of all students who are enrolled in the course titled 'Html css'.


SELECT s.student_name
FROM students s
JOIN enrollment e ON s.student_id = e.student_id
JOIN courses c ON e.course_id = c.course_id
WHERE c.course_name = 'Html Css';

  student_name
--------------
 Nirmal Raj
 Ikfan
(2 rows)



Query 3:
	Update the status of the student with the highest total (frontend_mark + backend_mark) mark to 'Awarded'


UPDATE students
SET status = 'Awarded'
WHERE student_id = (
SELECT student_id
FROM (
SELECT student_id, (frontend_mark + backend_mark) AS total_mark
FROM students
ORDER BY total_mark DESC
LIMIT 1
) AS highest_mark
 );

UPDATE 1


Query 4:
	Delete all courses that have no students enrolled.


DELETE FROM courses
WHERE course_id NOT IN (SELECT DISTINCT course_id FROM enrollment);

DELETE 2


Query 5:
	Retrieve the names of students using a limit of 2, starting from the 3rd student.


SELECT student_name
FROM students
ORDER BY student_id
LIMIT 2 OFFSET 2;

 student_name
--------------
 Rahul
 Deva
(2 rows)

Query 6:
	Retrieve the course names and the number of students enrolled in each course.



SELECT c.course_name, COUNT(e.student_id) AS students_enrolled
FROM courses c
LEFT JOIN enrollment e ON c.course_id = e.course_id
GROUP BY c.course_name;
 course_name | students_enrolled
 
-------------+-------------------
 Html Css     |                 2
 React.js    |                 2
(2 rows)


Query 7:
	Calculate and display the average age of all students.


SELECT AVG(age) AS average_age
FROM students;
     average_age
	 
---------------------
 23.0000000000000000
(1 row)


Query 8:
	Retrieve the names of students whose email addresses contain 'gmail.com'.


SELECT student_name
FROM students
WHERE email LIKE '%gmail.com';

  student_name
----------------
 Nirmal Raj
 Ikfan
 Kamalesh
 Hamsavanan
 Gokul
 Sandhya Suresh
 Sanjai
(7 rows)


