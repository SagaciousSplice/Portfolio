-- drop table if exists
DROP TABLE IF EXISTS users;

-- create table users
CREATE TABLE users(
	user_id VARCHAR(20) NOT NULL,
	password VARCHAR(32) NOT NULL,
	user_type VARCHAR(2) NOT NULL,
	email_address VARCHAR(255) NOT NULL,
	first_name VARCHAR(128) NOT NULL,
	last_name VARCHAR(128) NOT NULL,
	birth_date DATE NOT NULL,
	enrol_date DATE NOT NULL,
	last_access DATE NOT NULL,
	PRIMARY KEY (user_id)
);
ALTER TABLE users OWNER TO group07_admin;
-- insert values into table
INSERT INTO users (user_id, password, user_type, email_address, first_name, last_name, birth_date, enrol_date, last_access) VALUES (
	'wchurchill',
	md5('stogie'),
	'a',
	'tophat@gmail.com',
	'Winston',
	'Churchill',
	'1954-10-30',
	'2017-9-18',
	'2017-9-18'
);

INSERT INTO users (user_id, password, user_type, email_address, first_name, last_name, birth_date, enrol_date, last_access) VALUES (
	'alincoln',
	md5('freethem'),
	'a',
	'emancipationguy@gmail.com',
	'Abe',
	'Lincoln',
	'1954-2-12',
	'2017-9-19',
	'2017-9-19'
);

INSERT INTO users (user_id, password, user_type, email_address, first_name, last_name, birth_date, enrol_date, last_access) VALUES (
	'sunnyGuy',
	md5('StaysPut247!'),
	'd',
	'relativemovement@gmail.com',
	'Galileo',
	'Galilei',
	'1954-2-15',
	'2017-9-17',
	'2017-9-18'
);

INSERT INTO users (user_id, password, user_type, email_address, first_name, last_name, birth_date, enrol_date, last_access) VALUES (
	'joanie',
	md5('Arc4Eva'),
	'i',
	'saintlylady@gmail.com',
	'Joan',
	'd''Arc',
	'1954-12-14',
	'2017-9-18',
	'2017-9-19'
);
