using System;

namespace Bitacora.Domain.Entities
{
    public class EvidenciasSoporte
    {
        #region Fields
        private Guid _IdEvidenciaSoporte;
        private DateTime _FechaCarga;
        private string _RutaEvidencia;
        private string _Descripcion;
        private Guid _IdSoporteTransaccion;
        private SoporteTransaccion _SoporteTransaccion;
        #endregion

        #region Properties
        public Guid IdEvidenciaSoporte
        {
            get { return _IdEvidenciaSoporte; }
            set { _IdEvidenciaSoporte = value; }
        }

        public Guid IdSoporteTransaccion
        {
            get { return _IdSoporteTransaccion; }
            set { _IdSoporteTransaccion = value; }
        }

        public SoporteTransaccion SoporteTransaccion
        {
            get { return _SoporteTransaccion; }
            set { _SoporteTransaccion = value; }
        }

        public DateTime FechaCarga
        {
            get { return _FechaCarga; }
            set { _FechaCarga = value; }
        }

        public string RutaEvidencia
        {
            get { return _RutaEvidencia; }
            set { _RutaEvidencia = value; }
        }

        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }
        #endregion
    }
}