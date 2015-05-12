<?php
/**
 * Created by PhpStorm.
 * User: Vincent
 * Date: 05/05/2015
 * Time: 10:46
 */
header ("Content-Type:application/soap+xm");

include '../config/config.php';

$userID = (isset($_GET['userId'])) ? htmlentities($_GET['userId']) : NULL;

$jsonObj = array();

try {
    $sql = $dbh->query("SELECT * FROM User WHERE user_id = '" . $userID . "'");

    if ($sql->rowCount() < 1) {
        $jsonObj= "ERROR : Bad request";
    }
    else {
        $jsonObj = $sql->fetch(PDO::FETCH_ASSOC);
    }

} catch (PDOException $e) {
    print "Erreur !: " . $e->getMessage() . "<br/>";
}

array_to_xml($jsonObj, $xml);
print $xml->asXML();