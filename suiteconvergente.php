<html>
<body>
    <?php 
    $rangTerme = $_POST["rangTerme"];
    $valeurDepart = $_POST["valeurDepart"];
    'Valeur pour le rang 0 :'. print 2."</br>";
    $somme = $valeurDepart;
    for ($i = 0; $i <= 10; $x++) {
        'Valeur pour le '.$i.'ème rang : '.$somme = $somme/4+2;
    }
    ?>
</body>
</html>