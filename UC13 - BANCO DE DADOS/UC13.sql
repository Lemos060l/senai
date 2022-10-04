--DDL -- Cadastrar Tabelas

CREATE DATABASE RpgOnlineBD

USE RpgOnlineBD

-- IDENTITY = Como um CPF , morrer contigo.
-- UNIQUE = Só pode ser 1 por cada item , como nesse caso cada email só pode ser cadastado uma vez.

CREATE TABLE Usuarios(
UsuarioID INT PRIMARY KEY IDENTITY
,Email VARCHAR(100) UNIQUE NOT NULL
,Senha VARCHAR (255) NOT NULL
)

-- Classe 
CREATE TABLE Classes(
ClasseID INT PRIMARY KEY IDENTITY
,Nome VARCHAR (30) UNIQUE NOT NULL
,Descricao VARCHAR(255) NOT NULL
)

CREATE TABLE Personagens(
PersonagemID INT PRIMARY KEY IDENTITY
,NomePersonagem VARCHAR (20) UNIQUE NOT NULL
,UsuarioID INT UNIQUE FOREIGN KEY REFERENCES Usuarios(UsuarioID)
,ClasseID INT FOREIGN KEY REFERENCES Classes(ClasseID)
)

CREATE TABLE Habilidades(
HabilidadeID INT PRIMARY KEY IDENTITY
,Nome VARCHAR (100) UNIQUE NOT NULL
)

CREATE TABLE ClasseHabilidade(
ClasseID INT FOREIGN KEY REFERENCES Classes(ClasseID)
,HabilidadeID INT FOREIGN KEY REFERENCES Habilidades(HabilidadeID)
)

ALTER TABLE Personagens 
ALTER COLUMN NomePersonagem VARCHAR (100);

-- DML -- Adicionar Dados
INSERT INTO Usuarios VALUES ('MATHEUS@LEMOS.COM','123456')
INSERT INTO Classes VALUES ('CAVALEIRO TREVOSO','PODEROSO É AQUELE Q TEME O PODER')
INSERT INTO Usuarios (Email, Senha) VALUES ('manoel@manoel.com', HASHBYTES('SHA2_512','123456'))
INSERT INTO Habilidades VALUES ('RAIO DAS TREVAS'),('DEDO MOLHADO NO OUVIDO'),('CUECÃO'),('PEDALA ROBINHO')
INSERT INTO Personagens (NomePersonagem, UsuarioID, ClasseID) VALUES ('Bill_DAS_TREVAS', 2,2)
INSERT INTO ClasseHabilidade (ClasseID, HabilidadeID) VALUES (1,3), (1,2), (1,1)

UPDATE Usuarios
SET Senha = '9989898'
WHERE UsuarioID = 1

-- DQL -- Consulta Tabela
SELECT * FROM Usuarios
SELECT * FROM Classes
SELECT * FROM Habilidades
SELECT * FROM Personagens
SELECT * FROM ClasseHabilidade

SELECT * FROM Personagens
INNER JOIN Classes
ON Personagens.ClasseID = Classes.ClasseID


-- Exemplos de JOIN

CREATE DATABASE ExemplosJOIN

USE ExemplosJOIN

--DDL

CREATE TABLE TabelaA(
Nome VARCHAR (50) NULL 
)
CREATE TABLE TabelaB(
Nome VARCHAR (50) NULL 
)

-- DML

INSERT INTO TabelaA VALUES ('Mario')
INSERT INTO TabelaA VALUES ('Matheus')
INSERT INTO TabelaA VALUES ('Marcos')
INSERT INTO TabelaA VALUES ('Marta')

INSERT INTO TabelaB VALUES ('Mario'), ('Marta'), ('Tiago'), ('Fernando')

--DQL

SELECT * FROM TabelaA
SELECT * FROM TabelaB

SELECT  TabelaA.Nome, TabelaB.Nome FROM TabelaA
INNER JOIN TabelaB
ON TabelaA.Nome = TabelaB.Nome

SELECT  TabelaA.Nome, TabelaB.Nome FROM TabelaA
LEFT JOIN TabelaB
ON TabelaA.Nome = TabelaB.Nome

SELECT  TabelaA.Nome, TabelaB.Nome FROM TabelaA
RIGHT JOIN TabelaB
ON TabelaA.Nome = TabelaB.Nome

SELECT  TabelaA.Nome, TabelaB.Nome FROM TabelaA
FULL OUTER JOIN TabelaB
ON TabelaA.Nome = TabelaB.Nome