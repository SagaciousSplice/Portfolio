DROP TABLE IF EXISTS "tblJoeNerdsLocation";

CREATE TABLE "tblJoeNerdsLocation" (
	joeLocationId		SERIAL PRIMARY KEY,
	joeName			VARCHAR	NOT NULL,
	joeAddress1		VARCHAR	NOT NULL,
	joeAddress2		VARCHAR,
	joeCity			VARCHAR	NOT NULL,
	joeStateProvince	VARCHAR	NOT NULL,
	joePostalCode		VARCHAR NOT NULL,
	joeCountry		VARCHAR	NOT NULL,
	joePhone		VARCHAR	NOT NULL,
	joeEmail		VARCHAR	NOT NULL,
	joeManager		VARCHAR
);

INSERT INTO "tblJoeNerdsLocation" (joeName, joeAddress1, joeCity, joeStateProvince, joePostalCode, JoeCountry, joePhone, joeEmail)
VALUES (
	'Uptown JoeNerds',
	'34B Placid Way',
	'Scarborough',
	'Ontario',
	'M1F1G4',
	'Canada',
	'905-555-8888',
	'joenerds28@email.com'
);

INSERT INTO "tblJoeNerdsLocation" (joeName, joeAddress1, joeCity, joeStateProvince, joePostalCode, JoeCountry, joePhone, joeEmail)
VALUES (
	'Downtown JoeNerds',
	'8 General Dr',
	'Toronto',
	'Ontario',
	'M5Y1F7',
	'Canada',
	'905-666-9999',
	'joenerds32@email.com'
);