DROP TABLE IF EXISTS "tblShirtSize";

CREATE TABLE "tblShirtSize" (
	shirtSizeId	SERIAL PRIMARY KEY,
	shirtSizeLabel 	VARCHAR NOT NULL,
	gender		VARCHAR NOT NULL
);

INSERT INTO "tblShirtSize" (shirtSizeLabel, gender)
VALUES ('xxs', 'women');

INSERT INTO "tblShirtSize" (shirtSizeLabel, gender)
VALUES ('xs', 'women');

INSERT INTO "tblShirtSize" (shirtSizeLabel, gender)
VALUES ('s', 'women');

INSERT INTO "tblShirtSize" (shirtSizeLabel, gender)
VALUES ('m', 'women');

INSERT INTO "tblShirtSize" (shirtSizeLabel, gender)
VALUES ('lg', 'women');

INSERT INTO "tblShirtSize" (shirtSizeLabel, gender)
VALUES ('xlg', 'women');

INSERT INTO "tblShirtSize" (shirtSizeLabel, gender)
VALUES ('xxlg', 'women');

INSERT INTO "tblShirtSize" (shirtSizeLabel, gender)
VALUES ('xxs', 'men');

INSERT INTO "tblShirtSize" (shirtSizeLabel, gender)
VALUES ('xs', 'men');

INSERT INTO "tblShirtSize" (shirtSizeLabel, gender)
VALUES ('s', 'men');

INSERT INTO "tblShirtSize" (shirtSizeLabel, gender)
VALUES ('m', 'men');

INSERT INTO "tblShirtSize" (shirtSizeLabel, gender)
VALUES ('lg', 'men');

INSERT INTO "tblShirtSize" (shirtSizeLabel, gender)
VALUES ('xlg', 'men');

INSERT INTO "tblShirtSize" (shirtSizeLabel, gender)
VALUES ('xxlg', 'men');