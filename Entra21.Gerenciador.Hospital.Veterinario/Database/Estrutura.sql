CREATE TABLE veterinario(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(100),
	idade TINYINT,
	telefone INTEGER,
	cpf INTEGER,
	especialidade VARCHAR(200),
	crmv_estado VARCHAR(2),
	crmv_numero INTEGER);

CREATE TABLE consulta(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	data_consulta DATE,
	hora_consulta TIME,
	observação TEXT,

	id_veterinario INTEGER,
	id_pet INTEGER,

	FOREIGN KEY(id_veterinario) REFERENCES veterinario(id),
	FOREIGN KEY(id_pet) REFERENCES pet(id));

CREATE TABLE raca(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	especie VARCHAR(100),
	nome VARCHAR(100));

CREATE TABLE pet(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(100),
	idade TINYINT,
	peso DECIMAL(5,2),
	altura DECIMAL(3,2),
	genero CHAR,
	
	id_responsavel INTEGER,
	id_raca INTEGER,
	
	FOREIGN KEY(id_raca) REFERENCES raca(id),
	FOREIGN KEY(id_responsavel) REFERENCES responsavel(id));

CREATE TABLE responsavel(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(100),
	idade TINYINT,
	cpf INTEGER,
	telefone INTEGER,
	endereco VARCHAR);

CREATE TABLE endereco(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	cep INTEGER,
	logradouro VARCHAR(100),
	bairro VARCHAR(100),
	cidade VARCHAR(100),
	unidade_federativa VARCHAR(2),
	
	id_responsavel INTEGER,
	
	FOREIGN KEY(id_responsavel) REFERENCES responsavel(id));

SELECT * FROM veterinario;
SELECT * FROM consulta;
SELECT * FROM raca;
SELECT * FROM pet;
SELECT * FROM responsavel;
SELECT * FROM endereco;