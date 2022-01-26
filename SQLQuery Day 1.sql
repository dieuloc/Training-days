select ProductID, Name, Color, ListPrice
from Production.Product
GO

select ProductID, Name, Color, ListPrice
from Production.Product
where ListPrice <> 0
GO

select ProductID, Name, Color, ListPrice
from Production.Product
where Color IS NULL
GO

select ProductID, Name, Color, ListPrice
from Production.Product
where Color IS NOT NULL
GO

select ProductID, Name, Color, ListPrice
from Production.Product
where Color IS NOT NULL AND ListPrice > 0
GO

select Name + ': ' + Color as [Name and Color]
from Production.Product
where Color IS NOT NULL
GO

select 'NAME: ' + Name + '  --  COLOR: ' + Color as [Name and Color]
from Production.Product
where Color IS NOT NULL
GO

select ProductID, Name
from Production.Product
where ProductID BETWEEN 400 AND 500

select ProductID, Name, Color
from Production.Product
where Color IN ('black','blue')
GO

select ProductID, Name, Color
from Production.Product
where Name LIKE 'S%'
GO

select Name, ListPrice
from Production.Product
where Name LIKE 's%'
ORDER BY Name
GO

select Name, ListPrice
from Production.Product
where Name LIKE '[as]%'
ORDER BY Name
GO

select Name, ListPrice
from Production.Product
where Name LIKE 'SPO[^k]%'
ORDER BY Name
GO

select DISTINCT Color
from Production.Product
where Color IS NOT NULL
ORDER BY Color DESC
GO

select DISTINCT ProductSubcategoryID, Color
from Production.Product
where ProductSubcategoryID IS NOT NULL AND Color IS NOT NULL
GO