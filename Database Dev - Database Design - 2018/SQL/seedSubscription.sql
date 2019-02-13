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

INSERT INTO "tblSubscription" (subscriberId, genreId, subscriptionDate, subscriptionExpiry, isAutoRenewal)
VALUES (
	6,
	1,
	NOW(),
	NOW() + '2 months',
	true	
);

INSERT INTO "tblSubscription" (subscriberId, genreId, subscriptionDate, subscriptionExpiry, isAutoRenewal)
VALUES (
	2,
	3,
	NOW(),
	NOW() + '4 months',
	true	
);

INSERT INTO "tblSubscription" (subscriberId, genreId, subscriptionDate, subscriptionExpiry, isAutoRenewal)
VALUES (
	3,
	4,
	NOW(),
	NOW() + '1 month',
	true	
);

INSERT INTO "tblSubscription" (subscriberId, genreId, subscriptionDate, subscriptionExpiry, isAutoRenewal)
VALUES (
	4,
	4,
	NOW(),
	NOW() + '5 months',
	true	
);

INSERT INTO "tblSubscription" (subscriberId, genreId, subscriptionDate, subscriptionExpiry, isAutoRenewal)
VALUES (
	5,
	5,
	NOW(),
	NOW() + '2 months',
	true	
);