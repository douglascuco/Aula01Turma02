update Livros set Ativo = 1 where Ativo = 0


UPDATE LIVROS SET Ativo = 0 where ID =
(SELECT id FROM Livros WHERE Ativo = 1 ORDER BY id desc OFFSET 1 ROWS FETCH NEXT 1 ROWS ONLY)


select * from Livros where ativo = 1