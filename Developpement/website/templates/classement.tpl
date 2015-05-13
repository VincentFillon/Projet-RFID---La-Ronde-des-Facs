<?php
include ('requetes/ClassementUserTop.php');
?>
<div class="jumbotron">
    <h1 class="place" style="color: #337ab7">Classement</h1>
    <h4 class="place">Voyez quel est votre position lors de cette compétition </h4>
</div>
<div class="container">
    <div class="row">
        <div class="col-md-4"></div>
        <div class="col-md-4 place" style="background-color: #d5d5d5">1ère Position : <?php echo  $row['user_id'];?></div>
    </div>
    <div class="row">
        <div class="col-md-6 place" style="background-color: #d5d5d5 ">2ème Position</div>
        <div class="col-md-6 place" style="background-color: #d5d5d5">3ème Position</div>
    </div>
    <br>
    <table class="table table-striped">
        <tr>
            <th>Nom</th>
            <th>Prénom</th>
            <th>Position</th>
            <th>Temp</th>
        </tr>
        <tr>
            <td>test</td>
            <td>test</td>
            <td>4</td>
            <td>45m</td>
        </tr>
        <tr>
            <td>essai</td>
            <td>essai</td>
            <td>5</td>
            <td>45m</td>
        </tr>
        <tr>
            <td>cc</td>
            <td>cc</td>
            <td>6</td>
            <td>45m</td>
        </tr>
        <tr>
            <td>des</td>
            <td>des</td>
            <td>7</td>
            <td>45m</td>
        </tr>
    </table>
</div>