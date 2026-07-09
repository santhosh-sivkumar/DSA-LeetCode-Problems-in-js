-- 									QUERIES RELATED TO DATABASE:
-- 1. To Create & Delete
-- CREATE DATABASE MyFirstDB;
-- DROP DATABASE MyFirstDB;
-- DROP SCHEMA MyFirstDB;
-- DROP SCHEMA IF EXISTS MyFirstDB;

-- 2. To Read
-- SHOW DATABASES;
-- SHOW SCHEMAS;

-- 3. To Use
-- USE MyFirstDB;
-- -----------------------------------------------------------------------------------------
-- 							         QUERIES RELATED TO TABLE:	
 
-- 1. READ TABLE:
-- USE Myfirstdb;
-- SHOW tables;

-- 2. CREATE TABLE:
-- CREATE TABLE Student(
-- 	Id INT PRIMARY KEY,
--     Name VARCHAR(30),
--     GPA DECIMAL(3,2)
-- );
--          (OR)
-- CREATE TABLE Student(
-- 	   Id INT,
--     Name VARCHAR(30),
--     GPA DECIMAL(3,2),
--     PRIMARY KEY(Id)
-- );

-- 3. DELETE TABLE:
-- DROP TABLE Student;

-- 4. READ TABLE TYPE: TO KNOW FILES AND TYPES OF ALL COLUMNS OF A TABLE
-- DESCRIBE Student;

-- 5. UPDATE TABLE (COLUMNS AND ROWS): ----------------------------------------------------------------------------
-- 									5A. TABLE - COLUMN RELATED QUERIES
-- 1. CREATE COLUMN:
-- ALTER TABLE student ADD COLUMN deparment VARCHAR(15); -- add new column

-- 2. DELETE COLUMN:
-- ALTER TABLE student DROP COLUMN department;
--           (or)
-- ALTER TABLE student DROP department;
-- ---------------------------------
-- 									5B. TABLE - ROW RELATED QUERIES

-- 1. CREATE ROW:
-- INSERT INTO student VALUES(1, "Santhosh", 8.9)  -- to insert single row or data
-- INSERT INTO student VALUES(2,"name1", 1.0), (3, "name2", 3.9);
-- INSERT INTO student(Id,Name) VALUES(4,"name4"); -- to insert single (SPECIFIC COLUMNS)
-- INSERT INTO student(Id,Name) VALUES(5,"name5"),(6,"name6"); -- to insert multiple (SPECIFIC COLUMNS)

-- 2. UPDATE ROW:
-- UPDATE employee SET job_desc = "ADMIN"	-- updates and sets all rows
-- UPDATE employee SET job_desc = "ADMIN" WHERE job_desc = "MANAGER"; -- updates all rows that contains "manager" as job_desc;
-- UPDATE employee SET eName =  "eName2" WHERE employee_Id = 1;

-- 3. DELETE ROW:
-- DELETE FROM employee -- deletes all rows
-- DELETE FROM employee WHERE employee_Id = 1;

-- 4. READ ROW:
-- 4a. SELECT QUERY:
-- SELECT * FROM student; -- displays all rows and columns of this student table;
-- SELECT Id, name from student; -- displays specific columns
-- --------
-- 4b. USING WHERE and CONDITIONS:
-- SYNTAX: SELECT column1, column2,... from table_name where condition;

-- OPERATORS								SPECIAL OPERATORS
-- 1. = equal								  7. BETWEEN
-- 2. <> not equals							  8. LIKE
-- 3. > greater than						  9. IN
-- 4. < less than							  10. NOT
-- 5. >= greater than or equals to			  11. AND
-- 6. <= less than or equals to				  12. OR
 
