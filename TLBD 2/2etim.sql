create database IF NOT EXISTS mat_2ETIM;
use mat_2ETIM;

DROP TABLE IF EXISTS aluno;
CREATE TABLE IF NOT EXISTS aluno (
  ra 		smallint unsigned not null auto_increment, 
  nome_al	varchar(50) not null,
  rg_al		char(9) not null,
  data_nasc date,
  sexo_al 	set('M', 'F'),
  turma		enum('A', 'B'),
  data_edicao timestamp not null default current_timestamp on update current_timestamp,
  PRIMARY KEY (ra)
);

DROP TABLE IF EXISTS curso;
CREATE TABLE IF NOT EXISTS curso (
  id_curso		tinyint unsigned not null,
  nome_curso	varchar(60),
  periodo 		varchar(15),
  ch_curso		tinyint unsigned not null,
  data_edicao timestamp not null default current_timestamp on update current_timestamp,
  PRIMARY KEY (id_curso)
) ;

DROP TABLE IF EXISTS disciplina;
CREATE TABLE IF NOT EXISTS disciplina (
  id_disciplina tinyint unsigned not null,
  nome_disc		varchar(30),
  ch_disc		tinyint unsigned not null,
  id_modulo		tinyint unsigned not null,
  id_prof		smallint unsigned not null,
   data_edicao timestamp not null default current_timestamp on update current_timestamp,
  PRIMARY KEY (id_disciplina)
) ;

DROP TABLE IF EXISTS matricula;
CREATE TABLE IF NOT EXISTS matricula (
  id_mat 	smallint unsigned not null,
  ra		smallint unsigned not null,
  data_mat	timestamp (6),
  id_modulo	tinyint unsigned not null,
  data_edicao timestamp not null default current_timestamp on update current_timestamp,
  PRIMARY KEY (id_mat)
) ;

DROP TABLE IF EXISTS modulo;
CREATE TABLE IF NOT EXISTS modulo (
  id_modulo		tinyint unsigned not null,
  desc_modulo	varchar(40) ,
  ch_modulo 	tinyint unsigned not null,
  id_curso		tinyint unsigned not null,
  data_edicao timestamp not null default current_timestamp on update current_timestamp,
  PRIMARY KEY (id_modulo)
) ;

DROP TABLE IF EXISTS professor;
CREATE TABLE IF NOT EXISTS professor (
  id_professor 	smallint unsigned not null,
  nome_prof		varchar(50),
  rg_prof		char(9),
  data_nasc 	date,
  sexo_prof		set('M', 'F'),
  cpf_prof		char(11),
  data_edicao timestamp not null default current_timestamp on update current_timestamp,
  PRIMARY KEY (id_professor)
) ;

ALTER TABLE disciplina  
	ADD FOREIGN KEY (id_prof) REFERENCES professor (id_Professor),
	ADD FOREIGN KEY (id_modulo) REFERENCES modulo (id_modulo);

ALTER TABLE matricula
	ADD FOREIGN KEY (id_modulo) REFERENCES modulo (id_modulo),
	ADD FOREIGN KEY (ra) REFERENCES aluno (ra);
	
ALTER TABLE modulo  
	ADD FOREIGN KEY (id_curso) REFERENCES curso (id_curso);

insert into aluno (ra,nome_al,turma) value
(08348,	'ALAN VIEIRA DE SOUZA'				,'A'),
(08324,	'AMADEU JOSÉ MARCHI'				,'A'),
(08446,	'ANDERSON DE ARRUDA LOPES JUNIOR'	,'A'),
(08811,	'ANDRÉ FELIPE DE PAULA'				,'A'),
(08375,	'ARIEL ANDRIELLI RODRIGUES DA SILVA','A'),
(08346,	'ARISTON TOMIELLO FURLANETTO'		,'A'),
(08444,	'ARTHUR GROSSKLAUSS ZANCA'			,'A'),
(08520,	'BRUNO NOGUEIRA VILLA'				,'A'),
(08580,	'EDUARDA DE ARAUJO RINALDI'			,'A'),
(08116,	'GABRIEL AUGUSTO MERCADANTE'		,'A'),
(08439,	'GABRIEL HENRIQUE MOREIRA'			,'A'),
(08418,	'GABRIELA CARVALHO OLIVEIRA'		,'A'),
(08343,	'GUSTAVO HENRIQUE PINTO'			,'A'),
(08809,	'HENRIQUE BEZERRA DA SILVA'			,'A'),
(07917,	'IGOR SILVA SANTANA'				,'A'),
(08412,	'ISABELA VITÓRIA VICENTINI'			,'A'),
(08481,	'JEFERSON ANTONY PESCADOR BORIOLO'	,'A'),
(08605,	'JOÃO PEDRO BERGAMASCO HERNANDEZ'	,'A'),
(08337,	'JOAO VICTOR CUSTODIO'				,'A'),
(08326,	'JOÃO VICTOR DA SILVA GUIMARÃES'	,'A'),
(08478,	'JOAO VITOR GONCALVES VALLIM'		,'B'),
(08597,	'JOICE FERNANDA RODRIGUES'			,'B'),
(08420,	'JONATAS TONIN COELHO'				,'B'),
(08404,	'JOSE WELTON TEIXEIRA MOREIRA'		,'B'),
(08577,	'JULIA FERNANDA BALDOINO SANTOS'	,'B'),
(08401,	'LANDRISON FERREIRA SOUSA'			,'B'),
(08807,	'LETICIA FERNANDA DOS SANTOS MALTA'	,'B'),
(08339,	'LUIZ FERNANDO DOS SANTOS'			,'B'),
(08342,	'NAIARA APARECIDA CAVACHIOLI'		,'B'),
(08344,	'NÍCOLAS SERAFIN CONFORTI'			,'B'),
(08329,	'PATRICIA MARQUES QUEIROZ'			,'B'),
(08808,	'PAULO HENRIQUE DOS SANTOS MANO'	,'B'),
(08125,	'RIQUELME VITOR DOS SANTOS'			,'B'),
(08406,	'RONALD DA SILVA'					,'B'),
(08425,	'RYAN RAMON DA SILVA MENDONÇA'		,'B'),
(08363,	'THAYNA ALVES DE SOUSA'				,'B'),
(08593,	'VITOR CARDOSO MARANGON'			,'B'),
(08460,	'VITOR HENRIQUE DOS SANTOS'			,'B'),
(08596,	'WILLIAN BORTOLIN PARRILLO'			,'B');


