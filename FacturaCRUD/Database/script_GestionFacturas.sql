-- Creación de la base de datos
CREATE DATABASE GestionFacturas;
GO

USE GestionFacturas;
GO

-- Creación de la tabla Facturas
CREATE TABLE Facturas (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    NumeroFactura VARCHAR(50) NOT NULL,
    FechaVencimiento DATE NOT NULL
);
GO

-- Insertar datos de prueba
INSERT INTO Facturas (NumeroFactura, FechaVencimiento)
VALUES 
    ('0001', '2024-03-14'),
    ('0002', '2025-03-21'),
    ('0003', '2025-03-27'),
    ('0004', '2025-04-03');
GO
