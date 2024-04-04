create database dreamfit;
use dreamfit;

create table Cliente(
id int not null auto_increment primary key,
Nome varchar(50) not null,
Endereco varchar(150) not null,
Telefone varchar(50) not null,
plano varchar(50) not null
);

create table venda(
id int not null auto_increment primary key,
nomePlano varchar(50) not null,
valor decimal(10,2) not null,
idCliente int not null,
foreign key (idCliente) references Cliente(id)
);

select*from Cliente;



