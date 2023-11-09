

--DDL

CREATE

CREATE DATABASE ACADEMIANET;

DROP DATABASE testes


create table alunos
(
	CPF varchar(11) not null primary key,
	nome varchar(50) not null,
	idade integer,
	email varchar(40) not null,
	endereco varchar(80),
	fone varchar(12),
	sexo char check( sexo in ('F', 'M'))
)

drop table ALUNOS

ALTER

ALTER TABLE alunos
ADD RG varchar(12)

alter table alunos
drop column idade

alter table alunos
alter column nome varchar(100) not null

sp_rename 'alunos.nome', 'nome_completo', 'COLUMN';


create table cursos
(
	ID integer not null primary key identity,
	nome varchar(30) not null,
	CH integer,
	ativo bit default 1,
	descricao text
)

create table disciplinas
(
	ID integer not null primary key identity,
	nome varchar(30) not null,
	CH integer not null,
	fk_curso integer not null,
	foreign key (fk_curso) references cursos(ID)
)

create table matriculas
(
	ID integer primary key not null identity,
	quando datetime default getdate(),
	fk_aluno varchar(11) not null,
	fk_curso integer not null,
	foreign key (fk_aluno) references ALUNOS(CPF),
	foreign key (fk_curso) references cursos(ID)
)




--DML
INSERT
UPDATE
DELETE
SELECT
