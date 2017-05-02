<?php

require_once("Conexao/conexao.php");

?>

<!DOCTYPE HTML>
<html>
	<head>
		<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
		<title>Gráficos</title>

		<script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.8.2/jquery.min.js"></script>
        
<!-- 1. Add these JavaScript inclusions in the head of your page -->
		<script type="text/javascript" src="Highcharts/js/jquery.min.js"></script>
		<script type="text/javascript" src="Highcharts/js/highcharts.js"></script>
		
	
			<script type="text/javascript" src="Highcharts/js/themes/dark-unica.js"></script>
		
		
		<!-- 1b) Optional: the exporting module -->
		<script type="text/javascript" src="Highcharts/js/modules/exporting.js"></script>
		
		

		<style type="text/css">
${demo.css}
		</style>
		<script type="text/javascript">
$(function () {
    Highcharts.chart('container', {
        chart: {
            type: 'bar'
        },
        title: {
            text: 'Resultados das Últimas Avaliações Físicas'
        },
        subtitle: {
            text: 'Sport Fitness'
        },
        xAxis: {
            categories: [
                <?php
                //consulta na url
                $idAluno = htmlspecialchars($_GET["idAluno"]);
                //http://localhost/WebService/Alunos.php?email=edergp2009@gmail.com


                $sql= "SELECT data from avaliacoes where idAluno = $idAluno and situacao = 1 ORDER BY id_avaliacao DESC limit 2;";
                $result = $conn->query($sql);
                while($res = $result->fetch_assoc()){
                ?>

                '<?php echo $res['data']; ?>',

               

                <?php
                    
        }
                ?>
            ],
            title: {
                text: null
            }
        },
        yAxis: {
            min: 0,
            title: {
                text: '',
                align: 'high'
            },
            labels: {
                overflow: 'justify'
            }
        },
        tooltip: {
            valueSuffix: ' '
        },
        plotOptions: {
            bar: {
                dataLabels: {
                    enabled: true
                }
            }
        },
        legend: {
            layout: 'vertical',
            align: 'right',
            verticalAlign: 'top',
            x: -40,
            y: 80,
            floating: false,
            borderWidth: 1,
            backgroundColor: ((Highcharts.theme && Highcharts.theme.legendBackgroundColor) || '#FFFFFF'),
            shadow: true
        },
        credits: {
            enabled: false
        },
         
                <?php
                $line1;
                $line2;
                $line3;
                $sql= "SELECT data, idAluno , peso, pressaoArterial, imc, gorduraIdeal, massaGorda from avaliacoes where idAluno = $idAluno and situacao = 1 ORDER BY id_avaliacao DESC limit 2;";
                $result = $conn->query($sql);

                $sql1= "SELECT data, idAluno , peso, altura, imc, gorduraIdeal, massaGorda from avaliacoes where idAluno = $idAluno and situacao = 1 ORDER BY id_avaliacao DESC limit 2;";
                $result1 = $conn->query($sql1);

                $sql2= "SELECT data, idAluno , peso, altura, imc, gorduraIdeal, massaGorda from avaliacoes where idAluno = $idAluno and situacao = 1 ORDER BY id_avaliacao DESC limit 2;";
                $result2 = $conn->query($sql2);

                $sql3= "SELECT data, idAluno , peso, altura, imc, gorduraIdeal, massaGorda from avaliacoes where idAluno = $idAluno and situacao = 1 ORDER BY id_avaliacao DESC limit 2;";
                $result3 = $conn->query($sql3);

                $sql4= "SELECT data, idAluno , peso, altura, imc, gorduraIdeal, massaGorda from avaliacoes where idAluno = $idAluno and situacao = 1 ORDER BY id_avaliacao DESC limit 2;";
                $result4 = $conn->query($sql4);

                $sql5= "SELECT data, idAluno , peso, altura, imc, gorduraIdeal, massaGorda, pesoDesejavel from avaliacoes where idAluno = $idAluno and situacao = 1 ORDER BY id_avaliacao DESC limit 2;";
                $result5 = $conn->query($sql5);

                $sql6= "SELECT data, idAluno , peso, altura, imc, gorduraIdeal, massaGorda, pesoOsseo from avaliacoes where idAluno = $idAluno and situacao = 1 ORDER BY id_avaliacao DESC limit 2;";
                $result6 = $conn->query($sql6);

                $sql7= "SELECT data, idAluno , peso, altura, imc, gorduraIdeal, massaGorda, pesoOsseo, gorduraAtual from avaliacoes where idAluno = $idAluno and situacao = 1 ORDER BY id_avaliacao DESC limit 2;";
                $result7 = $conn->query($sql7);

                $sql8= "SELECT data, idAluno , peso, altura, imc, gorduraIdeal, massaGorda, pesoOsseo, gorduraAtual, massaMagra from avaliacoes where idAluno = $idAluno and situacao = 1 ORDER BY id_avaliacao DESC limit 2;";
                $result8 = $conn->query($sql8);

                $sql9= "SELECT data, idAluno , peso, altura, imc, gorduraIdeal, massaGorda, pesoOsseo, gorduraAtual, massaMagra, pesoResidual from avaliacoes where idAluno = $idAluno and situacao = 1 ORDER BY id_avaliacao DESC limit 2;";
                $result9 = $conn->query($sql9);

                $sql10= "SELECT data, idAluno , peso, altura, imc, gorduraIdeal, massaGorda, pesoOsseo, gorduraAtual, massaMagra, pesoResidual, pesoMuscular from avaliacoes where idAluno = $idAluno and situacao = 1 ORDER BY id_avaliacao DESC limit 2;";
                $result10 = $conn->query($sql10);

                $sql11= "SELECT data, idAluno , peso, pressaoArterialMinima, imc, gorduraIdeal, massaGorda, pesoOsseo, gorduraAtual, massaMagra, pesoResidual, pesoMuscular from avaliacoes where idAluno = $idAluno and situacao = 1 ORDER BY id_avaliacao DESC limit 2;";
                $result11 = $conn->query($sql11);

               // while($res = $result->fetch_assoc()){
                
               //  echo $line1 = $res['altura'] . ',';
               // }

                ?>

        series: [

            {
            name: 'Pressão Máxima (sistolica)',
            data: [
                <?php 
                //echo $line1;
                 while($res = $result->fetch_assoc()){
                
                 echo $line1 = $res['pressaoArterial'] . ',';
                }
                ?>

               

            ]
        },{
            name: 'Pressão Mínima (diastólica)',
            data: [
                <?php 
                //echo $line1;
                 while($res = $result11->fetch_assoc()){
                
                 echo $line1 = $res['pressaoArterialMinima'] . ',';
                }
                ?>

               

            ]
        }, {
            name: 'Peso (Kg)',
            data: [
                <?php 
                //echo $line2; 
                while($res = $result1->fetch_assoc()){
                
                 echo $line1 = $res['peso'] . ',';
                }
                ?>
    
            ]
        }, {
            name: 'imc',
            data: [
                  <?php 
                  while($res = $result2->fetch_assoc()){
                
                 echo $line1 = $res['imc'] . ','; 
                  }
                  ?>

               

               
            ]
        },{
            name: 'Gordura Ideal (%)',
            data: [
                  <?php 
                  while($res = $result3->fetch_assoc()){
                
                 echo $line1 = $res['gorduraIdeal'] . ','; 
                  }
                  ?>

               

               
            ]
        },{
            name: 'Massa Gorda (Kg)',
            data: [
                  <?php 
                  while($res = $result4->fetch_assoc()){
                
                 echo $line1 = $res['massaGorda'] . ','; 
                  }
                  ?>

               

               
            ]
        },{
            name: 'Massa Magra (Kg)',
            data: [
                  <?php 
                  while($res = $result8->fetch_assoc()){
                
                 echo $line1 = $res['massaMagra'] . ','; 
                  }
                  ?>

               

               
            ]
        },
        {
            name: 'Peso Desejavel (Kg)',
            data: [
                  <?php 
                  while($res = $result5->fetch_assoc()){
                
                 echo $line1 = $res['pesoDesejavel'] . ','; 
                  }
                  ?>

               

               
            ]
        },{
            name: 'Peso Ósseo (Kg)',
            data: [
                  <?php 
                  while($res = $result6->fetch_assoc()){
                
                 echo $line1 = $res['pesoOsseo'] . ','; 
                  }
                  ?>

               

               
            ]
        },{
            name: 'Gordura Atual (%)',
            data: [
                  <?php 
                  while($res = $result7->fetch_assoc()){
                
                 echo $line1 = $res['gorduraAtual'] . ','; 
                  }
                  ?>

               

               
            ]
        },{
            name: 'Peso Residual (Kg)',
            data: [
                  <?php 
                  while($res = $result9->fetch_assoc()){
                
                 echo $line1 = $res['pesoResidual'] . ','; 
                  }
                  ?>

               

               
            ]
        },{
            name: 'Peso Muscular (Kg)',
            data: [
                  <?php 
                  while($res = $result10->fetch_assoc()){
                
                 echo $line1 = $res['pesoMuscular'] . ','; 
                  }
                  ?>
            ]
        }


        ]
    });
});
		</script>
	</head>
	<body>

<!--<script src="https://code.highcharts.com/highcharts.js"></script>-->
<!--<script src="https://code.highcharts.com/highcharts-3d.js"></script> -->
<!--<script src="https://code.highcharts.com/modules/exporting.js"></script>-->

<div id="container" style="height: 400px"></div>
	</body>
</html>
