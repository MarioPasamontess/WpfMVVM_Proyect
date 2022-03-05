using InformeProyecto.ViewModels;
using InformeProyecto.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfMVVM_Proyect.Models;

namespace InformeProyecto.Commands
{
    class AñadirProductoCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            FormularioView view = new FormularioView();
            ProductoModel p;
            if (view != null)
            {
                p = (ProductoModel)view.cmbProducto.SelectedItem;
                //p.Cantidad =  view.Cantidad;
            }
        }
        public void cargarListaP(ProductoModel producto)
        {
            FormularioView view = new FormularioView();
            
        }
        FormularioViewModel formulario;
        public AñadirProductoCommand(FormularioViewModel formulario)
        {
            this.formulario = formulario;
        }
    }
}
