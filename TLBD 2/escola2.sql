create database escola;
use escola;
create table curso(
	id_curso int,
	nome_curso varchar(25),
	primary key (id_curso)
);
create table aluno(
	id_aluno int,
	nome_aluno varchar(35),
	id_curso_aluno int,
	primary key (id_aluno)
);
alter table aluno add foreign key (id_curso_aluno) references curso (id_curso);
