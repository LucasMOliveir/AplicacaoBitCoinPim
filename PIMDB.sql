--Criando a base para o PIM
CREATE DATABASE PimDB;

--Para usar a base
USE PimDB;

--Criando o Schema para os Usu�rios
CREATE SCHEMA Usu�rios;

--Criando a tabela funcion�rios
CREATE TABLE Usu�rios.Funcionarios (
Funcion�rioId INT PRIMARY KEY NOT NULL,
Nome VARCHAR (30),
CPF INT UNIQUE NOT NULL,
Cargo VARCHAR (30),
Email VARCHAR (100),
DataNasc Date,
Setor VARCHAR (30),
--nivel de acesso (ainda vou definir isso)
Senha VARCHAR (10) NOT NULL
--Endere�o (ainda vou definir)
--Telefone ainda ser� definido
);

--tabela de logins Cliente para o Web/mobile
CREATE TABLE Usu�rios.Cliente (
ClienteId INT PRIMARY KEY NOT NULL,
Nome VARCHAR (30),
CPF INT UNIQUE NOT NULL,
Email VARCHAR (100),
DataNasc Date,
--Status (vou definir)
--nivel de acesso (ainda vou definir isso)
Senha VARCHAR (10) NOT NULL
--Endere�o (ainda vou definir)
--Telefone ainda ser� definido
--Ids de liga��o ainda ser�o definidos
);

--Criando o Schema para os Logins
CREATE SCHEMA Logins;

--tabela de logins Cliente para o Web/mobile
CREATE TABLE Logins.Acesso(
 AcessoId INT PRIMARY KEY NOT NULL,
 CONSTRAINT fk_USULOG FOREIGN KEY (AcessoId) REFERENCES Usu�rios.Cliente (ClienteId),
 Senha VARCHAR (10) NOT NULL
)

--tabela de logins Funcion�rio para o Desktop
create TABLE Logins.AcessoFunc(
 AcessoFuncId INT PRIMARY KEY NOT NULL,
 CONSTRAINT fk_FUNCLOG FOREIGN KEY (AcessoFuncId) REFERENCES Usu�rios.Funcionarios (Funcion�rioId),
 Senha VARCHAR (10) NOT NULL
)

--cria a procedure e o usp antes do nome � = user stored procedure 
--Consulta cadastro do CLIENTE 

drop PROCEDURE uspConsultarLoginUser

--Todos os parametros come�am com o @ e tem que ter o mesmo tipo do valor a ser comprado
@ClienteId INT

AS
BEGIN

	SELECT * 

	FROM Usuarios.Cliente 
	
--Comprar o clienteid com o parametro @		
	WHERE ClienteId = @ClienteId
	

END

--EXEC de teste
--EXEC uspConsultarLoginUser 1

-------------------------------------------------------------------------------------------------------------

--cria a procedure e o usp antes do nome � = user stored procedure 
--Consulta cadastro do Funcionario

drop PROCEDURE uspConsultarLoginFunc

--Todos os parametros come�am com o @ e tem que ter o mesmo tipo do valor a ser comprado
@FuncionarioId INT

AS
BEGIN

	SELECT * 

	FROM Usuarios.Funcionarios
	
--Comprar o clienteid com o parametro @		
	WHERE FuncionarioId = @FuncionarioId
	

END

--EXEC de teste
--EXEC uspConsultarLoginFunc 1

-------------------------------------------------------------------------------------------------------------

--cria a procedure e o usp antes do nome � = user stored procedure 
--Consulta Acesso Funcionario

drop PROCEDURE uspConsultarAcessoFunc

--Todos os parametros come�am com o @ e tem que ter o mesmo tipo do valor a ser comprado
@AcessoFuncId INT,
@Senha VARCHAR (10)

AS
BEGIN
 
	SELECT * 

	FROM Logins.AcessoFunc
	
--Comprar o clienteid com o parametro @		
	WHERE AcessoFuncId = @AcessoFuncId and Senha = @Senha



END

--EXEC de teste exemplo
--EXEC uspConsultarAcessoFunc '1', 'xx';

-------------------------------------------------------------------------------------------------------------

--cria a procedure e o usp antes do nome � = user stored procedure 
--Consulta Acesso Funcionario

drop PROCEDURE uspConsultarAcessoUser

--Todos os parametros come�am com o @ e tem que ter o mesmo tipo do valor a ser comprado
@AcessoId INT,
@Senha VARCHAR (10)

AS
BEGIN
 
	SELECT * 

	FROM Logins.Acesso
	
--Comprar o clienteid com o parametro @		
	WHERE AcessoId = @AcessoId and Senha = @Senha



END

CREATE PROCEDURE uspConsultarAcessoUser
@AcessoId int,
@Senha varchar (10)
AS BEGIN
DECLARE @Status int
	IF exists (Select * from Usu�rios.Funcionarios where Usu�rios.Funcionarios.Funcion�rioId = @AcessoId and Senha = @Senha)
	SET @Status = 1
	ELSE
	SET @Status = 0
	SELECT @Status
END

INSERT INTO Usu�rios.Funcionarios (Funcion�rioId, Nome, CPF, Cargo, Email, DataNasc, Setor, Senha)
VALUES (1,'funcionario teste', 333, 'teste','teste@teste.com','2020-10-11','setorTeste','teste')

select * from Usu�rios.Funcionarios