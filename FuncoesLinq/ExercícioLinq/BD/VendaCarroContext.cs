using ExercícioLinq.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioLinq.BD
{
    public class VendaCarroContext
    {
        public List<VendaCarro> listaVendaCarro { get; set; }

        public VendaCarroContext()
        {
            listaVendaCarro = new List<VendaCarro>();
            listaVendaCarro.Add(new VendaCarro() { Id = 1, Nome = "Risus Company", Valor = 7200, Quantidade = 18, DataVenda = DateTime.Parse("29/01/2019") });
            listaVendaCarro.Add(new VendaCarro() { Id = 2, Nome = "Risus Associates", Valor = 9961, Quantidade = 4, DataVenda = DateTime.Parse("10/02/2019") });
            listaVendaCarro.Add(new VendaCarro() { Id = 3, Nome = "Et Libero Proin Foundation", Valor = 8710, Quantidade = 17, DataVenda = DateTime.Parse("24/01/2019") });
            listaVendaCarro.Add(new VendaCarro() { Id = 4, Nome = "Cursus Et Ltd", Valor = 9010, Quantidade = 17, DataVenda = DateTime.Parse("26/10/2019") });
            listaVendaCarro.Add(new VendaCarro() { Id = 5, Nome = "Odio Etiam Ligula Company", Valor = 5245, Quantidade = 8, DataVenda = DateTime.Parse("16/02/2019") });
            listaVendaCarro.Add(new VendaCarro() { Id = 6, Nome = "Eu Nibh Inc.", Valor = 7922, Quantidade = 9, DataVenda = DateTime.Parse("27/06/2019") });
            listaVendaCarro.Add(new VendaCarro() { Id = 7, Nome = "Tellus Limited", Valor = 7294, Quantidade = 7, DataVenda = DateTime.Parse("26/01/2019") });
            listaVendaCarro.Add(new VendaCarro() { Id = 8, Nome = "Imperdiet PC", Valor = 8305, Quantidade = 5, DataVenda = DateTime.Parse("06/09/2019") });
            listaVendaCarro.Add(new VendaCarro() { Id = 9, Nome = "Elit Inc.", Valor = 5398, Quantidade = 18, DataVenda = DateTime.Parse("09/06/2019") });
            listaVendaCarro.Add(new VendaCarro() { Id = 11, Nome = "Adipiscing Institute", Valor = 8133, Quantidade = 4, DataVenda = DateTime.Parse("24/10/2019") });
            listaVendaCarro.Add(new VendaCarro() { Id = 12, Nome = "Posuere At Velit Ltd", Valor = 5121, Quantidade = 15, DataVenda = DateTime.Parse("19/11/2019") });
            listaVendaCarro.Add(new VendaCarro() { Id = 13, Nome = "Nunc In Industries", Valor = 8902, Quantidade = 2, DataVenda = DateTime.Parse("21/07/2019") });
            listaVendaCarro.Add(new VendaCarro() { Id = 14, Nome = "Integer Vitae Nibh Corporation", Valor = 6313, Quantidade = 20, DataVenda = DateTime.Parse("02/02/2019") });
            listaVendaCarro.Add(new VendaCarro() { Id = 15, Nome = "Tellus Nunc Lectus Company", Valor = 9650, Quantidade = 2, DataVenda = DateTime.Parse("20/07/2019") });
            listaVendaCarro.Add(new VendaCarro() { Id = 16, Nome = "Suspendisse LLC", Valor = 5319, Quantidade = 12, DataVenda = DateTime.Parse("24/12/2019") });
            listaVendaCarro.Add(new VendaCarro() { Id = 17, Nome = "Mauris Vestibulum Corporation", Valor = 5790, Quantidade = 5, DataVenda = DateTime.Parse("14/11/2019") });
            listaVendaCarro.Add(new VendaCarro() { Id = 18, Nome = "Sed Nec Corp.", Valor = 8421, Quantidade = 2, DataVenda = DateTime.Parse("05/05/2019") });
            listaVendaCarro.Add(new VendaCarro() { Id = 19, Nome = "Enim Nisl Elementum Inc.", Valor = 5904, Quantidade = 6, DataVenda = DateTime.Parse("26/06/2019") });
            listaVendaCarro.Add(new VendaCarro() { Id = 20, Nome = "Ac Mattis Semper Corporation", Valor = 5110, Quantidade = 4, DataVenda = DateTime.Parse("14/01/2019") });
            listaVendaCarro.Add(new VendaCarro() { Id = 21, Nome = "Donec Tempus Lorem LLC", Valor = 8576, Quantidade = 16, DataVenda = DateTime.Parse("29/03/2019") });
            listaVendaCarro.Add(new VendaCarro() { Id = 22, Nome = "Tempor Augue Ac Ltd", Valor = 9072, Quantidade = 16, DataVenda = DateTime.Parse("09/07/2019") });
            listaVendaCarro.Add(new VendaCarro() { Id = 23, Nome = "Diam Duis Mi LLC", Valor = 8472, Quantidade = 4, DataVenda = DateTime.Parse("23/09/2019") });
            listaVendaCarro.Add(new VendaCarro() { Id = 24, Nome = "Aliquam Corp.", Valor = 6607, Quantidade = 4, DataVenda = DateTime.Parse("28/09/2019") });
            listaVendaCarro.Add(new VendaCarro() { Id = 25, Nome = "Montes Institute", Valor = 6176, Quantidade = 8, DataVenda = DateTime.Parse("19/06/2019") });
            listaVendaCarro.Add(new VendaCarro() { Id = 26, Nome = "Hendrerit Institute", Valor = 8387, Quantidade = 11, DataVenda = DateTime.Parse("17/09/2019") });
            listaVendaCarro.Add(new VendaCarro() { Id = 27, Nome = "Erat Etiam Vestibulum Corporation", Valor = 7584, Quantidade = 9, DataVenda = DateTime.Parse("02/06/2019") });
            listaVendaCarro.Add(new VendaCarro() { Id = 28, Nome = "Adipiscing Ltd", Valor = 7887, Quantidade = 9, DataVenda = DateTime.Parse("19/03/2019") });
            listaVendaCarro.Add(new VendaCarro() { Id = 29, Nome = "In Tempus Eu Inc.", Valor = 5233, Quantidade = 16, DataVenda = DateTime.Parse("20/07/2019") });
            listaVendaCarro.Add(new VendaCarro() { Id = 30, Nome = "Elit Institute", Valor = 7359, Quantidade = 11, DataVenda = DateTime.Parse("12/09/2019") });
            listaVendaCarro.Add(new VendaCarro() { Id = 31, Nome = "Aliquam Erat LLC", Valor = 8842, Quantidade = 4, DataVenda = DateTime.Parse("14/03/2019") });
            listaVendaCarro.Add(new VendaCarro() { Id = 32, Nome = "A Feugiat Tellus PC", Valor = 9176, Quantidade = 4, DataVenda = DateTime.Parse("10/12/2019") });
            listaVendaCarro.Add(new VendaCarro() { Id = 33, Nome = "Aliquet Incorporated", Valor = 9057, Quantidade = 8, DataVenda = DateTime.Parse("26/04/2019") });
            listaVendaCarro.Add(new VendaCarro() { Id = 34, Nome = "Dolor Dolor Tempus Institute", Valor = 8433, Quantidade = 15, DataVenda = DateTime.Parse("31/10/2019") });
            listaVendaCarro.Add(new VendaCarro() { Id = 35, Nome = "Risus Odio Auctor PC", Valor = 8286, Quantidade = 11, DataVenda = DateTime.Parse("29/03/2019") });
            listaVendaCarro.Add(new VendaCarro() { Id = 36, Nome = "Aliquet Molestie Tellus Corp.", Valor = 8779, Quantidade = 1, DataVenda = DateTime.Parse("05/07/2019") });
            listaVendaCarro.Add(new VendaCarro() { Id = 37, Nome = "Ipsum Corp.", Valor = 5568, Quantidade = 15, DataVenda = DateTime.Parse("10/03/2019") });
            listaVendaCarro.Add(new VendaCarro() { Id = 38, Nome = "Mi Lacinia Foundation", Valor = 7442, Quantidade = 20, DataVenda = DateTime.Parse("09/07/2019") });
            listaVendaCarro.Add(new VendaCarro() { Id = 39, Nome = "Cubilia Curae; Corp.", Valor = 8421, Quantidade = 7, DataVenda = DateTime.Parse("26/05/2019") });
            listaVendaCarro.Add(new VendaCarro() { Id = 40, Nome = "Velit Sed Malesuada Associates", Valor = 9841, Quantidade = 6, DataVenda = DateTime.Parse("07/11/2019") });
            listaVendaCarro.Add(new VendaCarro() { Id = 41, Nome = "Duis Foundation", Valor = 9849, Quantidade = 6, DataVenda = DateTime.Parse("08/12/2019") });

            /*
               listaVendaCarros.add( Id = 42	, Nome = Erat Semper Consulting	 6,168	10	10/11/2019
               listaVendaCarros.add( Id = 43	, Nome = Turpis Inc.	 7,758	7	12/08/2019
               listaVendaCarros.add( Id = 44	, Nome = Aenean Industries	 8,770	12	10/09/2019
               listaVendaCarros.add( Id = 45	, Nome = Nulla Industries	 8,884	8	10/11/2019
               listaVendaCarros.add( Id = 46	, Nome = Semper Egestas Urna Inc.	 9,428	11	26/06/2019
               listaVendaCarros.add( Id = 47	, Nome = Donec Luctus Aliquet Industries	 5,928	8	11/07/2019
               listaVendaCarros.add( Id = 48	, Nome = Cum Sociis Natoque Foundation	 7,506	2	21/07/2019
               listaVendaCarros.add( Id = 49	, Nome = Vitae Sodales Limited	 8,912	8	22/06/2019
               listaVendaCarros.add( Id = 50	, Nome = Tellus Sem Mollis Ltd	 9,615	20	30/10/2019
               listaVendaCarros.add( Id = 51	, Nome = Nulla Tincidunt LLC	 5,562	19	22/09/2019
               listaVendaCarros.add( Id = 52	, Nome = Sed Dictum Institute	 9,243	14	26/06/2019
               listaVendaCarros.add( Id = 53	, Nome = Sed Turpis Company	 7,243	14	20/08/2019
               listaVendaCarros.add( Id = 54	, Nome = Vitae Diam Proin Associates	 6,631	2	10/06/2019
               listaVendaCarros.add( Id = 55	, Nome = Curabitur Inc.	 8,090	3	09/02/2019
               listaVendaCarros.add( Id = 56	, Nome = Suscipit Est Ac LLC	 8,567	15	08/03/2019
               listaVendaCarros.add( Id = 57	, Nome = Neque Morbi Industries	 5,171	1	03/10/2019
               listaVendaCarros.add( Id = 58	, Nome = Non Ltd	 5,102	19	14/08/2019
               listaVendaCarros.add( Id = 59	, Nome = Arcu Vestibulum Ante Institute	 6,128	1	08/10/2019
               listaVendaCarros.add( Id = 60	, Nome = Nulla Foundation	 7,636	6	14/04/2019
               listaVendaCarros.add( Id = 61	, Nome = Quis Massa Mauris LLP	 5,053	3	09/10/2019
               listaVendaCarros.add( Id = 62	, Nome = Ut Incorporated	 6,922	17	16/09/2019
               listaVendaCarros.add( Id = 63	, Nome = Aenean Egestas Corp.	 8,142	19	17/11/2019
               listaVendaCarros.add( Id = 64	, Nome = Fusce Mi Lorem Consulting	 8,312	20	19/11/2019
               listaVendaCarros.add( Id = 65	, Nome = A Sollicitudin Orci PC	 5,864	1	20/03/2019
               listaVendaCarros.add( Id = 66	, Nome = Sociosqu Limited	 5,985	12	28/11/2019
               listaVendaCarros.add( Id = 67	, Nome = Ullamcorper Duis Cursus LLC	 5,164	7	22/12/2019
               listaVendaCarros.add( Id = 68	, Nome = Nibh Lacinia LLC	 7,760	10	13/06/2019
               listaVendaCarros.add( Id = 69	, Nome = Eu Dui Institute	 7,695	8	12/12/2019
               listaVendaCarros.add( Id = 70	, Nome = Fringilla Purus Mauris Consulting	 5,845	6	01/03/2019
               listaVendaCarros.add( Id = 71	, Nome = Donec Tempus Lorem Industries	 8,472	19	09/03/2019
               listaVendaCarros.add( Id = 72	, Nome = Auctor Incorporated	 6,795	1	04/10/2019
               listaVendaCarros.add( Id = 73	, Nome = Enim Etiam Imperdiet Corporation	 6,532	13	14/10/2019
               listaVendaCarros.add( Id = 74	, Nome = Non Cursus Non Industries	 9,569	16	25/10/2019
               listaVendaCarros.add( Id = 75	, Nome = Ut Semper Incorporated	 5,760	18	14/01/2019
               listaVendaCarros.add( Id = 76	, Nome = Sed Malesuada Corporation	 6,561	4	06/03/2019
               listaVendaCarros.add( Id = 77	, Nome = Sed Neque Consulting	 7,308	2	31/08/2019
               listaVendaCarros.add( Id = 78	, Nome = Nisl Arcu PC	 7,260	8	19/06/2019
               listaVendaCarros.add( Id = 79	, Nome = Euismod Est Consulting	 6,020	11	27/10/2019
               listaVendaCarros.add( Id = 80	, Nome = Leo Vivamus Ltd	 5,055	8	22/10/2019
               listaVendaCarros.add( Id = 81	, Nome = Tristique Neque Inc.	 9,268	13	25/02/2019
               listaVendaCarros.add( Id = 82	, Nome = In Lobortis PC	 5,539	4	18/12/2019
               listaVendaCarros.add( Id = 83	, Nome = Nunc Ltd	 6,846	2	09/10/2019
               listaVendaCarros.add( Id = 84	, Nome = Dictum Proin Limited	 5,543	12	05/10/2019
               listaVendaCarros.add( Id = 85	, Nome = Erat Vitae LLP	 5,060	7	12/12/2019
               listaVendaCarros.add( Id = 86	, Nome = Pellentesque Ultricies Dignissim PC	 7,971	15	25/10/2019
               listaVendaCarros.add( Id = 87	, Nome = Phasellus Elit Company	 5,350	15	31/10/2019
               listaVendaCarros.add( Id = 88	, Nome = Luctus Felis Ltd	 9,872	13	06/01/2019
               listaVendaCarros.add( Id = 89	, Nome = Dui Suspendisse PC	 6,878	7	06/02/2019
               listaVendaCarros.add( Id = 90	, Nome = Odio Associates	 7,636	18	24/07/2019
               listaVendaCarros.add( Id = 91	, Nome = Vel Company	 7,410	5	16/02/2019
               listaVendaCarros.add( Id = 92	, Nome = Lobortis Institute	 5,110	8	27/05/2019
               listaVendaCarros.add( Id = 93	, Nome = Scelerisque Company	 7,983	19	03/12/2019
               listaVendaCarros.add( Id = 94	, Nome = Posuere Enim Company	 6,968	19	22/04/2019
               listaVendaCarros.add( Id = 95	, Nome = Sem Ut Corp.	 6,504	11	02/02/2019
               listaVendaCarros.add( Id = 96	, Nome = Dui Fusce Aliquam PC	 7,837	2	08/12/2019
               listaVendaCarros.add( Id = 97	, Nome = Nisl Sem Industries	 6,835	5	14/11/2019
               listaVendaCarros.add( Id = 98	, Nome = Vitae Corp.	 7,669	7	09/11/2019
               listaVendaCarros.add( Id = 99	, Nome = Malesuada Incorporated	 5,960	4	26/09/2019
               listaVendaCarros.add( Id = 100	, Nome = Mauris Ltd	 8,974	18	16/05/2019
*/
        }

    }
}
