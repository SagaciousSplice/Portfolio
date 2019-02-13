DROP TABLE IF EXISTS "tblGenre";

CREATE TABLE "tblGenre" (
	genreId		SERIAL PRIMARY KEY,
	genreName	VARCHAR NOT NULL,
	isActive	BOOLEAN NOT NULL
);

INSERT INTO "tblGenre" (genreName, isActive)
VALUES (
	'Horror',
	true
);

INSERT INTO "tblGenre" (genreName, isActive)
VALUES (
	'Super Hero',
	true
);

INSERT INTO "tblGenre" (genreName, isActive)
VALUES (
	'Arcade',
	true
);

INSERT INTO "tblGenre" (genreName, isActive)
VALUES (
	'Retro',
	true
);

INSERT INTO "tblGenre" (genreName, isActive)
VALUES (
	'Comics',
	true
);