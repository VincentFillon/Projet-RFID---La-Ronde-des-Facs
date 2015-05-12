<?php
/**
 * Created by PhpStorm.
 * User: melanie
 * Date: 06/05/2015
 * Time: 14:23
 */

// Fichier de configuration pour l'interface PHP de notre annuaire LDAP
$server = "unice";

$port = "389";

$host = "ldap.unice.fr";

$rootdn = "ou=people,dc=unice,dc=fr";

$ldapconnexion = ldap_connect($host, $port) or die("Impossible de se connecter au serveur LDAP $host");
?>