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
    // Create the chart
    Highcharts.chart('container', {
        chart: {
            type: 'column'
        },
        title: {
            text: 'Os Dez Alunos com maior frequência'
        },
        subtitle: {
            text: 'Sport Fitness'
        },
        xAxis: {
            type: 'category'
        },
        yAxis: {
            title: {
                text: 'Porcentagem Total'
            }

        },
        legend: {
            enabled: false
        },
        plotOptions: {
            series: {
                borderWidth: 0,
                dataLabels: {
                    enabled: true,
                    format: '{point.y:.1f}%'
                }
            }
        },

        tooltip: {
            headerFormat: '<span style="font-size:11px">{series.name}</span><br>',
            pointFormat: '<span style="color:{point.color}">{point.name}</span>: <b>{point.y:.2f}%</b> of total<br/>'
        },

        series: [{
            name: 'Porcentagem',
            colorByPoint: true,
            data: [

                <?php
                $sql= "SELECT a.nome , count(*) as total from frequencia f INNER JOIN alunos a ON f.idAluno = a.id_aluno group by a.nome ORDER BY `total` DESC LIMIT 10";
                $result = $conn->query($sql);
                while($res = $result->fetch_assoc()){
                ?>

                ['<?php echo $res['nome']; ?>', <?php echo $res['total'] ?>],

                <?php
                    
        }
                ?>


            ]
        }],
        drilldown: {
            series: [{
                //name: 'Microsoft Internet Explorer',
                //id: 'Microsoft Internet Explorer',
                data: [
                    <?php
                $sql= "SELECT a.nome , count(*) as total from frequencia f INNER JOIN alunos a ON f.idAluno = a.id_aluno group by a.nome";
                $result = $conn->query($sql);
                while($res = $result->fetch_assoc()){
                ?>

                ['<?php echo $res['nome']; ?>', <?php echo $res['total'] ?>],

                <?php
                    
        }
                ?>
                ]
            }]
        }
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
