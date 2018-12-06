CREATE TABLE [dbo].[ProductsToCategories]
(
	[ID] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[CategoryID] INT NOT NULL,
	[ProductID] INT NOT NULL,
	CONSTRAINT [FK_ProductsToCategories_Categories] FOREIGN KEY([CategoryID]) REFERENCES [dbo].[Categories] ([ID]),
	CONSTRAINT [FK_ProductsToCategories_Products] FOREIGN KEY([ProductID]) REFERENCES [dbo].[Products] ([ID])
)
