using WpfMVVM_Proyect.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfMVVM_Proyect.Commands;
using WpfMVVM_Proyect.Models;
using WpfMVVM_Proyect.ViewModels;

namespace WpfMVVM_Proyect.ViewModels
{
    class FormularioViewModel: ViewModelBase
    {
        private ProductoModel producto;
        public ProductoModel Producto
        {
            get { return producto; }
            set
            {
               producto = value;
                OnPropertyChanged(nameof(Producto));
            }
        }
        private ClienteModel cliente;
        public ClienteModel Cliente
        {
            get { return cliente; }
            set
            {
                cliente = value;
                OnPropertyChanged(nameof(Cliente));
            }
        }
        public ObservableCollection<ClienteModel> listaClientes;
        public ObservableCollection<ClienteModel> ListaClientes
        {
            get
            {
                return listaClientes;
            }
            set
            {
                listaClientes = value;
                OnPropertyChanged(nameof(ListaClientes));
            }
        }

        public UpdateViewCommand update { set; get; }
        public FormularioViewModel()
        {
        
        }
    }
}
