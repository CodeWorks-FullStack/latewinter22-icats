CREATE TABLE IF NOT EXISTS accounts(
  id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name varchar(255) COMMENT 'User Name',
  email varchar(255) COMMENT 'User Email',
  picture varchar(255) COMMENT 'User Picture'
) default charset utf8 COMMENT '';
CREATE TABLE IF NOT EXISTS cats (
  id INT AUTO_INCREMENT primary key,
  name TEXT NOT NULL,
  color TEXT NOT NULL,
  lives int DEFAULT 9,
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  creatorId VARCHAR(255) NOT NULL,
  FOREIGN KEY (creatorId) REFERENCES accounts(id) ON DELETE CASCADE
) default charset utf8 COMMENT '';
INSERT INTO
  cats (name, color, `creatorId`)
VALUES
  ('Bozko', 'Calico', '60d3560eceb6bbdfae388576');
SELECT
  *
FROM
  cats;
SELECT
  *
FROM
  cats
WHERE
  creatorId = "6234ac00abca50735a3c9205";
SELECT
  cats.name,
  accounts.name
FROM
  cats
  JOIN accounts ON cats.creatorId = accounts.id;
SELECT
  cats.name,
  accounts.name
FROM
  cats
  JOIN accounts ON cats.creatorId = accounts.id
WHERE
  cats.creatorId = "6234ac00abca50735a3c9205";