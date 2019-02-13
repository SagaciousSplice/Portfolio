
/* 
LIST OF TABLES
-gender
-city
-smoker
-drinker
-religion
-education
-body_size
-height
-realationship
-have_kids
-want_kids
-pets
-entertainment
-smoking
*/

-- GENDER TABLE --
DROP TABLE IF EXISTS gender;

CREATE TABLE gender(
id SMALLINT NOT NULL PRIMARY KEY,
property VARCHAR(20) NOT NULL
);

ALTER TABLE gender OWNER TO group07_admin;

INSERT INTO gender(id, property)
	VALUES(
			'0',
			'Not Selected'
	);
	
	INSERT INTO gender(id, property)
	VALUES(
			'1',
			'Male'
	);
	
	INSERT INTO gender(id, property)
	VALUES(
			'2',
			'Female'
	);
	
	INSERT INTO gender(id, property)
	VALUES(
			'4',
			'Transgendered'
	);

-- GENDER_SOUGHT TABLE --
DROP TABLE IF EXISTS gender_sought;

CREATE TABLE gender_sought(
id SMALLINT NOT NULL PRIMARY KEY,
property VARCHAR(20) NOT NULL
);

ALTER TABLE gender_sought OWNER TO group07_admin;

INSERT INTO gender_sought(id, property)
	VALUES(
			'0',
			'Not Selected'
	);
	
	INSERT INTO gender_sought(id, property)
	VALUES(
			'1',
			'Male'
	);
	
	INSERT INTO gender_sought(id, property)
	VALUES(
			'2',
			'Female'
	);
	
	INSERT INTO gender_sought(id, property)
	VALUES(
			'4',
			'Transgendered'
	);
	
	INSERT INTO gender_sought(id, property)
	VALUES(
			'8',
			'All of the Above'
	);

-- CITY TABLE --
DROP TABLE IF EXISTS city;

CREATE TABLE city(
id SMALLINT NOT NULL,
property VARCHAR(20) NOT NULL,

PRIMARY KEY (id)
);

ALTER TABLE city OWNER TO group07_admin;

	INSERT INTO city(id, property)
	VALUES(
			'0',
			'Not Selected'
	);
	
	INSERT INTO city(id, property)
	VALUES(
			'1',
			'Ajax'
	);
	
	INSERT INTO city(id, property)
	VALUES(
			'2',
			'Brooklin'
	);
	
	INSERT INTO city(id, property)
	VALUES(
			'4',
			'Bowmanville'
	);
	
	INSERT INTO city(id, property)
	VALUES(
			'8',
			'Oshawa'
	);
	
	INSERT INTO city(id, property)
	VALUES(
			'16',
			'Pickering'
	);
	
	INSERT INTO city(id, property)
	VALUES(
			'32',
			'Port Perry'
	);
	
	INSERT INTO city(id, property)
	VALUES(
			'64',
			'Whitby'
	);

-- SMOKER TABLE --
DROP TABLE IF EXISTS smoker;

CREATE TABLE smoker(
id SMALLINT NOT NULL,
property VARCHAR(20) NOT NULL,

PRIMARY KEY (id)
);

ALTER TABLE smoker OWNER TO group07_admin;

	INSERT INTO smoker(id, property)
	VALUES
	(
	'0',
	'Not Selected'
	);

	INSERT INTO smoker(id, property)
	VALUES
	(
	'1',
	'Never'
	);
	
	INSERT INTO smoker(id, property)
	VALUES
	(
	'2',
	'Socially'
	);

	INSERT INTO smoker(id, property)
	VALUES
	(
	'3',
	'Once a Week'
	);

	INSERT INTO smoker(id, property)
	VALUES
	(
	'4',
	'Few Times a Week'
	);
	
	INSERT INTO smoker(id, property)
	VALUES
	(
	'5',
	'Daily'
	);

-- DRINKER TABLE --
DROP TABLE IF EXISTS drinker;

CREATE TABLE drinker(
id SMALLINT NOT NULL,
property VARCHAR(20) NOT NULL,

PRIMARY KEY (id)
);

