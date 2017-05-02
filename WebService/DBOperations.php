<?php

class DBOperations{

	 private $host = '127.0.0.1';
	 private $user = 'root';
	 private $db = 'SportFitness';
	 private $pass = '';
	 private $conn;

public function __construct() {

	$this -> conn = new PDO("mysql:host=".$this -> host.";dbname=".$this -> db, $this -> user, $this -> pass);

}


 public function insertData($name,$email,$password){

 	$unique_id = uniqid('', true);
    $hash = $this->getHash($password);
    $encrypted_password = $hash["encrypted"];
	$salt = $hash["salt"];

 	$sql = 'INSERT INTO users SET unique_id =:unique_id,name =:name,
    email =:email,encrypted_password =:encrypted_password,salt =:salt,created_at = NOW()';

 	$query = $this ->conn ->prepare($sql);
 	$query->execute(array('unique_id' => $unique_id, ':name' => $name, ':email' => $email,
     ':encrypted_password' => $encrypted_password, ':salt' => $salt));

    if ($query) {
        
        return true;

    } else {

        return false;

    }
 }


 public function checkLogin($email, $password) {

    $sql = 'SELECT * FROM alunos WHERE email = :email';
    $query = $this -> conn -> prepare($sql);
    $query -> execute(array(':email' => $email));
    $data = $query -> fetchObject();
    //$salt = $data -> salt;
    $db_encrypted_password = $data -> senha;
    $db_email = $data -> email;
    
//Transformando a senha em md5 com o salt
    $md5 = md5($password . "1Sport8Fitne55%");

    if ($db_email == $email && $db_encrypted_password == $md5) {
//$db_email == $email

        $user["name"] = $data -> nome;
        $user["email"] = $data -> email;
        $user["unique_id"] = $data -> id_aluno;
        return $user;

    } else {

        return false;
    }

 }


 public function changePassword($email, $password){


    //$hash = $this -> getHash($password);
    //$encrypted_password = $hash["encrypted"];
    //$salt = $hash["salt"];
    $md5 = md5($password . "1Sport8Fitne55%"); 

    $sql = 'UPDATE alunos SET senha = :senha WHERE email = :email';
    $query = $this -> conn -> prepare($sql);
    $query -> execute(array(':email' => $email, ':senha' => $md5));

    if ($query) {
        
        return true;

    } else {

        return false;

    }

 }

 public function checkUserExist($email){

    $sql = 'SELECT COUNT(*) from alunos WHERE email =:email';
    $query = $this -> conn -> prepare($sql);
    $query -> execute(array('email' => $email));

    if($query){

        $row_count = $query -> fetchColumn();

        if ($row_count == 0){

            return false;

        } else {

            return true;

        }
    } else {

        return false;
    }
 }

 public function getHash($password) {

     //$salt = sha1(rand());
     $salt = "1Sport8Fitne55%";
     $encrypted = password_hash($password.$salt, PASSWORD_DEFAULT);
     $hash = array("salt" => $salt, "encrypted" => $encrypted);

     return $hash;

}


//$md5 = md5($password . "1Sport8Fitne55%");
public function verifyHash($password, $hash) {

    return password_verify ($password, $hash);
}
}




