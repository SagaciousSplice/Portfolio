DROP TABLE IF EXISTS "tblSupplier";

CREATE TABLE "tblSupplier" (
	supplierId		SERIAL PRIMARY KEY,
	supName			VARCHAR NOT NULL,
	supAddress1		VARCHAR NOT NULL,
	supAddress2		VARCHAR,
	supCity			VARCHAR NOT NULL,
	supStateProvince	VARCHAR NOT NULL,
	supPostalCode		VARCHAR NOT NULL,
	supCountry		VARCHAR NOT NULL,
	supPhone		VARCHAR NOT NULL,
	supEmail		VARCHAR NOT NULL
);

INSERT INTO "tblSupplier" (supName, supAddress1, supCity, supStateProvince, supPostalCode, supCountry, supPhone, supEmail)
VALUES (
	'Geek Things',
	'34 Pacific St',
	'Vancouver',
	'British Columbia',
	'T7Y6I9',
	'Canada',
	'999-888-7777',
	'geekthings@email.com'
);

INSERT INTO "tblSupplier" (supName, supAddress1, supCity, supStateProvince, supPostalCode, supCountry, supPhone, supEmail)
VALUES (
	'Super Hero Supplies',
	'178 Manitoba Dr',
	'Winnipeg',
	'Manitopa',
	'P8R5G3',
	'Canada',
	'111-222-3333',
	'superherosupplies@email.com'
);

INSERT INTO "tblSupplier" (supName, supAddress1, supCity, supStateProvince, supPostalCode, supCountry, supPhone, supEmail)
VALUES (
	'Trinkets N Things',
	'68 Klondike St',
	'Montreal',
	'Quebec',
	'K8Y6G4',
	'Canada',
	'444-555-7777',
	'trinkets@email.com'
);