select 
vei.Modelo, 
mar.Nome as 'Marca', 
usu.Nome as 'Usuario Criação' ,
usua.Nome as 'Usuario Alteração',
vei.Placa, 
vei.Ano 


from Veiculos vei inner join Marcas mar on vei.MarcaCodigo = mar.Codigo 
				  inner join Usuarios usu on vei.UsuarioCriacao= usu.Id
				  inner join Usuarios usua on vei.UsuarioAlteracao = usua.Id