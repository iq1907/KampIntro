--Select 
--Ansi
--case insensitive

select ContactName Adi,CompanyName ŞirketAdı,City Şehir from Customers;

select * from Customers where city = 'Berlin';
select * from Products where CategoryID = 1 or CategoryID = 3;
select * from Products where CategoryID = 1 and  UnitPrice > 20;
select * from Products order by ProductName desc;
select * from Products order by CategoryID, ProductName;
select * from Products where CategoryID = 2 order by UnitPrice desc;

select count(*) from Products where CategoryID = 1;

select CategoryID, count(*) from Products group by CategoryID;
--havingler kümülatif olanlara uygulanır
select CategoryID, count(*) from Products group by CategoryID having count(*) > 5;

select CategoryID, count(*) from Products where UnitPrice<20 group by CategoryID having count(*) > 5;

--inner join (sadece eşleşenleri getirir)
select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryID, CategoryName
from Products inner	join Categories 
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice > 10;

--left join (solda olup sağda olmayanları da getir)
select * from Products p left join [Order Details] od
on p.ProductID = od.ProductID 

--hiç sipariş vermemiş müşteriler
select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null;

select * from Customers c inner join Orders o
on c.CustomerID = o.CustomerID
inner join [Order Details] od
on o.OrderID = od.OrderID

select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID 
inner join Orders o
on od.OrderID = o.OrderID




















