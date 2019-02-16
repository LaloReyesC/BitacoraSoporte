using System;
using System.Collections.Generic;

namespace Bitacora.Domain.Entities
{
    //TODO: Implementar carga de evidencia al finalizar el proceso.
    public class SoporteTransaccion
    {
        #region Fields
        private Guid _IdSoporteTransaccion;
        private Guid _IdSoporte;
        private int _IdEstatus;
        private EstatusSoporte _EstatusSoporte;
        private DateTime _FechaTransaccion;
        private ICollection<EvidenciasSoporte> _EvidenciasSoporte;
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

        public ICollection<EvidenciasSoporte> EvidenciasSoporte
        {
            get { return _EvidenciasSoporte; }
            set { _EvidenciasSoporte = value; }
        }
        #endregion
    }
}