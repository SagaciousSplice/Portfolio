DROP TABLE IF EXISTS "tblSubscriber";

CREATE TABLE "tblSubscriber" (
    subscriberId     SERIAL PRIMARY KEY,
    email            VARCHAR  NOT NULL,
    firstName        VARCHAR  NOT NULL,
    lastName         VARCHAR  NOT NULL,
    address1         VARCHAR  NOT NULL,
    address2         VARCHAR,
    city             VARCHAR  NOT NULL,
    stateProvince    VARCHAR  NOT NULL,
    postalCode       VARCHAR  NOT NULL,
    country          VARCHAR  NOT NULL,
    password         VARCHAR  NOT NULL,
    dateJoined       TIMESTAMP NOT NULL,
    shirtSizeId      INTEGER  NOT NULL,
    FOREIGN KEY (shirtSizeId) REFERENCES "tblShirtSize"(shirtSizeId)
);

INSERT INTO "tblSubscriber" (email, firstName, lastName, address1, city, stateProvince, postalCode, country, password, dateJoined, shirtSizeId)
VALUES (
	'michelle@email.com',
	'michelle',
	'smith',
	'123 Any Street',
	'Sunnytown',
	'Ontario',
	'L7T8M9',
	'Canada',
	'password',
	NOW(),
	5
);

INSERT INTO "tblSubscriber" (email, firstName, lastName, address1, city, stateProvince, postalCode, country, password, dateJoined, shirtSizeId)
VALUES (
	'jane@email.com',
	'Jane',
	'Brown',
	'456 Another Street',
	'Combermere',
	'Ontario',
	'P0L4HV',
	'Canada',
	'password',
	NOW(),
	3
);

INSERT INTO "tblSubscriber" (email, firstName, lastName, address1, city, stateProvince, postalCode, country, password, dateJoined, shirtSizeId)
VALUES (
	'laura@email.com',
	'Laura',
	'Lee',
	'7 Jamms Rd',
	'Hanover',
	'Ontario',
	'M4G5M5',
	'Canada',
	'password',
	NOW(),
	2
);

INSERT INTO "tblSubscriber" (email, firstName, lastName, address1, city, stateProvince, postalCode, country, password, dateJoined, shirtSizeId)
VALUES (
	'patricia@email.com',
	'Pat',
	'Nyugen',
	'89 Hook Cres',
	'Toronto',
	'Ontario',
	'M7G9M1',
	'Canada',
	'password',
	NOW(),
	7
);

INSERT INTO "tblSubscriber" (email, firstName, lastName, address1, city, stateProvince, postalCode, country, password, dateJoined, shirtSizeId)
VALUES (
	'li@email.com',
	'Li',
	'Chan',
	'100 Millionaire Row',
	'King City',
	'Ontario',
	'N9R3P5',
	'Canada',
	'password',
	NOW(),
	1
);