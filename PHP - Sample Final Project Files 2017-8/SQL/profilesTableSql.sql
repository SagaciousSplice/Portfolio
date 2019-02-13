-- drop table if exists
DROP TABLE IF EXISTS profiles;

CREATE TABLE profiles(
user_id VARCHAR(20) NOT NULL PRIMARY KEY REFERENCES users(user_id),
gender SMALLINT NOT NULL,
gender_sought SMALLINT NOT NULL,
city INT NOT NULL,
images SMALLINT NOT NULL DEFAULT 0, --updated as per class
headline VARCHAR(100) NOT NULL,
self_description VARCHAR(1000) NOT NULL,
match_description VARCHAR(1000) NOT NULL,

smoker SMALLINT NOT NULL,
drinker SMALLINT NOT NULL,
religion SMALLINT NOT NULL,
education SMALLINT NOT NULL,
body_size SMALLINT NOT NULL,
height SMALLINT NOT NULL,
relationship SMALLINT NOT NULL,
have_kids SMALLINT NOT NULL,
want_kids SMALLINT NOT NULL,
pets SMALLINT NOT NULL,
entertainment SMALLINT NOT NULL,
tolerate_smoking SMALLINT NOT NULL

);

ALTER TABLE profiles OWNER TO group07_admin;

INSERT INTO profiles (user_id, gender, gender_sought, city, images, headline, self_description, match_description, smoker, drinker, religion, education, body_size, height, relationship, have_kids, want_kids, pets, entertainment, tolerate_smoking)
VALUES('wchurchill', 1, 2, 1, 0, 'headline', 'self', 'match', 16, 16, 2, 4, 16, 64, 32, 1, 4, 4, 16, 16);