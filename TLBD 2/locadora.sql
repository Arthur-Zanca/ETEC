create database locadora;
use locadora;
create table cliente(
	id_cliente int,
	nome_cliente varchar(50),
	rg char(10),
	data_nasc date,
	endereco varchar(75),
	telefone char(8),
	celular char(9),
	primary key(id_cliente)
);
create table dvd(
	id_dvd int,
	nome_dvd varchar(300),
	genero varchar(30),
	estudio varchar(50),
	primary key(id_dvd)
);
create table funcionario(
	id_funcionario int,
	nome_funcionario varchar(50),
	rg char(10),
	data_nasc date,
	endereco varchar(50),
	telefone char(8),
	celular char(9),
	primary key(id_funcionario)
);
create table locacao(
	id_locacao int,
	id_cliente_locacao int,
	id_dvd_locacao int,
	id_funcionario_locacao int,
	data_devolucao date,
	preco_locacao int,
	primary key (id_locacao)
);
alter table locacao add foreign key (id_cliente_locacao) references cliente (id_cliente);
alter table locacao add foreign key (id_dvd_locacao) references dvd (id_dvd);
alter table locacao add foreign key (id_funcionario_locacao)references funcionario(id_funcionario);
