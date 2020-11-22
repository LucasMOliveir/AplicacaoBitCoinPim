--Criando a base para o PIM
CREATE DATABASE PimDB;
GO 
--Para usar a base
USE PimDB;
GO
--------------------------------------------------------------------------------------------------------------------

--Criando a tabela endereço
CREATE TABLE Enderecos.Enderecos(
EnderecoId INT PRIMARY KEY NOT NULL IDENTITY (1,1),
Logradouro VARCHAR (120) NOT NULL,
Numero VARCHAR (4) NOT NULL,
Bairro VARCHAR (50) NOT NULL,
Cidade VARCHAR (50) NOT NULL,
Estado VARCHAR (50) NOT NULL,
Pais VARCHAR (50) NOT NULL,
Complemento VARCHAR(20),
Cep VARCHAR (10)
);
GO
-----------------------------------------------------------------------------------------------------

--Criando a tabela funcionários
CREATE TABLE Usuarios.Funcionarios (
FuncionarioId INT PRIMARY KEY NOT NULL IDENTITY (1,1),
Nome VARCHAR (30) NOT NULL,
CPF VARCHAR (11) UNIQUE NOT NULL,
Cargo VARCHAR (30) NOT NULL,
Email VARCHAR (100) NOT NULL,
DataNasc Date NOT NULL,
TelefoneFixo VARCHAR (10),
Celular VARCHAR (11) NOT NULL,
EnderecoId INT NOT NULL,
CONSTRAINT fk_EnderecoIdFunc FOREIGN KEY (EnderecoId) REFERENCES Enderecos.Enderecos (EnderecoId),
Setor VARCHAR (30) NOT NULL,
Senha VARCHAR (10) UNIQUE NOT NULL
--nivel de acesso (ainda vou definir isso)
);

GO
-----------------------------------------------------------
--tabela de logins Cliente para o Web/mobile
CREATE TABLE Usuarios.Cliente (
ClienteId INT PRIMARY KEY NOT NULL IDENTITY (1,1),
Nome VARCHAR (30) NOT NULL,
CPF VARCHAR (11) UNIQUE NOT NULL,
Email VARCHAR (100) NOT NULL,
DataNasc Date NOT NULL,
Senha VARCHAR (10) UNIQUE NOT NULL,
TelefoneFixo VARCHAR (10),
Celular VARCHAR (11) NOT NULL,
EnderecoId INT NOT NULL,
CONSTRAINT fk_EnderecoId FOREIGN KEY (EnderecoId) REFERENCES Enderecos.Enderecos (EnderecoId)
--Statuscadastro VARCHAR (9) NOT NULL
--Ids de ligação ainda serão definidos dos contratos e transações
);

GO
--------------------------------------------------------------------------------------------------------
--criando tabela requisições
CREATE TABLE Requisicoes.RequisicaoCliente(
RequisicaoId INT NOT NULL PRIMARY KEY IDENTITY (1,1),
TipoRequisicao VARCHAR (40) NOT NULL,
Data DATETIME NOT NULL, --Data da criação
Valor FLOAT NOT NULL,
QuantidadeDeMoedas FLOAT NOT NULL,
ClienteId INT NOT NULL,
CONSTRAINT fk_ClienteReq FOREIGN KEY (ClienteId) REFERENCES Usuarios.Cliente (ClienteId)
);
GO
--------------------------------------------------------------------------------------------------------
--Criando tabela de smartContract

CREATE TABLE SmartContrato.Contrato(
ContratoId INT NOT NULL PRIMARY KEY IDENTITY (1,1),
TipoContrato VARCHAR (40),
DataCriacao DATETIME NOT NULL,
Valor FLOAT NOT NULL,
ClienteId INT NOT NULL,
CONSTRAINT fk_ClienteReq FOREIGN KEY (ClienteId) REFERENCES Usuarios.Cliente (ClienteId)
);
GO
--------------------------------------------------------------------------------------------------------
--procedure para inserção de endereço para Desktop

CREATE PROCEDURE uspInserirEndereco

@Logradouro VARCHAR (120),
@Numero VARCHAR (6),
@Bairro VARCHAR (50),
@Cidade VARCHAR (50),
@Estado VARCHAR (50),
@Pais VARCHAR (50),
@Complemento VARCHAR (20),
@Cep VARCHAR (10)


