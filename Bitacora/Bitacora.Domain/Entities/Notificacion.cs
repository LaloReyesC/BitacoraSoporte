namespace Bitacora.Domain.Entities
{
    public class Notificacion
    {
        #region Fields
        private int _IdNotificacion;
        private string _TipoNotificacion;
        private string _Descripcion;
        #endregion

        #region Properties
        public int IdNotificacion
        {
            get { return _IdNotificacion; }
            set { _IdNotificacion = value; }
        }

        public string TipoNotificacion
        {
            get { return _TipoNotificacion; }
            set { _TipoNotificacion = value; }
        }

        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }
        #endregion
    }
}