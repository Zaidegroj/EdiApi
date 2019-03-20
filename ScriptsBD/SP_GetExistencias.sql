USE [EdiDB]
GO
/****** Object:  StoredProcedure [dbo].[SP_GetExistencias]    Script Date: 3/20/2019 9:08:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SP_GetExistencias]
	@IdClient int
AS
BEGIN
	SELECT 
		pr.CodProducto,
		pr.Descripcion,
		SUM(ii.Existencia) Existencia,
		um.UnidadMedida,
		eq.CodProductoLear
	FROM wms.dbo.Inventario i
		JOIN wms.dbo.ItemInventario ii 
			ON ii.InventarioID =i.InventarioID
		JOIN wms.dbo.Producto pr
			ON pr.CodProducto = ii.CodProducto
		JOIN wms.dbo.UnidadMedida um
			ON um.UnidadMedidaID = i.TipoBulto
		LEFT JOIN LEAR_EQUIVALENCIAS eq
			ON eq.CodProducto = pr.CodProducto
	WHERE i.ClienteID = @IdClient
	GROUP BY pr.CodProducto, 
		pr.Descripcion, 
		um.UnidadMedida,
		eq.CodProductoLear
	ORDER BY pr.CodProducto
END
GO
--EXEC [SP_GetExistencias] 618