using System;
using System.Collections.Generic;
using Datos;
using Entidad;

namespace Logica
{
    public class TiendaService
    {

        private readonly ConnectionManager conexion;
        private readonly TiendaRepository repositorio;
        public TiendaService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new TiendaRepository(conexion);
        }
        public string NumeroFactura()
        {
            try
            {
                conexion.Open();

                string numeroFactura;

                numeroFactura= repositorio.numeroFactura();

                return numeroFactura;


            }
            catch (Exception exception)
            {

                return $"Se presentó el siguiente error: " + exception.Message;
            }
            finally
            { conexion.Close(); }
        }
        public string NumeroProducto()
        {
            try
            {
                conexion.Open();

                string numeroFactura;

                numeroFactura = repositorio.numeroProducto();

                return numeroFactura;


            }
            catch (Exception exception)
            {

                return $"Se presentó el siguiente error: " + exception.Message;
            }
            finally
            { conexion.Close(); }

        }
        public string NumeroProveedor()
        {
            try
            {
                conexion.Open();

                string numeroFactura;

                numeroFactura = repositorio.numeroProveedor();

                return numeroFactura;


            }
            catch (Exception exception)
            {

                return $"Se presentó el siguiente error: " + exception.Message;
            }
            finally
            { conexion.Close(); }
        }
        public string NumeroCliente()
        {
            try
            {
                conexion.Open();

                string numeroFactura;

                numeroFactura = repositorio.numeroCliente();

                return numeroFactura;


            }
            catch (Exception exception)
            {

                return $"Se presentó el siguiente error: " + exception.Message;
            }
            finally
            { conexion.Close(); }
        }



        public string NumeroDetalleFactura()
        {
             
                 try
            {
                conexion.Open();

                

                string numero = repositorio.NumeroDetalleFactura();

                return numero.ToString();


            }
            catch (Exception exception)
            {

                return $"Se presentó el siguiente error: " + exception.Message;
            }
            finally
            { conexion.Close(); }
            
        }

        public string GuardarFactura(Factura factura)
        {
            try
            {
                conexion.Open();


                    repositorio.GuardarFactura(factura);

                    return "Datos Guardados Satisfactoriamente";

               
            }
            catch (Exception exception)
            {

                return $"Se presentó el siguiente error: " + exception.Message;
            }
            finally
            { conexion.Close(); }
        }
        public string GuardarDetalleFactura(DetalleFactura detalleFactura)
        {
            
                try
                {
                    conexion.Open();


                    repositorio.GuardarDetalleFactura(detalleFactura);
                    return "Datos Guardados Satisfactoriamente";


                }
                catch (Exception exception)
                {

                    return $"Se presentó el siguiente error: " + exception.Message;
                }
                finally
                { conexion.Close(); }
            

        }
        public string GuardarProducto(Producto producto)
        {
            try
            {
                conexion.Open();


                repositorio.GuardarProducto(producto);

                return "Datos Guardados Satisfactoriamente";


            }
            catch (Exception exception)
            {

                return $"Se presentó el siguiente error: " + exception.Message;
            }
            finally
            { conexion.Close(); }
        }
        public string GuardarCliente(Cliente cliente)
        {
            try
            {
                conexion.Open();


                repositorio.GuardarCliente(cliente);

                return "Datos Guardados Satisfactoriamente";


            }
            catch (Exception exception)
            {

                return $"Se presentó el siguiente error: " + exception.Message;
            }
            finally
            { conexion.Close(); }
        }
        public string GuardarProveedor(Proveedor proveedor)
        {
            try
            {
                conexion.Open();


                repositorio.GuardarProveedor(proveedor);

                return "Datos Guardados Satisfactoriamente";


            }
            catch (Exception exception)
            {

                return $"Se presentó el siguiente error: " + exception.Message;
            }
            finally
            { conexion.Close(); }
        }

        public List<Proveedor> ConsultarProveedores()
        {
            try
            {
                conexion.Open();
                List<Proveedor> proveedores = new List<Proveedor>();
                proveedores=repositorio.ConsultarProveedores();
                return proveedores;
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                conexion.Close();
            }
            
        }
        public List<Cliente> ConsultarClientes()
        {
            try
            {
                conexion.Open();
                List<Cliente> clientes = new List<Cliente>();
                clientes = repositorio.ConsultarClientes();
                return clientes;
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                conexion.Close();
            }
        }

        public List<Producto> ConsultarProductos()
        {
            try
            {
                conexion.Open();
                List<Producto> productos = new List<Producto>();
                productos = repositorio.ConsultarProductos();
                return productos;
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                conexion.Close();
            }
        }
        public List<Factura> ConsultarFacturas()
        {
            try
            {
                conexion.Open();
                List<Factura> facturas = new List<Factura>();
                facturas = repositorio.ConsultarFacturas();
                return facturas;
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                conexion.Close();
            }
        }
        
             public List<DetalleFactura> ConsultarDetalles()
        {
            try
            {
                conexion.Open();
                List<DetalleFactura> detalles = new List<DetalleFactura>();
                detalles = repositorio.ConsultarDetalles();
                return detalles;
            }
            catch (Exception exception)
            {
                return null;
            }
            finally
            {
                conexion.Close();
            }
        }

        public string ModificarCliente(Cliente cliente)
        {
            try
            {
                conexion.Open();


                repositorio.ModificarCliente(cliente);

                return "Datos Modificados Satisfactoriamente";


            }
            catch (Exception exception)
            {

                return $"Se presentó el siguiente error: " + exception.Message;
            }
            finally
            { conexion.Close(); }
            
        }
        
