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
CREATE TABLE Logins.AcessoFunc(
 AcessoFuncId INT PRIMARY KEY NOT NULL,
 CONSTRAINT fk_FUNCLOG FOREIGN KEY (AcessoFuncId) REFERENCES Usu�rios.Funcionarios (Funcion�rioId),
 Senha VARCHAR (10) NOT NULL
)