<?php

//Chama o arquivo php de acesso ao Banco de Dados
require_once 'ConfigBd.php';

//consulta na url
$idFichaTreino = htmlspecialchars($_GET[utf8_encode("idFichaTreino")]);
//http://localhost/WebService/Alunos.php?email=edergp2009@gmail.com

//Buscar linhas da tabela do Banco de Dados mysql
$sql = "SELECT f.id_fichaDetalhe, g.nome as grupoMuscular, e.nome as exercicio, f.series, f.repeticoes, f.carga  FROM fichaDetalhe f INNER JOIN exercicios e 
ON f.idExercicio = e.id_exercicio INNER JOIN grupoMuscular g 
ON e.idGrupoMuscular = g.id_grupoMuscular Where f.idFichaTreino = $idFichaTreino; ";
$result = mysqli_query($connection, $sql) or die("Error in Selecting " . mysqli_error($connection));

//Criar um array
$emparray = array();
if ($result->num_rows > 0) {
    // output data of each row
    while ($row = $result->fetch_assoc()){
    
    $linha = array("id_fichaDetalhe"=>$row["id_fichaDetalhe"], "grupoMuscular"=> utf8_encode($row["grupoMuscular"]), "exercicio"=> utf8_encode($row["exercicio"]), "series"=> utf8_encode($row["series"]), "repeticoes"=> utf8_encode($row["repeticoes"]), "carga"=> utf8_encode($row["carga"]));
    $emparray[] = $linha;  
    }
    
} else {
    //echo "0 results";
    $linha = array("id_fichaDetalhe"=> "0", "grupoMuscular"=> utf8_encode(""), "exercicio"=> "Nem um exercício encontrado!", "series"=> utf8_encode(""), "repeticoes"=> utf8_encode(""), "carga"=> utf8_encode(""));
    $emparray[] = $linha; 
}

$lista = array("exercicios"=>$emparray);

    //Exibe o JSON
    echo json_encode($lista, JSON_UNESCAPED_SLASHES | JSON_UNESCAPED_UNICODE | JSON_PRETTY_PRINT);

//Fecha a conexão
mysqli_close($connection);

?>