CREATE TABLE [dbo].[Brands]
(
	[BrandId] INT NOT NULL PRIMARY KEY, 
    [BrandName] NCHAR(20) NULL,
	CONSTRAINT BrandName CHECK (DATALENGTH(BrandName)>=2)

)
