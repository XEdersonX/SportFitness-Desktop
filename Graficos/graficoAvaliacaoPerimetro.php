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
            text: 'Avaliações Físicas dos Perímetros'
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
                $sql= "SELECT data, idAluno, torax from avaliacoes where idAluno = $idAluno and situacao = 1 ORDER BY id_avaliacao DESC limit 2;";
                $result = $conn->query($sql);

                $sql1= "SELECT data, idAluno, cintura from avaliacoes where idAluno = $idAluno and situacao = 1 ORDER BY id_avaliacao DESC limit 2;";
                $result1 = $conn->query($sql1);

                $sql2= "SELECT data, idAluno, abdome from avaliacoes where idAluno = $idAluno and situacao = 1 ORDER BY id_avaliacao DESC limit 2;";
                $result2 = $conn->query($sql2);

                $sql3= "SELECT data, idAluno, quadril from avaliacoes where idAluno = $idAluno and situacao = 1 ORDER BY id_avaliacao DESC limit 2;";
                $result3 = $conn->query($sql3);

                $sql4= "SELECT data, idAluno, antebraco_esquerdo from avaliacoes where idAluno = $idAluno and situacao = 1 ORDER BY id_avaliacao DESC limit 2;";
                $result4 = $conn->query($sql4);

                $sql5= "SELECT data, idAluno , antebraco_direito from avaliacoes where idAluno = $idAluno and situacao = 1 ORDER BY id_avaliacao DESC limit 2;";
                $result5 = $conn->query($sql5);

                $sql6= "SELECT data, idAluno, bracoRelaxado_esquerdo from avaliacoes where idAluno = $idAluno and situacao = 1 ORDER BY id_avaliacao DESC limit 2;";
                $result6 = $conn->query($sql6);

                $sql7= "SELECT data, idAluno, bracoRelaxado_direito from avaliacoes where idAluno = $idAluno and situacao = 1 ORDER BY id_avaliacao DESC limit 2;";
                $result7 = $conn->query($sql7);

                $sql8= "SELECT data, idAluno, bracoFletido_esquerdo from avaliacoes where idAluno = $idAluno and situacao = 1 ORDER BY id_avaliacao DESC limit 2;";
                $result8 = $conn->query($sql8);

                $sql9= "SELECT data, idAluno, bracoFletido_direito from avaliacoes where idAluno = $idAluno and situacao = 1 ORDER BY id_avaliacao DESC limit 2;";
                $result9 = $conn->query($sql9);

                $sql10= "SELECT data, idAluno, punho_esquerdo from avaliacoes where idAluno = $idAluno and situacao = 1 ORDER BY id_avaliacao DESC limit 2;";
                $result10 = $conn->query($sql10);

                $sql11= "SELECT data, idAluno, punho_direito from avaliacoes where idAluno = $idAluno and situacao = 1 ORDER BY id_avaliacao DESC limit 2;";
                $result11 = $conn->query($sql11);

                $sql12= "SELECT data, idAluno, coxaProximal_esquerda from avaliacoes where idAluno = $idAluno and situacao = 1 ORDER BY id_avaliacao DESC limit 2;";
                $result12 = $conn->query($sql12);

                $sql13= "SELECT data, idAluno, coxaProximal_direita from avaliacoes where idAluno = $idAluno and situacao = 1 ORDER BY id_avaliacao DESC limit 2;";
                $result13 = $conn->query($sql13);

                $sql14= "SELECT data, idAluno, coxa_esquerda from avaliacoes where idAluno = $idAluno and situacao = 1 ORDER BY id_avaliacao DESC limit 2;";
                $result14 = $conn->query($sql14);

                $sql15= "SELECT data, idAluno, coxa_direita from avaliacoes where idAluno = $idAluno and situacao = 1 ORDER BY id_avaliacao DESC limit 2;";
                $result15 = $conn->query($sql15);

                $sql16= "SELECT data, idAluno, coxaDistal_esquerda from avaliacoes where idAluno = $idAluno and situacao = 1 ORDER BY id_avaliacao DESC limit 2;";
                $result16 = $conn->query($sql16);

                $sql17= "SELECT data, idAluno, coxaDistal_direita from avaliacoes where idAluno = $idAluno and situacao = 1 ORDER BY id_avaliacao DESC limit 2;";
                $result17 = $conn->query($sql17);

                $sql18= "SELECT data, idAluno, tornozelo_esquerdo from avaliacoes where idAluno = $idAluno and situacao = 1 ORDER BY id_avaliacao DESC limit 2;";
                $result18 = $conn->query($sql18);

                $sql19= "SELECT data, idAluno, tornozelo_direito from avaliacoes where idAluno = $idAluno and situacao = 1 ORDER BY id_avaliacao DESC limit 2;";
                $result19 = $conn->query($sql19);

                $sql20= "SELECT data, idAluno, panturrilha_esquerda from avaliacoes where idAluno = $idAluno and situacao = 1 ORDER BY id_avaliacao DESC limit 2;";
                $result20 = $conn->query($sql20);

                $sql21= "SELECT data, idAluno, panturrilha_direita from avaliacoes where idAluno = $idAluno and situacao = 1 ORDER BY id_avaliacao DESC limit 2;";
                $result21 = $conn->query($sql21);

                ?>

        series: [

            {
            name: 'Tórax (cm)',
            data: [
                <?php 
                //echo $line1;
                 while($res = $result->fetch_assoc()){
                
                 echo $line1 = $res['torax'] . ',';
                }
                ?>

               

            ]
        }, {
            name: 'Cintura (cm)',
            data: [
                <?php 
                //echo $line2; 
                while($res = $result1->fetch_assoc()){
                
                 echo $line1 = $res['cintura'] . ',';
                }
                ?>
    
            ]
        }, {
            name: 'Abdome (cm)',
            data: [
                  <?php 
                  while($res = $result2->fetch_assoc()){
                
                 echo $line1 = $res['abdome'] . ','; 
                  }
                  ?>

               

               
            ]
        },{
            name: 'Quadril (cm)',
            data: [
                  <?php 
                  while($res = $result3->fetch_assoc()){
                
                 echo $line1 = $res['quadril'] . ','; 
                  }
                  ?>

               

               
            ]
        },{
            name: 'Antebraço Esquerdo (cm)',
            data: [
                  <?php 
                  while($res = $result4->fetch_assoc()){
                
                 echo $line1 = $res['antebraco_esquerdo'] . ','; 
                  }
                  ?>

               

               
            ]
        },{
            name: 'Antebraço Direito (cm)',
            data: [
                  <?php 
                  while($res = $result5->fetch_assoc()){
                
                 echo $line1 = $res['antebraco_direito'] . ','; 
                  }
                  ?>

               

               
            ]
        },
        {
            name: 'Braço Relaxado Esquerdo (cm)',
            data: [
                  <?php 
                  while($res = $result6->fetch_assoc()){
                
                 echo $line1 = $res['bracoRelaxado_esquerdo'] . ','; 
                  }
                  ?>

               

               
            ]
        },{
            name: 'Braço Relaxado Direito (cm)',
            data: [
                  <?php 
                  while($res = $result7->fetch_assoc()){
                
                 echo $line1 = $res['bracoRelaxado_direito'] . ','; 
                  }
                  ?>

               

               
            ]
        },{
            name: 'Braço Fletido Esquerdo (cm)',
            data: [
                  <?php 
                  while($res = $result8->fetch_assoc()){
                
                 echo $line1 = $res['bracoFletido_esquerdo'] . ','; 
                  }
                  ?>

               

               
            ]
        },{
            name: 'Braço Fletido Direito (cm)',
            data: [
                  <?php 
                  while($res = $result9->fetch_assoc()){
                
                 echo $line1 = $res['bracoFletido_direito'] . ','; 
                  }
                  ?>

               

               
            ]
        },{
            name: 'Punho Esquerdo (cm)',
            data: [
                  <?php 
                  while($res = $result10->fetch_assoc()){
                
                 echo $line1 = $res['punho_esquerdo'] . ','; 
                  }
                  ?>
            ]
        },{
            name: 'Punho Direito (cm)',
            data: [
                  <?php 
                  while($res = $result11->fetch_assoc()){
                
                 echo $line1 = $res['punho_direito'] . ','; 
                  }
                  ?>
            ]
        },{
            name: 'Coxa Proximal Esquerda (cm)',
            data: [
                  <?php 
                  while($res = $result12->fetch_assoc()){
                
                 echo $line1 = $res['coxaProximal_esquerda'] . ','; 
                  }
                  ?>
            ]
        },{
            name: 'Coxa Proximal Direita (cm)',
            data: [
                  <?php 
                  while($res = $result13->fetch_assoc()){
                
                 echo $line1 = $res['coxaProximal_direita'] . ','; 
                  }
                  ?>
            ]
        },{
            name: 'Coxa Meso-femural Esquerda (cm)',
            data: [
                  <?php 
                  while($res = $result14->fetch_assoc()){
                
                 echo $line1 = $res['coxa_esquerda'] . ','; 
                  }
                  ?>
            ]
        },{
            name: 'Coxa Meso-femural Direita (cm)',
            data: [
                  <?php 
                  while($res = $result15->fetch_assoc()){
                
                 echo $line1 = $res['coxa_direita'] . ','; 
                  }
                  ?>
            ]
        },{
            name: 'Coxa Distral Esquerda (cm)',
            data: [
                  <?php 
                  while($res = $result16->fetch_assoc()){
                
                 echo $line1 = $res['coxaDistal_esquerda'] . ','; 
                  }
                  ?>
            ]
        },{
            name: 'Coxa Distral Direita (cm)',
            data: [
                  <?php 
                  while($res = $result17->fetch_assoc()){
                
                 echo $line1 = $res['coxaDistal_direita'] . ','; 
                  }
                  ?>
            ]
        },{
            name: 'Tornozelo Esquerdo (cm)',
            data: [
                  <?php 
                  while($res = $result18->fetch_assoc()){
                
                 echo $line1 = $res['tornozelo_esquerdo'] . ','; 
                  }
                  ?>
            ]
        },{
            name: 'Tornozelo Direito (cm)',
            data: [
                  <?php 
                  while($res = $result19->fetch_assoc()){
                
                 echo $line1 = $res['tornozelo_direito'] . ','; 
                  }
                  ?>
            ]
        },{
            name: 'Panturrilha Esquerda (cm)',
            data: [
                  <?php 
                  while($res = $result20->fetch_assoc()){
                
                 echo $line1 = $res['panturrilha_esquerda'] . ','; 
                  }
                  ?>
            ]
        },{
            name: 'Panturrilha Direita (cm)',
            data: [
                  <?php 
                  while($res = $result21->fetch_assoc()){
                
                 echo $line1 = $res['panturrilha_direita'] . ','; 
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
