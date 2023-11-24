-- Insertar datos en CatTipoCliente
INSERT INTO CatTipoCliente (TipoCliente) VALUES ('Corporativo');
INSERT INTO CatTipoCliente (TipoCliente) VALUES ('Individual');
INSERT INTO CatTipoCliente (TipoCliente) VALUES ('Gubernamental');
GO

-- Insertar datos en TblClientes
INSERT INTO TblClientes (RazonSocial, IdTipoCliente, FechaCreacion, RFC) VALUES ('Empresa X', 1, GETDATE(), 'EX123456789');
INSERT INTO TblClientes (RazonSocial, IdTipoCliente, FechaCreacion, RFC) VALUES ('Juan Perez', 2, GETDATE(), 'JP987654321');
INSERT INTO TblClientes (RazonSocial, IdTipoCliente, FechaCreacion, RFC) VALUES ('Gobierno del Estado', 3, GETDATE(), 'GE123456789');
GO

-- Insertar datos en CatProductos
INSERT INTO CatProductos (NombreProducto, ImagenProducto, PrecioUnitario, ext) VALUES ('Laptop XYZ', NULL, 15000.00, 'jpg');
INSERT INTO CatProductos (NombreProducto, ImagenProducto, PrecioUnitario, ext) VALUES ('Smartphone ABC', NULL, 8000.00, 'jpg');
INSERT INTO CatProductos (NombreProducto, ImagenProducto, PrecioUnitario, ext) VALUES ('Teclado USB', NULL, 500.00, 'png');
GO

-- Insertar datos en TblFacturas
INSERT INTO TblFacturas (FechaEmisionFactura, IdCliente, NumeroFactura, NumeroTotalArticulos, SubTotalFactura, TotalImpuesto, TotalFactura) VALUES (GETDATE(), 1, 1, 3, 30000.00, 4800.00, 34800.00);
INSERT INTO TblFacturas (FechaEmisionFactura, IdCliente, NumeroFactura, NumeroTotalArticulos, SubTotalFactura, TotalImpuesto, TotalFactura) VALUES (GETDATE(), 2, 2, 1, 8000.00, 1280.00, 9280.00);
GO

-- Insertar datos en TblDetallesFactura
INSERT INTO TblDetallesFactura (IdFactura, IdProducto, CantidadDeProducto, PrecioUnitarioProducto, SubtotalProducto, Notas) VALUES (1, 1, 1, 15000.00, 15000.00, 'Laptop para el departamento de IT');
INSERT INTO TblDetallesFactura (IdFactura, IdProducto, CantidadDeProducto, PrecioUnitarioProducto, SubtotalProducto, Notas) VALUES (1, 2, 2, 8000.00, 16000.00, 'Smartphones para ejecutivos');
INSERT INTO TblDetallesFactura (IdFactura, IdProducto, CantidadDeProducto, PrecioUnitarioProducto, SubtotalProducto, Notas) VALUES (2, 3, 1, 500.00, 500.00, 'Teclado para la recepción');
GO
