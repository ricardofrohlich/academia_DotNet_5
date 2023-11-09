

create database livraria

create table editoras
(
	id integer not null primary key identity,
	nome varchar(60) not null
)

create table autores
(
	id integer not null primary key identity,
	nome varchar(50) not null,
	nacionalidade varchar(40)
)

create table categorias
(
	id integer primary key not null identity,
	nome varchar(50) not null
)

create table livros
(
	isbn varchar(22) primary key not null,
	titulo varchar(50) not null,
	ano integer not null,
	fk_editora integer not null,
	fk_categoria integer not null,
	foreign key (fk_editora) references editoras(id),
	foreign key (fk_categoria) references categorias(id)
)

create table livro_autor
(
	id integer not null primary key identity,
	fk_livro varchar(22) not null,
	fk_autor integer not null,
	foreign key (fk_livro) references livros(isbn),
	foreign key (fk_autor) references autores(id)
)
