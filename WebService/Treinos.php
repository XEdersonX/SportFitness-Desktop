<?php

//Chama o arquivo php de acesso ao Banco de Dados
require_once 'ConfigBd.php';

//consulta na url
$idAluno = htmlspecialchars($_GET[utf8_encode("idAluno")]);
//http://localhost/WebService/Alunos.php?email=edergp2009@gmail.com

//Buscar linhas da tabela do Banco de Dados mysql
$sql = "SELECT f.id_fichaTreino, p.dataInicio, p.vezesSemana, f.nomeFicha, f.numeroTreinosRealizados, t.nome as treinador, o.nome as objetivo FROM planoTreino p INNER JOIN fichaTreino f 
ON p.id_planoTreino = f.idPlanoTreino INNER JOIN treinadores t 
ON p.idTreinador = t.id_treinador INNER JOIN objetivo o 
ON p.idObjetivo = o.id_objetivo where p.idAluno = $idAluno and p.situacao = 1 and f.situacao = 1; ";
$result = mysqli_query($connection, $sql) or die("Error in Selecting " . mysqli_error($connection));

//Criar um array
$emparray = array();
if ($result->num_rows > 0) {
    // output data of each row
    while ($row = $result->fetch_assoc()){
    
    $linha = array("id_fichaTreino"=>$row["id_fichaTreino"], "dataInicio"=> utf8_encode($row["dataInicio"]), "vezesSemana"=> utf8_encode($row["vezesSemana"]), "nomeFicha"=> utf8_encode($row["nomeFicha"]), "numeroTreinosRealizados"=> utf8_encode($row["numeroTreinosRealizados"]), "treinador"=> utf8_encode($row["treinador"]), "objetivo"=> utf8_encode($row["objetivo"]));
    $emparray[] = $linha;  
    }
    
} else {
    //echo "0 results";
    $linha = array("id_fichaTreino"=> "0", "dataInicio"=> utf8_encode(""), "vezesSemana"=> utf8_encode(""), "nomeFicha"=> utf8_encode("Nem um treino encontrado!"), "numeroTreinosRealizados"=> utf8_encode(""), "treinador"=> utf8_encode(""), "objetivo"=> utf8_encode(""));
    $emparray[] = $linha; 
}

$lista = array("treino"=>$emparray);

    //Exibe o JSON
    echo json_encode($lista, JSON_UNESCAPED_SLASHES | JSON_UNESCAPED_UNICODE | JSON_PRETTY_PRINT);

//Fecha a conexão
mysqli_close($connection);

?>