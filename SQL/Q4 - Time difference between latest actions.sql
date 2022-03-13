--From the following table of user actions, write a query to return for each user the time elapsed 
--between the last action and the second-to-last action, in ascending order by user ID. 

USE DOCNET_TUTORIAL

CREATE TABLE users2(
user_id int NOT NULL,
action char(25) NOT NULL,
action_date DATE NOT NULL);

INSERT INTO users2 VALUES
('1','Start','2-12-20'),
('1','Cancel','2-13-20'),
('2','Start','2-11-20'),
('2','Publish','2-14-20'),
('3','Start','2-15-20'),
('3','Cancel','2-15-20'),
('4','Start','2-18-20'),
('1','Publish','2-19-20');

SELECT * FROM users2


--Create date rank (the latest date will has the highest rank for each user_id)
CREATE TABLE #daterank(user_id int NOT NULL,action char(25) NOT NULL,action_date DATE NOT NULL,date_rank INT)
INSERT INTO #daterank
SELECT *, row_number() OVER (PARTITION by user_id ORDER BY action_date DESC) FROM users2  --rank() skip duplicate values,where as row_number won't
select * from #daterank

--Create temp table for last and second-last action of each user
CREATE TABLE #lastaction(user_id int NOT NULL,action char(25) NOT NULL,action_date DATE NOT NULL,date_rank INT)
CREATE TABLE #secondlastaction(user_id int NOT NULL,action char(25) NOT NULL,action_date DATE NOT NULL,date_rank INT)

INSERT INTO #lastaction
SELECT *
FROM #daterank
WHERE date_rank=1;

INSERT INTO #secondlastaction
SELECT *
FROM #daterank
WHERE date_rank=2;

select * from #lastaction
select * from #secondlastaction

--Calculate the time difference between the latest and second-latest update
SELECT l.user_id, DATEDIFF(day,s.action_date,l.action_date) AS days_elapsed --Using DateDiff function (interval,d1,d2)
FROM #lastaction l LEFT JOIN #secondlastaction s --Not every user has the second-latest update. thus, only use left join to get all the information from latest update
ON l.user_id = s.user_id
ORDER BY user_id