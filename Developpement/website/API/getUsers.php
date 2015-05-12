<?php
/**
 * Created by PhpStorm.
 * User: Vincent
 * Date: 05/05/2015
 * Time: 10:46
 */

header ("Content-Type:application/soap+xm");

include '../config/config.php';

try {
    $sql = $dbh->query("SELECT * FROM User");

    $jsonObj = array();

    if ($sql->rowCount() < 1) {
        $jsonObj= "ERROR : Bad request";
    }
    else {
        while ($user = $sql->fetch(PDO::FETCH_ASSOC)) {
            $jsonObj[] = $user;
        }
    }

} catch (PDOException $e) {
    print "Erreur !: " . $e->getMessage() . "<br/>";
}

$xml = new SimpleXMLElement('<result/>');
array_to_xml($jsonObj, $xml);
print $xml->asXML();