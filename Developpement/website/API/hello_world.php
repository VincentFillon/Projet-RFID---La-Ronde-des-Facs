<?php
/**
 * Created by PhpStorm.
 * User: Vincent
 * Date: 05/05/2015
 * Time: 10:46
 */

$name = (isset($_GET['name'])) ? htmlentities($_GET['name']) : NULL;

$jsonObj= "Hello " . $name;

$final_res =json_encode($jsonObj) ;

echo $final_res;