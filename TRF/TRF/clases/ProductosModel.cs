using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;


namespace TRF.clases
{
    public class ProductosModel:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string nombre = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
        }

        private bool isBusy=false;

        public bool Isbusy
        {
            get { return isBusy=false; }
            set { isBusy = value; OnPropertyChanged(); }
        }
        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; OnPropertyChanged(); }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; OnPropertyChanged(); }
        }
        private string descripcion;
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; OnPropertyChanged(); }
        }
        private float price;
        public float Price
        {
            get { return price; }
            set { price = value; OnPropertyChanged(); }
        }
    }
}
