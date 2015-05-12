<div class="jumbotron">
    <h1 class="place" style="color: #337ab7">Inscription Étudiant</h1>
    <h4 class="place">Remplire les champs ci-dessous pour vous inscrire au prochain évènement de La Ronde des FACS</h4>
</div>
<form>
    <div class="form-group">
        <div class="row">
            <div class="col-md-6">
                <label>Nom : </label>
                <input type="text" class="form-control" placeholder="Nom"><br>
                <label>Prénom :</label>
                <input type="text" class="form-control" placeholder="Prénom"><br>
                <label>Date de Naissance :</label>
                <input type="text" class="form-control" placeholder="Àge"><br>
                <label>Établissement :</label>
                <input type="text" class="form-control" placeholder="École"><br>
                <label>Promo : </label>
                <input type="text" class="form-control" placeholder="Promo"><br>
            </div>
            <div class="col-md-6">
                <label>Numéro étudiant : </label>
                <input type="text" class="form-control" placeholder="Numéro Étudiant"><br>
                <label>Adresse email : </label>
                <input type="email" class="form-control" placeholder="email"><br>
            </div>
        </div>
    </div>
    <div class="place">
        <button type="submit" class="btn btn-primary">Valider l'inscription</button>
    </div>
</form>
<?php
    include("config/config.php");
?>