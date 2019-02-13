DROP TABLE IF EXISTS interests;

CREATE TABLE interests(
interested_user VARCHAR(20) NOT NULL REFERENCES users(user_id),
interest VARCHAR(20) NOT NULL REFERENCES users(user_id),
primary key (interested_user, interest)
);

ALTER TABLE interests OWNER TO group07_admin;

--first three women that are interested in wchurchill
INSERT INTO interests(interested_user, interest)
	VALUES(
			'lunsfordd',
			'wchurchill'	
	);
	
INSERT INTO interests(interested_user, interest)
	VALUES(
			'baskina',
			'wchurchill'	
	);
	
INSERT INTO interests(interested_user, interest)
	VALUES(
			'weiderholdf',
			'wchurchill'	
	);
	
--next three are the women wchurchill are interested in
--firstone, lunsfordd, is a reciprocated interest
INSERT INTO interests(interested_user, interest)
	VALUES(
			'wchurchill',
			'lunsfordd'	
	);
	
	
INSERT INTO interests(interested_user, interest)
	VALUES(
			'wchurchill',
			'burchh'	
	);
	
	
INSERT INTO interests(interested_user, interest)
	VALUES(
			'wchurchill',
			'gelsingero'	
	);
	
