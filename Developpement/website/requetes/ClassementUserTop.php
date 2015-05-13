<?php
/**
 * Created by PhpStorm.
 * User: melanie
 * Date: 12/05/2015
 * Time: 20:48
 */
include('/config/configSecondaire.php');


$sql = "Select TOP 3 *
FROM [Borne]
where [nb_passage] = (SELECT MAX([nb_passage]) FROM [Borne])
order by [temps] desc ";


$stm = sqlsrv_query($link, $sql);
if( $stm === false ) {
    die( print_r( sqlsrv_errors(), true));
}
    while( $row = sqlsrv_fetch_array( $stm, SQLSRV_FETCH_ASSOC) ) {
        $userObj[] = array("user_id"=>$row["user_id"], "nb_passage"=>$row["nb_passage"], "temps"=>$row["temps"], "borne_id"=>$row["borne_id"]);
    }

//header('../index.php');