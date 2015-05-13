<?php
/**
 * Created by PhpStorm.
 * User: Vincent
 * Date: 26/03/2015
 * Time: 10:46
 */

$server = 'MELANIE-PC\SQLEXPRESS';
$connexionInfo = array("Database"=>"FacSecondaire");
$link = sqlsrv_connect($server,$connexionInfo);
if( !$link ) {
    echo "La connexion n'a pu être établie.<br />";
    die( print_r( sqlsrv_errors(), true));
}