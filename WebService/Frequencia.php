<?php

//Chama o arquivo php de acesso ao Banco de Dados
require_once 'ConfigBd.php';

//consulta na url
$idAluno = htmlspecialchars($_POST["idAluno"]);
$idTreino = htmlspecialchars($_POST["idTreino"]);
$data = htmlspecialchars($_POST["data"]);
$hora = htmlspecialchars($_POST["hora"]);
//http://localhost/WebService/Alunos.php?email=edergp2009@gmail.com

//Buscar linhas da tabela do Banco de Dados mysql
$sql = "INSERT INTO frequencia (idAluno, idTreino, data, hora)
VALUES ($idAluno, $idTreino, '$data', '$hora')";
//$result = mysqli_query($connection, $sql) or die("Error in Selecting " . mysqli_error($connection));

if ($connection->query($sql) === TRUE) {
    $last_id = $connection->insert_id;
    $dataRet = array("wsId"=>1, 
        "wsMsg"=>utf8_encode("Ok! Frequência. Inserido com Sucesso - Id: ".$last_id));

} else {
    $dataRet = array("wsId"=>0, 
        "wsMsg"=> utf8_encode("Erro no Cadastro da Frequência". $conn->error));
    
}

echo json_encode($dataRet);

//Fecha a conexão
mysqli_close($connection);
?>

