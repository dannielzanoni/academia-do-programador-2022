--Inserindo um registo na tabela
INSERT INTO [TBDISCIPLINA]
(
	[NOME]
)
VALUES
(
	'FILOSOFIA'
)

--Atualizando um registro
UPDATE [TBDISCIPLINA]
	SET
		[NOME]	= 'Física'
	WHERE
		[NUMERO] = 1

--Excluindo um registro
DELETE FROM [TBDISCIPLINA]
	WHERE 
		[NUMERO] = 1

--Selecionando todos os registros
SELECT
	[NUMERO],
	[NOME]
FROM 
	[TBDISCIPLINA]

--Selecionando apenas um registro
