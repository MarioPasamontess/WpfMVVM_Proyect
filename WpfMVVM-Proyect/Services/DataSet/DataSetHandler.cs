using WpfMVVM_Proyect.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfMVVM_Proyect.Services.DataSet.ProyectoDataSetTableAdapters;

namespace WpfMVVM_Proyect.Services.DataSet
{
    class DataSetHandler
    {
        private static clienteTableAdapter clienteAdapter = new clienteTableAdapter();
        public static ObservableCollection<ClienteModel> getCliente()
        {
            DataTable dptosDataTable = clienteAdapter.GetData();
            ObservableCollection<ClienteModel> listaClientes = new ObservableCollection<ClienteModel>();
            foreach (DataRow clie in dptosDataTable.Rows)
            {
                ClienteModel myClie = new ClienteModel();
                myClie._dni = clie["DNI"].ToString();
                myClie.Nombre = clie["Nombre"].ToString();
                myClie.Direccion = clie["Direccion"].ToString();
                myClie.Telefono = clie["Telefono"].ToString();
                myClie.Mail = clie["Email"].ToString();

                listaClientes.Add(myClie);
            }
            return listaClientes;
            {

            }
        }

    }
}
