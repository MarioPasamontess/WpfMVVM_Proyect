using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using InformeProyecto.Models;
using InformeProyecto.Services;
using InformeProyecto.ViewModels;
using InformeProyecto.Views;

namespace InformeProyecto.Commands
{
    class DeleteProveedorCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public async void Execute(object parameter)
        {
            ProveedoresView view = (ProveedoresView)parameter;
            MessageBoxResult result = MessageBox.Show("¿Está seguro que desa eliminar?", "Eliminar Proveedor", MessageBoxButton.YesNo);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    bool eliminar = ProveedoresDBHandler.DeleteProveedor(proveedorViewModel.CurrentProveedor);
                    if (eliminar)
                    {
                        MessageBox.Show("Se ha eliminado el proveedor");
                    }
                    break;
                case MessageBoxResult.No:
                    break;
                    /*case MessageBoxResult.Yes:
                        RequestModel requestModel = new RequestModel();
                        requestModel.route = "/proveedores";
                        requestModel.method = "DELETE";
                        requestModel.data = proveedorViewModel.CurrentProveedor._id;
                        ResponseModel responseModel = await APIHandler.ConsultAPI(requestModel);

                        if (responseModel.resultOk)
                        {
                            proveedorViewModel.LoadProveedoresCommand.Execute("");
                            view.proveedorlistView.SelectedIndex = 0;
                            MessageBox.Show("Se ha eliminado el proveedor");
                        }
                        break;
                    case MessageBoxResult.No:
                        break;*/
            }


        }

        public ProveedoresViewModel proveedorViewModel;
        public DeleteProveedorCommand (ProveedoresViewModel proveedorViewModel)
        {
            this.proveedorViewModel = proveedorViewModel;
        }
    }
}