ALTER TABLE drinker OWNER TO group07_admin;

	INSERT INTO drinker(id, property)
	VALUES
	(
	'0',
	'Not Selected'
	);

	INSERT INTO drinker(id, property)
	VALUES
	(
	'1',
	'Never'
	);
	
	INSERT INTO drinker(id, property)
	VALUES
	(
	'2',
	'Socially'
	);

	INSERT INTO drinker(id, property)
	VALUES
	(
	'3',
	'Once a Week'
	);

	INSERT INTO drinker(id, property)
	VALUES
	(
	'4',
	'Few Times a Week'
	);
	
	INSERT INTO drinker(id, property)
	VALUES
	(
	'5',
	'Daily'
	);

-- RELIGIONS TABLE --
DROP TABLE IF EXISTS religion;

CREATE TABLE religion(
id SMALLINT NOT NULL,
property VARCHAR(40) NOT NULL,

PRIMARY KEY (id)
);

ALTER TABLE religion OWNER TO group07_admin;

	INSERT INTO religion(id, property)
	VALUES
	(
	'0',
	'Not Selected'
	);

	INSERT INTO religion(id, property)
	VALUES
	(
	'1',
	'Christian Catholic'
	);

	INSERT INTO religion(id, property)
	VALUES
	(
	'2',
	'Christian Protestant’'
	);

	INSERT INTO religion(id, property)
	VALUES
	(
	'3',
	'Christian Eastern Orthodox'
	);

	INSERT INTO religion(id, property)
	VALUES
	(
	'4',
	'Jewish'
	);

	INSERT INTO religion(id, property)
	VALUES
	(
	'5',
	'Muslim'
	);

	INSERT INTO religion(id, property)
	VALUES
	(
	'6',
	'Buddist'
	);

	INSERT INTO religion(id, property)
	VALUES
	(
	'7',
	'Hindu'
	);

	INSERT INTO religion(id, property)
	VALUES
	(
	'8',
	'Sikh'
	);

	INSERT INTO religion(id, property)
	VALUES
	(
	'9',
	'Chinese Traditional'
	);
	
	INSERT INTO religion(id, property)
	VALUES
	(
	'10',
	'Primal-Indigenous'
	);
	INSERT INTO religion(id, property)
	VALUES
	(
	'11',
	'Other'
	);
	
	INSERT INTO religion(id, property)
	VALUES
	(
	'12',
	'No Religious Affiliation'
	);
	
	INSERT INTO religion(id, property)
	VALUES
	(
	'13',
	'Prefer Not to Say'
	);

-- EDUCATION TABLE --
DROP TABLE IF EXISTS education;

CREATE TABLE education(
id SMALLINT NOT NULL,
property VARCHAR(30) NOT NULL,

PRIMARY KEY (id)
);

ALTER TABLE education OWNER TO group07_admin;

	INSERT INTO education(id, property)
	VALUES
	(
	'0',
	'Not Selected'
	);

	INSERT INTO education(id, property)
	VALUES
	(
	'1',
	'Doctorate'
	);

	INSERT INTO education(id, property)
	VALUES
	(
	'2',
	'Masters'
	);

	INSERT INTO education(id, property)
	VALUES
	(
	'3',
	'Bachelors'
	);

	INSERT INTO education(id, property)
	VALUES
	(
	'4',
	'Associates'
	);

	INSERT INTO education(id, property)
	VALUES
	(
	'5',
	'College Diploma'
	);

	INSERT INTO education(id, property)
	VALUES
	(
	'6',
	'High School Diploma'
	);

	INSERT INTO education(id, property)
	VALUES
	(
	'7',
	'Less than High School Diploma'
	);

-- BODIES TABLE --
DROP TABLE IF EXISTS body_size;

CREATE TABLE body_size(
id SMALLINT NOT NULL,
property VARCHAR(40) NOT NULL,

PRIMARY KEY (id)
);

