--Select

Select ContactName as Adi ,CompanyName as SirketAdi,City as Sehir from Customers

Select * from Customers where City = 'Barcelona'

select * from Products where CategoryID = 1 or CategoryID = 3
select * from Products where CategoryID = 1 and UnitPrice>=10

select * from Products order by ProductName asc
select * from Products order by ProductName desc
select * from Products order by CategoryID,ProductName
select * from Products order by UnitPrice
select * from Products order by UnitPrice desc
select * from Products where CategoryID=1 order by UnitPrice
select * from Products where CategoryID=1 order by UnitPrice desc

Select count(*) from Products

Select CategoryID, count(*)  from Products where UnitPrice>20
group by CategoryID having count(*)< 10

Select ProductID, ProductName, CompanyName, CategoryName, QuantityPerUnit,
UnitPrice,UnitsInStock,UnitsOnOrder,ReorderLevel, Discontinued from Products 
inner join Categories x on x.CategoryID = Products.CategoryID
inner join Suppliers y on y.SupplierID = Products.SupplierID

select * from Customers c left join Orders o 
on c.CustomerID = o.CustomerID
where o.CustomerID is null

select * from Customers c right join Orders o 
on c.CustomerID = o.CustomerID
where o.CustomerID is null