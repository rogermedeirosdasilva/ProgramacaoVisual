CREATE TABLE ftec.disciplina
(
	disciplinaid integer not null,
	descricao varchar(60) not null,
	constraint pk_disciplina primary key (disciplinaid)
);


CREATE TABLE ftec.aluno
(
	matricula VARCHAR(20) NOT NULL,
	nome varchar(60) not null,
	celular varchar(20) null,
	nascimento date null,
	constraint pk_aluno primary key(matricula)
);


CREATE TABLE ftec.aluno_nota
(
	notaid serial not null,
	matricula varchar(20) not null,
	disciplinaid integer not null,
	avaliacao numeric(5, 2) not null,
	constraint pk_aluno_nota primary key(notaid),
	constraint fk_nota_aluno foreign key (matricula)
		references ftec.aluno (matricula),
	constraint fk_nota_disciplina foreign key (disciplinaid)
		references ftec.disciplina (disciplinaid)
);


INSERT INTO ftec.disciplina (disciplinaid, descricao)
	VALUES
		(1, 'Engenharia de Software'),
		(2, 'Programação Visual'),
		(3, 'Sistemas Operacionais'),
		(4, 'Qualidade de Software'),
		(6, 'Algorítimos'),
		(7, 'Lógica Computacional');
