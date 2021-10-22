CREATE TABLE IF NOT EXISTS accounts(
  id int NOT NULL primary key COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name varchar(255) COMMENT 'User Name',
  email varchar(255) COMMENT 'User Email',
  picture varchar(255) COMMENT 'User Picture'
) default charset utf8 COMMENT '';

CREATE TABLE IF NOT EXISTS cars(
  id int NOT NULL PRIMARY KEY AUTO_INCREMENT COMMENT 'primary key',
  make VARCHAR(20),
  model VARCHAR(20),
  year int,
  price int,
  imgUrl VARCHAR(255),
  description VARCHAR(255)
) default charset utf8 COMMENT '';
DROP TABLE accounts;
SELECT * FROM accounts;
CREATE 