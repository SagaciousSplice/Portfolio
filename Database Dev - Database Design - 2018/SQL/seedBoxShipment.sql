DROP TABLE IF EXISTS "tblBoxShipment";

CREATE TABLE "tblBoxShipment" (
	subscriptionId			INTEGER NOT NULL,
	boxId				INTEGER NOT NULL,
	dateShipped			TIMESTAMP NOT NULL,
	PRIMARY KEY (subscriptionId, boxId),
	FOREIGN KEY (subscriptionId) 	REFERENCES "tblSubscription"(subscriptionId),
	FOREIGN KEY (boxId) 		REFERENCES "tblBoxItemGenre"(boxId)
);

INSERT INTO "tblBoxShipment" (subscriptionId, boxId, dateShipped)
VALUES (
	3,
	1,
	NOW()
);

INSERT INTO "tblBoxShipment" (subscriptionId, boxId, dateShipped)
VALUES (
	4,
	2,
	NOW()
);

INSERT INTO "tblBoxShipment" (subscriptionId, boxId, dateShipped)
VALUES (
	5,
	1,
	NOW()
);

INSERT INTO "tblBoxShipment" (subscriptionId, boxId, dateShipped)
VALUES (
	6,
	2,
	NOW()
);

INSERT INTO "tblBoxShipment" (subscriptionId, boxId, dateShipped)
VALUES (
	7,
	1,
	NOW()
);
