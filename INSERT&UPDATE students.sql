UPDATE PictureProduct 
SET Picture = 
      (SELECT * FROM OPENROWSET(BULK N'C:\1.jpg', SINGLE_BLOB) AS image)
WHERE Id = 6

INSERT INTO PictureProduct (Id, IdProduct, Picture) 
SELECT 8, 4, BulkColumn 
FROM Openrowset( Bulk 'C:\2.jpeg', Single_Blob) as image