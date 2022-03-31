using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRF.ViewModel;
using TRF.clases;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TRF.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductosPage : ContentPage
    {
        ProductoViewModel contexto = new ProductoViewModel();

        public ProductosPage()
        {
            InitializeComponent();
            BindingContext = contexto;
            LvProductos.ItemSelected += LvProductos_ItemSelected;
        }

        private void LvProductos_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(e.SelectedItem != null)
            {
                ProductosModel modelos = (ProductosModel)e.SelectedItem;
                contexto.Nombre = modelos.Nombre;
                contexto.Descripcion = modelos.Descripcion;
                contexto.Price = modelos.Price;

            }
        }
    }
}