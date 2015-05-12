<div class="jumbotron">
    <h1 class="place" style="color: #337ab7">Désinscription</h1>
    <h4 class="place">Vous voulez quitter la compétition ? Validez votre choix ici</h4>
</div>
<form method="post" action="requetes/DeleteUser.php">
    <div class="form-group">
        <div class="row">
                    <h2 class="miniTitre" style="color: #337ab7">Vous souhaitez ne plus participer à la compétition ? </h2>
                    <label>Numéro Identifiant : </label>
                    <input name="id" type="text" class="form-control" placeholder="numéro étudiant"><br>
    </div>
    <div class="place">
        <button type="submit" class="btn btn-primary">Désinscription</button>
    </div>
</form>
