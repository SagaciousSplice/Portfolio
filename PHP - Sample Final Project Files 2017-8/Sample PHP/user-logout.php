<?php

/*
	File Description: Will verify that user is logged into session, 
					unset and destroy session, start a new session, 
					message user thatn they have logged out, and 
					redirect to login page.
	
	Date Modified: 06 October 2017
	
	Class: WEBD3201
	
	Author: Sarah Powell
			Group 07
*/

			$title = "Juan in a Million - Logout - WebD3201";
			$banner= "Juan in a Million - Logged - WebD3201";
			$filename= $_SERVER["SCRIPT_NAME"];
			$date = "Oct 06, 2017";
			$description = "This is the user logout page for the *FAKE* dating website 'Juan in a Million' being created for WebD3201. This site will be added to over the the fall 2017/2018 semester. This page allows
			users to logout if they a currently in a session, start a new session, message the user, and redirect to the login page.";
			
			
			
?>

<!-- header file include -->
<?php 
require 'header.php';

$message = "";

if(session_id() != "")
{
	//if session is active, end it
	//if there are values in $_SESSION, unset them and destroy the session
	if(isset($_SESSION))
	{
		session_unset();
		session_destroy();
		setCookie("login_id", null, time() + COOKIE_EXPIRE);
	}
	
	// start a new session 
} 

	session_start();


	//if logged out, change message
	$logout_message .= "You are now logged out.";
	$_SESSION['message'] = $logout_message;
	
	redirect("./user_login.php");
?>