ALTER TABLE body_size OWNER TO group07_admin;

	INSERT INTO body_size(id, property)
	VALUES
	(
	'0',
	'Not Selected'
	);
	
	INSERT INTO body_size(id, property)
	VALUES
	(
	'1',
	'Skinny'
	);
	
	INSERT INTO body_size(id, property)
	VALUES
	(
	'2',
	'Skinny-Average'
	);
	
	INSERT INTO body_size(id, property)
	VALUES
	(
	'3',
	'Average'
	);
	
	INSERT INTO body_size(id, property)
	VALUES
	(
	'4',
	'Average-Overweight'
	);
	
	INSERT INTO body_size(id, property)
	VALUES
	(
	'5',
	'Overweight'
	);

-- HEIGHT TABLE --
DROP TABLE IF EXISTS height;

CREATE TABLE height(
id SMALLINT NOT NULL,
property VARCHAR(20) NOT NULL,

PRIMARY KEY (id)
);

ALTER TABLE height OWNER TO group07_admin;

	INSERT INTO height(id, property)
	VALUES
	(
	'0',
	'Not Selected'
	);
	
	INSERT INTO height(id, property)
	VALUES
	(
	'1',
	'Shorter than 5''5'''
	);
	
	INSERT INTO height(id, property)
	VALUES
	(
	'2',
	'5''5'''
	);
	
	INSERT INTO height(id, property)
	VALUES
	(
	'3',
	'5''6'''
	);
	
	INSERT INTO height(id, property)
	VALUES
	(
	'4',
	'5''7'''
	);
	
	INSERT INTO height(id, property)
	VALUES
	(
	'5',
	'5''8'''
	);
	
	INSERT INTO height(id, property)
	VALUES
	(
	'6',
	'5''9'''
	);
	
	INSERT INTO height(id, property)
	VALUES
	(
	'7',
	'5''10'''
	);
	
	INSERT INTO height(id, property)
	VALUES
	(
	'8',
	'5''11'''
	);
	
	INSERT INTO height(id, property)
	VALUES
	(
	'9',
	'6''0'''
	);
	
	INSERT INTO height(id, property)
	VALUES
	(
	'10',
	'6''1'''
	);
	
	INSERT INTO height(id, property)
	VALUES
	(
	'11',
	'6''2'''
	);
	
	INSERT INTO height(id, property)
	VALUES
	(
	'12',
	'Taller than 6''2'''
	);
	
-- REALATIONSHIP TABLE --
DROP TABLE IF EXISTS relationship;

CREATE TABLE relationship(
id SMALLINT NOT NULL,
property VARCHAR(30) NOT NULL,

PRIMARY KEY (id)
);

ALTER TABLE relationship OWNER TO group07_admin;

	INSERT INTO relationship(id, property)
	VALUES
	(
	'0',
	'Not Selected'
	);

	INSERT INTO relationship(id, property)
	VALUES
	(
	'1',
	'Single'
	);

	INSERT INTO relationship(id, property)
	VALUES
	(
	'2',
	'In a realationship'
	);

	INSERT INTO relationship(id, property)
	VALUES
	(
	'3',
	'Divorced'
	);

	INSERT INTO relationship(id, property)
	VALUES
	(
	'4',
	'Separated'
	);

	INSERT INTO relationship(id, property)
	VALUES
	(
	'5',
	'Widowed'
	);

	INSERT INTO relationship(id, property)
	VALUES
	(
	'6',
	'Married'
	);

-- HAVEKIDS TABLE --
DROP TABLE IF EXISTS have_kids;

CREATE TABLE have_kids(
id SMALLINT NOT NULL,
property VARCHAR(20) NOT NULL,

PRIMARY KEY (id)
);

ALTER TABLE have_kids OWNER TO group07_admin;

	INSERT INTO have_kids(id, property)
	VALUES
	(
	'0',
	'Not Selected'
	);

	INSERT INTO have_kids(id, property)
	VALUES
	(
	'1',
	'No kids'
	);

	INSERT INTO have_kids(id, property)
	VALUES
	(
	'2',
	'1'
	);

	INSERT INTO have_kids(id, property)
	VALUES
	(
	'3',
	'2'
	);

	INSERT INTO have_kids(id, property)
	VALUES
	(
	'4',
	'2+'
	);

	INSERT INTO have_kids(id, property)
	VALUES
	(
	'5',
	'5+'
	);

	INSERT INTO have_kids(id, property)
	VALUES
	(
	'6',
	'7+'
	);

	INSERT INTO have_kids(id, property)
	VALUES
	(
	'7',
	'10+'
	);

