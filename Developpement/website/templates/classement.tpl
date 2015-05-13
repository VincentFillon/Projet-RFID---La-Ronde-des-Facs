<?php
include ('requetes/ClassementUserTop.php');
ini_set('display_errors','off');
?>
<div class="jumbotron">
    <h1 class="place" style="color: #337ab7">Classement</h1>
    <h4 class="place">Voyez quel est votre position lors de cette compétition </h4>
</div>
<div class="container">
    <div class="row">
        <div class="col-md-4"></div>
        <div class="col-md-4 place" style="background-color: #d5d5d5">1ère Position :<p> <?php echo  $userObj[0]["user_id"];?></p></div>
    </div>
    <div class="row">
        <div class="col-md-6 place" style="background-color: #d5d5d5 ">2ème Position : <p> <?php echo  $userObj[1]["user_id"];?></p></div>
        <div class="col-md-6 place" style="background-color: #d5d5d5">3ème Position : <p> <?php echo  $userObj[2]["user_id"];?></p></div>
    </div>
    <br>
</div>
    <?php
        include('requetes/ClassementUser4.php');
    ?>
<div class="container">
    <table class="table table-striped">
        <?php
        $valeur = sqlsrv_num_fields($stmt);
       echo "<tr>
            <th>Identifiant User</th>
            <th>Nombre de passage</th>
            <th>Temp</th>
            <th>Position Classement</th>
        </tr>";

            for ($i = 0; $i < $valeur; $i++){
                echo '<tr>';
                    echo '<td>'.$userPlus[$i]["user_id"].'</td>';
                    echo '<td>'.$userPlus[$i]["nb_passage"].'</td>';
                    echo '<td>';
                        $result = $userPlus[$i]["temps"]->format('Y-m-d H:i:s');
                        if ($result) {
                        echo $result;
                        } else { // format failed
                        echo "Unknown Time";
                        }
                    echo '</td>';
                    echo '<td>';
                            $number = $i +1;
                            echo $number;
                    echo '</td>';
                echo '</tr>';
            }
        ?>
    </table>
</div>