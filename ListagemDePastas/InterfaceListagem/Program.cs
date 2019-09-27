using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DllPastaWin;

namespace InterfaceListagem
{
    class Program
    {
        static DocumentsAutoGenerate documentsAutoGenerate = new DocumentsAutoGenerate();
        static HoraDoShow horaDoShow = new HoraDoShow();
        static void Main(string[] args)
        {

            documentsAutoGenerate.CriarPastaMeusDocumentos("DeletaIsso/Agora/Nfaz/Mal");
            documentsAutoGenerate.DeletarPastaMeusDocumentos("DeletaIsso", true);

            //horaDoShow.Birllllllllll();
            Console.ReadKey();
        }
    }
}
