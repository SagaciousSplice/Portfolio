DROP TABLE IF EXISTS "tblBoxItemGenre";

CREATE TABLE "tblBoxItemGenre" (
	boxId			SERIAL PRIMARY KEY,
	itemId			INTEGER NOT NULL,
	genreId			INTEGER NOT NULL,
	boxDate			TIMESTAMP,
	FOREIGN KEY (itemId)	REFERENCES "tblItem"(itemId),
	FOREIGN KEY (genreId)	REFERENCES "tblGenre"(genreId)		
);

INSERT INTO "tblBoxItemGenre" (itemId, genreId, boxDate)
VALUES (
	1,
	2,
	NOW()
);

INSERT INTO "tblBoxItemGenre" (itemId, genreId, boxDate)
VALUES (
	2,
	2,
	NOW()
);

INSERT INTO "tblBoxItemGenre" (itemId, genreId, boxDate)
VALUES (
	3,
	2,
	NOW()
);

INSERT INTO "tblBoxItemGenre" (itemId, genreId, boxDate)
VALUES (
	4,
	2,
	NOW()
);

INSERT INTO "tblBoxItemGenre" (itemId, genreId, boxDate)
VALUES (
	5,
	2,
	NOW()
);

INSERT INTO "tblBoxItemGenre" (itemId, genreId, boxDate)
VALUES (
	6,
	1,
	NOW()
);

INSERT INTO "tblBoxItemGenre" (itemId, genreId, boxDate)
VALUES (
	7,
	1,
	NOW()
);

INSERT INTO "tblBoxItemGenre" (itemId, genreId, boxDate)
VALUES (
	8,
	1,
	NOW()
);

INSERT INTO "tblBoxItemGenre" (itemId, genreId, boxDate)
VALUES (
	9,
	1,
	NOW()
);

INSERT INTO "tblBoxItemGenre" (itemId, genreId, boxDate)
VALUES (
	10,
	1,
	NOW()
);