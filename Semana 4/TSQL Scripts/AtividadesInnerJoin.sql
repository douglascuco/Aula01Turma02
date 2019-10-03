/*update Marcas
set UsuAlt = 1, UsuInc = 1
where UsuInc = 0*/

--Trazer somente as marcas que Felipe Cadastrou
select mar.Nome from Marcas mar 
inner join Usuarios usu on usu.Id = mar.UsuInc
where usu.Usuario like 'Felipe%'

--Trazer somente as marcas que Giomar Cadastrou
select mar.Nome from Marcas mar 
inner join Usuarios usu on usu.Id = mar.UsuInc
where usu.Usuario like 'Giomar%'

--Trazer somente a quantidade de marcas que Felipe cadastrou do maior para menor "so colocar o desc mesmo não fazendo sentido"
select COUNT(mar.Nome) as 'Qtd Marcas Felipe'from Marcas mar 
inner join Usuarios usu on usu.Id = mar.UsuInc
where usu.Usuario like 'Felipe%'
order by COUNT(mar.Nome) desc

--Trazer somente a quantidade de marcas que Giomar cadastrou do menor para maior
select COUNT(mar.Nome) as 'Qtd Marcas Giomar' from Marcas mar 
inner join Usuarios usu on usu.Id = mar.UsuInc
where usu.Usuario like 'Giomar%'
order by COUNT(mar.Nome) asc

--Trazer somente a quantidade de marcas que Felipe e Giomar cadastraram 
select COUNT(mar.Nome) as 'Quantidade de Marcas' from Marcas mar 
inner join Usuarios usu on usu.Id = mar.UsuInc
where usu.Usuario like 'Felipe%' OR usu.Usuario like 'Giomar%'
group by usu.Usuario

--Trazer somente os carros que Felipe cadastrou
select car.Modelo from Carros car
inner join Usuarios usu on usu.Id = car.UsuInc
where usu.Usuario like 'Felipe%'

--Trazer somente os carros que Giomar cadastrou
select car.Modelo from Carros car
inner join Usuarios usu on usu.Id = car.UsuInc
where usu.Usuario like 'Giomar%'

--Trazer somente a quantidade de carros que Felipe cadastrou maior para menor
select COUNT(car.Modelo) as 'Qtd de carros Felipe' from Carros car
inner join Usuarios usu on usu.Id = car.UsuInc
where usu.Usuario like 'Felipe%'
order by COUNT(car.Modelo) desc

--Trazer somente a quantidade de carros que Giomar cadastrou menor para maior
select COUNT(car.Modelo) as 'Qtd de Carros Giomar' from Carros car
inner join Usuarios usu on usu.Id = car.UsuInc
where usu.Usuario like 'Giomar%'
order by COUNT(car.Modelo) asc

--Trazer somente a quantidade de carros que Felipe e Giomar cadastraram 
select COUNT(car.Modelo) as 'Qtd de Carros' from Carros car
inner join Usuarios usu on usu.Id = car.UsuInc
where usu.Usuario like 'Felipe%' OR usu.Usuario like 'Giomar%'
group by usu.Usuario

--Trazer somente os carros das marcas que Felipe cadastrou
select car.Modelo from Carros car
inner join Marcas mar on mar.Id = car.Marca
inner join Usuarios usu on usu.Id = mar.UsuInc
where usu.Usuario like 'Felipe%'

--Trazer somente os carros das marcas que Giomar cadastrou
select car.Modelo from Carros car
inner join Marcas mar on mar.Id = car.Marca
inner join Usuarios usu on usu.Id = mar.UsuInc
where usu.Usuario like 'Giomar%'

--Trazer somente a quantidade de carros das marcas que Felipe cadastrou maior para menor
select COUNT(car.Modelo) as 'Qtd  de carros das marcas cadastradas por Felipe' from Carros car
inner join Marcas mar on mar.Id = car.Marca
inner join Usuarios usu on usu.Id = mar.UsuInc
where usu.Usuario like 'Felipe%'
order by COUNT(car.Modelo) desc


--Trazer somente a quantidade de carros das marcas que Giomar cadastrou menor para maior
select COUNT(car.Modelo) as 'Qtd  de carros da marcas cadastradas por Giomar' from Carros car
inner join Marcas mar on mar.Id = car.Marca
inner join Usuarios usu on usu.Id = mar.UsuInc
where usu.Usuario like 'Giomar%'
order by COUNT(car.Modelo) asc





--Trazer o valor total de vendas 2019 isolado
select SUM((Valor)*(Quantidade)) as 'Valor Total de Vendas de 2019' from Vendas
where YEAR(DatInc) = 2019

