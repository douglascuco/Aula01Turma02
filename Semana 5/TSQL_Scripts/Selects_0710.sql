select * from Funcionarios
order by Nome

select * from Produtos
order by Valor desc


select fun.Nome, ped.ProdutoID, ped.Quantidade from Pedidos ped
inner join Funcionarios fun on fun.Id = ped.FuncionarioID


select fun.Nome, SUM(ped.Quantidade) as 'Quantidade Produtos' from Pedidos ped
inner join Funcionarios fun on fun.Id = ped.FuncionarioID
group by fun.Nome

select fun.Nome, SUM(ped.Quantidade * pro.Valor) as 'Valor Total dos Pedidos' from Pedidos ped
inner join Funcionarios fun on fun.Id = ped.FuncionarioID
inner join Produtos pro on pro.Id = ped.ProdutoID
group by fun.Nome

select ProdutoID, SUM(Quantidade) as 'Quantidade de Vendas' from Pedidos
group by ProdutoID
order by SUM(Quantidade) desc


select pro.Nome, SUM(ped.Quantidade * pro.Valor) as 'Maior receita de Vendas' from Pedidos ped
inner join Produtos pro on pro.Id = ped.ProdutoID
group by pro.Nome
order by SUM(ped.Quantidade * pro.Valor) desc


select Nome from Produtos 
where Id NOT IN (select pedidos.ProdutoID from Pedidos pedidos
					inner join Funcionarios fun on fun.Id = pedidos.FuncionarioID
					where fun.nome like 'Douglas%')



select ProdutoID, COUNT(ProdutoID) as 'Quantidade' from Pedidos
group by ProdutoID
order by COUNT(ProdutoID)desc




