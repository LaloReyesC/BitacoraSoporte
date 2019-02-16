using System;

namespace Bitacora.Domain.Entities
{
    public class CatalogoProductos
    {
        #region Fields
        private int _IdProducto;
        private string _Nombre;
        private string _Descripcion;
        private DateTime _FechaRegistro;
        private bool _Vigente;
        #endregion

        #region Properties
        public int IdProducto
        {
            get { return _IdProducto; }
            set { _IdProducto = value; }
        }

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        public DateTime FechaRegistro
        {
            get { return _FechaRegistro; }
            set { _FechaRegistro = value; }
        }

        public bool Vigente
        {
            get { return _Vigente; }
            set { _Vigente = value; }
        }
        #endregion
    }
}