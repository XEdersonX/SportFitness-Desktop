SELECT o.nome , count(*) as total from planoTreino p INNER JOIN objetivo o 
ON p.idObjetivo = id_objetivo group by o.nome;

SELECT t.nome , count(*) as total from planoTreino p INNER JOIN treinadores treinadores
ON p.idTreinador = t.id_treinador group by t.nome;

SELECT a.nome , count(*) as total from frequencia f INNER JOIN alunos a 
ON f.idAluno = a.id_aluno group by a.nome

SELECT a.nome , count(*) as total from frequencia f INNER JOIN alunos a ON f.idAluno = a.id_aluno group by a.nome

SELECT a.nome , count(*) as total from frequencia f INNER JOIN alunos a ON f.idAluno = a.id_aluno group by a.nome ORDER BY `total` DESC LIMIT 10