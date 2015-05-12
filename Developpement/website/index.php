<?php
/**
 * Created by PhpStorm.
 * User: Vincent
 * Date: 26/03/2015
 * Time: 10:29
 */

// Start php user session
session_start();

// Get asked page
$page = (isset($_GET['page'])) ? htmlentities($_GET['page']) : NULL;

?>

<!DOCTYPE html>
<html lang="fr">
    <head>
        <meta charset="utf-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
        <meta name="description" content="">
        <meta name="author" content="">
        <!-- TODO => Définir un favicon
        <link rel="icon" href="img/favicon.ico">
        -->
        <title>La Ronde des Facs</title>

        <!-- Bootstrap core CSS -->
        <link href="bootstrap-3.3.4/css/bootstrap.min.css" rel="stylesheet">

        <!-- Custom styles -->
        <link href="style/css/global.css" rel="stylesheet">
        <link href="style/css/melanie.css" rel="stylesheet">

        <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
        <!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
        <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
        <![endif]-->
    </head>

    <body>

        <!-- Fixed navbar -->
        <nav class="navbar navbar-default navbar-fixed-top">
            <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navbar" aria-expanded="false" aria-controls="navbar">
                        <span class="sr-only">Toggle navigation</span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand" href="#">La ronde des facs</a>
                </div>
                <div id="navbar" class="collapse navbar-collapse">
                    <ul class="nav navbar-nav">
                        <li class="active"><a href="index.php?page=home.tpl">Accueil</a></li>
                        <li class="dropdown">
                            <a class="dropdown-toggle" data-toggle="dropdown" href=""  role="button" aria-expanded="false">Inscription<span class="caret"></span></a>
                            <ul class="dropdown-menu" role="menu">
                                <li><a href="index.php?page=inscPerso.tpl">Vous  êtes un personnel ?</a></li>
                                <li><a href="index.php?page=inscEtud.tpl">Vous êtes étudiant ?</a> </li>
                            </ul>
                        </li>
                        <li><a href="index.php?page=desinscription.tpl">Se Désinscrire</a></li>
                        <li><a href="index.php?page=classement.tpl">Classement</a></li>
                        <li><a href="index.php?page=contact.tpl">Contactez-nous</a></li>
                    </ul>
                </div><!--/.nav-collapse -->
            </div>
        </nav>
        <!-- Begin page content -->
        <div class="container">
            <?php
            if ( $page ) {
                include('templates/' . $page);
            }
            else {
                include('templates/home.tpl');
            }
            ?>
        </div>

        <footer class="footer">
            <div class="container">
                <p class="text-muted">IUT Nice Sophia Antipolis</p>
            </div>
        </footer>

        <script src="js/global.js"></script>
        <!-- Bootstrap core JavaScript
        ================================================== -->
        <!-- Placed at the end of the document so the pages load faster -->
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.2/jquery.min.js"></script>
        <script src="bootstrap-3.3.4/js/bootstrap.min.js"></script>
    </body>
</html>