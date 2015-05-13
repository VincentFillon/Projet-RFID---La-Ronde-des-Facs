<?php
/**
 * Created by PhpStorm.
 * User: melanie
 * Date: 12/05/2015
 * Time: 20:48
 */
include('../config/config.php');

$userId = $_POST['id'];

$sql = "DELETE FROM [User] WHERE [user_id] = '$userId' ";
//$param = array($userId, $nom, $prenom, $dateNaiss, $faculte, $promo);

$stmt = sqlsrv_query($link, $sql);
if( $stmt === false ) {
    die( print_r( sqlsrv_errors(), true));
}
else{
    echo "Success ";
}
header('../index.php');