using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using TRF.clases;

namespace TRF.servicio
{
    public class ProductoServicio {

        public ObservableCollection<ProductosModel> productos { get; set; }
        public ProductoServicio()
        {
            if (productos == null)
            {
                productos = new ObservableCollection<ProductosModel>();
            }
        }
        public ObservableCollection<ProductosModel> Consultar()
        {
            return productos;
        }

        public void Guardar(ProductosModel modelo)
        {
            productos.Add(modelo);
        }
        public void Modificar(ProductosModel modelo)
        {
            for (int i = 0; i < productos.Count; i++)
            {
                if (productos[i].Id == modelo.Id)
                {
                    productos[i] = modelo;
                }
            }
        }
        public void Eliminar(string idProducto)
        {
            ProductosModel modelo = productos.FirstOrDefault(p => p.Id == idProducto);
            productos.Remove(modelo);
        }
    }

}
