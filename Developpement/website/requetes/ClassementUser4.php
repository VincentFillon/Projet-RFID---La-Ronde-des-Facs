<?php
/**
 * Created by PhpStorm.
 * User: melanie
 * Date: 12/05/2015
 * Time: 20:48
 */
include('../config/configSecondaire.php');


$sql = "Select *
FROM [Borne]
order by [nb_passage],[temps] desc ";


$stmt = sqlsrv_query($link, $sql);
if( $stmt === false ) {
    die( print_r( sqlsrv_errors(), true));
}
else{
    while( $row = sqlsrv_fetch_array( $stmt, SQLSRV_FETCH_ASSOC) ) {
        echo $row."<br />";
    }

    echo "Success ";
}

//header('../index.php');