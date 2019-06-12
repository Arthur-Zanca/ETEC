create database cleitons;
use cleitons;
create table tabelaA (
    nome varchar(50) null
);
insert into tabelaA values ('cleitinho');
insert into tabelaA values ('jubiscleiton');
insert into tabelaA values ('robiscleiton');
insert into tabelaA values ('cleitão');

create table tabelaB (
    nome varchar(50) null
);
insert into tabelaB values ('cleito');
insert into tabelaB values ('cleyton');
insert into tabelaB values ('cleytinho');
insert into tabelaB values ('cleiton');

/* INNER JOIN
select a.nome, b.nome
from tabelaA as a
inner join tabelaB as b
on a.nome = b.nome

LEFT JOIN
select a.nome, b.nome
from tabelaA as a
left join tabelaB as b
on a.nome = b.nome

RIGHT JOIN
select a.nome, b.nome
from tabelaA as a
right join tabelaB as b
on a.nome = b.nome 

FULL OUTER JOIN
select a.nome, b.nome
from tabelaA as a
full outer join tabelaB as b
on a.nome = b.nome
where a.nome is null

LEFT EXCLUDING JOIN
select a.nome, b.nome
from tabelaA as a
left join tabelaB as b
on a.nome = b.nome
where b.nome is null 

RIGHT EXCLUDING JOIN
select a.nome, b.nome
from tabelaA as a
right join tabelaB as b
on a.nome = b.nome
where a.nome is null 

FULL OUTER JOIN EXCLUDING JOIN
select a.nome, b.nome
from tabelaA as a
full outer join tabelaB as b
on a.nome = b.nome
where a.nome is null or b.nome is null */

/* 
saur0n esteve aki ^^
dadinho esteve aki 
*/