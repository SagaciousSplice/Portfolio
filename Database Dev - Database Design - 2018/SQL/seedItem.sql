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

--1
INSERT INTO "tblItem" (itemName, location, shelfNumber, quantity, isForReorder)
VALUES (
	'Batman Bobblehead',
	1,
	1,
	120,
	false
);

--2
INSERT INTO "tblItem" (itemName, location, shelfNumber, quantity, isForReorder)
VALUES (
	'Spiderman Socks',
	1,
	1,
	120,
	false
);

--3
INSERT INTO "tblItem" (itemName, location, shelfNumber, quantity, isForReorder)
VALUES (
	'Ironman Keychain',
	1,
	1,
	120,
	false
);

--4
INSERT INTO "tblItem" (itemName, location, shelfNumber, quantity, isForReorder)
VALUES (
	'Thor Ring',
	1,
	1,
	120,
	false
);

--5
INSERT INTO "tblItem" (itemName, location, shelfNumber, quantity, isForReorder)
VALUES (
	'Stan Lee Notepad',
	1,
	1,
	120,
	false
);

--6
INSERT INTO "tblItem" (itemName, location, shelfNumber, quantity, isForReorder)
VALUES (
	'Mike Myers Shirt',
	1,
	1,
	120,
	false
);

--7
INSERT INTO "tblItem" (itemName, location, shelfNumber, quantity, isForReorder)
VALUES (
	'Shining Twins Keychain',
	1,
	1,
	120,
	false
);

--8
INSERT INTO "tblItem" (itemName, location, shelfNumber, quantity, isForReorder)
VALUES (
	'Bloody Knife Socks',
	1,
	1,
	120,
	false
);

--9
INSERT INTO "tblItem" (itemName, location, shelfNumber, quantity, isForReorder)
VALUES (
	'Omen Stickers',
	1,
	1,
	120,
	false
);

--10
INSERT INTO "tblItem" (itemName, location, shelfNumber, quantity, isForReorder)
VALUES (
	'Scream T-shirt',
	1,
	1,
	120,
	false
);

--11
INSERT INTO "tblItem" (itemName, location, shelfNumber, quantity, isForReorder)
VALUES (
	'Pac-Man Ring',
	1,
	1,
	120,
	false
);

--12
INSERT INTO "tblItem" (itemName, location, shelfNumber, quantity, isForReorder)
VALUES (
	'Asteroids Pen',
	1,
	1,
	120,
	false
);

--12
INSERT INTO "tblItem" (itemName, location, shelfNumber, quantity, isForReorder)
VALUES (
	'Street Figher Finger Puppets',
	1,
	1,
	120,
	false
);

--13
INSERT INTO "tblItem" (itemName, location, shelfNumber, quantity, isForReorder)
VALUES (
	'Pinball Stickers',
	1,
	1,
	120,
	false
);

--14
INSERT INTO "tblItem" (itemName, location, shelfNumber, quantity, isForReorder)
VALUES (
	'Pong Eraser',
	1,
	1,
	120,
	false
);

--15
INSERT INTO "tblItem" (itemName, location, shelfNumber, quantity, isForReorder)
VALUES (
	'Wreck It Ralph Applique',
	1,
	1,
	120,
	false
);

--16
INSERT INTO "tblItem" (itemName, location, shelfNumber, quantity, isForReorder)
VALUES (
	'Fallout Boy Pen',
	1,
	1,
	120,
	false
);

--17
INSERT INTO "tblItem" (itemName, location, shelfNumber, quantity, isForReorder)
VALUES (
	'Fallout Boy Notepad',
	1,
	1,
	120,
	false
);

--18
INSERT INTO "tblItem" (itemName, location, shelfNumber, quantity, isForReorder)
VALUES (
	'Marty McFly Stickers',
	1,
	1,
	120,
	false
);

--19
INSERT INTO "tblItem" (itemName, location, shelfNumber, quantity, isForReorder)
VALUES (
	'DriveIn Button',
	1,
	1,
	120,
	false
);

--20
INSERT INTO "tblItem" (itemName, location, shelfNumber, quantity, isForReorder)
VALUES (
	'Skateboarder Bobblehead',
	1,
	1,
	120,
	false
);

--21
INSERT INTO "tblItem" (itemName, location, shelfNumber, quantity, isForReorder)
VALUES (
	'Archie Colouring Page',
	1,
	1,
	120,
	false
);

--22
INSERT INTO "tblItem" (itemName, location, shelfNumber, quantity, isForReorder)
VALUES (
	'Richie Rich Notepad',
	1,
	1,
	120,
	false
);

--22
INSERT INTO "tblItem" (itemName, location, shelfNumber, quantity, isForReorder)
VALUES (
	'Sabrina Button',
	1,
	1,
	120,
	false
);

--23
INSERT INTO "tblItem" (itemName, location, shelfNumber, quantity, isForReorder)
VALUES (
	'Jughead Junior Hamburger Eraser',
	1,
	1,
	120,
	false
);

--24
INSERT INTO "tblItem" (itemName, location, shelfNumber, quantity, isForReorder)
VALUES (
	'Josie Socks',
	1,
	1,
	120,
	false
);

--25
INSERT INTO "tblItem" (itemName, location, shelfNumber, quantity, isForReorder)
VALUES (
	'Archie T-shirt',
	1,
	1,
	120,
	false
);