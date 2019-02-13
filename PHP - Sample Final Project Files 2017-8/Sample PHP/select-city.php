<?php

/*
Author: Sarah Powell
File Name: select-city.php
Description: Page that displays graphic of cities that offers an imagemap that users can use to select a city.
Last Updated: 01 Dec 17
*/

error_reporting(E_ALL);
ini_set("display_errors", 1);

$title = "CITY SELECTION - JUAN IN A MILLION";

/*require header file*/
require 'header.php';
$conn = db_connect();
$user = $_SESSION['user'];
$error = "";

?>



<?php
if($_SERVER["REQUEST_METHOD"] == "POST")
{
	//if no checkboxes checked, load all
	if(!isset($_POST['city']))
	{
		$_SESSION['cities'] = 127;
	}
	else
	{
	//sum values of cities 	
	$_SESSION['cities'] = array_sum($_POST['city']);
	}
	
	//echo "Sum is: " . $_SESSION['cities'];
	header('location: profile-search.php');		
}
?>

<script type="text/javascript">
<!--
	/*NOTE: for the following function to work, on your page
			you have to create a checkbox id'ed as city_toggle
				
	<input type="checkbox"  id="city_toggle" onclick="cityToggleAll();" name="city[]" value="0">
			
		and each city checkbox element has to be an named as an 
		array (specifically named "city[]")
		e.g.
			<input type="checkbox" name="city[]" value="1">Ajax
	*/
	function cityToggleAll()
	{
		//alert("In cityToggleAll()");  //alerts used for de-bugging
		var isChecked = document.getElementById("city_toggle").checked;
		var city_checkboxes = document.getElementsByName("city[]");
		for (var i in city_checkboxes){
		//SAME AS for ( i = 0; i < city_checkboxes.length; i++){
			city_checkboxes[i].checked = isChecked;
		}		
	}
	
//-->
</script>

<h2>Select the areas in which you would like to search for matches:</h2>

<form method="post" action="<?php echo $_SERVER['PHP_SELF'];  ?>">

<table width="100%"  border="0">
	

	<tr>
		<th colspan="4" align="center"><h2>Cities Available:</h2> 	</th> 		
	</tr>
	<tr>
		<td>
			<?php buildCheckbox("city") ?>
		</td>
		
		
		<td>
		
		<img src="./images/webdMap.jpg" alt="Map of Durham Region" usemap="#durhamregion">
		
		<map name="durhamregion">

		<area shape="poly" coords="194, 500, 322, 500, 322, 662, 214, 662, 214, 627, 185, 575, 201, 539, 202, 521, 194,500" alt="Ajax" href="profile-search.php?city=1">
		
		<area shape="poly" coords="327, 331, 484, 331, 484, 459, 327, 459" alt="Brooklin" href="profile-search.php?city=2">
		
		<area shape="poly" coords="633, 333, 779, 333, 779, 657, 633, 657, 633, 333" atl="Bowmanville" href="profile-search.php?city=4">
		
		<area shape="poly" coords="493, 337, 636, 337, 636, 662, 614, 650, 594, 655, 572, 663, 552, 667, 558, 670, 515, 669, 493, 664, 493, 337" atl="Oshawa" href="profile-search.php?city=8">

		<area shape="poly" coords="20, 335, 320, 335, 320, 487, 187, 487, 191, 524, 172, 570, 205, 659, 189, 665, 152, 665, 118, 629, 93, 655, 47, 651, 20, 578, 20, 335" alt="Pickering" href="profile-search.php?city=16">
		
		<area shape="poly" coords="326, 324, 326, 6, 629, 6, 633, 143, 653, 112, 668, 90, 685, 70, 705, 58, 716, 50, 728, 48, 772, 48, 772, 65, 756, 111, 742, 137, 723, 166, 709, 183, 701, 193, 725, 184, 749, 179, 772, 170, 772, 324" alt="Port Perry" href="profile-search.php?city=32">
		
		<area shape="poly" coords="484, 465, 484, 628, 478, 644, 467, 658, 445, 662,409, 631, 375, 646, 331, 645, 327, 465, 448, 465" alt="Whitby" href="profile-search.php?city=64">
		
	</map>
		</td>
		<tr>
		<td colspan="4" align="center"> <br/><input type="submit" value="Submit" style="height:50px; width:150px" /> </td>
	</tr>
</table>

</body>
</html>
