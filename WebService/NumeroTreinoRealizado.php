<?php

//Chama o arquivo php de acesso ao Banco de Dados
require_once 'ConfigBd.php';

//consulta na url
$id_fichaTreino = htmlspecialchars($_POST["id_fichaTreino"]);
$numeroTreinosRealizados = htmlspecialchars($_POST["numeroTreinosRealizados"]);
//http://localhost/WebService/Alunos.php?email=edergp2009@gmail.com

//Buscar linhas da tabela do Banco de Dados mysql
$sql = "UPDATE fichaTreino SET numeroTreinosRealizados = $numeroTreinosRealizados WHERE id_fichaTreino = $id_fichaTreino";
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

