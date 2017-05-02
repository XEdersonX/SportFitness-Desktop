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
    $('#container').highcharts({
        chart: {
            type: 'pie',
            options3d: {
                enabled: true,
                alpha: 45,
                beta: 0
            }
        },
        title: {
            text: 'Treinadores por Treinos'
        },
        subtitle: {
            text: 'Sport Fitness'
        },
        tooltip: {
            pointFormat: '{series.name}: <b>{point.percentage:.1f}%</b>'
        },
        plotOptions: {
            pie: {
                allowPointSelect: true,
                cursor: 'pointer',
                depth: 35,
                dataLabels: {
                    enabled: true,
                    format: '{point.name}'
                }
            }
        },
        series: [{
            type: 'pie',
            name: 'Porcentagem de alunos',
            data: [
                
                <?php
                $sql= "SELECT t.nome , count(*) as total from planoTreino p INNER JOIN treinadores t ON p.idTreinador = t.id_treinador WHERE p.situacao = 1 group by t.nome;";
                $result = $conn->query($sql);
                while($res = $result->fetch_assoc()){
                ?>

                ['<?php echo $res['nome']; ?>', <?php echo $res['total'] ?>],

               

                <?php
                    
        }
                ?>


            ]
        }]
    });
});
		</script>
	</head>
	<body>

<!--<script src="https://code.highcharts.com/highcharts.js"></script>-->
<!--<script src="https://code.highcharts.com/highcharts-3d.js"></script>-->
<!--<script src="https://code.highcharts.com/modules/exporting.js"></script>-->

<div id="container" style="height: 400px"></div>
	</body>
</html>
