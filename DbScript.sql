-- Crear la base de datos
CREATE DATABASE FacturacionDB;
GO

-- Seleccionar la base de datos para usar
USE FacturacionDB;
GO

-- Crear la tabla de Clientes
CREATE TABLE TblClientes (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    RazonSocial VARCHAR(200),
    IdTipoCliente INT,
    FechaCreacion DATE,
    RFC VARCHAR(50)
);
GO

-- Crear la tabla de Tipos de Cliente
CREATE TABLE CatTipoCliente (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    TipoCliente VARCHAR(50)
);
GO

-- Crear la tabla de Productos
CREATE TABLE CatProductos (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    NombreProducto VARCHAR(50),
    ImagenProducto IMAGE,
    PrecioUnitario DECIMAL(18, 2),
    ext VARCHAR(5)
);
GO

-- Crear la tabla de Facturas
CREATE TABLE TblFacturas (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FechaEmisionFactura DATETIME,
    IdCliente INT,
    NumeroFactura INT,
    NumeroTotalArticulos INT,
    SubTotalFactura DECIMAL(18, 2),
    TotalImpuesto DECIMAL(18, 2),
    TotalFactura DECIMAL(18, 2),
    CONSTRAINT FK_Facturas_Cliente FOREIGN KEY (IdCliente) REFERENCES TblClientes(Id)
);
GO

-- Crear la tabla de Detalles de Factura
CREATE TABLE TblDetallesFactura (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    IdFactura INT,
    IdProducto INT,
    CantidadDeProducto INT,
    PrecioUnitarioProducto DECIMAL(18, 2),
    SubtotalProducto DECIMAL(18, 2),
    Notas VARCHAR(200),
    CONSTRAINT FK_DetallesFactura_Factura FOREIGN KEY (IdFactura) REFERENCES TblFacturas(Id),
    CONSTRAINT FK_DetallesFactura_Producto FOREIGN KEY (IdProducto) REFERENCES CatProductos(Id)
);
GO

-- Establecer las relaciones de clave foránea
ALTER TABLE TblClientes ADD CONSTRAINT FK_Clientes_TipoCliente FOREIGN KEY (IdTipoCliente) REFERENCES CatTipoCliente(ID);
GO
