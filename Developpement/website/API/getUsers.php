<?php
/**
 * Created by PhpStorm.
 * User: Vincent
 * Date: 05/05/2015
 * Time: 10:46
 */

include '../config/config.php';

try {
    $sql = $dbh->query("SELECT * FROM User");

    $jsonObj = array();

    if ($sql->rowCount() < 1) {
        $jsonObj= "ERROR : Bad request";
    }
    else {
        while ($user = $sql->fetch(PDO::FETCH_OBJ)) {
            $jsonObj[] = $user;
        }
    }

} catch (PDOException $e) {
    print "Erreur !: " . $e->getMessage() . "<br/>";
}

$final_res =json_encode($jsonObj) ;

echo $final_res;