AS BEGIN
BEGIN TRAN
INSERT INTO Enderecos.Enderecos VALUES (@Logradouro,@Numero,@Bairro,@Cidade,@Estado,@Pais,@Complemento,@Cep)
SELECT @@IDENTITY AS 'RetornoIE'
COMMIT TRAN
END
GO
-- teste procedure uspInserirEndereco 'RUA','123','BAIRRO','SÃO PAULO','SP','BRASIL','COMPLEMENTO','CEP'
--------------------------------------------------------------------------------------------------------

CREATE PROCEDURE uspConsultarAcessoUser
@AcessoId int,
@Senha varchar (10)
AS BEGIN
DECLARE @Status int
	IF exists (Select * from Usuarios.Funcionarios where Usuarios.Funcionarios.FuncionarioId = @AcessoId and Senha = @Senha)
	SET @Status = 1
	ELSE
	SET @Status = 0
	SELECT @Status
END

-- TESTE ACESSO USER uspConsultarAcessoUser @AcessoId = 1, @Senha = '123b'

-- TESTE INSERT INSERT INTO Usuários.Funcionarios (FuncionárioId, Nome, CPF, Cargo, Email, DataNasc, Setor, Senha)
--VALUES (1,'funcionario teste', 333, 'teste','teste@teste.com','2020-10-11','setorTeste','teste')
GO
--------------------------------------------------------------------------------------------------------
-- procedure para consulta de endereço por ID para desktop

CREATE PROCEDURE uspConsultarIdEndereco

@EnderecoId int

AS BEGIN
SELECT * FROM Enderecos.Enderecos
WHERE EnderecoId = @EnderecoId
END
GO
--------------------------------------------------------------------------------------------------------
--procedure para consulta de endereço por Cep para desktop

CREATE PROCEDURE uspConsultaCepEndereco

@Cep VARCHAR (10)

AS BEGIN
SELECT * FROM Enderecos.Enderecos WHERE Enderecos.Cep LIKE '%' + @Cep + '%'
END
GO
--------------------------------------------------------------------------------------------------------
--procedure para excluir endereco para desktop

CREATE PROCEDURE uspExcluirEndereco
@EnderecoId int
AS BEGIN
DELETE FROM Enderecos.Enderecos WHERE EnderecoId = @EnderecoId
Select @@IDENTITY AS 'RetornoEE'
END

GO
--------------------------------------------------------------------------------------------------------
--procedure para alterar endereço para desktop
CREATE PROCEDURE uspAlterarEndereco
@EnderecoId int,
@Logradouro varchar (20),
@Numero varchar(6),
@Bairro varchar(50),
@Cidade varchar(50),
@Estado varchar(50),
@Pais varchar(50),
@Cep varchar(10),
@Complemento varchar(20)
AS BEGIN
BEGIN TRAN
UPDATE Enderecos.Enderecos SET Logradouro = @Logradouro,  Numero = @Numero, Bairro = @Bairro, Cidade = @Cidade, Estado = @Estado, Pais = @Pais, Cep = @Cep, Complemento = @Complemento
WHERE EnderecoId = @EnderecoId
SELECT @@IDENTITY AS 'RetornoAE'
COMMIT TRAN
END
GO

--------------------------------------------------------------------------------------------------------
-- PROCEDURE PARA INSERÇÃO DE FUNCIONARIO
CREATE PROCEDURE uspInserirFuncionario

@Nome VARCHAR(30),
@CPF VARCHAR(11),
@Cargo VARCHAR(30),
@Email VARCHAR(100),
@DataNasc DATE,
@Telefone VARCHAR(10),
@Celular VARCHAR(11),
@EnderecoId INT,
@Setor VARCHAR (30),
@Senha VARCHAR(10)

AS BEGIN
INSERT INTO Usuarios.Funcionarios VALUES (@Nome,@CPF,@Cargo,@Email,@DataNasc,@Telefone,@Celular,@EnderecoId,@Setor,@Senha)
SELECT @@IDENTITY AS 'RetornoFI'

END

--uspInserirFuncionario 'jão','CPFffFF','CARGO','','2011-03-12','TELFIXO','TELCEL',1,'ADIMISTRATIVO','123456'
go 
--------------------------------------------------------------------------------------------------------
--PROCEDURE PARA A CONSULTA DE FUNCIONARIO POR NOME
CREATE PROCEDURE uspConsultarUsuarioFuncionarioPorNome

@Nome VARCHAR (30)

