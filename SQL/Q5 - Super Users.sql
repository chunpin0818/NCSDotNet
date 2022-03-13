--A company defines its super users as those who have made at least two transactions. From the following table, 
--write a query to return, for each user, the date when they become a super user, ordered by oldest super users first. 
--Users who are not super users should also be present in the table. 

USE DOCNET_TUTORIAL

CREATE TABLE users3(
user_id int NOT NULL,
product_id varchar(25) NOT NULL,
transaction_date DATE NOT NULL);

INSERT INTO users3 VALUES
('1','101','2-12-20'),
('2','105','2-13-20'),
('1','111','2-14-20'),
('3','121','2-15-20'),
('1','101','2-16-20'),
('2','105','2-17-20'),
('4','101','2-16-20'),
('3','105','2-15-20');

SELECT * FROM users3

--Create temp table to store the count of transactions and specific date for each user
CREATE TABLE #transactions(user_id int,product_id varchar(25),transaction_date DATE,transaction_count int);

INSERT INTO #transactions 
SELECT *,row_number() OVER (PARTITION by user_id ORDER BY transaction_date ASC)
FROM users3

SELECT * FROM #transactions

--Create temp table to store superuser (transaction_count =2) and the date
CREATE TABLE #superusers(user_id int,transaction_date DATE,transaction_count int);

INSERT INTO #superusers 
SELECT user_id,transaction_date,transaction_count
FROM #transactions
WHERE transaction_count=2

SELECT * FROM #superusers

--In order to displaya non-super users as well, the left join is needed
SELECT DISTINCT t.user_id,s.transaction_date
FROM #transactions t LEFT JOIN #superusers s
ON t.user_id=s.user_id
ORDER BY s.transaction_date ASC
