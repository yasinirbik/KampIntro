-- Select(Listele) 
Select ContactName Adi, CompanyName SirketAdi ,City from Customers 
-- fromdan önce * koyarsak hepsini yukarıdaki gibi yazarsak seçtklerimizi listeleriz

-----------Where(koşul)
Select * from Customers where City = 'Berlin'--where kosşul sagliyor(if)
--case insensitive --Byük-küçük hassasiyeti bulunmamakta
sElEcT * from Products where CategoryID =1 or CategoryID = 3
select * from Products where UnitPrice<=10 and CategoryID = 1

--------Order by(srala)
select * from Products order by CategoryID, ProductName --Ürün ismine göre alphabetik öncesinde de kategori ıd'ye göre sayısal sıralar
select * from Products order by UnitPrice asc--Ascending--default'u budur zaten yazmasak da aynı durum söz konusu artarak listeler
select * from Products order by UnitPrice desc--descending--Düşürerek listeler
select * from Products order by ProductName desc --alfabetik olarak tersten (z-->a) şeklnde listeler.
select * from Products where CategoryID = 1 order by UnitPrice desc--Kategori ıd'si 1 olanların fiyatını azalan şekilde sırala.

------Count(/)(say)
select count(*) from Products --tüm ürüm sayısı/77
select count(*) from Customers --Tüm müsterilerin sayısı/91
select count(*) UrunSayisi from Products where CategoryID =2 --Kategoriıd,'si 2 olan ürün sayısı/12 --Urun sayısı yazılmasa da pek tabi olur.
--no column name yeri dolu olsun istiyorsan  from'dan önceki bölüme yaz

--------Group by(Grupla)
select CategoryID from Products group by CategoryID--Bu kod diypr ki; ürünlerden kategori ıd'yi al ve tekrarlamadan listele
select CategoryId,count(*) from products group by CategoryID
--Gruplandırılmış kategori ID'leri ve ID başına ne kadar ürün düştüğünü listeler
select CategoryId,count(*) UrunSayisi from products group by CategoryID --Sutunu tanımladık ürün sayısı yerine hiçbirşey yazmazdı şimdi UruSayisi yazıyor, yazmasak da olurdu
select City,count(*) from Customers group by City--şehirleri ve o şehirden kaç kisinin Custtomers database'inde varoldugunu listeledik.
select CategoryId, count(*) from Products group by CategoryID having count(*)>=10--10'dan fazla ürüne sahip kategori Idleriürün sayısı ile birlikte listele.
select CategoryId , count(*) from Products where UnitPrice<=20 group by CategoryId having count(*)<10
--üst satırdaki kod satırı der ki ; fiyatı 20 ve 20'den az olan ürünleri kategori Id'ye göre grupla o gruplarda da sayıları 10'dan az olanları ürün sayısı ile birlikte yaz.

select *
from Products inner join Categories
on Products.CategoryId = Categories.CategoryId
--Products veri tabanına Category Id'lerin eşitliği kullanılarak Categories veritabanı eklendi . 
select Products.ProductID, products.ProductName, Products.UnitPrice,Categories.CategoryName
from Products inner join Categories
on Products.CategoryId = Categories.CategoryId
where Products.UnitPrice<15
--Belli başlı sutünların listelenmesii seçerek ve koşul ekleyerek, tabloyu CategoryName eklnemiş olarak listeledik
--inner join 2 tabloda eşleşşen dataları bir araya getirmekte kullanılır.
---DTO Data Transformation Objects

select *
from Products p left join [Order Details] od --products'i p ORDER DETAİL'I ORDER OLARAK ALLİAS'lıyabiliriz.
--left join solda olup sağda olmayanları da getir demek
on  p.ProductID = od.ProductID

select * from Customers c left join Orders o--müsterilerde olup siparişlerde olmayanları da getir demektir. inner yapınca 830 left yapınca 832 çıktı 
on c.CustomerID = o.CustomerID
where o.CustomerID is null--null bu data yok demek
--o iki hiç sipariş vermemiş müşterilerimizi listeleriz.
-- right join de mevcuttur lakin kullanacağımız zaman yerlerini değiştrmemiz gerkeir ve manası da tabiki, sağda olup saolda olmayan demektir.
