--Criando a base para o PIM
CREATE DATABASE PimDB;
GO 
--Para usar a base
USE PimDB;

--------------------------------------------------------------------------------------------------------------------
--Criando o schema endereços
CREATE SCHEMA Enderecos;
GO
-----------------------------------------
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

--Criando o Schema para os Usuários
CREATE SCHEMA Usuarios;
GO
-----------------------------------------

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
-------------------------------------------------------------------------------------------------------------------

--Criando o Schema para os Logins
CREATE SCHEMA Logins;

GO
-----------------------------------------------

--tabela de logins Cliente para o Web/mobile
CREATE TABLE Logins.Acesso(
 AcessoId INT PRIMARY KEY NOT NULL,
 Senha VARCHAR (10) NOT NULL,
 CONSTRAINT fk_USULOG FOREIGN KEY (AcessoId) REFERENCES Usuarios.Cliente (ClienteId),
 CONSTRAINT fk_USUSENHA FOREIGN KEY (Senha) REFERENCES Usuarios.Cliente (Senha)
 ON DELETE CASCADE
 ON UPDATE CASCADE
)

GO
-------------------------------------------------
--tabela de logins Funcionário para o Desktop
CREATE TABLE Logins.AcessoFunc(
 AcessoFuncId INT PRIMARY KEY NOT NULL,
 Senha VARCHAR (10) NOT NULL,
 CONSTRAINT fk_FUNCLOG FOREIGN KEY (AcessoFuncId) REFERENCES Usuarios.Funcionarios (FuncionarioId),
 CONSTRAINT fk_FUNCSENHA FOREIGN KEY (Senha) REFERENCES Usuarios.Funcionarios (Senha)
 ON DELETE CASCADE
 ON UPDATE CASCADE
)

--------------------------------------------------------------------------------------------------------
--procedure para inserção de endereço para Desktop

GO

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
SELECT @@IDENTITY AS 'RetornoUI'
COMMIT TRAN
END

uspInserirEndereco 'RUA','123','BAIRRO','SÃO PAULO','SP','BRASIL','COMPLEMENTO','CEP'

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

uspConsultarAcessoUser @AcessoId = 1, @Senha = '123b'

INSERT INTO Usuários.Funcionarios (FuncionárioId, Nome, CPF, Cargo, Email, DataNasc, Setor, Senha)
VALUES (1,'funcionario teste', 333, 'teste','teste@teste.com','2020-10-11','setorTeste','teste')

SELECT * FROM Usuarios.Funcionarios
--------------------------------------------------------------------------------------------------------
-- procedure para consulta de endereço por ID para desktop

GO
CREATE PROCEDURE uspConsultarIdEndereco

@EnderecoId int

AS BEGIN
SELECT * FROM Enderecos.Enderecos
WHERE EnderecoId = @EnderecoId
END
--------------------------------------------------------------------------------------------------------
--procedure para consulta de endereço por Cep para desktop

GO
CREATE PROCEDURE uspConsultaCepEndereco

@Cep VARCHAR (10)

AS BEGIN
SELECT * FROM Enderecos.Enderecos WHERE Enderecos.Cep LIKE '%' + @Cep + '%'
END
--------------------------------------------------------------------------------------------------------
--procedure para excluir endereco para desktop
GO

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
CREATE PROCEDURE uspConsultarUsuarioFuncionarioPorNome

@Nome VARCHAR (30)

AS BEGIN
SELECT * FROM Usuarios.Funcionarios WHERE Nome LIKE '%' + @Nome + '%'
END
go
--------------------------------------------------------------------------------------------------------

CREATE PROCEDURE uspConsultarUsuarioFuncionarioPorId

@FuncionarioId INT

AS BEGIN
SELECT * FROM Usuarios.Funcionarios WHERE FuncionarioId = @FuncionarioId
END
GO

CREATE PROCEDURE uspAlterarUsuarioFuncionario

@FuncionarioId INT,
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
BEGIN TRAN
UPDATE Usuarios.Funcionarios SET Nome = @Nome, CPF = @CPF, Cargo = @Cargo, Email = @Email, DataNasc = @DataNasc, TelefoneFixo = @Telefone,
Celular = @Celular,EnderecoId = @EnderecoId, Setor = @Setor, Senha = @Senha WHERE EnderecoId = @EnderecoId
SELECT @@IDENTITY AS 'RetornoAF'
COMMIT TRAN
END

--------------------------------------------------------------------------------------------------------

