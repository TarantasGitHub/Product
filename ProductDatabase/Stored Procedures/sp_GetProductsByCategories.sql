CREATE PROCEDURE [dbo].[sp_GetProductsByCategories]
	@CategoryID int	=	NULL,
	@ProductID int	=	NULL
AS
BEGIN

	SELECT	 P.[ID]
			,P.[Name]
			,P.[Description]
			,C.[ID]
			,C.[Name]
			,C.[Description]
	FROM	Products P
	LEFT JOIN	ProductsToCategories PTC	ON	P.ID			=	PTC.ProductID
	LEFT JOIN	Categories C				ON	PTC.CategoryID	=	C.ID
	WHERE	(@ProductID IS NULL OR P.ID = @ProductID)
		AND	(@CategoryID IS NULL OR PTC.CategoryID = @CategoryID)
	ORDER BY P.[Name], C.[Name]
END
