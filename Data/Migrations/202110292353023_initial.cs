namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Articulo",
                c => new
                    {
                        IdArticulo = c.Int(nullable: false, identity: true),
                        Codigo = c.String(nullable: false, maxLength: 10, unicode: false),
                        Nombre = c.String(nullable: false, maxLength: 20, unicode: false),
                        Descripcion = c.String(maxLength: 50, unicode: false),
                        Imagen = c.Binary(nullable: false, maxLength: 50),
                        IdCategoria = c.Int(nullable: false),
                        IdPresentacion = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdArticulo);
            
            CreateTable(
                "dbo.Detalle_ingreso",
                c => new
                    {
                        IdDetalle_ingreso = c.Int(nullable: false, identity: true),
                        IdIngreso = c.Int(nullable: false),
                        IdArticulo = c.Int(nullable: false),
                        Precio_compra = c.Decimal(nullable: false, storeType: "money"),
                        Precio_venta = c.Decimal(nullable: false, storeType: "money"),
                        Stock_inicial = c.Int(nullable: false),
                        Stock_actual = c.Int(nullable: false),
                        Fecha_produccion = c.DateTime(nullable: false, storeType: "date"),
                        Fecha_vencimiento = c.DateTime(nullable: false, storeType: "date"),
                    })
                .PrimaryKey(t => t.IdDetalle_ingreso)
                .ForeignKey("dbo.Articulo", t => t.IdArticulo, cascadeDelete: true)
                .Index(t => t.IdArticulo);
            
            CreateTable(
                "dbo.detalle_venta",
                c => new
                    {
                        Iddetalle_venta = c.Int(nullable: false, identity: true),
                        Idventa = c.Int(nullable: false),
                        Iddetalle_ingreso = c.Int(nullable: false),
                        Cantidad = c.Int(nullable: false),
                        Precio_venta = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Descuento = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Iddetalle_venta)
                .ForeignKey("dbo.Detalle_ingreso", t => t.Iddetalle_ingreso, cascadeDelete: true)
                .ForeignKey("dbo.Venta", t => t.Idventa, cascadeDelete: true)
                .Index(t => t.Idventa)
                .Index(t => t.Iddetalle_ingreso);
            
            CreateTable(
                "dbo.Venta",
                c => new
                    {
                        idventa = c.Int(nullable: false, identity: true),
                        idcliente = c.Int(nullable: false),
                        idtrabajador = c.Int(nullable: false),
                        fecha = c.DateTime(nullable: false, storeType: "date"),
                        tipo_comprobante = c.String(nullable: false, maxLength: 50, unicode: false),
                        serie = c.String(nullable: false, maxLength: 50, unicode: false),
                        correlativo = c.String(nullable: false, maxLength: 50, unicode: false),
                        igv = c.String(nullable: false, maxLength: 50, unicode: false),
                        estado = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.idventa)
                .ForeignKey("dbo.Cliente", t => t.idcliente, cascadeDelete: true)
                .ForeignKey("dbo.Trabajador", t => t.idtrabajador, cascadeDelete: true)
                .Index(t => t.idcliente)
                .Index(t => t.idtrabajador);
            
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        Idcliente = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 50, unicode: false),
                        Apellidos = c.String(maxLength: 50, unicode: false),
                        Sexo = c.String(maxLength: 20, unicode: false),
                        Fecha_nacimiento = c.DateTime(nullable: false, storeType: "date"),
                        Tipo_documento = c.String(maxLength: 30, unicode: false),
                        Num_documento = c.Int(nullable: false),
                        Direccion = c.String(maxLength: 30, unicode: false),
                        Telefono = c.String(maxLength: 20, unicode: false),
                        Email = c.String(maxLength: 30, unicode: false),
                    })
                .PrimaryKey(t => t.Idcliente);
            
            CreateTable(
                "dbo.Trabajador",
                c => new
                    {
                        Idtrabajador = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        Apellidos = c.String(maxLength: 50, unicode: false),
                        Sexo = c.String(nullable: false, maxLength: 12, unicode: false),
                        Fecha_nacimiento = c.DateTime(nullable: false, storeType: "date"),
                        Num_documento = c.String(nullable: false, maxLength: 12, unicode: false),
                        Direccion = c.String(maxLength: 50, unicode: false),
                        Telefono = c.String(maxLength: 50, unicode: false),
                        Email = c.String(maxLength: 50, unicode: false),
                        Acceso = c.String(nullable: false, maxLength: 50, unicode: false),
                        Usuario = c.String(nullable: false, maxLength: 12, unicode: false),
                        Password = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Idtrabajador);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Venta", "idtrabajador", "dbo.Trabajador");
            DropForeignKey("dbo.detalle_venta", "Idventa", "dbo.Venta");
            DropForeignKey("dbo.Venta", "idcliente", "dbo.Cliente");
            DropForeignKey("dbo.detalle_venta", "Iddetalle_ingreso", "dbo.Detalle_ingreso");
            DropForeignKey("dbo.Detalle_ingreso", "IdArticulo", "dbo.Articulo");
            DropIndex("dbo.Venta", new[] { "idtrabajador" });
            DropIndex("dbo.Venta", new[] { "idcliente" });
            DropIndex("dbo.detalle_venta", new[] { "Iddetalle_ingreso" });
            DropIndex("dbo.detalle_venta", new[] { "Idventa" });
            DropIndex("dbo.Detalle_ingreso", new[] { "IdArticulo" });
            DropTable("dbo.Trabajador");
            DropTable("dbo.Cliente");
            DropTable("dbo.Venta");
            DropTable("dbo.detalle_venta");
            DropTable("dbo.Detalle_ingreso");
            DropTable("dbo.Articulo");
        }
    }
}
