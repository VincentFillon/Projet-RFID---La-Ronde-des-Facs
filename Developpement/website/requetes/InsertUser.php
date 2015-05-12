<?php
/**
 * Created by PhpStorm.
 * User: melanie
 * Date: 12/05/2015
 * Time: 20:48
 */
include('../config/config.php');

$userId = $_POST['userId'];
$nom = $_POST['nom'];
$prenom = $_POST['prenom'];
$dateNaiss = $_POST['date'];
$faculte = $_POST['faculte'];
$promo = $_POST['promo'];

//$sql = "EXEC ps_Insert @user = '$userId', @nom = '$nom', @prenom = '$prenom', @dateNaissance = $dateNaiss, @faculte = '$faculte', @promotion = '$promo'";
//$param = array($userId, $nom, $prenom, $dateNaiss, $faculte, $promo);
//echo $sql;

$newtry = "INSERT INTO [User] VALUES (? , ? , ? , ?, ?, ?)";
$param = array($userId, $nom, $prenom, $dateNaiss, $faculte, $promo);

$stmt = sqlsrv_query($link, $newtry, $param);
if( $stmt === false ) {
    die( print_r( sqlsrv_errors(), true));
}
else{
    echo "Success ";
}
header('../index.php');