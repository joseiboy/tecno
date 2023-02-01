create database logingg

use logingg

create table usuarios(
id_usuarios int primary key not null,
Nombre varchar(50),
Contraseña varchar(50),
Roll int
)

insert into usuarios values(1,'Juan','Juan1234',1)
insert into usuarios values(2,'Pablo','pablo345',2)
insert into usuarios values(3,'Maria','mari567',3)
insert into usuarios values(4,'Jose','Jos123',2)
insert into usuarios values(5,'Pedro','pe1234',1)
insert into usuarios values(6,'Mario','mario147',3)

select *from usuarios

drop table usuarios																																																																																																								