-- 4c. BASIC SAMPLE QUERIES AND USECASES:
-- I. USING AND, OR, NOT, IN, >=, <, =, BETWEEN
-- 1. SELECT * FROM employee where eName = "Santhosh";
-- 2. SELECT employee_Id, eName, job_desc FROM employee WHERE salary >= 50000;
-- 3. SELECT employee_Id, eName, job_desc FROM employee WHERE salary < 100000 and job_desc = "Manager";
-- 4. SELECT employee_Id, eName, job_desc FROM employee WHERE job_desc = "Manager" OR job_desc = "HR";
-- 5. SELECT employee_Id, eName, job_desc FROM employee WHERE job_desc IN ("Manager", "HR");
-- 6. SELECT * FROM employee WHERE job_desc NOT IN ("Admin", "HR");
-- 7. SELECT * FROM employee WHERE salary BETWEEN 10000 AND 50000;
-- 8. SELECT * FROM employee LIMIT 5;

-- ROUGH NOTES:
-- 9. SELECT MAX(salary) FROM employee; -- to get max 
-- 10. SELECT MAX(salary) FROM employee WHERE salary < (SELECT MAX(salary) FROM employee); -- second max
-- 11. SELECT * FROM employee WHERE salary = (SELECT MAX(salary) FROM employee WHERE salary < (SELECT MAX(salary) FROM employee)) -- second max

-- 4d. USING LIKE and WILDCARDS:
-- 1. SELECT * FROM employee WHERE eName LIKE "S%";  -- gets all employees thats eName starts with "S"
-- 2. SELECT * FROM employee WHERE eName LIKE "%h"; -- gets all employees thats eName ends with "h"
-- 3. SELECT * FROM employee WHERE eName LIKE "%o%"; -- gets all employees that contains "o" on eName
-- 4. SELECT * FROM employee WHERE eName LIKE "__n%"; --gets all employess that has letter n as third letter on eName;
-- 5. SELECT * FROM employee WHERE eName LIKE "S\%"; -- gets all employess that eName starts with "S%"

-- 4e. DISTINCT (WITHOUT DUPLICATES):
-- SELECT DISTINCT job_desc from employee; -- by this we can see all types of job_desc available

-- 4f. ORDER BY:
-- SELECT * FROM employee ORDER BY salary; -- order by salary asending
-- SELECT * FROM employee ORDER BY salary ASC; -- same as above
-- SELECT * FROM employee ORDER BY salary DESC; -- order by salary desending
-- SELECT * FROM employee WHERE job_desc = "MANAGER" ORDER BY salary; -- order the manager salary in desc order
-- SELECT * FROM employee ORDER BY job_desc,ename; -- first sorts by job_desc then ename
-- SELECT * FROM employee ORDER BY (CASE job_desc WHEN 'CEO' THEN 1 WHEN 'HR' THEN 2 WHEN 'ADMIN' THEN 3 ELSE 100 END);
-- SELECT * FROM employee ORDER BY (CASE job_desc WHEN 'CEO' THEN 1 WHEN 'HR' THEN 3 WHEN 'ADMIN' THEN 3 ELSE 100 END);

