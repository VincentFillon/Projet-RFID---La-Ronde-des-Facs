<?php
/**
 * Created by PhpStorm.
 * User: Vincent
 * Date: 26/03/2015
 * Time: 10:46
 */


// TODO => CHANGER LA CONFIG !!! (ici : config de Pronostiques)
$hote = '37.187.120.205';
$login_bdd = 'prono';
$mdp_bdd = 'pronoPWD';
$bdd = 'pronostiques';
$salt = sha1('pr0n0S31');

// Connect to server and select database.
try
{
    $dbh = new PDO('mysql:host=' . $hote . ';dbname=' . $bdd ,$login_bdd , $mdp_bdd, array(PDO::MYSQL_ATTR_INIT_COMMAND => 'SET NAMES utf8'));
}

catch(Exception $e)
{
    die('Erreur :'.$e->getMessage());
}