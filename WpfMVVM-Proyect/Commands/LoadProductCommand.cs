using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using InformeProyecto.Models;
using InformeProyecto.Services;
using InformeProyecto.ViewModels;

namespace InformeProyecto.Commands
{
    class LoadProductCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ProductoModel producto = (ProductoModel)parameter;
            if (producto != null) {
            productosViewModel.CurrentProducto = (ProductoModel)producto.Clone();
            //productosViewModel.ListaAlmacenes = ProductosDBHandler.CargarListaProveedor(productosViewModel.CurrentProducto);
            }
            else
            {
                
                productosViewModel.CurrentProducto._id = "";
                productosViewModel.CurrentProducto.Tipo = "";
                productosViewModel.CurrentProducto.Marca = "";
                productosViewModel.CurrentProducto.Color = "";
                productosViewModel.CurrentProducto.Referencia = "";
                productosViewModel.CurrentProducto.Descripcion = "";
                productosViewModel.CurrentProducto.Precio = 0;
                productosViewModel.CurrentProducto.Stock = 0;
                productosViewModel.CurrentProducto.Fecha = DateTime.Today;
                //productosViewModel.ListaAlmacenes = null;
            }

        }
        public ProductosViewModel productosViewModel;
        public LoadProductCommand(ProductosViewModel productosViewModel)
        {
            this.productosViewModel = productosViewModel;
        }
        
    }
}
