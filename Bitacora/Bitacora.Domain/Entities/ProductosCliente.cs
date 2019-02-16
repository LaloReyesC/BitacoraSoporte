using System;

namespace Bitacora.Domain.Entities
{
    public class ProductosCliente
    {

        #region Fields
        private Guid _IdProductoCliente;
        private int _IdCliente;
        private int _IdProducto;
        #endregion

        #region Properties
        public Guid IdProductoCliente
        {
            get { return _IdProductoCliente; }
            set { _IdProductoCliente = value; }
        }

        public int IdCliente
        {
            get { return _IdCliente; }
            set { _IdCliente = value; }
        }

        public int IdProducto
        {
            get { return _IdProducto; }
            set { _IdProducto = value; }
        }
        #endregion
    }
}