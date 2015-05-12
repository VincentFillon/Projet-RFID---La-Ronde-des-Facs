<div class="jumbotron">
    <h1 class="place" style="color: #337ab7">Inscription Non Étudiant</h1>
    <h4 class="place">Remplire les champs ci-dessous pour vous inscrire au prochain évènement de La Ronde des FACS</h4>
</div>
<form method="post" action="requetes/InsertUser.php">
<div class="form-group">
    <div class="row">
        <div class="col-md-6">
            <label>Nom : </label>
            <input name="nom" type="text" class="form-control" placeholder="Nom"><br>
            <label>Prénom :</label>
            <input name="prenom" type="text" class="form-control" placeholder="Prénom"><br>
            <label>Date de Naissance :</label>
            <input name="date" type="text" class="form-control" placeholder="Àge"><br>

        </div>
        <div class="col-md-6">
            <label>Numéro étudiant : </label>
            <input name="userId" type="text" class="form-control" placeholder="Numéro Étudiant"><br>
            <label>Établissement :</label>
            <input name="faculte" type="text" class="form-control" placeholder="École"><br>
            <label>Promo : </label>
            <input name="promo" type="text" class="form-control" placeholder="Promo"><br>
        </div>
    </div>
</div>
<div class="place">
    <button type="submit" class="btn btn-primary">Valider l'inscription</button>
</div>
</form>