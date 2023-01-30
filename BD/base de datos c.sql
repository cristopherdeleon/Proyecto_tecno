CREATE DATABASE Tarea
USE Tarea

CREATE TABLE Usuarios(
USUARIO VARCHAR(50) PRIMARY KEY,
CONTRASEÑA VARCHAR(50),
ROLL VARCHAR(50)
)

INSERT INTO Usuarios VALUES ('Carlos123','1','administrador')
INSERT INTO Usuarios VALUES ('Victor123','2','usuario')
INSERT INTO Usuarios VALUES ('Marta123','3','secretaria')
INSERT INTO Usuarios VALUES ('Sol123','4','administrador')

CREATE TABLE Participantes
(id int primary key,
nombre varchar(50),
apellido varchar(50),
correo varchar(50),
edad int,
usuario varchar(50),
contraseña varchar(50),
roll varchar(50))
select *from PARTICIPANTES
select *from Usuarios