--Trazer a quantidade total de vendas 2019 isolado
select SUM(Quantidade) as 'Quantidade Total de Vendas de 2019' from Vendas
where YEAR(DatInc) = 2019

--Trazer o valor total de vendas em cada ano e ordenar do maior para o menor
select YEAR(DatInc) as 'Ano',SUM(Valor*Quantidade) as 'Valor Total' from Vendas 
group by YEAR(DatInc)
order by SUM(Valor*Quantidade) desc

--Trazer a quantidade de vendas em cada ano e ordenar do maior para o menor
select YEAR(DatInc) as 'Ano',SUM(Quantidade) as 'Quantidade Total' from Vendas 
group by YEAR(DatInc)
order by SUM(Quantidade) desc

--Trazer o mês de cada ano que retornou a maior quantidade de vendas
--		- Tradução "Retornar agrupado por mês e ordenar do maior para menor"


SELECT  YEAR(DatInc),MONTH(DatInc),SUM(Quantidade)  FROM Vendas
GROUP BY YEAR(DatInc),MONTH(DatInc)
ORDER BY YEAR(DatInc),SUM(Quantidade) DESC





		
--Trazer o mês de cada ano que retornou o maior valor de vendas
--		- Tradução "Retornar agrupado por mês e ordenar do maior para menor"
SELECT  YEAR(DatInc),MONTH(DatInc),SUM(Quantidade*Valor)  FROM Vendas
GROUP BY YEAR(DatInc),MONTH(DatInc)
ORDER BY SUM(Quantidade*Valor) DESC

--Trazer o valor total de vendas que Felipe realizou
select SUM(ven.Valor*ven.Quantidade) as 'Valor Total Vendas Felipe' from Vendas ven
inner join Usuarios usu on usu.Id = ven.UsuInc
where usu.Usuario like 'Felipe%'





--Trazer o valor total de vendas que Giomar realizou
select SUM(ven.Valor*ven.Quantidade) as 'Valor Total Vendas Giomar' from Vendas ven
inner join Usuarios usu on usu.Id = ven.UsuInc
where usu.Usuario like 'Giomar%'





--Trazer a quantidade total de vendas que Felipe realizou
select SUM(ven.Quantidade) as 'Valor Total Vendas Felipe' from Vendas ven
inner join Usuarios usu on usu.Id = ven.UsuInc
where usu.Usuario like 'Felipe%'





--Trazer a quantidade de vendas que Giomar realizou
select SUM(ven.Quantidade) as 'Valor Total Vendas Giomar' from Vendas ven
inner join Usuarios usu on usu.Id = ven.UsuInc
where usu.Usuario like 'Giomar%'





--Trazer a quantidade total de vendas que Felipe e Giomar realizaram ordenando do maior para menor
select SUM(ven.Quantidade) as 'Quantidade Total Vendas' from Vendas ven
inner join Usuarios usu on usu.Id = ven.UsuInc
where usu.Usuario like 'Giomar%' OR usu.Usuario like 'Felipe%'
group by usu.Usuario
order by SUM(ven.Quantidade) desc

--Trazer o valor de vendas que Felipe e Giomar realizaram ordenando do maior para menor
select usu.Usuario , SUM(ven.Quantidade * ven.Valor) as 'Valor Total Vendas' from Vendas ven
inner join Usuarios usu on usu.Id = ven.UsuInc
where usu.Usuario like 'Giomar%' OR usu.Usuario like 'Felipe%'
group by usu.Usuario
order by SUM(ven.Quantidade*ven.Valor) desc








--Trazer  a marca mais vendida de todos os anos
--		- Tradução "Retornar todas as marcas que foram vendidas mas ordernada da maior para menor"
select mar.Nome from Marcas mar
inner join Carros car on car.Marca = mar.Id
inner join Vendas ven on ven.Carro = car.Id
group by mar.Nome
order by SUM(ven.Quantidade) desc 









--Trazer o valor total da marca mais vendida de todos os anos		
select SUM(ven.Quantidade*ven.Valor) as 'Valor total marcas mais vendida' from Marcas mar
inner join Carros car on car.Marca = mar.Id
inner join Vendas ven on ven.Carro = car.Id
group by mar.Nome
order by SUM(ven.Quantidade*ven.Valor) desc 





--Trazer a quantidade do carro mais vendido de todos os anos
select car.Modelo, SUM(ven.Quantidade) as 'Quantidade' from Vendas ven
inner join Carros car on car.Id = ven.Carro
group by car.Modelo
order by SUM(ven.Quantidade) desc


--Trazer o valor do carro mais vendido de todos os anos */
select car.Modelo, SUM(ven.Valor) as 'Valor' from Vendas ven
inner join Carros car on car.Id = ven.Carro
group by car.Modelo
order by SUM(ven.Valor) desc