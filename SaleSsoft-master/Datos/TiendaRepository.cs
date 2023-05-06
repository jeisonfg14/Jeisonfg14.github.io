using System;
using System.IO;
using System.Linq;
using Entidad;
using System.Collections.Generic;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace Datos
{
    public class TiendaRepository
    {
        private readonly OracleConnection conexion;
        public TiendaRepository(ConnectionManager connection)
        {
            conexion = connection.conexion;
        }
        public string numeroFactura()
        {
            string mensaje="";
            OracleDataReader dataReader;
            using (var command = conexion.CreateCommand())
            {
                command.CommandText = @"select COUNT(*) from FACTURA";
                dataReader = command.ExecuteReader();
                
                    dataReader.Read();
                    int numero = dataReader.GetInt32(0);
                mensaje = numero.ToString();
                    dataReader.Close();
                   
                

            }
            return mensaje;
        }

        public string numeroCliente()
        {
            string mensaje = "";
            OracleDataReader dataReader;
            using (var command = conexion.CreateCommand())
            {
                command.CommandText = @"select COUNT(*) from CLIENTE";
                dataReader = command.ExecuteReader();

                dataReader.Read();
                int numero = dataReader.GetInt32(0);
                mensaje = numero.ToString();
                dataReader.Close();



            }
            return mensaje;
        }
        public string numeroProducto()
        {
            string mensaje = "";
            OracleDataReader dataReader;
            using (var command = conexion.CreateCommand())
            {
                command.CommandText = @"select COUNT(*) from PRODUCTO";
                dataReader = command.ExecuteReader();

                dataReader.Read();
                int numero = dataReader.GetInt32(0);
                mensaje = numero.ToString();
                dataReader.Close();



            }
            return mensaje;
        }
        public string numeroProveedor()
        {
            string mensaje = "";
            OracleDataReader dataReader;
            using (var command = conexion.CreateCommand())
            {
                command.CommandText = @"select COUNT(*) from PROVEEDOR";
                dataReader = command.ExecuteReader();

                dataReader.Read();
                int numero = dataReader.GetInt32(0);
                mensaje = numero.ToString();
                dataReader.Close();



            }
            return mensaje;
        }
        public string NumeroDetalleFactura()
        {
            string mensaje = "";
            OracleDataReader dataReader;
            using (var command = conexion.CreateCommand())
            {
                command.CommandText = @"select COUNT(*) from DETALLEFACTURA";
                dataReader = command.ExecuteReader();

                dataReader.Read();
                int numero = dataReader.GetInt32(0);
                mensaje = numero.ToString();
                dataReader.Close();



            }
            return mensaje;
        }
        public void GuardarFactura(Factura Factura)
        {
            using (var comando = conexion.CreateCommand())
            {
                comando.CommandText = "GUARDARFACTURA";
                comando.CommandType = CommandType.StoredProcedure;
                comando.BindByName = true;
                comando.Parameters.Add("NUMEROFACTURA", OracleDbType.Varchar2).Value = Factura.NoFactura;
                comando.Parameters.Add("FECHAFACTURA", OracleDbType.Date).Value = Factura.FechaFactura;
                comando.Parameters.Add("SUBTOTAL", OracleDbType.Double).Value = Factura.SubTotal;
                comando.Parameters.Add("IMPUESTO", OracleDbType.Double).Value = Factura.Impuesto;
                comando.Parameters.Add("TOTAL", OracleDbType.Double).Value = Factura.Total;
                comando.Parameters.Add("IDCLIENTE_FK", OracleDbType.Varchar2).Value = Factura.IdCliente;
                comando.ExecuteNonQuery();
            }

        }


        public void GuardarDetalleFactura(DetalleFactura detalleFactura)
        {
            using (var comando = conexion.CreateCommand())
            {
                comando.CommandText = "GUARDARDETALLEFACTURA";
                comando.CommandType = CommandType.StoredProcedure;
                comando.BindByName = true;
                comando.Parameters.Add("NUMERODETALLEFACTURA", OracleDbType.Varchar2).Value = detalleFactura.IdDetalleFactura;
                comando.Parameters.Add("CANTIDADPRODUCTO", OracleDbType.Int64).Value = detalleFactura.Cantidad;
                comando.Parameters.Add("PRECIOUNITARIO", OracleDbType.Double).Value = detalleFactura.PrecioUnitario;
                comando.Parameters.Add("DESCRIPCION", OracleDbType.Varchar2).Value = detalleFactura.Descripcion;
                comando.Parameters.Add("IMPORTE", OracleDbType.Double).Value = detalleFactura.Importe;
                comando.Parameters.Add("NUMEROFACTURA_FK", OracleDbType.Varchar2).Value = detalleFactura.NoFactura;
                comando.Parameters.Add("IDPRODUCTO_FK", OracleDbType.Varchar2).Value = detalleFactura.IdProducto;
                comando.ExecuteNonQuery();
            }

        }
        //            comando.CommandText = @"Insert Into Cliente(IDCLIENTE,PRIMERNOMBRE,SEGUNDONOMBRE,PRIMERAPELLIDO,SEGUNDOAPELLIDO,EDAD,SEXO,EMAIL,TELEFONO)
        //values(:IDCLIENTE,:PRIMERNOMBRE,:SEGUNDONOMBRE,:PRIMERAPELLIDO,:SEGUNDOAPELLIDO,:EDAD,:SEXO,:EMAIL,:TELEFONO)";

        public void GuardarCliente(Cliente cliente)
        {
            using (var comando = conexion.CreateCommand())
            {
                comando.CommandText = "GUARDARCLIENTE";
                comando.CommandType = CommandType.StoredProcedure;
                comando.BindByName = true;
                comando.Parameters.Add("IDCLIENTE", OracleDbType.Varchar2).Value = cliente.IdCliente;
                comando.Parameters.Add("PRIMERNOMBRE", OracleDbType.Varchar2).Value = cliente.PrimerNombre;
                comando.Parameters.Add("SEGUNDONOMBRE", OracleDbType.Varchar2).Value = cliente.SegundoNombre;
                comando.Parameters.Add("PRIMERAPELLIDO", OracleDbType.Varchar2).Value = cliente.PrimerApellido;
                comando.Parameters.Add("SEGUNDOAPELLIDO", OracleDbType.Varchar2).Value = cliente.SegundoApellido;
                comando.Parameters.Add("EDAD", OracleDbType.Int64).Value = cliente.edad;
                comando.Parameters.Add("SEXO", OracleDbType.Varchar2).Value = cliente.sexo;
                comando.Parameters.Add("EMAIL", OracleDbType.Varchar2).Value = cliente.Email;
                comando.Parameters.Add("TELEFONO", OracleDbType.Varchar2).Value = cliente.Telefono;
                comando.ExecuteNonQuery();
            }

        }
        public void GuardarProveedor(Proveedor  proveedor)
        {
            using (var comando = conexion.CreateCommand())
            {
                comando.CommandText = "GUARDARPROVEEDOR";
                comando.CommandType = CommandType.StoredProcedure;
                comando.BindByName = true;
                comando.Parameters.Add("IDPROVEEDOR", OracleDbType.Varchar2).Value = proveedor.IdProveedor;
                comando.Parameters.Add("NOMBREEMPRESA", OracleDbType.Varchar2).Value = proveedor.NombreEmpresa;
                comando.Parameters.Add("PRIMERNOMBRE", OracleDbType.Varchar2).Value = proveedor.PrimerNombre;
                comando.Parameters.Add("SEGUNDONOMBRE", OracleDbType.Varchar2).Value = proveedor.SegundoNombre;
                comando.Parameters.Add("PRIMERAPELLIDO", OracleDbType.Varchar2).Value = proveedor.PrimerApellido;
                comando.Parameters.Add("SEGUNDOAPELLIDO", OracleDbType.Varchar2).Value = proveedor.SegundoApellido;
                comando.Parameters.Add("EDAD", OracleDbType.Int64).Value = proveedor.edad;
                comando.Parameters.Add("SEXO", OracleDbType.Varchar2).Value = proveedor.sexo;
                comando.Parameters.Add("EMAIL", OracleDbType.Varchar2).Value = proveedor.Email;
                comando.Parameters.Add("TELEFONO", OracleDbType.Varchar2).Value = proveedor.Telefono;
                comando.ExecuteNonQuery();
            }

        }

        public void GuardarProducto(Producto producto)
        {
            using (var comando = conexion.CreateCommand())
            {
                comando.CommandText = "GUARDARPRODUCTO";
                comando.CommandType = CommandType.StoredProcedure;
                comando.BindByName = true;
                comando.Parameters.Add("IDPRODUCTO", OracleDbType.Varchar2).Value = producto.IdProducto;
                comando.Parameters.Add("NOMBRE", OracleDbType.Varchar2).Value = producto.Nombre;
                comando.Parameters.Add("CANTIDADDISPONIBLE", OracleDbType.Varchar2).Value = producto.CantidadDísponible;
                comando.Parameters.Add("PRECIOUNITARIO", OracleDbType.Varchar2).Value = producto.PrecioUnitario;
                comando.Parameters.Add("PRECIOCOMPRA", OracleDbType.Varchar2).Value = producto.PrecioCompra;
                comando.Parameters.Add("IDPROVEEDOR_FK", OracleDbType.Varchar2).Value = producto.IdProveedor;
                comando.ExecuteNonQuery();
            }

        }

         public Proveedor DataReaderMapToProveedor(OracleDataReader dataReader)
        {
            if(!dataReader.HasRows) return null;
            Proveedor proveedor = new Proveedor();
            proveedor.IdProveedor = (string)dataReader["IdProveedor"]; //(double)dataReade["CantidadKilometrosInicial"]
            proveedor.NombreEmpresa = dataReader.GetString(1);
            proveedor.PrimerNombre = dataReader.GetString(2);
            proveedor.SegundoNombre = dataReader.GetString(3);
            proveedor.PrimerApellido = dataReader.GetString(4);
            proveedor.SegundoApellido = dataReader.GetString(5);
            proveedor.edad = dataReader.GetInt32(6);
            proveedor.sexo = dataReader.GetString(7);
            proveedor.Email = dataReader.GetString(8);
            proveedor.Telefono = dataReader.GetString(9);

            return proveedor;
        }
        public Cliente DataReaderMapToCliente(OracleDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Cliente cliente = new Cliente();
            cliente.IdCliente = (string)dataReader["IdCliente"]; //(double)dataReade["CantidadKilometrosInicial"]
            cliente.PrimerNombre = dataReader.GetString(1);
            cliente.SegundoNombre = dataReader.GetString(2);
            cliente.PrimerApellido = dataReader.GetString(3);
            cliente.SegundoApellido = dataReader.GetString(4);
            cliente.edad = dataReader.GetInt32(5);
            cliente.sexo = dataReader.GetString(6);
            cliente.Email = dataReader.GetString(7);
            cliente.Telefono = dataReader.GetString(8);

            return cliente;
        }
        
        public Producto DataReaderMapToProducto(OracleDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Producto producto = new Producto();
            producto.IdProducto = (string)dataReader["IdProducto"]; //(double)dataReade["CantidadKilometrosInicial"]
            producto.Nombre = dataReader.GetString(1);
            producto.CantidadDísponible = dataReader.GetInt32(2);
            producto.PrecioUnitario = dataReader.GetDouble(3);
            producto.PrecioCompra = dataReader.GetDouble(4);
            producto.IdProveedor = dataReader.GetString(5);
            return producto;
        }
        
            public Factura DataReaderMapToFactura(OracleDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Factura factura = new Factura();
            factura.NoFactura = dataReader.GetString(0); //(double)dataReade["CantidadKilometrosInicial"]
            factura.FechaFactura = dataReader.GetDateTime(1);
            factura.SubTotal = dataReader.GetDouble(2);
            factura.Impuesto = dataReader.GetDouble(3);
            factura.Total = dataReader.GetDouble(4);
            factura.IdCliente = dataReader.GetString(5);
            return factura;
        }

        public DetalleFactura DataReaderMapToDetalle(OracleDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            DetalleFactura detalle = new DetalleFactura();
            detalle.IdDetalleFactura = dataReader.GetString(0); //(double)dataReade["CantidadKilometrosInicial"]
            detalle.Cantidad = dataReader.GetInt32(1);
            detalle.PrecioUnitario = dataReader.GetDouble(2);
            detalle.Descripcion = dataReader.GetString(3);
            detalle.Importe = dataReader.GetDouble(4);
            detalle.NoFactura = dataReader.GetString(5);
            detalle.IdProducto = dataReader.GetString(6);

            return detalle;
        }

            public List<Proveedor> ConsultarProveedores()
        {
            OracleDataReader dataReader;
            List<Proveedor> proveedores = new List<Proveedor>();
            using (var command = conexion.CreateCommand())
            {
                command.CommandText = "SELECT *FROM PROVEEDOR";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Proveedor proveedor = DataReaderMapToProveedor(dataReader);
                        proveedores.Add(proveedor);
                    }
                    dataReader.Close();
                }
            }
           
            return proveedores;
        }
        public List<Cliente> ConsultarClientes()
        {
            OracleDataReader dataReader;
            List<Cliente> clientes = new List<Cliente>();
            using (var command = conexion.CreateCommand())
            {
                command.CommandText = "SELECT *FROM Cliente";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Cliente cliente = DataReaderMapToCliente(dataReader);
                        clientes.Add(cliente);
                    }
                    dataReader.Close();
                }
            }

            return clientes;
        }
        public List<Producto> ConsultarProductos()
        {
            OracleDataReader dataReader;
            List<Producto> productos = new List<Producto>();
            using (var command = conexion.CreateCommand())
            {
                command.CommandText = "SELECT *FROM PRODUCTO";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Producto producto = DataReaderMapToProducto(dataReader);
                        productos.Add(producto);
                    }
                    dataReader.Close();
                }
            }

            return productos;
        }
        
            public List<DetalleFactura> ConsultarDetalles()
        {
            OracleDataReader dataReader;
            List<DetalleFactura> detalles = new List<DetalleFactura>();
            using (var command = conexion.CreateCommand())
            {
                command.CommandText = "SELECT *FROM DETALLEFACTURA";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        DetalleFactura detalle = DataReaderMapToDetalle(dataReader);
                        detalles.Add(detalle);
                    }
                    dataReader.Close();
                }
            }

            return detalles;
        }
        public List<Factura> ConsultarFacturas()
        {
            OracleDataReader dataReader;
            List<Factura> facturas = new List<Factura>();
            using (var command = conexion.CreateCommand())
            {
                command.CommandText = "SELECT *FROM FACTURA";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Factura factura = DataReaderMapToFactura(dataReader);
                        facturas.Add(factura);
                    }
                    dataReader.Close();
                }
            }

            return facturas;
        }
        


        public void ModificarCliente(Cliente cliente)
        {
            using (var comando = conexion.CreateCommand())
            {
                comando.CommandText = "MODIFICARCLIENTE";
                comando.CommandType = CommandType.StoredProcedure;
                comando.BindByName = true;
                comando.Parameters.Add("P_CLIENTE", OracleDbType.Varchar2).Value = cliente.IdCliente;
                comando.Parameters.Add("P_PRIMERNOMBRE", OracleDbType.Varchar2).Value = cliente.PrimerNombre;
                comando.Parameters.Add("P_SEGUNDONOMBRE", OracleDbType.Varchar2).Value = cliente.SegundoNombre;
                comando.Parameters.Add("P_PRIMERAPELLIDO", OracleDbType.Varchar2).Value = cliente.PrimerApellido;
                comando.Parameters.Add("P_SEGUNDOAPELLIDO", OracleDbType.Varchar2).Value = cliente.SegundoApellido;
                comando.Parameters.Add("P_EDAD", OracleDbType.Int64).Value = cliente.edad;
                comando.Parameters.Add("P_SEXO", OracleDbType.Varchar2).Value = cliente.sexo;
                comando.Parameters.Add("P_EMAIL", OracleDbType.Varchar2).Value = cliente.Email;
                comando.Parameters.Add("P_TELEFONO", OracleDbType.Varchar2).Value = cliente.Telefono;
                comando.ExecuteNonQuery();
            }

        }
        
            public void ModificarProveedor(Proveedor proveedor)
        {
            using (var comando = conexion.CreateCommand())
            {
                comando.CommandText = "MODIFICARPROVEEDOR";
                comando.CommandType = CommandType.StoredProcedure;
                comando.BindByName = true;
                comando.Parameters.Add("P_IDPROVEEDOR", OracleDbType.Varchar2).Value = proveedor.IdProveedor;
                comando.Parameters.Add("P_NOMBREEMPRESA", OracleDbType.Varchar2).Value = proveedor.NombreEmpresa;
                comando.Parameters.Add("P_PRIMERNOMBRE", OracleDbType.Varchar2).Value = proveedor.PrimerNombre;
                comando.Parameters.Add("P_SEGUNDONOMBRE", OracleDbType.Varchar2).Value = proveedor.SegundoNombre;
                comando.Parameters.Add("P_PRIMERAPELLIDO", OracleDbType.Varchar2).Value = proveedor.PrimerApellido;
                comando.Parameters.Add("P_SEGUNDOAPELLIDO", OracleDbType.Varchar2).Value = proveedor.SegundoApellido;
                comando.Parameters.Add("P_EDAD", OracleDbType.Int64).Value = proveedor.edad;
                comando.Parameters.Add("P_SEXO", OracleDbType.Varchar2).Value = proveedor.sexo;
                comando.Parameters.Add("P_EMAIL", OracleDbType.Varchar2).Value = proveedor.Email;
                comando.Parameters.Add("P_TELEFONO", OracleDbType.Varchar2).Value = proveedor.Telefono;
                comando.ExecuteNonQuery();
            }

        }
        
             public void ModificarProducto(Producto producto)
        {
            using (var comando = conexion.CreateCommand())
            {
                comando.CommandText = "MODIFICARPRODUCTO";
                comando.CommandType = CommandType.StoredProcedure;
                comando.BindByName = true;
                comando.Parameters.Add("P_IDPRODUCTO", OracleDbType.Varchar2).Value = producto.IdProducto;
                comando.Parameters.Add("P_NOMBRE", OracleDbType.Varchar2).Value = producto.Nombre;
                comando.Parameters.Add("P_CANTIDADDISPONIBLE", OracleDbType.Int64).Value = producto.CantidadDísponible;
                comando.Parameters.Add("P_PRECIOUNITARIO", OracleDbType.Double).Value = producto.PrecioUnitario;
                comando.Parameters.Add("P_PRECIOCOMPRA", OracleDbType.Double).Value = producto.PrecioCompra;
                comando.ExecuteNonQuery();
            }

        }

        //public Liquidacion BuscarPorNumeroLiquidacionAutobus(int numeroLiquidacion)
        //{
        //    OracleDataReader dataReader;
        //    using (var command = conexion.CreateCommand())
        //    {
        //        command.CommandText = @"select *from liquidacionAutobus where NumeroLiquidacion=:NumeroLiquidacion";
        //        command.Parameters.Add("NumeroLiquidacion", OracleDbType.Int64).Value = numeroLiquidacion;
        //        dataReader = command.ExecuteReader();
        //        dataReader.Read();
        //        Liquidacion liquidacion = DataReaderMapToLiq(dataReader);
        //        return liquidacion;
        //    }
        //}
        //public Liquidacion BuscarPorNumeroLiquidacionTractor(int numeroLiquidacion)
        //{
        //    OracleDataReader dataReader;
        //    using (var command = conexion.CreateCommand())
        //    {
        //        command.CommandText = @"select *from liquidacionTractor where NumeroLiquidacion=:NumeroLiquidacion";
        //        command.Parameters.Add("NumeroLiquidacion", OracleDbType.Int64).Value = numeroLiquidacion;
        //        dataReader = command.ExecuteReader();
        //        dataReader.Read();
        //        Liquidacion liquidacion = DataReaderMapToLiq(dataReader);
        //        return liquidacion;
        //    }
        //}
        //private Liquidacion DataReaderMapToLiq(OracleDataReader dataReader)
        //{
        //    if (!dataReader.HasRows) return null;
        //    string tipoVehiculo = (string)dataReader["TipoVehiculo"];
        //    Liquidacion liquidacion;
        //    if (tipoVehiculo.ToUpper().Equals("AUTOBUS"))
        //    {
        //        liquidacion = new LiquidacionAutobus();
        //        liquidacion.CantidadKilometrosInicial = dataReader.GetDouble(3);//(double)dataReade["CantidadKilometrosInicial"]
        //        liquidacion.CantidadKilometrosFinal = dataReader.GetDouble(4);
        //        liquidacion.CantidadKilometrosTotal = dataReader.GetDouble(5);
        //        liquidacion.NumeroLiquidacion = dataReader.GetInt32(0);
        //        liquidacion.TipoVehiculo = (string)dataReader["TipoVehiculo"];
        //        liquidacion.Placa = (string)dataReader["Placa"];
        //        liquidacion.ValorRenta = dataReader.GetDouble(6);
        //        return liquidacion;
        //    }
        //    else if (tipoVehiculo.ToUpper().Equals("TRACTOR"))
        //    {
        //        liquidacion = new LiquidacionTractor();
        //        liquidacion.FechaRenta = (DateTime)dataReader["FechaRenta"];
        //        liquidacion.FechaDevolucion = (DateTime)dataReader["FechaDevolucion"];
        //        liquidacion.DiasTotal = dataReader.GetInt32(5);
        //        liquidacion.NumeroLiquidacion = dataReader.GetInt32(0);
        //        liquidacion.TipoVehiculo = (string)dataReader["TipoVehiculo"];
        //        liquidacion.Placa = (string)dataReader["Placa"];
        //        liquidacion.ValorRenta = dataReader.GetDouble(6);
        //        return liquidacion;
        //    }

        //    return null;
        //}
        //public List<Liquidacion> Consultar()
        //{
        //    OracleDataReader dataReader;
        //    List<Liquidacion> liquidaciones = new List<Liquidacion>();
        //    using (var command = conexion.CreateCommand())
        //    {
        //        command.CommandText = "Select * from LiquidacionAutobus ";
        //        dataReader = command.ExecuteReader();
        //        if (dataReader.HasRows)
        //        {
        //            while (dataReader.Read())
        //            {
        //                Liquidacion liquidacion = DataReaderMapToLiq(dataReader);
        //                liquidaciones.Add(liquidacion);
        //            }
        //            dataReader.Close();
        //        }
        //    }
        //    using (var command = conexion.CreateCommand())
        //    {
        //        command.CommandText = "Select * from liquidacionTractor ";
        //        dataReader = command.ExecuteReader();
        //        if (dataReader.HasRows)
        //        {
        //            while (dataReader.Read())
        //            {
        //                Liquidacion liquidacion = DataReaderMapToLiq(dataReader);
        //                liquidaciones.Add(liquidacion);
        //            }
        //            dataReader.Close();
        //        }
        //    }
        //    return liquidaciones;
        //}

        //public List<Liquidacion> BuscarLiquidacionesRenta(string tipo)
        //{
        //    if (!tipo.Equals("Todo"))
        //    {
        //        var Liquidaciones = Consultar();
        //        return (from liquidacion in Liquidaciones
        //                where liquidacion.TipoVehiculo.Equals(tipo)
        //                orderby liquidacion.NumeroLiquidacion ascending
        //                select liquidacion).ToList();


        //    }
        //    else
        //    {
        //        var Liquidaciones = Consultar();
        //        return (from liquidacion in Liquidaciones
        //                orderby liquidacion.NumeroLiquidacion ascending
        //                select liquidacion).ToList();
        //    }
        //}

        //public void EliminarLiquidacionAutobus(int numeroLiquidacion)
        //{
        //    using (var command = conexion.CreateCommand())
        //    {
        //        command.CommandText = @"delete from LiquidacionAutobus 
        //                                where NumeroLiquidacion=:NumeroLiquidacion";
        //        command.Parameters.Add("NumeroLiquidacion", OracleDbType.Int64).Value = numeroLiquidacion;
        //        command.ExecuteReader();

        //    }
        //}
        //public void EliminarLiquidacionTractor(int numeroLiquidacion)
        //{
        //    using (var command = conexion.CreateCommand())
        //    {
        //        command.CommandText = @"delete from LiquidacionTractor 
        //                                where NumeroLiquidacion=:NumeroLiquidacion";
        //        command.Parameters.Add("NumeroLiquidacion", OracleDbType.Int64).Value = numeroLiquidacion;
        //        command.ExecuteReader();
        //    }
        //}

        //public void ModificarLiquidacionAutobus(Liquidacion liquidacionNueva, int numeroLiquidacion)
        //{
        //    using (var command = conexion.CreateCommand())
        //    {
        //        command.Parameters.Add("CantidadKilometrosInicial", OracleDbType.Decimal).Value = liquidacionNueva.CantidadKilometrosInicial;
        //        command.Parameters.Add("CantidadKilometrosFinal", OracleDbType.Int64).Value = liquidacionNueva.CantidadKilometrosFinal;
        //        command.Parameters.Add("CantidadKilometrosTotal", OracleDbType.Int64).Value = liquidacionNueva.CantidadKilometrosTotal;
        //        command.Parameters.Add("ValorRenta", OracleDbType.Decimal).Value = liquidacionNueva.ValorRenta;
        //        command.Parameters.Add("NumeroLiquidacion", OracleDbType.Int32).Value = numeroLiquidacion;
        //        command.CommandText = @"UPDATE LIQUIDACIONAUTOBUS SET CANTIDADKILOMETROSINICIAL =:CantidadKilometrosInicial,CANTIDADKILOMETROSFINAL=:CantidadKilometrosFinal,CANTIDADKILOMETROSTOTAL=:CantidadKilometrosTotal,VALORRENTA =:ValorRenta 
        //                                WHERE NumeroLiquidacion=:NumeroLiquidacion";
        //        command.ExecuteReader();
        //    }

        //}
        //public void ModificarLiquidacionTractor(Liquidacion liquidacionNueva, int numeroLiquidacion)
        //{
        //    using (var command = conexion.CreateCommand())
        //    {
        //        command.Parameters.Add("FechaRenta", OracleDbType.Date).Value = liquidacionNueva.FechaRenta;
        //        command.Parameters.Add("FechaDevolucion", OracleDbType.Date).Value = liquidacionNueva.FechaDevolucion;
        //        command.Parameters.Add("DiasTotal", OracleDbType.Int64).Value = liquidacionNueva.DiasTotal;
        //        command.Parameters.Add("ValorRenta", OracleDbType.Decimal).Value = liquidacionNueva.ValorRenta;
        //        command.Parameters.Add("NumeroLiquidacion", OracleDbType.Int32).Value = numeroLiquidacion;
        //        command.CommandText = @"UPDATE LIQUIDACIONTRACTOR SET FechaRenta =:FechaRenta,FechaDevolucion=:FechaDevolucion,DiasTotal=:DiasTotal,ValorRenta =:ValorRenta 
        //                                WHERE NumeroLiquidacion=:NumeroLiquidacion";
        //        command.ExecuteReader();
        //    }
        //}
    }
}
