INSERT INTO [Genero] ([Nome]) VALUES (1, N'R u mine',				N'Arctic Monkeys',				N'Indie Rock')
INSERT INTO [Genero] ([Nome]) VALUES (2, N'D is for dangerous',		N'Arctic Monkeys',				N'Indie Rock')
INSERT INTO [Genero] ([Nome]) VALUES (3, N'Modern Age',				N'The Strokes',					N'Indie Rock')
INSERT INTO [Genero] ([Nome]) VALUES (4, N'Ize of the world',	    N'The Strokes',					N'Indie Rock')
INSERT INTO [Genero] ([Nome]) VALUES (5, N'Evidências',				N'Chitãozinho & Xororó',		N'Sertanejo')
INSERT INTO [Genero] ([Nome]) VALUES (6, N'Fio de cabelo',		    N'Chitãozinho e Xororó',		N'Sertanejo')
INSERT INTO [Genero] ([Nome]) VALUES (7, N'Sign of the Times',		N'Harry Styles',				N'Pop')
INSERT INTO [Genero] ([Nome]) VALUES (8, N'From the dinning table', N'Harry Styles',				N'Pop')
INSERT INTO [Genero] ([Nome]) VALUES (9, N'Refrão de Bolero',		N'Engenheiros do Hawaii',		N'Rock Nacional')
INSERT INTO [Genero] ([Nome]) VALUES (10,N'Piano Bar',			    N'Engenheiros do Hawaii',		N'Rock Nacional')

INSERT INTO GENEROS (Nome) VALUES ('Indie Rock')
INSERT INTO GENEROS (Nome) VALUES ('Sertanejo')
INSERT INTO GENEROS (Nome) VALUES ('Pop')
INSERT INTO GENEROS (Nome) VALUES ('Rock Nacional')

INSERT INTO ARTISTAS (GeneroId, Nome) VALUES (1 , 'Arctic Monkeys')
INSERT INTO ARTISTAS (GeneroId, Nome) VALUES (1 , 'The Strokes')
INSERT INTO ARTISTAS (GeneroId, Nome) VALUES (2 , 'Chitãozinho & Xororó')
INSERT INTO ARTISTAS (GeneroId, Nome) VALUES (3, 'Harry Styles')
INSERT INTO ARTISTAS (GeneroId, Nome) VALUES (4 , 'Engenheiros do Hawaii')

INSERT INTO CANCOES (ARTISTAID, Nome) VALUES ( 1, 'R u mine'			)
INSERT INTO CANCOES (ARTISTAID, Nome) VALUES ( 1, 'D is for dangerous'	)
INSERT INTO CANCOES (ARTISTAID, Nome) VALUES ( 1, 'Modern Age'			)
INSERT INTO CANCOES (ARTISTAID, Nome) VALUES ( 1, 'Ize of the world'	)
INSERT INTO CANCOES (ARTISTAID, Nome) VALUES ( 2, 'Evidências'		)
INSERT INTO CANCOES (ARTISTAID, Nome) VALUES ( 2, 'Fio de cabelo')
INSERT INTO CANCOES (ARTISTAID, Nome) VALUES ( 3, 'Sign of the Times'		)
INSERT INTO CANCOES (ARTISTAID, Nome) VALUES ( 3, 'From the dinning table')
INSERT INTO CANCOES (ARTISTAID, Nome) VALUES ( 4, 'Refrão de Bolero')
INSERT INTO CANCOES (ARTISTAID, Nome) VALUES ( 4, 'Piano Bar'		)


select gen.Nome 'Genero' , count(can.nome) as 'Quantidade Musicas'
from Generos gen
inner join Artistas art on art.GeneroID = gen.Id
inner join Cancoes can on can.ArtistaId = art.Id
group by gen.Nome