DROP TABLE IF EXISTS "tblJob";

CREATE TABLE "tblJob" (
	jobId	SERIAL PRIMARY KEY,
	title 	VARCHAR NOT NULL
);

INSERT INTO "tblJob" (title)
VALUES (
	'CSR'
);

INSERT INTO "tblJob" (title)
VALUES (
	'CSR Manager'
);

INSERT INTO "tblJob" (title)
VALUES (
	'HR'
);

INSERT INTO "tblJob" (title)
VALUES (
	'HR Manager'
);

INSERT INTO "tblJob" (title)
VALUES (
	'IT Support'
);

INSERT INTO "tblJob" (title)
VALUES (
	'IT Support Manager'
);