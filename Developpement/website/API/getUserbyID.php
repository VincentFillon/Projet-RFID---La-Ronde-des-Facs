<?php
/**
 * Created by PhpStorm.
 * User: Vincent
 * Date: 05/05/2015
 * Time: 10:46
 */

header ("Content-Type:text/xml");

include '../config/config.php';

$userID = (isset($_GET['userId'])) ? htmlentities($_GET['userId']) : NULL;

$sql = "Select * FROM [User] where [user_id] = '" . $userID . "'";

$stmt = sqlsrv_query($link, $sql);

if( $stmt === false ) {
    die( print_r( sqlsrv_errors(), true));
}

while( $row = sqlsrv_fetch_array( $stmt, SQLSRV_FETCH_ASSOC) ) {
    $jsonObj[] = array("user_id"=>$row["user_id"], "nom"=>$row["nom"], "prenom"=>$row["prenom"], "date_naissance"=>$row["date_naissance"], "faculte"=>$row["faculte"], "promotion"=>$row["promotion"],);
}

array_to_xml($jsonObj, $xml);
print $xml->asXML();