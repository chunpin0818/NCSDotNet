--From the following table of user IDs, actions, and dates, write a query to 
--return the publication and cancellation rate for each user. 

CREATE DATABASE DOCNET_TUTORIAL
USE DOCNET_TUTORIAL

CREATE TABLE users(
user_id int NOT NULL,
action char(25) NOT NULL,
date DATE NOT NULL);

INSERT INTO users VALUES
('1','start','1-1-20'),
('1','cancel','1-2-20'),
('2','start','1-3-20'),
('2','publish','1-4-20'),
('3','start','1-5-20'),
('3','cancel','1-6-20'),
('4','start','1-7-20');

SELECT * FROM users

CREATE TABLE #temptable
(user_id INT NOT NULL,
starts INT NOT NULL,
cancels INT NOT NULL,
publishes INT NOT NULL);

INSERT INTO #temptable(user_id,starts,cancels,publishes)
SELECT user_id,
SUM(CASE WHEN action = 'start' THEN 1 ELSE 0 END), 
SUM(CASE WHEN action = 'cancel' THEN 1 ELSE 0 END), 
SUM(CASE WHEN action = 'publish' THEN 1 ELSE 0 END)
FROM users
GROUP BY user_id

SELECT * FROM #temptable  

-- calculate publication, cancelation rate for each user by dividing by number of starts, casting as float by multiplying by 1.0
SELECT user_id, (publishes/starts)*1.0 AS publishes, (cancels/starts)*1.0 AS cancel_rate
FROM #temptable