        public string ModificarProveedor(Proveedor proveedor)
        {
            try
            {
                conexion.Open();


                repositorio.ModificarProveedor(proveedor);

                return "Datos Modificados Satisfactoriamente";


            }
            catch (Exception exception)
            {

                return $"Se presentó el siguiente error: " + exception.Message;
            }
            finally
            { conexion.Close(); }

        }
        
            public string ModificarProducto(Producto producto)
        {
            try
            {
                conexion.Open();


                repositorio.ModificarProducto(producto);

                return "Datos Modificados Satisfactoriamente";


            }
            catch (Exception exception)
            {

                return $"Se presentó el siguiente error: " + exception.Message;
            }
            finally
            { conexion.Close(); }

        }

        //public class ConsultaResponse
        //{
        //    public List<Liquidacion> Liquidaciones { get; set; }
        //    public string Mensaje { get; set; }
        //    public bool Error { get; set; }

        //    public ConsultaResponse(List<Liquidacion> liquidaciones)
        //    {
        //        Liquidaciones = liquidaciones;
        //        Error = false;
        //    }
        //    public ConsultaResponse(string mensaje)
        //    {
        //        Mensaje = mensaje;
        //        Error = true;
        //    }

        //}
        //public ConsultaResponse Consultar(string tipo)
        //{
        //    try
        //    {
        //        conexion.Open();
        //        return new ConsultaResponse(repositorio.BuscarLiquidacionesRenta(tipo));
        //    }
        //    catch (Exception exception)
        //    {
        //        return new ConsultaResponse("Se presentó el siguiente error:" + exception.Message);
        //    }
        //    finally
        //    {
        //        conexion.Close();
        //    }
        //}

        //public string Eliminar(int numeroLiquidacion)
        //{

        //    try
        //    {
        //        conexion.Open();
        //        if (repositorio.BuscarPorNumeroLiquidacionAutobus(numeroLiquidacion) != null)
        //        {
        //            repositorio.EliminarLiquidacionAutobus(numeroLiquidacion);
        //            return $"Se eliminó a la Persona con identificacion {numeroLiquidacion}";
        //        }
        //        else if (repositorio.BuscarPorNumeroLiquidacionTractor(numeroLiquidacion) != null)
        //        {
        //            repositorio.EliminarLiquidacionTractor(numeroLiquidacion);
        //            return $"Se eliminó a la Persona con identificacion {numeroLiquidacion}";
        //        }
        //        return $"No se encontró a la persona con Identificacion {numeroLiquidacion}";
        //    }
        //    catch (Exception exception)
        //    {

        //        return "Se presentó el siguiente error:" + exception.Message;
        //    }
        //    finally
        //    {
        //        conexion.Close();
        //    }

        //}
        //public string Modificar(Liquidacion liquidacionNueva, int numeroliquidacion)
        //{

        //    try
        //    {
        //        conexion.Open();
        //        if (repositorio.BuscarPorNumeroLiquidacionAutobus(numeroliquidacion) != null)
        //        {
        //            repositorio.ModificarLiquidacionAutobus(liquidacionNueva, numeroliquidacion);
        //            return $"Se Modificó a la Persona con Identificacion {numeroliquidacion}";
        //        }
        //        else if (repositorio.BuscarPorNumeroLiquidacionTractor(numeroliquidacion) != null)
        //        {
        //            repositorio.ModificarLiquidacionTractor(liquidacionNueva, numeroliquidacion);
        //            return $"Se Modificó a la Persona con Identificacion {numeroliquidacion}";
        //        }
        //        return $"No se encontró a la persona con Identificacion {numeroliquidacion}";
        //    }
        //    catch (Exception exception)
        //    {

        //        return "Se presentó el siguiente error:" + exception.Message;
        //    }
        //    finally
        //    {
        //        conexion.Close();
        //    }
        //}

        //public class BusquedaResponse
        //{
        //    public Liquidacion Liquidacion { get; set; }
        //    public string Mensaje { get; set; }
        //    public bool Error { get; set; }

        //    public BusquedaResponse(Liquidacion liquidacion)
        //    {
        //        Liquidacion = liquidacion;
        //        Error = false;
        //    }
        //    public BusquedaResponse(string mensaje)
        //    {
        //        Mensaje = mensaje;
        //        Error = true;
        //    }
        //}

        //public BusquedaResponse BuscarLiquidacionAutobus(int numeroLiquidacion)
        //{
        //    try
        //    {
        //        conexion.Open();
        //        return new BusquedaResponse(repositorio.BuscarPorNumeroLiquidacionAutobus(numeroLiquidacion));
        //    }
        //    catch (Exception exception)
        //    {
        //        return new BusquedaResponse("Se presentó el siguiente error:" + exception.Message);
        //    }
        //    finally
        //    {
        //        conexion.Close();
        //    }
        //}
        //public BusquedaResponse BuscarLiquidacionTractor(int numeroLiquidacion)
        //{
        //    try
        //    {
        //        conexion.Open();
        //        return new BusquedaResponse(repositorio.BuscarPorNumeroLiquidacionTractor(numeroLiquidacion));
        //    }
        //    catch (Exception exception)
        //    {
        //        return new BusquedaResponse("Se presentó el siguiente error:" + exception.Message);
        //    }
        //    finally
        //    {
        //        conexion.Close();
        //    }
        //}

    }
}