-- 4g. FUNCTIONS:( MOST USED: COUNT, AVG, SUM, MAX, MIN, CONCAT.
-- SELECT COUND(*) FROM employee -- count of all records
-- SELECT AVG(salary) FROM employee -- average salary of all employees
-- SELECT AVG(salary) FROM employee WHERE job_desc = "MANAGER" -- average salary of managers
-- SELECT SUM(salary) FROM employee WHERE job_desc = "ADMIN" -- total salary given to all admins
-- SELECT * FROM employee WHERE salary = (SELECT MAX(salary) FROM employee) -- employee with highest salary
-- SELECT MIN(salary) FROM employee -- lowest salary
-- SELECT eName, UCASE(eName) FROM employee -- upper case
-- SELECT eName, CHAR_LENGTH(eName) FROM employee -- char length
-- SELECT eName, CONCAT("Rs.", salary) FROM employee -- adds "Rs." to the beginning of salary
-- SELECT eName, CONCAT("Rs.", FORMAT(salary, 0)) FROM employee -- adds "Rs." to the beginning and formats salary with coma.
-- SELECT eName, LEFT(job_desc, 3) FROM employee  -- extracts first 3 chars from job_desc

-- 4h. USING DATE:
-- ROUGH NOTES
-- ALTER TABLE student add column dob DATE;
-- UPDATE student SET dob =  '2001-09-05' WHERE Id = 1; -- updating for id 1
-- UPDATE student SET dob = '1995-05-03'; -- updating for all

-- SELECT NOW(); -- current date and time
-- SELECT DATE(NOW()); -- current date
-- SELECT CURDATE(); -- current system date
-- SELECT DATE_FORMAT(CURDATE(), "%d/%m/%Y");
-- SELECT DATEDIFF(CURDATE(), "2026-02-16") AS DAYS
-- SELECT CURDATE() STARTDATE, date_add(CURDATE(), INTERVAL 1 day) ONEDAYLATER, date_add(CURDATE(), INTERVAL 1 WEEK) ONEWEEKLATER, date_format(DATE_ADD(CURDATE(), INTERVAL 1 MONTH), '%Y/%m/%d') as "ONEMONTHLATER(FORMATTED)"; -- current system date

-- 4i. GROUPBY AND HAVING
-- SELECT job_desc, AVG(salary) as avg_salary FROM employee GROUP BY job_desc; -- average salary for each job_desc
-- SELECT job_desc, COUNT(*) as Count FROM employee GROUP BY job_desc;
-- SELECT job_desc, COUNT(*) as Count FROM employee GROUP BY job_desc HAVING COUNT(*) > 1;
-- SELECT job_desc, COUNT(*) as count FROM employee GROUP BY job_desc HAVING COUNT(*) > 1 ORDER BY job_desc ASC;
-- SELECT job_desc, COUNT(*) as empcount FROM employee GROUP BY job_desc ORDER BY empcount DESC;
-- SELECT job_desc, COUNT(*) as emp_count FROM employee WHERE salary >= 120000 GROUP BY job_desc HAVING COUNT(*) > 1 ORDER BY emp_count DESC;

-- 4j. CONSTRAINS (NOT NULL, AUTO_INCREMENT, DEFAULT, CHECK, UNIQUE)
-- CREATE TABLE employee(
--  emp_id INT PRIMARY KEY AUTO_INCREMENT,
--  emp_name VARCHAR(30) NOT NULL,
--  job_desc VARCHAR(20) DEFAULT "Unassigned",
--  salary INT,
--  pan CHAR(10) UNIQUE,
--  CHECK(salary > 10000)
-- )

-- 4k. FOREIGN KEY & ON DELETE
-- CREATE FOREIGN KEY
-- CREATE TABLE branch(
-- 	   branch_id INT AUTO_INCREMENT PRIMARY KEY,
--     branch_name VARCHAR(20),
--     address VARCHAR(50)
-- );

-- CREATE  TABLE  employee(
-- 	emp_id INT PRIMARY KEY AUTO_INCREMENT,
-- 	emp_name VARCHAR(40) NOT NULL,
-- 	job_desc VARCHAR(20) DEFAULT 'unassigned',
-- 	salary INT,
-- 	pan CHAR(10) UNIQUE,
-- 	check (salary > 10000),
-- 	branch_id INT,
-- 	CONSTRAINT fk_branchId FOREIGN KEY(branch_id) REFERENCES branch(branch_id)
--  ON DELETE CASCADE  -- IF BRANCH IS DELETED, EMPLOYEES WORKING ON THAT BRANCH ALSO GETS DELETED
--       (OR)
--  ON DELETE SET NULL  -- IF BRANCH IS DELETED, branch_id OF THOSE EMPLOYEES GETS VALUE = NULL
-- );

-- DELETE FOREIGN KEY
-- ALTER TABLE employee DROP FOREIGN KEY fk_branchId

-- 4l. INDEX
--  FOR LATER

-- 4m. ON DELETE
-- ADDED DEFINITION ON FOREIGN KEY SECTION

-- 4n. JOINS (INNER JOIN, LEFT JOIN, RIGHT JOIN, CROSS JOIN)

--  4n-1.INNER JOIN (ONLY MATCHING ROWS FROM EACH TABLE)
-- SELECT employee.emp_id, employee.emp_name, branch.branch_name
-- FROM employee
-- INNER JOIN branch
-- ON employee.emp_id = branch.branch_id
-- ORDER BY employee.emp_id;

-- 4n-2.INNER JOIN USING WHERE CLAUSE
-- SELECT employee.emp_id, employee.emp_name, branch.branch_name
-- FROM employee, branch
-- WHERE employee.emp_id = branch.branch_id
-- ORDER BY employee.emp_id;

-- 4n-3. INNER JOIN USING ALIAS
-- SELECT e.emp_id, e.emp_name, b.branch_id , b.branch_name 
-- FROM employee as e 
-- INNER JOIN branch as b 
-- ON e.branch_id = b.branch_ids
-- ORDER BY emp_id

-- 4n-4. RIGHT JOIN USING ALIAS
-- SELECT e.emp_id, b.branch_id 
-- FROM employee AS e 
-- RIGHT JOIN branch AS b 
-- ON e.emp_id = b.branch_id

-- 4n-5. LEFT JOIN USING ALIAS
-- SELECT e.emp_id, b.branch_id 
-- FROM employee AS e 
-- LEFT JOIN branch AS b 
-- ON e.emp_id = b.branch_id

-- 4n-6. CROSS JOIN USING ALIAS
-- SELECT e.emp_id, b.branch_id 
-- FROM employee AS e 
-- CROSS JOIN branch AS b 
-- ON e.emp_id = b.branch_id

-- ROUGH PROBLEM:
--  SELECT b.branch_name, COUNT(e.emp_id)
--  FROM branch AS b
--  LEFT JOIN employee AS e
--  ON b.branch_id = e.branch_id
--  GROUP BY b.branch_id

-- 4o. UNIONS (COMBINES TWO TABLES ONLY IF BOTH HAS SAME COLUMNS AND DATATYPES)
-- SELECT * FROM EMPLOYEE2 UNION SELECT * FROM EMPLOYEE2; -- WITHOUT DUPLICATES
-- SELECT * FROM EMPLOYEE2 UNION ALL SELECT * FROM EMPLOYEE2; -- WITH DUPLICATES

-- 4p. SUBQURIES, ANY, EXISTS, ALL
-- PROBLEMS FOR THIS:
-- SELECT * FROM employee where branch_id = (SELECT branch_id FROM branch WHERE branch_name = 'chennai')
-- SELECT e.*, b.branch_name FROM employee AS e INNER JOIN branch AS b ON e.branch_id = b.branch_id WHERE b.branch_name = 'chennai'
-- SELECT * FROM employee WHERE salary = (SELECT MIN(salary) from employee)
--  SELECT * FROM employee WHERE job_desc = 'ADMIN';
-- SELECT branch_id,branch_name FROM branch WHERE EXISTS (SELECT * FROM employee WHERE job_desc="ADMIN" AND branch.branch_id = employee.branch_id);
-- SELECT * FROM employee WHERE branch_id <> ALL (SELECT branch_id from branch WHERE branch_name IN ('chennai', 'coimbatore'))

-- 4q. VIEWS
-- CREATE
-- CREATE VIEW EMP_BRANCH AS SELECT e.*, b.branch_name FROM employee AS e INNER JOIN branch AS b ON e.branch_id = b.branch_id WHERE b.branch_name = 'chennai';

-- READ
-- SELECT * FROM EMP_BRANCH;

-- DELETE
-- DROP VIEW EMP_BRANCH

-- UPDATE
-- CREATE OR REPLACE VIEW EMP_BRANCH 
-- AS 
-- SELECT e.*, b.branch_name FROM employee AS e 
-- INNER JOIN branch AS b
-- ON e.branch_id = b.branch_id 
-- WHERE b.branch_name = 'chennai'
-- ORDER BY e.emp_id desc









