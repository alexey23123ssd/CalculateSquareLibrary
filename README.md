SQL Решение

CREATE TABLE Product(
id INT PRIMARY KEY IDENTITY, 
name VARCHAR(255) NOT NULL);

CREATE TABLE Category(
id INT PRIMARY KEY IDENTITY,
name VARCHAR(255) NOT NULL);

CREATE TABLE ProductCategory(
product_category_id INT PRIMARY KEY IDENTITY,
product_id INT NULL,
category_id INT NULL,
FOREIGN KEY(product_id) REFERENCES Product(id) ON DELETE SET DEFAULT,
FOREIGN KEY(category_id) REFERENCES Category(id) ON DELETE SET DEFAULT);


CREATE UNIQUE INDEX product_category ON ProductCategory(product_id, category_id);

--INSERT INTO Product
INSERT INTO Product (name)
VALUES ('Milk');

INSERT INTO Product (name)
VALUES ('Phone');

INSERT INTO Product (name)
VALUES ('Pen');

--INSERT INTO Category
INSERT INTO Category (name)
VALUES ('Meal');

INSERT INTO Category (name)
VALUES ('Device');

--INSERT INTO ProductCategory
INSERT INTO ProductCategory (product_id,category_id) 
VALUES (1, 1);

INSERT INTO ProductCategory (product_id,category_id) 
VALUES (2, 2);

INSERT INTO ProductCategory (product_id,category_id) 
VALUES (3, null);

SELECT p.name, c.name
FROM Category as c
JOIN ProductCategory as pc on pc.product_id = c.id
RIGHT JOIN Product as p on pc.product_id = p.id
