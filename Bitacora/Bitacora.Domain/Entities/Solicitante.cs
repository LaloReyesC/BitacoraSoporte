using System;
using System.Collections.Generic;

namespace Bitacora.Domain.Entities
{
    public class Solicitante
    {
        #region Fields
        private Guid _IdSolicitante;
        private string _IdUsuarioSolicitante;
        private int _IdNotificacion;
        private ICollection<Notificacion> _Notificaciones;
        #endregion

        #region Properties
        public Guid IdSolicitante
        {
            get { return _IdSolicitante; }
            set { _IdSolicitante = value; }
        }

        public string IdUsuarioSolicitante
        {
            get { return _IdUsuarioSolicitante; }
            set { _IdUsuarioSolicitante = value; }
        }

        public int IdNotificacion
        {
            get { return _IdNotificacion; }
            set { _IdNotificacion = value; }
        }

        public ICollection<Notificacion> Notificaciones
        {
            get { return _Notificaciones; }
            set { _Notificaciones = value; }
        }
        #endregion
    }
}