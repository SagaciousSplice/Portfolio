DROP TABLE IF EXISTS offensives;

CREATE TABLE offensives(
offender VARCHAR(20) NOT NULL PRIMARY KEY REFERENCES users(user_id),
reporter VARCHAR(20) NOT NULL REFERENCES users(user_id),
time_reported TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
is_open BOOLEAN NOT NULL
);

ALTER TABLE offensives OWNER TO group07_admin;


INSERT INTO offensives(offender, reporter, is_open)
	VALUES(
			'wontorc',
			'kemptonq',
			false
	);
	
	INSERT INTO offensives(offender, reporter, is_open)
	VALUES(
			'vidulichr',
			'luthyk',
			false
	);
	
	INSERT INTO offensives(offender, reporter, is_open)
	VALUES(
			'molesa',
			'tietzek',
			true
	);
	
	INSERT INTO offensives(offender, reporter, is_open)
	VALUES(
			'critchfieldm',
			'lehmannd',
			true
	);
	
	INSERT INTO offensives(offender, reporter, is_open)
	VALUES(
			'asah',
			'aguirrea',
			true
	);
	
	INSERT INTO offensives(offender, reporter, is_open)
	VALUES(
			'pesinm',
			'blowes',
			true
	);