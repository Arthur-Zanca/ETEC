create database aula;
use aula;
create table aluno(
	rm int,
	nome varchar(50),
	rg char(9),
	data_nasc date,
	sexo char(1),
	primary key (rm)
);
insert into aluno values
	(1,'clebinho','123654789','2001-02-10','f'),
	(2,'adamastor','985632147','2001-02-11','m');

create table matricula(
	id_mat int,
	rm_mat int,
	date_mat date,
	id_mod_mat int,
	primary key (id_mat)
);
insert into matricula values
	(1,1,'2019-03-12','1'),
	(2,2,'2019-03-12','1');

create table modulo(
	id_mod int,
	desc_mod varchar (40),
	ch_mod int,
	id_curso_mod int,
	primary key (id_mod)
);
insert into modulo values
	(1,'CCDC',40,'1'),
	(2,'TCPT',40,'1');

create table curso(
	id_curso int,
	nome_curso varchar (60),
	periodo varchar (15),
	ch_curso int,
	primary key (id_curso)
);
insert into curso values
	(1,'CV','tarde',4500),
	(2,'INFO','integral',8500);

create table professor(
	id_prof int,
	nome_prof varchar (50),
	ch_prof int,
	rg char (9),
	data_nasc date,
	sexo char (1),
	cpf char (11),
	primary key (id_prof)
);
insert into professor values
	(1,'doisberto',69,'125478963','1901-05-23','i','78965412300'),
	(2,'andrezoka',6969,'965874123','1967-02-11','m','74589632110');

create table disciplina(
	id_disc int,
	nome_disc varchar (30),
	ch_disc int,
	id_disc_mod int,
	id_prof_disc int,
	primary key (id_disc)
);
insert into disciplina values
	(1,'desgrama',44589,1,1),
	(2,'feladapu',458,1,2);

alter table matricula add foreign key (rm_mat) references aluno (rm);
alter table matricula add foreign key (id_mod_mat) references modulo (id_mod);
alter table modulo add foreign key (id_curso_mod) references curso (id_curso);
alter table disciplina add foreign key (id_disc_mod) references modulo (id_mod);
alter table disciplina add foreign key (id_prof_disc) references professor (id_prof);
-- saur0n esteve aki ^^