<!-- seed the users table -->

<?php

	/*
		Author: Sarah Powell
		File Name: seedDB.php
		Description: Page that uses a file of names to populate the db based on criteria
		Last Updated: 01 Dec 17
	*/

	require './header.php';
	require './includes/names.php';
	//require './includes/functions.php';

	error_reporting(E_ALL);
	ini_set('display_errors', 1);
	
	//variables
	$error = "";
	
	//tested connection function
	$conn = db_connect();
	
	$users_insert_statement = pg_prepare($conn, 'users_insert', "INSERT INTO users (user_id, password, user_type, email_address, first_name, last_name, birth_date, enrol_date, last_access) VALUES ($1, $2, $3, $4, $5, $6, $7, $8, $9)");

	$profile_insert_statement = pg_prepare($conn, 'profile_insert', "INSERT INTO profiles (user_id, gender, 	gender_sought, city, images, headline, self_description, match_description, smoker, drinker, religion, education, body_size, height, relationship, have_kids, want_kids, pets, entertainment, tolerate_smoking)
	VALUES($1, $2, $3, $4, $5, $6, $7, $8, $9, $10, $11, $12, $13, $14, $15, $16, $17, $18, $19, $20)");
	
	//function to pull random data based on table name
	function random_data($table_name, $array_of_tables, $table_data)
	{
		$index = (array_search($table_name, $array_of_tables));
		$random_item = $table_data[$index][array_rand($table_data[$index])]['id'];
		return $random_item;
	};
	
		//date enrolled in the last couple of calendar years
		define('OLDEST_YEAR_OF_ENROLLMENT', 2015);
		define('YEARS_SINCE', 2);
		define('MONTHS', 12);
		define('DAYS',28);
		define('DATE_OFFSET', 1);
		
		
		//create a date of birth between 1950 and 2017
		define('OLDEST_YEAR_OF_BIRTH', 1950);
		define('CURRENT_YEAR', 2017);
		define('MAXIMUM_AGE', 56);
		define ('MINIMUM_AGE', 19);
		
		define('IMAGES_DEFAULT',0);
		
		define('SECONDS_IN_A_YEAR', 31536000);
		
		define('OLDEST_YEAR_OF_LAST_ACCESS', 2016);
		define('YEARS_SINCE_ACCESS', 1);
				
		
	
	for($i = 0; $i <= 2500; $i++)
	{
		//array of referential table names
		$reference_table_names = array("gender", "gender_sought", "city", "smoker", "drinker", "religion", "education", "body_size", "height", "relationship", "have_kids", "want_kids", "pets", "entertainment", "tolerate_smoking");
		
		//create an array to capture all the data from all the tables
		$all_table_data = array();
		//loop through tables and grab all the data from all tables where the id is not 0 and put it in the $all_table_data
		foreach($reference_table_names as $table)
		{
			$sql = "SELECT * FROM $table WHERE id <> 0";
			$result = pg_query($conn, $sql);
			$data = pg_fetch_all($result);
			
			array_push($all_table_data, $data);
			
		}
		
		//dump($all_table_data);
		//PROFILES TABLE SEED SECTION
		
		//list the variables that need filling for the prepared insert statement
		
		//gender first so names can be picked
		//create a varaible to hold a random gender value
		//go into all table data where gender is table index 0 and randomly pick an id from gender table
		$gender = random_data('gender', $reference_table_names, $all_table_data);
		
		//randomize the gender sought
		$gender_sought = random_data('gender_sought', $reference_table_names, $all_table_data);
		
		
		//last name random from last name array
		$last_name = ucwords(strtolower($last_names[mt_rand()%sizeof($last_names)]));
		
		
		//use random gender to pick a first and last names
		if($gender == 1)
		{
			$first_name = ucwords(strtolower($male_names[mt_rand()%sizeof($male_names)]));
		}
		else
		{
			$first_name = ucwords(strtolower($female_names[mt_rand()%sizeof($female_names)]));
		}
		
		
		//create userid from the firstname and last name
		$temp_last_name = substr($last_name, 0, 18);
		$user_id = strtolower($temp_last_name . substr($first_name, 0, 1));
		
		//random city from all table data;
		$city = random_data('city', $reference_table_names, $all_table_data);
		
		//set images to default 'cause there is none
		$images = IMAGES_DEFAULT;
		
		//create a decent headline later
		$headline = "I am a fun-loving " . strtolower($all_table_data[0][$gender-1]['property']) . " looking for a serious relationship with a great " . strtolower($all_table_data[1][$gender_sought-1]['property']) . ".";
		
		//MAKE BIRTH_DATE HERE TO USE IN DESCRIPTION
		//date entered as yyyy-mm-dd
		$temp_year = OLDEST_YEAR_OF_BIRTH + mt_rand()%MAXIMUM_AGE;
		//make sure there's no under-18s 
		$year = (CURRENT_YEAR-$temp_year < MINIMUM_AGE ? CURRENT_YEAR - MINIMUM_AGE:$temp_year);
		$month = (mt_rand()%12) + 1;
		$day = (mt_rand()%28) + 1;
		$birth_date = $year . "-"  . $month . "-" . $day;
		
		
		
		//randomize if user is a smoker
		$smoker = random_data('smoker', $reference_table_names, $all_table_data);
		
		//randomize if user is a drinker
		$drinker = random_data('drinker', $reference_table_names, $all_table_data);
		
		//randomize user's religion
		$religion = random_data('religion', $reference_table_names, $all_table_data);
		
		//randomize user's education level
		$education = random_data('education', $reference_table_names, $all_table_data);
		
		//randomize body_size
		$body_size = random_data('body_size', $reference_table_names, $all_table_data);
		
		//randomize height
		$height = random_data('height', $reference_table_names, $all_table_data);
		
		//randomize relationship data
		$relationship_status = random_data('relationship', $reference_table_names, $all_table_data);
		
		//randomize if user has kids
		$have_kids = random_data('have_kids', $reference_table_names, $all_table_data);
		
		//randomize if user wants kids
		$want_kids = random_data('want_kids', $reference_table_names, $all_table_data);
		
		//randomize if user has pets
		$pets = random_data('pets', $reference_table_names, $all_table_data);
		
		//randomize the type of entertainment the user likes
		$entertainment = random_data('entertainment', $reference_table_names, $all_table_data);
		
		//randomize if user will be with a smoker
		$tolerate_smoking = random_data('tolerate_smoking', $reference_table_names, $all_table_data);
		
		//create a decent self-description later
		$dob = strtotime($birth_date);
		$age = floor((time()-$dob ) / SECONDS_IN_A_YEAR);
		$self_description = "I am a " . $age . " year old " . strtolower($all_table_data[8][array_search($body_size, array_column($all_table_data, 'body_size'))]['property']) . ", " . ucwords($all_table_data[5][array_search($religion, array_column($all_table_data, 'religion'))]['property']) . " " . strtolower($all_table_data[0][array_search($gender, array_column($all_table_data, 'gender'))]['property']) . " who likes to spend their free time " . strtolower($all_table_data[13][array_search($entertainment, array_column($all_table_data, 'entertainment'))]['property']) . ".";
		
		//create a decent match-description later
		$match_description = "I'm looking for " . $age . " year old " . strtolower($all_table_data[8][array_search($body_size, array_column($all_table_data, 'body_size'))]['property']) . ", " . ucwords($all_table_data[5][array_search($religion, array_column($all_table_data, 'religion'))]['property']) . " " . strtolower($all_table_data[0][array_search($gender_sought, array_column($all_table_data, 'gender_sought'))]['property']) . " who likes to spend their free time " . strtolower($all_table_data[13][array_search($entertainment, array_column($all_table_data, 'entertainment'))]['property']) . ".";
		
		//the collected array of user data to insert to the table
		$profile_data =  array( $user_id, $gender, $gender_sought, $city, $images, $headline, $self_description, $match_description, $smoker, $drinker, $religion, $education, $body_size, $height, $relationship_status, $have_kids, $want_kids, $pets, $entertainment, $tolerate_smoking );
		
		
		
		/* ************************************** */
		
		
		//USER TABLE SEED SECTION
		//need for user_id, password, user_type, email_address, first_name, last_name, birth_date, enrol_date, last_access
		
		//user_id, first_name, and last_name already dealt with above
		
		//always use same password: a
		$password = md5('a');
		
		//create an array with a proportion of different user types (mostly c and i) and randomly select from it
		$user_types = array('a', 'i', 'i', 'i', 'i', 'i', 'i', 'i', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'c', 'd', 'dc', 'da');
		$user_type =  $user_types[mt_rand()%sizeof($user_types)];
		
		//create an array of domains and randomly select and concatinate
		$email_domains =  array('@gmail.com', '@dcmail.ca', '@rogers.ca', '@bell.ca', '@me.com', '@yahoo.com', '@sympatico.ca', '@hotmail.com');
		$email_address = $user_id . ($email_domains[mt_rand()%sizeof($email_domains)]);
		
		
		//enrol date randomized
		//date enrolled in the last couple of calendar years
		//date enrolled as yyyy-mm-dd
		$enrol_year = OLDEST_YEAR_OF_ENROLLMENT + mt_rand()%YEARS_SINCE;
		$enrol_month = (mt_rand()%MONTHS) + DATE_OFFSET;
		$enrol_day = (mt_rand()%DAYS) + DATE_OFFSET;
		$enrol_date = $enrol_year . "-" . $enrol_month . "-" . $enrol_day;
		
		//last access in the last year
		$last_access_year =  OLDEST_YEAR_OF_LAST_ACCESS + mt_rand()%YEARS_SINCE_ACCESS;
		$last_access_month = (mt_rand()%MONTHS) + DATE_OFFSET;
		$last_access_day = (mt_rand()%DAYS) + DATE_OFFSET;
		$last_access = $last_access_year . "-" . $last_access_month . "-" . $last_access_day;
		
		//collect the variables in an array
		$user_data = array( $user_id, $password, $user_type, $email_address, $first_name, $last_name, $birth_date, $enrol_date, $last_access );
		
		//update users first so profiles update will succeed with foreign key reference
		$update_users = pg_execute($conn, 'users_insert', $user_data);
		
		//if the result of update fails spit out error
		if ($update_users === false)
		{
			//spit out failed update error
			$error .= " There was an error while attempting to update the users table. <br/>";
		}
		
		//only if the user is not "incomplete" do you update the profile information
		if($user_type!='i')
		{
			//execute the prepared statement with the user data as the variables
			$update_profile = pg_execute($conn, 'profile_insert', $profile_data);
	
			//if the result of update fails spit out error
			if ($update_profile === false)
			{
				//spit out failed update error
				$error .= " There was an error while attempting to update the profiles table. <br/>";
			}
		}
		
	}
	
	
	
	
	
	
?>