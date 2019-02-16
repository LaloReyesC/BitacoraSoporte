using System;
using System.Collections.Generic;

namespace Bitacora.Domain.Entities
{
    public class Soporte
    {
        //TODO: Implementar carga de evidencia al finalizar el proceso.
        #region Constructors
        public Soporte()
        {
        }
        #endregion

        #region Fields
        private Guid _IdSoporte;
        private string _Descripcion;
        private Guid _IdSolicitante;
        private Nullable<Guid> _IdAutorizador;
        private string _IdUsuarioEncargado;
        private string _DescripcionSolucion;
        private Guid _IdProductoCliente;
        private ProductosCliente _ProductosCliente;
        private ICollection<SoporteTransaccion> _SoportesTransacciones;
        #endregion

        #region Properties
        public Guid IdSoporte
        {
            get { return _IdSoporte; }
            set { _IdSoporte = value; }
        }

        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        public Guid IdSolicitante
        {
            get { return _IdSolicitante; }
            set { _IdSolicitante = value; }
        }

        public Nullable<Guid> IdAutorizador
        {
            get { return _IdAutorizador; }
            set { _IdAutorizador = value; }
        }

        public string IdUsuarioEncargado
        {
            get { return _IdUsuarioEncargado; }
            set { _IdUsuarioEncargado = value; }
        }

        public string DescripcionSolucion
        {
            get { return _DescripcionSolucion; }
            set { _DescripcionSolucion = value; }
        }

        public Guid IdProductoCliente
        {
            get { return _IdProductoCliente; }
            set { _IdProductoCliente = value; }
        }

        public ProductosCliente ProductosCliente
        {
            get { return _ProductosCliente; }
            set { _ProductosCliente = value; }
        }

        public ICollection<SoporteTransaccion> SoportesTransacciones
        {
            get { return _SoportesTransacciones; }
            set { _SoportesTransacciones = value; }
        }
        #endregion
    }
}