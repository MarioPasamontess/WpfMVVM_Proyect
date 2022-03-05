﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using InformeProyecto.Models;
using InformeProyecto.Services;
using InformeProyecto.ViewModels;

namespace InformeProyecto.Commands
{
    class LoadProveedorCommand: ICommand
    {
        public ProveedoresViewModel proveedoresViewModel;
        public LoadProveedorCommand(ProveedoresViewModel proveedoresViewModel)
        {
            this.proveedoresViewModel = proveedoresViewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public async void Execute(object parameter)
        {
            ProveedoresDBHandler.CargarLista();
            proveedoresViewModel.ListaProveedores = ProveedoresDBHandler.ObtenerListaProveedores();
        }

    }
}
