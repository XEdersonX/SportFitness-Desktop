<?php

//Chama o arquivo php de acesso ao Banco de Dados
require_once 'ConfigBd.php';

//consulta na url
$email = htmlspecialchars($_GET["email"]);
$senha = htmlspecialchars($_GET["senha"]);
//http://localhost/WebService/Alunos.php?email=edergp2009@gmail.com

//Transformando a senha em md5 com o salt
$md5 = md5($senha . "1Sport8Fitne55%");

//Buscar linhas da tabela do Banco de Dados mysql
$sql = "select id_aluno, nome, email, senha from alunos where email='$email' and senha='$md5'";
$result = mysqli_query($connection, $sql) or die("Error in Selecting " . mysqli_error($connection));

//Criar um array
$emparray = array();
if ($result->num_rows > 0) {
    // output data of each row
    $row = $result->fetch_assoc();
    
    $linha = array("id_aluno"=>$row["id_aluno"], "nome"=> utf8_encode($row["nome"]), "email"=> utf8_encode($row["email"]), "senha"=> utf8_encode($row["senha"]));
    $emparray[] = $linha; 
    
    $lista = array("alunos"=>$emparray);

    //Exibe o JSON
    echo json_encode($lista, JSON_PRETTY_PRINT);
    
} else {
    echo "0 results";
}

//Fecha a conexão
mysqli_close($connection);

?>