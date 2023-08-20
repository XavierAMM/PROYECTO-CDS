use PROYECTO_CDS;
GO
CREATE PROCEDURE PD_OBTENER_PRODUCTOS_TRANSACCIONES
@inventario_id int
as
begin
	SELECT p.nombre, p.cantidad, tu.descripcion as tipo_unidad, p.cantidad_maxima, p.cantidad_minima, p.precio_compra, p.precio_venta,
	c.nombre as categoria, pr.nombre_empresa as proveedor, p.producto_id, p.tipo_unidad_id, p.categoria_id, p.proveedor_id
	FROM producto p
	JOIN TIPO_UNIDAD tu on tu.tipo_unidad_id = p.tipo_unidad_id
	join categoria c on c.categoria_id = p.categoria_id
	join proveedor pr on pr.proveedor_id = p.proveedor_id
	where p.inventario_id = @inventario_id and p.estado_id = 1
end