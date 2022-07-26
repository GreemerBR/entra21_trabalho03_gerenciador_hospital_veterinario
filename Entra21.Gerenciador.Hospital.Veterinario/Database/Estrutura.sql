﻿CREATE TABLE veterinarios(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(100) NOT NULL,
	idade TINYINT NOT NULL,
	telefone CHAR(14) NOT NULL,
	cpf CHAR(14) NOT NULL,
	especialidade VARCHAR(200) NOT NULL,
	crmv_estado VARCHAR(2) NOT NULL,
	crmv_numero INTEGER NOT NULL);

CREATE TABLE racas(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	especie VARCHAR(100) NOT NULL,
	nome VARCHAR(100) NOT NULL);

CREATE TABLE responsaveis(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(100) NOT NULL,
	idade TINYINT NOT NULL,
	cpf CHAR(14) NOT NULL,
	telefone CHAR(14) NOT NULL);

CREATE TABLE pets(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(100) NOT NULL,
	idade TINYINT NOT NULL,
	peso DECIMAL(5,2) NOT NULL,
	altura DECIMAL(5,2) NOT NULL,
	genero CHAR NOT NULL,
	
	id_responsaveis INTEGER NOT NULL,
	id_racas INTEGER NOT NULL,
	
	FOREIGN KEY(id_responsaveis) REFERENCES responsaveis(id),
	FOREIGN KEY(id_racas) REFERENCES racas(id));

CREATE TABLE consultas(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	data_hora_consulta DATETIME2 NOT NULL,
	observacao TEXT,

	id_veterinarios INTEGER NOT NULL,
	id_pets INTEGER NOT NULL,

	FOREIGN KEY(id_veterinarios) REFERENCES veterinarios(id),
	FOREIGN KEY(id_pets) REFERENCES pets(id));


CREATE TABLE enderecos(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	cep CHAR(9),
	logradouro VARCHAR(100) NOT NULL,
	bairro VARCHAR(100) NOT NULL,
	cidade VARCHAR(100) NOT NULL,
	unidade_federativa VARCHAR(2) NOT NULL,
	
	id_responsaveis INTEGER NOT NULL,
	
	FOREIGN KEY(id_responsaveis) REFERENCES responsaveis(id));

SELECT * FROM veterinarios;
SELECT * FROM consultas;
SELECT * FROM racas;
SELECT * FROM pets;
SELECT * FROM responsaveis;
SELECT * FROM enderecos;

DROP TABLE veterinarios;
DROP TABLE consultas;
DROP TABLE racas;
DROP TABLE pets;
DROP TABLE responsaveis;
DROP TABLE endereco;

ALTER TABLE pets ALTER COLUMN peso DECIMAL(8,2);