using System;
using System.Collections.Generic;

namespace Bitacora.Domain.Entities
{
    public class Cliente
    {
        #region Fields
        private int _IdCliente;
        private string _Nombre;
        private DateTime _FechaInicioRelacion;
        private DateTime _FechaFinRelacion;
        private bool _SoporteActivo;
        private ICollection<Soporte> _Soportes;
        #endregion

        #region Properties
        public int IdCliente
        {
            get { return _IdCliente; }
            set { _IdCliente = value; }
        }

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public DateTime FechaInicioRelacion
        {
            get { return _FechaInicioRelacion; }
            set { _FechaInicioRelacion = value; }
        }

        public DateTime FechaFinRelacion
        {
            get { return _FechaFinRelacion; }
            set { _FechaFinRelacion = value; }
        }

        public bool SoporteActivo
        {
            get { return _SoporteActivo; }
            set { _SoporteActivo = value; }
        }

        public ICollection<Soporte> Soportes
        {
            get { return _Soportes; }
            set { _Soportes = value; }
        }
        #endregion
    }
}