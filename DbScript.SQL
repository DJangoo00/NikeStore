CREATE DATABASE nikestore CHARACTER SET utf8mb4;
USE nikestore;
-- `role` definition
CREATE TABLE
    `role` (
        id int NOT NULL AUTO_INCREMENT,
        roleName varchar(50) NOT NULL,
        PRIMARY KEY (id)
    );

-- `user` definition
CREATE TABLE
    `user` (
        id int NOT NULL AUTO_INCREMENT,
        nombre varchar(50) NOT NULL,
        correo varchar(100) NOT NULL,
        password varchar(255) NOT NULL,
        PRIMARY KEY (id)
    );

-- roleuser definition
CREATE TABLE
    roleuser (
        idUserFk int NOT NULL,  
        idRoleFk int NOT NULL,
        PRIMARY KEY (idRoleFk, idUserFk),
        FOREIGN KEY (idRoleFk) REFERENCES `role` (id),
        FOREIGN KEY (idUserFk) REFERENCES `user` (id)
    );

CREATE TABLE
    cliente (
        id INT AUTO_INCREMENT PRIMARY KEY,
        dni VARCHAR(12) NOT NULL UNIQUE,
        primerNombre VARCHAR(50) NOT NULL,
        segundoNombre VARCHAR(50) NULL,
        primerApellido VARCHAR(50) NOT NULL,
        segundoApellido VARCHAR(50) NULL,
        telefono VARCHAR(10) NOT NULL,
        idUserFk INT NOT NULL UNIQUE,
        FOREIGN KEY (idUserFk) REFERENCES `user` (id)
    );

CREATE TABLE
    carrito (
        id INT AUTO_INCREMENT PRIMARY KEY,
        idClienteFk INT NOT NULL,
        vendido BOOLEAN NOT NULL DEFAULT FALSE,
        FOREIGN KEY (idClienteFk) REFERENCES cliente (id)
    );

CREATE TABLE
    categoria (
        id INT AUTO_INCREMENT PRIMARY KEY,
        nombre VARCHAR(50) NOT NULL
    );

CREATE TABLE
    producto (
        id INT AUTO_INCREMENT PRIMARY KEY,
        idCategoriaFk INT NOT NULL,
        titulo VARCHAR(100) NOT NULL,
        imagen VARCHAR(255) NOT NULL,
        precio DECIMAL(10, 2) NOT NULL,
        stock INT NOT NULL,
        FOREIGN KEY (idCategoriaFk) REFERENCES categoria (id)
    );

CREATE TABLE
    carritoproducto (
        id INT AUTO_INCREMENT PRIMARY KEY,
        idCarritoFk INT NOT NULL,
        idProductoFk INT NOT NULL,
        cantidad INT NOT NULL,
        FOREIGN KEY (idCarritoFk) REFERENCES carrito (id),
        FOREIGN KEY (idProductoFk) REFERENCES producto (id)
    );

CREATE TABLE
    factura (
        id INT AUTO_INCREMENT PRIMARY KEY,
        precioTotal DECIMAL(10, 2) NOT NULL,
        idClienteFk INT NOT NULL,
        FOREIGN KEY (idClienteFk) REFERENCES cliente (id)
    );

CREATE TABLE
    detallefactura (
        id INT AUTO_INCREMENT PRIMARY KEY,
        idCarritoProductoFk INT NOT NULL,
        idFacturaFk INT NOT NULL,
        precioUnitario DECIMAL(10, 2) NOT NULL,
        cantidad INT NOT NULL,
        FOREIGN KEY (idCarritoProductoFk) REFERENCES carritoproducto (id),
        FOREIGN KEY (idFacturaFk) REFERENCES factura (id)
    );



