--Criando a base para o PIM
CREATE DATABASE PimDB;

--Para usar a base
USE PimDB;

--Criando o Schema para os Usuários
CREATE SCHEMA Usuários;

--Criando a tabela funcionários
CREATE TABLE Usuários.Funcionarios (
FuncionárioId INT PRIMARY KEY NOT NULL,
Nome VARCHAR (30),
CPF INT UNIQUE NOT NULL,
Cargo VARCHAR (30),
Email VARCHAR (100),
DataNasc Date,
Setor VARCHAR (30),
--nivel de acesso (ainda vou definir isso)
Senha VARCHAR (10) NOT NULL
--Endereço (ainda vou definir)
--Telefone ainda será definido
);

--tabela de logins Cliente para o Web/mobile
CREATE TABLE Usuários.Cliente (
ClienteId INT PRIMARY KEY NOT NULL,
Nome VARCHAR (30),
CPF INT UNIQUE NOT NULL,
Email VARCHAR (100),
DataNasc Date,
--Status (vou definir)
--nivel de acesso (ainda vou definir isso)
Senha VARCHAR (10) NOT NULL
--Endereço (ainda vou definir)
--Telefone ainda será definido
--Ids de ligação ainda serão definidos
);

--Criando o Schema para os Logins
CREATE SCHEMA Logins;

--tabela de logins Cliente para o Web/mobile
CREATE TABLE Logins.Acesso(
 AcessoId INT PRIMARY KEY NOT NULL,
 CONSTRAINT fk_USULOG FOREIGN KEY (AcessoId) REFERENCES Usuários.Cliente (ClienteId),
 Senha VARCHAR (10) NOT NULL
)

--tabela de logins Funcionário para o Desktop
CREATE TABLE Logins.AcessoFunc(
 AcessoFuncId INT PRIMARY KEY NOT NULL,
 CONSTRAINT fk_FUNCLOG FOREIGN KEY (AcessoFuncId) REFERENCES Usuários.Funcionarios (FuncionárioId),
 Senha VARCHAR (10) NOT NULL
)