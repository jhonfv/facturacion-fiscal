-- Procedimiento almacenado para insertar una nueva factura
CREATE PROCEDURE spCrearFactura
    @FechaEmision DATETIME,
    @IdCliente INT,
    @NumeroFactura INT,
    @SubTotalFactura DECIMAL(18, 2),
    @TotalImpuesto DECIMAL(18, 2),
    @TotalFactura DECIMAL(18, 2)
AS
BEGIN
    INSERT INTO TblFacturas (FechaEmisionFactura, IdCliente, NumeroFactura, SubTotalFactura, TotalImpuesto, TotalFactura)
    VALUES (@FechaEmision, @IdCliente, @NumeroFactura, @SubTotalFactura, @TotalImpuesto, @TotalFactura)
    
    SELECT SCOPE_IDENTITY() AS 'FacturaId';
END
GO

-- Procedimiento almacenado para agregar un detalle de factura
CREATE PROCEDURE spAgregarDetalleFactura
    @IdFactura INT,
    @IdProducto INT,
    @Cantidad INT,
    @PrecioUnitario DECIMAL(18, 2),
    @Notas VARCHAR(200)
AS
BEGIN
    INSERT INTO TblDetallesFactura (IdFactura, IdProducto, CantidadDeProducto, PrecioUnitarioProducto, SubtotalProducto, Notas)
    VALUES (@IdFactura, @IdProducto, @Cantidad, @PrecioUnitario, @Cantidad * @PrecioUnitario, @Notas)
END
GO

-- Procedimiento almacenado para buscar facturas por cliente
CREATE PROCEDURE spBuscarFacturasPorCliente
    @IdCliente INT
AS
BEGIN
    SELECT * FROM TblFacturas
    WHERE IdCliente = @IdCliente
END
GO

-- Procedimiento almacenado para buscar facturas por número de factura
CREATE PROCEDURE spBuscarFacturasPorNumero
    @NumeroFactura INT
AS
BEGIN
    SELECT * FROM TblFacturas
    WHERE NumeroFactura = @NumeroFactura
END
GO

-- Procedimiento almacenado para recuperar todos los clientes
CREATE PROCEDURE spObtenerTodosLosClientes
AS
BEGIN
     -- Configura la transacción para que no se mantenga nada bloqueado después de la lectura
    SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;

    SELECT * FROM TblClientes;

    -- Restablece el nivel de aislamiento de transacción al predeterminado
    SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
END;
GO

-- Procedimiento almacenado para recuperar todos los productos
CREATE PROCEDURE spObtenerTodosLosProductos
AS
BEGIN
    -- Configura la transacción para que no se mantenga nada bloqueado después de la lectura
    SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;

    -- Selecciona las columnas necesarias de la tabla de productos
    SELECT Id, NombreProducto, PrecioUnitario, ImagenProducto
    FROM CatProductos;

    -- Restablece el nivel de aislamiento de transacción al predeterminado
    SET TRANSACTION ISOLATION LEVEL READ COMMITTED;
END;
GO
