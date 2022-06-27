using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tela_de_Login_I.Commads;

namespace Tela_de_Login_I.ViewModels
{
    public class LogarViewModel
    {
        public LogarCommad Logar { get; set; }

        public LogarViewModel()
        {
            Logar = new LogarCommad();
        }



    }
}
