GO

select 
tip.Tipo as 'Tipo do Veículo',
mar.Nome as 'Marca do Veículo',
vei.Modelo as 'Modelo do Veículo'
from Veiculos vei inner join Marcas mar on vei.MarcaCodigo = mar.Codigo 
				  inner join TipoVeiculo tip on vei.TipoCodigo = tip.Codigo
				  where vei.MarcaCodigo = 10 AND vei.TipoCodigo = 1

GO

select 
tip.Tipo as 'Tipo do Veículo',
mar.Nome as 'Marca do Veículo',
vei.Modelo as 'Modelo do Veículo'
from Veiculos vei inner join Marcas mar on vei.MarcaCodigo = mar.Codigo
				  inner join TipoVeiculo tip on vei.TipoCodigo = tip.Codigo
				  where vei.MarcaCodigo = 20 AND vei.TipoCodigo = 2