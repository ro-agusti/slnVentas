using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using Data.Models;

namespace Data.DataContext
{
    public class DbVentasContext:DbContext
    {
        public DbVentasContext(): base("KeyDbVentas") { }

        public DbSet<Articulo> Articulos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Detalle_ingreso> Detalle_ingresos { get; set; }
        public DbSet<Detalle_venta> Detalle_ventas { get; set; }
        public DbSet<Trabajador> Trabajadores { get; set; }
        public DbSet<Venta> Ventas { get; set; }
    }
}
