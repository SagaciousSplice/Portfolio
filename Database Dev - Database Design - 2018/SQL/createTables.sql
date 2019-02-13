DROP TABLE IF EXISTS "tblShirtSize";

CREATE TABLE "tblShirtSize" (
	shirtSizeId	SERIAL PRIMARY KEY,
	shirtSizeLabel 	VARCHAR NOT NULL,
	gender		VARCHAR NOT NULL
);

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

DROP TABLE IF EXISTS "tblGenre";

CREATE TABLE "tblGenre" (
	genreId		SERIAL PRIMARY KEY,
	genreName	VARCHAR NOT NULL,
	isActive	BOOLEAN NOT NULL
);

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

DROP TABLE IF EXISTS "tblJob";

CREATE TABLE "tblJob" (
	jobId	SERIAL PRIMARY KEY,
	title 	VARCHAR NOT NULL
);

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

DROP TABLE IF EXISTS "tblSubscription";

CREATE TABLE "tblSubscription" (
	subscriptionId			SERIAL PRIMARY KEY,
	subscriberId			INTEGER NOT NULL,
	genreId				INTEGER NOT NULL,
	subscriptionDate		TIMESTAMP NOT NULL,
	subscriptionExpiry		TIMESTAMP NOT NULL,
	isAutoRenewal			BOOLEAN  NOT NULL,
	FOREIGN KEY (subscriberId) 	REFERENCES "tblSubscriber"(subscriberId),
	FOREIGN KEY (genreId)		REFERENCES "tblGenre"(genreId)
);

DROP TABLE IF EXISTS "tblItem";

CREATE TABLE "tblItem" (
	itemId			SERIAL PRIMARY KEY,
	itemName		VARCHAR NOT NULL,
	location		INTEGER NOT NULL,
	shelfNumber		VARCHAR NOT NULL,
	quantity		INTEGER NOT NULL,
	isForReorder		BOOLEAN NOT NULL,
	FOREIGN KEY (location) 	REFERENCES "tblLocation"(locationId)
);

DROP TABLE IF EXISTS "tblBoxItemGenre";

CREATE TABLE "tblBoxItemGenre" (
	boxId			SERIAL PRIMARY KEY,
	itemId			INTEGER NOT NULL,
	genreId			INTEGER NOT NULL,
	boxDate			TIMESTAMP,
	FOREIGN KEY (itemId)	REFERENCES "tblItem"(itemId),
	FOREIGN KEY (genreId)	REFERENCES "tblGenre"(genreId)		
);

DROP TABLE IF EXISTS "tblBoxShipment";

CREATE TABLE "tblBoxShipment" (
	subscriptionId			INTEGER NOT NULL,
	boxId				INTEGER NOT NULL,
	dateShipped			TIMESTAMP NOT NULL,
	PRIMARY KEY (subscriptionId, boxId),
	FOREIGN KEY (subscriptionId) 	REFERENCES "tblSubscription"(subscriptionId),
	FOREIGN KEY (boxId) 		REFERENCES "tblBoxItemGenre"(boxId)
);

DROP TABLE IF EXISTS "tblItemLocation";

CREATE TABLE "tblItemLocation" (
	itemId				INTEGER NOT NULL,
	locationId  			INTEGER NOT NULL,
	quantity 			INTEGER NOT NULL,
	PRIMARY KEY (itemId, locationId),
	FOREIGN KEY (itemId)		REFERENCES "tblItem",
	FOREIGN KEY (locationId)	REFERENCES "tblLocation"
);

DROP TABLE IF EXISTS "tblEmployee";

CREATE TABLE "tblEmployee" (
	employeeId			VARCHAR 	NOT NULL, 
	-- EMPLOYEEID - PRIMARY EMAIL, SHOULD BE UNIQUE
	empFirstName		VARCHAR 	NOT NULL,
	empLastName			VARCHAR 	NOT NULL,
	empAddress1			VARCHAR 	NOT NULL,
	empAddress2			VARCHAR,
	empCity				VARCHAR 	NOT NULL,
	empStateProvince		VARCHAR 	NOT NULL,
	empPostalCode			VARCHAR 	NOT NULL,
	empCountry			VARCHAR 	NOT NULL,
	empPassword			VARCHAR 	NOT NULL,
	empEmail2			VARCHAR,
	empPhone 			VARCHAR 	NOT NULL,
	empPhone2			VARCHAR 	NOT NULL,
	startDate			TIMESTAMP	NOT NULL,
	endDate				TIMESTAMP,
	jobId				INTEGER		NOT NULL,
	isSalaried			BOOLEAN		NOT NULL,
	salary				DECIMAL,
	-- 15, 3
	isHourly			BOOLEAN		NOT NULL,
	hourlyRate			DECIMAL,
	-- 15, 3
	PRIMARY KEY (employeeId),
	FOREIGN KEY (jobId)	REFERENCES "tblJob"
);

DROP TABLE IF EXISTS "tblEmployeeLocation";

CREATE TABLE "tblEmployeeLocation" (
	employeeId		VARCHAR 	NOT NULL,
	locationId 		INTEGER		NOT NULL,
	startDate		TIMESTAMP	NOT NULL,
	endDate			TIMESTAMP,
	PRIMARY KEY (employeeId, locationId),
	FOREIGN KEY (employeeId) 	REFERENCES "tblEmployee",
	FOREIGN KEY (locationId)	REFERENCES "tblLocation"
);

DROP TABLE IF EXISTS "tblTransfer";

CREATE TABLE "tblTransfer" (
	transferId		SERIAL PRIMARY KEY,
	joeLocationId		INTEGER NOT NULL,
	transferDate		TIMESTAMP NOT NULL,
	FOREIGN KEY (joeLocationId)	REFERENCES "tblJoeNerdsLocation"(joeLocationId)
);

DROP TABLE IF EXISTS "tblItemTransfer";

CREATE TABLE "tblItemTransfer" (
	itemId		INTEGER	NOT NULL,
	transferId	INTEGER NOT NULL,
	quantity 	INTEGER NOT NULL,
	PRIMARY KEY (itemId, transferId),
	FOREIGN KEY (itemId)		REFERENCES "tblItem"(itemId),
	FOREIGN KEY (transferId)	REFERENCES "tblTransfer"(transferId)
);

DROP TABLE IF EXISTS "tblSupplierOrder";

CREATE TABLE "tblSupplierOrder" (
	orderId			SERIAL PRIMARY KEY,
	supplierId		INTEGER NOT NULL,
	itemId			INTEGER NOT NULL,
	orderQuantity	 	INTEGER NOT NULL,
	orderDate		TIMESTAMP NOT NULL,
	subtotal		DECIMAL	NOT NULL,
	FOREIGN KEY (supplierId)	REFERENCES "tblSupplier"(supplierId),
	FOREIGN KEY (itemId)		REFERENCES "tblItem"(itemId)
);