AS BEGIN
SELECT * FROM Usuarios.Funcionarios WHERE Nome LIKE '%' + @Nome + '%'
END
go
--------------------------------------------------------------------------------------------------------
--PROCEDURE PARA CONSULTA DE FUNCIONARIO POR ID
CREATE PROCEDURE uspConsultarUsuarioFuncionarioPorId

@FuncionarioId INT

AS BEGIN
SELECT * FROM Usuarios.Funcionarios WHERE FuncionarioId = @FuncionarioId
END
GO
--------------------------------------------------------------------------------------------------------
-- PROCEDURE PARA ALTERAR USUARIO
CREATE PROCEDURE uspAlterarUsuarioFuncionario

@FuncionarioId INT,
@Nome VARCHAR(30),
@CPF VARCHAR(11),
@Cargo VARCHAR(30),
@Email VARCHAR(100),
@DataNasc DATE,
@TelefoneFixo VARCHAR(10),
@Celular VARCHAR(11),
@EnderecoId INT,
@Setor VARCHAR (30),
@Senha VARCHAR(10)

AS BEGIN
BEGIN TRAN
UPDATE Usuarios.Funcionarios SET Nome = @Nome,CPF = @CPF, Cargo = @Cargo, Email = @Email, DataNasc = @DataNasc, TelefoneFixo = @TelefoneFixo,
Celular = @Celular,EnderecoId = @EnderecoId, Setor = @Setor, Senha = @Senha WHERE FuncionarioId = @FuncionarioId
SELECT @@IDENTITY AS 'RetornoAF'
COMMIT TRAN
END

-- TESTE DE ALTER uspAlterarUsuarioFuncionario 1,'nOME','cpf','cargo','mail','2020-10-10','telf','telc',1,'setor','5555'

GO
--------------------------------------------------------------------------------------------------------
--PROCEDURE PARA INSERÇÃO DE CLIENTE
CREATE PROCEDURE uspInserirUsuarioCliente

@Nome VARCHAR(30),
@CPF VARCHAR(11),
@Email VARCHAR(100),
@DataNasc DATE,
@Senha VARCHAR(10),
@TelefoneFixo VARCHAR(10),
@Celular VARCHAR (11),
@EnderecoId INT

AS BEGIN
BEGIN TRAN
INSERT INTO Usuarios.Cliente VALUES (@Nome,@CPF,@Email,@DataNasc,@Senha,@TelefoneFixo,@Celular,@EnderecoId)
SELECT @@IDENTITY AS 'RetornoCI'
COMMIT TRAN
END

GO
--------------------------------------------------------------------------------------------------------
--PROCEDURE PARA ALTERAÇÃO DO CLIENTE
CREATE PROCEDURE uspAlterarUsuarioCliente 

@ClienteId INT,
@Nome VARCHAR(30),
@CPF VARCHAR(11),
@Email VARCHAR(100),
@DataNasc DATE,
@Senha VARCHAR(10),
@TelefoneFixo VARCHAR(10),
@Celular VARCHAR(11),
@EnderecoId INT

AS BEGIN
UPDATE Usuarios.Cliente SET Nome = @Nome, CPF = @CPF, Email = @Email, DataNasc = @DataNasc, Senha = @Senha,
TelefoneFixo = @TelefoneFixo, Celular = @Celular, EnderecoId = @EnderecoId
WHERE ClienteId = @ClienteId
SELECT @@IDENTITY AS 'RetornoAC'
END
use PimDB
uspAlterarUsuarioCliente 6,'JAO','CPF','EMAIL','2011-03-12','SENHA','TELF','TELC',1
select * from Usuarios.Cliente

GO
--------------------------------------------------------------------------------------------------------
--PROCEDURE PARA CONSULTA DO CLIENTE POR ID
CREATE PROCEDURE uspConsultarCliendeId

@ClienteId INT

AS BEGIN
SELECT * FROM Usuarios.Cliente WHERE ClienteId = @ClienteId
END
GO
--------------------------------------------------------------------------------------------------------
--PROCEDURE PARA CONSULTA DO CLIENTE POR NOME
CREATE PROCEDURE uspCunsultarClienteNome

@Nome VARCHAR(30)

AS BEGIN
SELECT * FROM Usuarios.Cliente WHERE NOME LIKE '%' + @Nome + '%'
END
GO
--------------------------------------------------------------------------------------------------------
--PROCEDURE PARA INSERÇÃO DE REQUISIÇÃO
CREATE PROCEDURE uspInserirRequisicao

