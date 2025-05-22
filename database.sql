CREATE DATABASE lojaDb CHARACTER SET utf8mb4 
COLLATE utf8mb4_unicode_ci;

USE lojaDb;
CREATE TABLE carros (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci,
    ano YEAR NOT NULL,
    marca varchar(255)CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci,
    descricao varchar(255)CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci,
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

CREATE TABLE clientes (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci,
    email VARCHAR(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci,
    telefone VARCHAR(20)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;




