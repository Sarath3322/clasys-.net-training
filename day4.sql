create database sharuk;
use sharuk;
CREATE TABLE register (
    id INT PRIMARY KEY ,
    first_name VARCHAR(20) NOT NULL,
    last_name VARCHAR(20)NOT NULL,
    date_of_birth DATE NOT NULL,
    age INT NOT NULL,
    gender VARCHAR(10) NOT NULL,
    phone_no VARCHAR(20) NOT NULL,
    email VARCHAR(20) NOT NULL,
    address VARCHAR(20) NOT NULL,
    city VARCHAR(20) NOT NULL,
    state VARCHAR(20) NOT NULL,
    username VARCHAR(20) NOT NULL,
    password VARCHAR(20) 
);

INSERT INTO register (id,first_name, last_name, date_of_birth, age, gender, phone_no, email, address, city, state, username, password)
VALUES
    (1,'kiran', 'shankar', '1999-11-19', 23, 'male', '9072375973', 'kiran@example.com', 'puthuruthy', 'thrissur', 'kerala', 'kiran_k', 'kiran321'),
    (2,'nimal', 'narayanan', '2000-06-22', 23, 'male', '9876543210', 'nimal44@example.com', 'pathramanagalam', 'thrissur', 'kerala', 'nimal_k', '0099776'),
    (3,'Alex', 'Johnson', '2000-02-10', 21, 'other', '6238131169', 'alex@example.com', 'thenmala', 'thenkashi', 'tamilnadu', 'alex_j', 'mypassword'),
    (4,'vibin', 'surender', '1998-11-18', 23, 'male', '8593942576', 'vibin@example.com', 'shornur', 'palakkad', 'tamilnadu', 'vibin_ks', 'abc123'),
    (5,'Chris', 'Lee', '1982-07-07', 41, 'male', '9998887777', 'chris@example.com', '101 Maple Ln', 'Miami', 'FL', 'chris_lee', 'qwerty');

SELECT * FROM register ;
SELECT * FROM register WHERE id=2;
UPDATE register SET city='kannur' where id=2;
delete from register where id=5;

CREATE TABLE employee (
    id INT PRIMARY KEY,
    first_name VARCHAR(50),
    last_name VARCHAR(50),
    salary DECIMAL(10, 2),
	department_name VARCHAR(50),
);

INSERT INTO employee (id, first_name, last_name, salary,department_name)
VALUES
    (1, 'Arun', 'Kumar', 50000.00,'hr'),
    (2, 'Deepa', 'Raj', 55000.00,'hr'),
    (3, 'Suresh', 'Menon', 60000.00,'marketing'),
    (4, 'Maya', 'Nair', 52000.00,'marketing'),
    (5, 'Rajesh', 'Pillai', 58000.00,'accounts');

SELECT *
FROM employee
WHERE salary = (
    SELECT MAX(salary)
    FROM employee
    WHERE salary < (
        SELECT MAX(salary)
        FROM employee
    )
);

SELECT department_name, COUNT(*) AS num_employees
FROM employee
GROUP BY department_name;


CREATE TABLE actor(
          actor_id INT PRIMARY KEY,
		  actor_name VARCHAR(20),
		  age INT NOT NULL,
		  );

		  INSERT INTO actor(actor_id,actor_name,age)
		  VALUES
		  (1,'prabhas',43),
		  (2,'dulquer',38),
		  (3,'yash',39),
		  (4,'nerraj madhav',28),
		  (5,'sreenath bhasi',29);

		 

CREATE TABLE movies (
    movie_id INT PRIMARY KEY,
	
    movie_name VARCHAR(20),
    budget DECIMAL(20, 2),
	total_profit DECIMAL(20, 2),
	actor_id INT 
	FOREIGN KEY (actor_id) REFERENCES actor(actor_id)
);

INSERT INTO movies (movie_id, movie_name, budget, total_profit, actor_id)
VALUES
    (1, 'bahubali 1', 1000000.00, 500000.00, 1),
    (2, 'bahubali 2', 1500000.00, 800000.00, 1),
    (3, 'kok', 800000.00, 300000.00, 2),
    (4, 'kgf 1', 1200000.00, 700000.00, 3),
    (5, 'kurupp', 2000000.00, 1000000.00, 2);

	select * from movies inner join actor on movies.actor_id=actor.actor_id;

select movies.movie_name, actor.actor_name from movies
INNER JOIN actor ON movies.actor_id = actor.actor_id;



SELECT actor.actor_name, movies.movie_name
FROM actor
LEFT JOIN movies
ON movies.actor_id=actor.actor_id
ORDER BY actor.actor_name;

SELECT movies.movie_id, actor.actor_name,actor.age
FROM movies
RIGHT JOIN actor ON movies.actor_id = actor.actor_id
ORDER BY actor.actor_id;

INSERT INTO movies (movie_id, movie_name, budget, total_profit, actor_id)
VALUES (6, 'neymar', 700000.00, 100000.00,null);


SELECT actor.actor_name, movies.movie_name
FROM actor
FULL OUTER JOIN movies ON actor.actor_id=movies.actor_id
ORDER BY actor.actor_name;;










