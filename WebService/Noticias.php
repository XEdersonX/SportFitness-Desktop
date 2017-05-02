<?php

//Chama o arquivo php de acesso ao Banco de Dados
require_once 'ConfigBd.php';

//Buscar linhas da tabela do Banco de Dados mysql
$sql = "select * from noticias";
$result = mysqli_query($connection, $sql) or die("Error in Selecting " . mysqli_error($connection));

//Criar um array
$emparray = array();
if ($result->num_rows > 0) {
    // output data of each row
    while ($row = $result->fetch_assoc()) {
        $linha = array("id_noticia"=>$row["id_noticia"], "data"=> utf8_encode($row["data"]), "titulo"=> utf8_encode($row["titulo"]), "texto"=> utf8_encode($row["texto"]), "idUsuario"=>$row["idUsuario"]);
        $emparray[] = $linha;        
    }
} else {
    echo "0 results";
}

$lista = array("noticia"=>$emparray);

//Exibe o JSON
echo json_encode($lista, JSON_PRETTY_PRINT);

//Fecha a conexão
mysqli_close($connection);

?>