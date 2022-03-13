--From the following table of transactions between two users, write a query to 
--return the change in net worth for each user, ordered by decreasing net change. 
USE DOCNET_TUTORIAL

--Create table and insert values
CREATE TABLE transactions(
sender INT NOT NULL ,
receiver INT NOT NULL,
amount INT NOT NULL,
transaction_date DATE);

INSERT INTO transactions VALUES
(5,2,10,'2-12-20'),
(1,3,15,'2-13-20'),
(2,1,20,'2-13-20'),
(2,3,25,'2-14-20'),
(3,1,20,'2-15-20'),
(3,2,15,'2-15-20'),
(1,4,5,'2-16-20');

SELECT * FROM transactions


--Calcuate the changes in net worth
SELECT user_id, sum(amount) AS net_change
FROM
(
SELECT sender AS user_id, -1* amount AS amount
FROM transactions
UNION all --Combine the result-set of two or more SELECTs
SELECT receiver AS user_id, amount
FROM transactions
)o
GROUP BY user_id
ORDER BY net_change DESC
