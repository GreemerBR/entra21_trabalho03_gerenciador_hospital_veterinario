CREATE TABLE Vets(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(100),
	idade TINYINT,
	telefone INTEGER,
	cpf INTEGER,
	especialidade VARCHAR(200),
	crmv_estado VARCHAR(2),
	crmv_numero INTEGER);

CREATE TABLE consultas(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	data_consulta DATE,
	hora_consulta TIME,
	observação TEXT,

	id_Vets INTEGER,
	id_pets INTEGER,

	FOREIGN KEY(id_Vets) REFERENCES Vets(id),
	FOREIGN KEY(id_pets) REFERENCES pets(id));

CREATE TABLE racas(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	especie VARCHAR(100),
	nome VARCHAR(100));

CREATE TABLE pets(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(100),
	idade TINYINT,
	peso DECIMAL(5,2),
	altura DECIMAL(3,2),
	genero CHAR,
	
	id_responsaveis INTEGER,
	id_racas INTEGER,
	
	FOREIGN KEY(id_racas) REFERENCES racas(id),
	FOREIGN KEY(id_responsaveis) REFERENCES responsaveis(id));

CREATE TABLE responsaveis(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(100),
	idade TINYINT,
	cpf INTEGER,
	telefone INTEGER,);

CREATE TABLE enderecos(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	cep INTEGER,
	logradouro VARCHAR(100),
	bairro VARCHAR(100),
	cidade VARCHAR(100),
	unidade_federativa VARCHAR(2),
	
	id_responsaveis INTEGER,
	
	FOREIGN KEY(id_responsaveis) REFERENCES responsaveis(id));

SELECT * FROM Vets;
SELECT * FROM consultas;
SELECT * FROM racas;
SELECT * FROM pets;
SELECT * FROM responsaveis;
SELECT * FROM enderecos;
