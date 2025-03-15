# GestionDeFacturas–EstebanColorado


GestionDeFacturas es una aplicación para la gestión de facturas desarrollada con Blazor y .NET 8.

## Requisitos

- .NET 8 SDK
- SQL Server (puede ser una instancia local o remota)

## Instalación

Sigue estos pasos para configurar y ejecutar el proyecto en tu entorno local.

### 1. Clonar el repositorio

Clona el repositorio en tu máquina local usando el siguiente comando:
git clone https://github.com/tu-usuario/FacturaCRUD.git cd GestionDeFacturas–EstebanColorado

### 2. Configurar la base de datos

1. **Crear la base de datos**: Abre SQL Server Management Studio (SSMS) o cualquier otra herramienta de administración de SQL Server y ejecuta el script de la base de datos proporcionado en el archivo `database-script.sql`.

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

Reemplaza `TU_SERVIDOR` con el nombre de tu servidor SQL. Si estás usando una instancia local, puedes usar `localhost` o `(localdb)\\MSSQLLocalDB`.

### 3. Restaurar paquetes NuGet

Restaura los paquetes NuGet necesarios para el proyecto usando el siguiente comando:

dotnet restore

### 4. Ejecutar la aplicación

Ejecuta la aplicación usando el siguiente comando:

dotnet run

La aplicación estará disponible en `https://localhost:5001` o `http://localhost:5000`.

## Uso

Una vez que la aplicación esté en funcionamiento, puedes acceder a las siguientes funcionalidades:

- **Lista de Facturas**: Ver la lista de todas las facturas.
- **Crear Factura**: Agregar una nueva factura.
- **Editar Factura**: Modificar una factura existente.
- **Eliminar Factura**: Eliminar una factura existente.

