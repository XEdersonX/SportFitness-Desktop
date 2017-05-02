<?php

header("Content-type: application/json; charset=utf-8");

//Abre uma conexão com o mysql
$connection = mysqli_connect("localhost", "root", "", "SportFitness") or die("Erro de Acesso ao Banco de Dados " . mysqli_error($connection));

?>