-- WANTKIDS TABLE --
DROP TABLE IF EXISTS want_kids;

CREATE TABLE want_kids(
id SMALLINT NOT NULL,
property VARCHAR(20) NOT NULL,

PRIMARY KEY (id)
);

ALTER TABLE want_kids OWNER TO group07_admin;

	INSERT INTO want_kids(id, property)
	VALUES
	(
	'0',
	'Not Selected'
	);

	INSERT INTO want_kids(id, property)
	VALUES
	(
	'1',
	'Yes(more)'
	);

	INSERT INTO want_kids(id, property)
	VALUES
	(
	'2',
	'Maybe'
	);

	INSERT INTO want_kids(id, property)
	VALUES
	(
	'3',
	'No(more)'
	);

-- PETS TABLE --
DROP TABLE IF EXISTS pets;

CREATE TABLE pets(
id SMALLINT NOT NULL,
property VARCHAR(20) NOT NULL,

PRIMARY KEY (id)
);

ALTER TABLE pets OWNER TO group07_admin;

	INSERT INTO pets(id, property)
	VALUES
	(
	'0',
	'Not Selected'
	);

	INSERT INTO pets(id, property)
	VALUES
	(
	'1',
	'No Pets'
	);

	INSERT INTO pets(id, property)
	VALUES
	(
	'2',
	'Only 1'
	);

	INSERT INTO pets(id, property)
	VALUES
	(
	'3',
	'Only 2'
	);

	INSERT INTO pets(id, property)
	VALUES
	(
	'4',
	'More than 2'
	);

	INSERT INTO pets(id, property)
	VALUES
	(
	'5',
	'More than 5'
	);

	INSERT INTO pets(id, property)
	VALUES
	(
	'6',
	'More than 7'
	);

	INSERT INTO pets(id, property)
	VALUES
	(
	'7',
	'More than 10'
	);

-- entertainment table
DROP TABLE IF EXISTS entertainment;

CREATE TABLE entertainment(
id SMALLINT NOT NULL,
property VARCHAR(30) NOT NULL,

PRIMARY KEY (id)
);

ALTER TABLE entertainment OWNER TO group07_admin;

	INSERT INTO entertainment(id, property)
	VALUES
	(
	'0',
	'Not Selected'
	);
	
	INSERT INTO entertainment(id, property)
	VALUES
	(
	'1',
	'Relaxing'
	);
	INSERT INTO entertainment(id, property)
	VALUES
	(
	'2',
	'Partying'
	);	
	INSERT INTO entertainment(id, property)
	VALUES
	(
	'3',
	'Seeing shows'
	);
	
	INSERT INTO entertainment(id, property)
	VALUES
	(
	'4',
	'Physical Activity'
	);
	
	INSERT INTO entertainment(id, property)
	VALUES
	(
	'5',
	'Hard to describe in few words'
	);

-- smoking table
DROP TABLE IF EXISTS tolerate_smoking;

CREATE TABLE tolerate_smoking(
id SMALLINT NOT NULL,
property VARCHAR(20) NOT NULL,

PRIMARY KEY (id)
);

ALTER TABLE tolerate_smoking OWNER TO group07_admin;

	INSERT INTO tolerate_smoking(id, property)
	VALUES
	(
	'0',
	'Not Selected'
	);

	INSERT INTO tolerate_smoking(id, property)
	VALUES
	(
	'1',
	'Never'
	);
	
	INSERT INTO tolerate_smoking(id, property)
	VALUES
	(
	'2',
	'Socially'
	);

	INSERT INTO tolerate_smoking(id, property)
	VALUES
	(
	'3',
	'Once a Week'
	);

	INSERT INTO tolerate_smoking(id, property)
	VALUES
	(
	'4',
	'Few Times a Week'
	);
	
	INSERT INTO tolerate_smoking(id, property)
	VALUES
	(
	'5',
	'Daily'
	);


