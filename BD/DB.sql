CREATE DATABASE examen

use examen;

create table usuarios(
cedula int not null primary key,
nombre varchar(30) not null,
apellido varchar(30) not null,
direc    varchar(45),
telefono  int,
correo varchar(50),
contraseña varchar(30)not null,
uid varchar(MAX)
 );


create table producto(
cod_prod  int not null primary key,
nombreprod varchar(30) not null,
cod_cat int not null,
marca varchar(30) not null,
precio int not null,
cantidad int not null
);


create table categoria(
cod_cat int not null primary key,
nombre_cat varchar(30) not null
);

create table deseos(
cod_des int not null primary key,
cedula int not null,
cod_prod int not null,
cantidad int not null
);

alter table producto add foreign key (cod_cat) references categoria(cod_cat)
alter table deseos add foreign key (cod_prod) references producto(cod_prod)
alter table  deseos add foreign key (cedula)  references usuarios(cedula)

select * from producto