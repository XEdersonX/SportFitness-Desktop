<?php

//Chama o arquivo php de acesso ao Banco de Dados
require_once 'ConfigBd.php';

//consulta na url
$titulo = htmlspecialchars($_GET[utf8_encode("titulo")]);
$data = htmlspecialchars($_GET[utf8_encode("data")]);
//http://localhost/WebService/Alunos.php?email=edergp2009@gmail.com


//Buscar linhas da tabela do Banco de Dados mysql
$sql = "select * from noticias where titulo LIKE'%$titulo%' and data LIKE'%$data%'";
$result = mysqli_query($connection, $sql) or die("Error in Selecting " . mysqli_error($connection));

//Criar um array
$emparray = array();
if ($result->num_rows > 0) {
    // output data of each row
    while ($row = $result->fetch_assoc()){
    
    $linha = array("id_noticia"=>$row["id_noticia"], "data"=> utf8_encode($row["data"]), "titulo"=> utf8_encode($row["titulo"]), "texto"=> utf8_encode($row["texto"]), "idUsuario"=>$row["idUsuario"]);
    $emparray[] = $linha;  
    }
//    $lista = array("noticia"=>$emparray);
//
//    //Exibe o JSON
//    echo json_encode($lista, JSON_UNESCAPED_SLASHES | JSON_UNESCAPED_UNICODE | JSON_PRETTY_PRINT);
    
} else {
    //echo "0 results";
    $linha = array("id_noticia" => "0", "data" => utf8_encode("") ,"titulo" => "Nem uma notícia encontrada!", "texto" => utf8_encode(""), "idUsuario" => "0");
    $emparray[] = $linha; 
}

$lista = array("noticia"=>$emparray);

    //Exibe o JSON
    echo json_encode($lista, JSON_UNESCAPED_SLASHES | JSON_UNESCAPED_UNICODE | JSON_PRETTY_PRINT);

//Fecha a conexão
mysqli_close($connection);

?>