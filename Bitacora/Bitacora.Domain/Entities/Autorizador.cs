using System;
using System.Collections.Generic;

namespace Bitacora.Domain.Entities
{
    public class Autorizador
    {
        #region Fields
        private Guid _IdAutorizador;
        private string _IdUsuarioAutorizador;
        private int _IdNotificacion;
        private ICollection<Notificacion> _Notificaciones;
        #endregion

        #region Fields
        public Guid IdSolicitante
        {
            get { return _IdAutorizador; }
            set { _IdAutorizador = value; }
        }

        public string IdUsuarioSolicitante
        {
            get { return _IdUsuarioAutorizador; }
            set { _IdUsuarioAutorizador = value; }
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