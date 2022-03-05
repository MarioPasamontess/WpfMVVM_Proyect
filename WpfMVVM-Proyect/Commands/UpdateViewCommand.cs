using InformeProyecto.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using InformeProyecto.ViewModels;

namespace InformeProyecto.Commands
{
    class UpdateViewCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Console.WriteLine(parameter.ToString());
            string vista = parameter.ToString();
            if (vista.Equals("Home"))
            {
                MainViewModel.SelectedViewModel = new HomeViewModel();
            }else if (vista.Equals("proveedores"))
            {
                MainViewModel.SelectedViewModel = new ProveedoresViewModel();
            }else if (vista.Equals("productos"))
            {
                MainViewModel.SelectedViewModel = new ProductosViewModel();
            }
            else if (vista.Equals("factura"))
            {
                MainViewModel.SelectedViewModel = new FormularioViewModel();
            }

        }
        public MainViewModel MainViewModel { get; set; }
        public UpdateViewCommand(MainViewModel mainViewModel)
        {
            MainViewModel = mainViewModel;
            MainViewModel.SelectedViewModel = new HomeViewModel();
        }
    }
}
