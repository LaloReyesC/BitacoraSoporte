using System;

namespace Bitacora.Domain.Entities
{
    public class SoporteTransaccion
    {
        #region Fields
        private Guid _IdSoporteTransaccion;
        private Guid _IdSoporte;
        private int _IdEstatus;
        private EstatusSoporte _EstatusSoporte;
        private DateTime _FechaTransaccion;
        #endregion

        #region Properties
        public Guid IdSoporteTransaccion
        {
            get { return _IdSoporteTransaccion; }
            set { _IdSoporteTransaccion = value; }
        }

        public Guid IdSoporte
        {
            get { return _IdSoporte; }
            set { _IdSoporte = value; }
        }

        public int IdEstatus
        {
            get { return _IdEstatus; }
            set { _IdEstatus = value; }
        }

        public EstatusSoporte EstatusSoporte
        {
            get { return _EstatusSoporte; }
            set { _EstatusSoporte = value; }
        }

        public DateTime FechaTransaccion
        {
            get { return _FechaTransaccion; }
            set { _FechaTransaccion = value; }
        }
        #endregion
    }
}