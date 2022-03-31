using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using TRF.clases;
using TRF.servicio;
using Xamarin.Forms;

namespace TRF.ViewModel
{
    public class ProductoViewModel: ProductosModel
    {
        public ObservableCollection<ProductosModel> Producto { get; set; }
        ProductoServicio servicio = new ProductoServicio();
        ProductosModel modelo;

        public ProductoViewModel()
        {
            Producto = servicio.Consultar();
            GuardarCommand = new Command(async () => await Guardar(), () => !Isbusy);
            ModificarCommand = new Command(async () => await Modificar(), () => !Isbusy);
            EliminarCommand = new Command(async () => await Eliminar(), () => !Isbusy);
            LimpiarCommand = new Command(Limpiar, () => !Isbusy);
        }
        public Command GuardarCommand { get; set; }
        public Command ModificarCommand { get; set; }
        public Command EliminarCommand { get; set; }
        public Command LimpiarCommand { get; set; }

        private async Task Guardar()
        {

            Isbusy = true;
            Guid IdProducto = Guid.NewGuid();
            modelo = new ProductosModel()
            {
                Nombre = Nombre,
                Descripcion = Descripcion,
                Price = Price,
                Id = IdProducto.ToString()

            };
            servicio.Guardar(modelo);
            await Task.Delay(2000);
            Isbusy = false;
        }

        private async Task Modificar()
        {
            Isbusy = true;
            modelo = new ProductosModel()
            {
                Nombre = Nombre,
                Descripcion = Descripcion,
                Price = Price,
                Id = Id

            };
            servicio.Modificar(modelo);
            await Task.Delay(2000);
            Isbusy = false;
        }

        private async Task Eliminar()
        {

            Isbusy = true;
            
            servicio.Eliminar(Id);
            await Task.Delay(2000);
            Isbusy = false;
        }

        private void Limpiar()
        {
            Nombre = "";
            Descripcion = "";
            Price = 0;


        }
    }
}
