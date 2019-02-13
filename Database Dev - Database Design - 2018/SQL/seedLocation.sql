DROP TABLE IF EXISTS "tblLocation";

CREATE TABLE "tblLocation" (
	locationId 		SERIAL PRIMARY KEY,
	locName			VARCHAR NOT NULL,
	locAddress1		VARCHAR NOT NULL,
	locAddress2		VARCHAR,
	locCity			VARCHAR NOT NULL,
	locStateProvince	VARCHAR NOT NULL,
	locPostalCode		VARCHAR NOT NULL,
	locCountry		VARCHAR NOT NULL
);

INSERT INTO "tblLocation" (locName, locAddress1, locCity, locStateProvince, locPostalCode, locCountry)
VALUES (
	'NerdBlock HQ',
	'101 Fantastic Way',
	'Toronto',
	'Ontario',
	'M4W1E6',
	'Canada'
);