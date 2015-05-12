<?php
/**
 * Created by PhpStorm.
 * User: Vincent
 * Date: 26/03/2015
 * Time: 10:46
 */

$server = '(local)';
$connexionInfo = array("Database"=>"FacPrincipal", 'ReturnDatesAsStrings'=>true);
$link = sqlsrv_connect($server,$connexionInfo);
if( !$link ) {
    echo "La connexion n'a pu être établie.<br />";
    die( print_r( sqlsrv_errors(), true));
}

// function defination to convert array to xml
function array_to_xml($student_info, &$xml_student_info) {
    foreach($student_info as $key => $value) {
        if(is_array($value)) {
            if(!is_numeric($key)){
                $subnode = $xml_student_info->addChild("$key");
                array_to_xml($value, $subnode);
            }
            else{
                $subnode = $xml_student_info->addChild("item");
                array_to_xml($value, $subnode);
            }
        }
        else {
            $xml_student_info->addChild("$key",htmlspecialchars("$value"));
        }
    }
}

$xml = new SimpleXMLElement('<?xml version="1.0"?>
<soap:Envelope
xmlns:soap="http://www.w3.org/2001/12/soap-envelope"
soap:encodingStyle="http://www.w3.org/2001/12/soap-encoding">

<soap:Header>
  <m:Trans xmlns:m="http://www.w3schools.com/transaction/"
  soap:mustUnderstand="1">
  </m:Trans>
</soap:Header>

</soap:Envelope>');