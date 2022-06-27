using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Tela_de_Login_I.Commads
{
    public class LogarCommad : ICommand
    {
        public event EventHandler CanExecuteChanged;

        // Validação. Se isso retornar Falso, a Ação não roda.
        // Validação de Login e senha. Pode inlcuir mensagens
        public bool CanExecute(object parameter)
        {
            return true;
        }

        // Ação
        public void Execute(object parameter)
        {
            string senha;
        }
    }
}
