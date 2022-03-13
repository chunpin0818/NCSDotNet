--From the following table containing a list of dates and items ordered, write a query to return 
--the most frequent item ordered on each date. Return multiple items in the case of a tie. 

USE NCS2020
CREATE TABLE items(date DATE,item varchar(50));
INSERT INTO items VALUES
('1-1-20','apple'),
('1-1-20','apple'),
('1-1-20','pear'),
('1-1-20','pear'),
('1-2-20','pear'),
('1-2-20','pear'),
('1-2-20','pear'),
('1-2-20','orange');
SELECT * FROM items

--Create temp table to store the most frequent item in everyday
CREATE TABLE #frequentitem (date DATE,item varchar(50),count_item INT)

INSERT INTO #frequentitem
SELECT date,item,count(item)
from items
GROUP BY date,item
ORDER BY date

SELECT * FROM #frequentitem


--Create temp table to store the ranking
CREATE TABLE #ranking (date DATE,item varchar(50),count_item INT,ranking INT)

INSERT INTO #ranking
SELECT *, rank() OVER (PARTITION by date ORDER BY count_item DESC)
FROM #frequentitem

SELECT * FROM #ranking


--Select the rank 1 item for each day FROM temporary table #ranking 
SELECT date, item
FROM #ranking
WHERE ranking = 1