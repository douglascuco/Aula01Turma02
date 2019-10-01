using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriarArvore
{
    public class Program
    {
        static void Main(string[] args)
        {
            //CriarArv();
            //CalcularAreaQuadrado();
            //MostrarCervejas();
            //MostrarCarros();
            Console.ReadKey();
        }

        /// <summary>
        /// Método para mostrar uma arvore na tela
        /// </summary>
        public static void CriarArv()
        {
            Console.WriteLine(@"                                                                                           
                                                     *//(##%%%#/(#((/,..                           
                                           .,*(/***(((#%%%%#(##%&&&%(/(((((//**,,,*.               
                                          ,(#((((#((#%&&%&%%%&&&%&@&((#(((((/////(/*.              
                              .,//*****.,.,/(#%%((#(%%%#%%%%##(&%((#(/(##%##(/(//((//**          
                          ,**/(/((((##%(#%&(##%%((((/(((&%&%%%###%#(%%%&&%#%###((###,.       
                      .**/(#((%(#(*(#(#%(((#(/(((((//%#(%%&&%&&&%%%%##((%%%@&&&%%@&%&%(##(*.       
                 .***//(#%%&/((/#%%%(((%&&%%#%##&&&%&@&&%&%%#%%##%&&&%%&&%%@&&&&&%%%%##.       
                .%%%%%##%&&%#//##(##%#%%%%%#(##&@&%#%###%&&&%%%&%&&&&%%%%##(&&&&&@&&%%%###/        
               ,/%&@&&@%&@/((#(##%&(/(#%%%(/#((#(%#&%%%&&&%%%%&@@&&%##/%@&%##&&&&%#,         
          .*/(/(%&&&&@&@(/##&&&&@@#%%%%%(//#%%%%&&&@@@@&@@&&&%&%%%&@@@&%%%#(#&@&&%%%((         
       ,*((((#%##&&&&&&&%(#&&%%%%%%%%%(((##%%%%&&%%#%&@@&%#%%&&@@@@&%%%%&&&%%%%%(/##(#%%(%(        
       #%/((/((((#%##&&&&&&%%%#&%%%@@@%%%%%##%&%((#####%%#(%%&&@@@@@&&%@@%%&%&%%#(#%#(((@&%((/,    
        ,(####%%&%%%&&&&%###%%%@&&@&&&%#%%%%&#(#%%%&&&@&%%&@&(#%##&@@%&%%&&@@@&%&%&&######*    
       ,/%&&&%%%%%##%%#%#((%%#%%%%%%%%#%&%@@%%@&&&&&@@%%%&&&%#%%#(&@@@&&@@@@&&@@%#%%#(#((/,    
       *(%%&@@&%(%%&%%%(%%%&&%%&%%@@&&%%&@%#%&&@&@@@@@@@%&&%%@###%(#%#(&&&&@@&@@%&%%%#(/.  
      .*##&&&//#((####%#(#&&&@@@@@@@&/%&%%%%&@@@@&&&&&&%&&%%&&&%%%%%&&##%&%#%%@@@&&&%#(%&(.  
     *(###%%((##/##(/#%##%&&%%%%%&@@&@&&%%&&&&&@@@@@&%&&&&&%&&&@@&%&&@@@@&%@&%@@%%@@@@&&%%#%&%%(/  
  */%%%%%#&&&@&%(#%&%#%%%&&%%@&&@@@@&@&%&&@@@@@@&&&&&&%%&@@@@&&@@@@@&&%#%#&@@@&%&%%&&#%%#%#(#/.
  #%%&%#%%%##%%#%&&&&&%#%#%&&&@@@@@@@@%%&&&@@@@@&%&&&%%%@@@&%%%@@@%&&%(%&&&@@&%&%#%&&#%* 
 *#&&&%%&%%%%@@@@@&##(%%&@@@@@@@@@@@@@&&&&&&&@@@@(&&&*&&@@@&%(@@@@@&@&&&&%@@@@%%#%%%##&(#%/  
  .(//%%&&&@#&&&&&&&%%&%&@@@@@@@@@@@@@@@%(#%(@@@@&((*/(%&@(&&@@&@@&*%/&@&&@@&&%%###%%#/.     
        //##.,%%#((##*,, ,@#,&@@@@&@@@@@@@&@# /@@@@@#(@#&@@@#@@@@@@@@@@@@@@&&&@@@@&%%&&%%&&%(/.    
           .%&%%/,*&&.         *%(#&@@@@@@@@@@&@@@@@@@@@@@@&@@@@@@&@@@@@@/,@@@@@@@@@@@@&@&&&(.     
                             /%%%&&&&&@@@@@%./@@@&&@@@@@@@@@@&&&&&%&@@&@@@@@@@@@@@@&&%@%%,       
                               *%&%%@@@@@@@@&&%&&&@@@@@&&@&&@&&@@@@@@@@&&&&&&@&&&&&&@@%&%.         
                               ,(.#/  *%&&@@@@@@@@@@&&&&@&%&&%&&&&&&%*(//,@@@@&&&&%%(          
                                        /#%#%@@@@@@&&@&&@&&%&@(/%%%%&%%&%&&%%%@@&@&%&&%/.          
                                         /(&@&&&&&@@&@%(/*,*(%(.(%%%%%%%%%%%%%%%((/.            
                                                   %&%%%.         *&&%@%&%##%##*.               
                                                   #%%%%.                                            
                                                   #%%%%.                                            
                                                   #%%%%.                                            
                                                   #%%%%.                                            
                                                   %%%%#.                                            
                                                   %%%%#.                                            
                                                   %%%%%.                                            
                                                   %%%%%.                                            
                                                  .%%%%%,                                            
                                                  .%%%%%,                                            
                                                  ,%#%%#(                                            
                                                  ,%#%%#(                                            ");
            // Console.WriteLine("")
            Console.ReadKey();
        }

        /// <summary>
        /// Metodo para calcular a area de um quadrado
        /// </summary>
        public static void CalcularAreaQuadrado()
        {
            Console.WriteLine("Digite o valor de um dos lados do quadrado: ");
            var lado = double.Parse(Console.ReadLine());
            Console.WriteLine($"A area desse quadrado é de { lado *= lado}");
        }

        /// <summary>
        /// Mostra uma lista das cervejas cadastradas
        /// </summary>
        public static void MostrarCervejas()
        {
            var listaCerveja = new List<string>();
            var cervejas = (@"Antarctica Sub Zero,Antarctica,Beck's,Brahma,Brahma Zero,Bohemia,Brahma Light,Brahma Extra,Brahma Bier,Brahma Fresh,Budweiser,Caracu,Colorado,Corona,Franziskaner,Goose IslandHertog Jan,Hoegaarden,Kronenbier,Labatt Blue,Lakeport Brewing,Leffe,Magnífica (somente no estado do Maranhão),Miller,Norteña,Nossa (somente no estado de Pernambuco),Original,Patagonia,Patricia,Pilsen,Polar,President,Puerto del Mar,Quilmes,Serramalte,Serrana,Skol,Skol Hops,Skol 360,Skol Beats Senses,Skol Beats Spirit,Skol Beats Secret,Skol Ultra,Skol Puro Malte,Samson,Stella Artois,Wäls").Split(',');
            for (int i = 0; i < cervejas.Length; i++)
            {
                listaCerveja.Add(cervejas[i]);
            }
            Console.WriteLine("Lista de Cervejas Cadastradas: ");
            foreach (var item in listaCerveja)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Mostra lista de carros cadastrados
        /// </summary>
        public static void MostrarCarros()
        {
            var listaCarros = new List<string>()
            {
                "Toyota",
                "BMW",
                "Volkswage",
                "Mercedes-Benz",
                "Honda" ,
                "Nissan" ,
                "Ford"
            };
            Console.WriteLine("Lista de marcas de carro Cadastradas: ");
            foreach (var item in listaCarros)
            {
                Console.WriteLine(item);
            }
        }

    }
}
