<?php

//Chama o arquivo php de acesso ao Banco de Dados
require_once 'ConfigBd.php';

//consulta na url
$idAluno = htmlspecialchars($_GET["idAluno"]);
//http://localhost/WebService/Alunos.php?email=edergp2009@gmail.com

//Buscar linhas da tabela do Banco de Dados mysql
$sql = "SELECT t.nomeFicha FROM frequencia f INNER JOIN fichaTreino t ON t.id_fichaTreino = f.idTreino WHERE f.idAluno = $idAluno ORDER BY f.id_frequencia DESC LIMIT 1;";
$result = mysqli_query($connection, $sql) or die("Error in Selecting " . mysqli_error($connection));

//Criar um array
$emparray = array();
if ($result->num_rows > 0) {
    // output data of each row
    $row = $result->fetch_assoc();
    
    $linha = array("nomeFicha"=> utf8_encode($row["nomeFicha"]));
    $emparray[] = $linha; 
    
    $lista = array("ultimoTreino"=>$emparray);
    //$lista = array('nomeFicha'=>'Ok!');

    //Exibe o JSON
    echo json_encode($linha, JSON_PRETTY_PRINT);
    
} else {
    echo "0 results";
}

//Fecha a conexão
mysqli_close($connection);

?>