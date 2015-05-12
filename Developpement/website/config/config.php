<?php
/**
 * Created by PhpStorm.
 * User: Vincent
 * Date: 26/03/2015
 * Time: 10:46
 */

$hote = '37.187.120.205';
$login_bdd = 'rondedesfacs';
$mdp_bdd = 'rdf2016';
$bdd = 'FacPrincipal';
$salt = sha1('pr0n0S31');

// Connect to server and select database.
try
{
    $dbh = new PDO('mysql:host=' . $hote . ';dbname=' . $bdd ,$login_bdd , $mdp_bdd,
        array(
            PDO::MYSQL_ATTR_LOCAL_INFILE => true,
            PDO::ATTR_ERRMODE => PDO::ERRMODE_EXCEPTION,
            PDO::MYSQL_ATTR_INIT_COMMAND => 'SET NAMES utf8'
        )
    );
}

catch(Exception $e)
{
    die('Erreur :'.$e->getMessage());
}

$server = '(local)';
$connexionInfo = array("Database"=>"FacPrincipal");
$link = sqlsrv_connect($server,$connexionInfo);
if( $link ) {
    echo "Connexion établie.<br />";
}else{
    echo "La connexion n'a pu être établie.<br />";
    die( print_r( sqlsrv_errors(), true));
}