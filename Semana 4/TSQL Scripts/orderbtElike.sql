select 
fun.Nome,
AVG(sal.Valor) as 'Soma Salario',
COUNT(sal.Valor) as 'Quantidade Pagamentos'
from Funcionarios fun
inner join Salarios sal on fun.Id = sal.FuncionarioId
group by fun.Nome
order by SUM(sal.Valor) desc


select * from Salarios
where DataCriacao between '07/06/2019' and '08/09/2019'


select * from Funcionarios where Nome like 'Gina%'