create database sharuk;
use sharuk;
CREATE TABLE register (
    id INT PRIMARY KEY IDENTITY(1,1),
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

INSERT INTO register (first_name, last_name, date_of_birth, age, gender, phone_no, email, address, city, state, username, password)
VALUES
    ('kiran', 'shankar', '1999-11-19', 23, 'male', '9072375973', 'kiran@example.com', 'puthuruthy', 'thrissur', 'kerala', 'kiran_k', 'kiran321'),
    ('nimal', 'narayanan', '2000-06-22', 23, 'male', '9876543210', 'nimal44@example.com', 'pathramanagalam', 'thrissur', 'kerala', 'nimal_k', '0099776'),
    ('Alex', 'Johnson', '2000-02-10', 21, 'other', '6238131169', 'alex@example.com', 'thenmala', 'thenkashi', 'tamilnadu', 'alex_j', 'mypassword'),
    ('vibin', 'surender', '1998-11-18', 23, 'male', '8593942576', 'vibin@example.com', 'shornur', 'palakkad', 'tamilnadu', 'vibin_ks', 'abc123'),
    ('Chris', 'Lee', '1982-07-07', 41, 'male', '9998887777', 'chris@example.com', '101 Maple Ln', 'Miami', 'FL', 'chris_lee', 'qwerty');

SELECT * FROM register ;
SELECT * FROM register WHERE id=2;
UPDATE register SET city='kannur' where id=2;
delete from register where id=5;
drop table register;
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

task 6 

SELECT  movies.movie_name, actor.actor_name,actor.age,
 movies.budget,movies.total_profit
FROM actor,movies 
WHERE  actor.actor_id =movies.actor_id


task 7 

CREATE PROCEDURE details
    @first_name VARCHAR(20),
    @LastName VARCHAR(20),
    @DateOfBirth DATE,
    @Age INT,
    @Gender VARCHAR(10),
    @PhoneNo VARCHAR(20),
    @Email VARCHAR(20),
    @Address VARCHAR(20),
    @City VARCHAR(20),
    @State VARCHAR(20),
    @Username VARCHAR(20),
    @Password VARCHAR(20)
AS
BEGIN
    DECLARE @NewuserID INT;

    IF OBJECTPROPERTY(OBJECT_ID('register'), 'TableHasIdentity') = 1
    BEGIN
        SET @NewuserID = IDENT_CURRENT('register') + 1;
    END
    ELSE
    BEGIN
        SET @NewuserID = (SELECT MAX(id) FROM register) + 1;
    END
    
    INSERT INTO register ( first_name, last_name, date_of_birth, age, gender, phone_no, email, address, city, state, username, password)
    VALUES ( ISNULL(@first_name, 'me'), ISNULL(@LastName, 'me'), ISNULL(@DateOfBirth, '1900-01-01'), 
            ISNULL(@Age, 0), ISNULL(@Gender, 'female'), ISNULL(@PhoneNo, '0000000000'), ISNULL(@Email, 'hgh@gmail.com'), ISNULL(@Address, 'xxxxx'),
            ISNULL(@City, 'thrissur'), ISNULL(@State, 'kerala'), ISNULL(@Username, 'johndoe321'), ISNULL(@Password, 'hdtggaggtwjd72362'));
END;

EXEC details
    @first_name = 'John',
    @LastName = 'Doe',
    @DateOfBirth = '1990-05-15',
    @Age = 32,
    @Gender = 'Male',
    @PhoneNo = '1234567890',
    @Email = 'john@example.com',
    @Address = '123 Main St',
    @City = 'Los Angeles',
    @State = 'CA',
    @Username = 'johndoe',
    @Password = 'hashedpassword1';


CREATE PROCEDURE ReadUser
    @UserId INT = NULL
AS
BEGIN
    IF @UserId IS NULL
        SELECT * FROM register; 
    ELSE
        SELECT * FROM register WHERE id = @UserId;
END;
 


EXEC ReadUser @UserId = 4;
EXEC ReadUser;

CREATE PROCEDURE UpdateUser
    @UserID INT,
    @First_Name VARCHAR(20),
    @Last_Name VARCHAR(20),
    @DateOfBirth DATE,
    @Age INT,
    @Gender VARCHAR(10),
    @PhoneNo VARCHAR(20),
    @Email VARCHAR(20),
    @Address VARCHAR(20),
    @City VARCHAR(20),
    @State VARCHAR(20),
    @Username VARCHAR(20),
    @Password VARCHAR(20)
AS
BEGIN
    UPDATE register
    SET
        first_name = ISNULL(@First_Name, first_name),
        last_name = ISNULL(@Last_Name, last_name),
        date_of_birth = ISNULL(@DateOfBirth, date_of_birth),
        age = ISNULL(@Age, age),
        gender = ISNULL(@Gender, gender),
        phone_no = ISNULL(@PhoneNo, phone_no),
        email = ISNULL(@Email, email),
        address = ISNULL(@Address, address),
        city = ISNULL(@City, city),
        state = ISNULL(@State, state),
        username = ISNULL(@Username, username),
        password = ISNULL(@Password, password)
    WHERE id = @UserID;
END;


EXEC UpdateUser
    @UserID = 4,
	@First_Name = 'vibin',
    @Last_Name = 'surendran',
    @DateOfBirth = '2000-2-1',
    @Age =23,
    @Gender = 'male',
    @PhoneNo = '9988409733',
    @Email = 'vibinsingham485@gmail.com',
    @Address = 'melevettil (house)',
    @City = 'vadanapilly',
    @State = 'kerala',
	 @Username = 'vibinrdx',
    @Password = 'vibin489s';

EXEC UpdateUser
    @UserID = 3,
	@First_Name = null,
    @Last_Name = null,
    @DateOfBirth = null,
    @Age =null,
    @Gender = null,
    @PhoneNo = '8593943576',
    @Email = 'alexpandian555@gmail.com',
    @Address = null,
    @City = null,
    @State = null,
	 @Username = null,
    @Password = null;



CREATE PROCEDURE DeleteUser
    @UserID INT
AS
BEGIN
    DELETE FROM register
    WHERE id = @UserID;
END;

EXEC DeleteUser
    @UserID = 6; 



task  8  

CREATE PROCEDURE ManageUser
    @Action VARCHAR(10),
    @UserID INT = NULL,
    @First_Name VARCHAR(20) = NULL,
    @Last_Name VARCHAR(20) = NULL,
    @DateOfBirth DATE = NULL,
    @Age INT = NULL,
    @Gender VARCHAR(10) = NULL,
    @PhoneNo VARCHAR(20) = NULL,
    @Email VARCHAR(100) = NULL,
    @Address VARCHAR(50) = NULL,
    @City VARCHAR(20) = NULL,
    @State VARCHAR(20) = NULL,
    @Username VARCHAR(20) = NULL,
    @Password VARCHAR(20) = NULL
AS
BEGIN
    IF @Action = 'CREATE'
    BEGIN
        INSERT INTO register (first_name, last_name, date_of_birth, Age, Gender, phone_no, Email, Address, City, State, Username, Password)
        VALUES (@First_Name, @Last_Name, @DateOfBirth, @Age, @Gender, @PhoneNo, @Email, @Address, @City, @State, @Username, @Password);
    END;

    IF @Action = 'READ'
    BEGIN
        IF @UserID IS NOT NULL
            SELECT * FROM register WHERE Id = @UserID;
        ELSE
            SELECT * FROM register;
    END;

    IF @Action = 'UPDATE'
    BEGIN
        UPDATE register
        SET
            first_name = ISNULL(@First_Name, first_name),
           last_name = ISNULL(@Last_Name, last_name),
            date_of_birth = ISNULL(@DateOfBirth, date_of_birth),
            Age = ISNULL(@Age, Age),
            Gender = ISNULL(@Gender, Gender),
            phone_no = ISNULL(@PhoneNo, phone_no),
            Email = ISNULL(@Email, Email),
            Address = ISNULL(@Address, Address),
            City = ISNULL(@City, City),
            State = ISNULL(@State, State),
            Username = ISNULL(@Username, Username),
            Password = ISNULL(@Password, Password)
        WHERE Id = @UserID;
    END;

    IF @Action = 'DELETE'
    BEGIN
        DELETE FROM register WHERE Id = @UserID;
    END;
END;

EXEC ManageUser
    @Action = 'CREATE',
    @First_Name = 'kishor',
    @Last_Name = 'surendran',
    @DateOfBirth = '2000-4-1',
    @Age =23,
    @Gender = 'male',
    @PhoneNo = '8188675733',
    @Email = 'kishork98@gmail.com',
    @Address = 'puthupalli (house)',
    @City = 'kunnamkulam',
    @State = 'kerala',
	 @Username = 'kishordom',
    @Password = 'hdgwqg32';


EXEC ManageUser
    @Action = 'READ';

EXEC ManageUser
    @Action = 'READ',
    @UserID = 1;

EXEC ManageUser
    @Action = 'UPDATE',
    @UserID = 1,
    @PhoneNo = '9876543210',
    @Email = 'iamtheking@gmail.com';

EXEC ManageUser
    @Action = 'DELETE',
    @UserID = 5;




select * from register