@TipoRequisicao VARCHAR (40),
@Data DATETIME,
@Valor FLOAT,
@QuantidadeDeMoedas FLOAT,
@ClienteId INT

AS BEGIN
BEGIN TRAN
INSERT INTO Requisicoes.RequisicaoCliente VALUES (@TipoRequisicao, @Data, @Valor, @QuantidadeDeMoedas, @ClienteId)
SELECT @@IDENTITY AS 'RetornoIR'
COMMIT TRAN
END
GO
--------------------------------------------------------------------------------------------------------
--PROCEDURE PARA ALTERAÇÃO DE REQUISIÇÃO
CREATE PROCEDURE uspAlterarRequisicao

@RequisicaoId INT,
@TipoRequisicao VARCHAR (40),
@Data DATETIME,
@Valor FLOAT,
@QuantidadeDeMoedas FLOAT,
@ClienteId INT

AS BEGIN
BEGIN TRAN
UPDATE Requisicoes.RequisicaoCliente SET TipoRequisicao = @TipoRequisicao, Data = @Data, Valor = @Valor, QuantidadeDeMoedas = @QuantidadeDeMoedas, ClienteId = @ClienteId WHERE RequisicaoId = @RequisicaoId
SELECT @@IDENTITY AS 'RetornoAR'
COMMIT TRAN
END

--------------------------------------------------------------------------------------------------------
--PROCEDURE PARA CONSULTA DE REQUISIÇÃO POR ID
CREATE PROCEDURE uspConsultarRequisicaoPorId

@RequisicaoId INT

AS BEGIN
SELECT * FROM Requisicoes.RequisicaoCliente WHERE RequisicaoId = @RequisicaoId
END
GO
uspConsultarRequisicaoPorId 1
--------------------------------------------------------------------------------------------------------
--PROCEDURE DE CONSULTA DE REEQUISIÇÃO GERAL
CREATE PROCEDURE uspConsultarRequisicao

AS BEGIN
SELECT * FROM Requisicoes.RequisicaoCliente
END
GO
--------------------------------------------------------------------------------------------------------
--PROCEDURE PARA CONSULTA DE REQUISICAO POR ID
CREATE PROCEDURE uspConsultarRequisicaoPorId

@RequisicaoId INT

AS BEGIN
SELECT * FROM Requisicoes.RequisicaoCliente WHERE RequisicaoId = @RequisicaoId
END
GO
--------------------------------------------------------------------------------------------------------
--PROCEDURE PARA CRIAÇÃO DE SMARTCONTRACT

CREATE PROCEDURE uspInserirSmartContract

@TipoContrato VARCHAR(40),
@DataCriacao DATETIME,
@Valor FLOAT,
@ClienteId INT

AS BEGIN
BEGIN TRAN
INSERT INTO SmartContrato.Contrato VALUES (@TipoContrato, @DataCriacao ,@Valor, @ClienteId)
SELECT @@IDENTITY AS 'RetornoIS'
COMMIT TRAN
END
GO
--------------------------------------------------------------------------------------------------------
--PROCEDURE PARA ALTERAÇÃO EM SMARTCONTRACT

CREATE PROCEDURE uspAlterarSmartContract

@ContratoId INT,
@TipoContrato VARCHAR(40),
@DataCriacao DATETIME,
@Valor FLOAT,
@ClienteId INT

AS BEGIN
BEGIN TRAN
UPDATE SmartContrato.Contrato SET TipoContrato = @TipoContrato, DataCriacao = @DataCriacao, Valor = @Valor, ClienteId = @ClienteId WHERE ContratoId = @ContratoId
SELECT @@IDENTITY AS 'RetornoAS'
COMMIT TRAN
END
GO
--------------------------------------------------------------------------------------------------------
--PROCEDURE PARA CONSULTA DE SMARTCONTRACT GERAL
CREATE PROCEDURE uspConsultaSmartContractPorId
@ContratoId INT

AS BEGIN
SELECT * FROM SmartContrato.Contrato WHERE ContratoId = @ContratoId
END
GO
--------------------------------------------------------------------------------------------------------
--PROCEDURE PARA CONSULTA DE SMARTCONTRACTS
ALTER PROCEDURE uspConsultaSmartContract

AS BEGIN
SELECT * FROM SmartContrato.Contrato 
END
GO
--------------------------------------------------------------------------------------------------------