insert into curso(id_curso,nome_curso,periodo,ch_curso) values
(1,'ETIM em Informática'		,'Integral',3000),
(2,'ETIM em Administração'		,'Integral',3000);

 insert into modulo(id_modulo,desc_modulo,ch_modulo,id_curso) values
(1,'1 ETIM em Informática',500,1),
(2,'2 ETIM em Informática',500,1),
(3,'3 ETIM em Informática',500,1),
(4,'1 ETIM em Administração',500,2),
(5,'2 ETIM em Administração',500,2),
(6,'3 ETIM em Administração',500,2);

insert into professor(id_professor,nome_prof,sexo_prof) values
(1,'Marcelo'	,'M'),
(2,'Paulo'		,'M'),
(3,'Fernando'	,'M'),
(4,'Luciana'  	,'F'),
(5,'Rose'  		,'F'),
(6,'Ana Rita'  	,'F');

insert into disciplina (id_disciplina,nome_disc,id_modulo,id_prof)  values
(1,'Português'	,3,4),
(2,'Matemática'	,2,6),
(3,'Física'		,1,1),
(4,'Inglês'		,6,5),
(5,'História'	,5,2),
(6,'Artes'		,4,3),
(7,'Física'		,3,1),
(8,'Inglês'		,2,5),
(9,'Português'	,1,4),
(10,'Matemática',6,6),
(11,'Física'	,5,1),
(12,'Português'	,4,4);
 
insert into matricula(id_mat,ra,data_mat,id_modulo) values
(1 ,08348,'2018-02-01',1),		
(2 ,08324,'2018-02-01',1),
(3 ,08446,'2018-02-01',1),		
(4 ,08811,'2018-02-01',2),
(5 ,08375,'2018-02-01',2),		
(6 ,08346,'2018-02-01',2),
(7 ,08444,'2018-02-01',3),		
(8 ,08520,'2018-02-01',3),
(9 ,08580,'2018-02-01',3),		
(10,08116,'2018-02-01',4),
(11,08439,'2018-02-01',4),		
(12,08418,'2018-02-01',4),
(13,08343,'2018-02-01',5),		
(14,08809,'2018-02-01',5),
(15,07917,'2018-02-01',5),		
(16,08412,'2018-02-01',6),
(17,08481,'2018-02-01',6),		
(18,08605,'2018-02-01',6),
(19,08337,'2018-02-01',1),		
(20,08326,'2018-02-01',1),
(21,08478,'2018-02-01',1),		
(22,08597,'2018-02-01',2),
(23,08420,'2018-02-01',2),		
(24,08404,'2018-02-01',2),
(25,08577,'2018-02-01',3),	
(26,08401,'2018-02-01',3),
(27,08807,'2018-02-01',3),	
(28,08339,'2018-02-01',4),
(29,08342,'2018-02-01',4),	
(30,08344,'2018-02-01',4),
(31,08329,'2018-02-01',5),	
(32,08808,'2018-02-01',5),
(33,08125,'2018-02-01',5),		
(34,08406,'2018-02-01',6),
(35,08425,'2018-02-01',6),		
(36,08363,'2018-02-01',6),
(37,08593,'2018-02-01',1),
(38,08460,'2018-02-01',2),
(39,08596,'2018-02-01',3);    
-- saur0n esteve aki ^^
-- dadinho esteve aki XD