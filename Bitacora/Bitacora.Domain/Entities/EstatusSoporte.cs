namespace Bitacora.Domain.Entities
{
    public class EstatusSoporte
    {
        #region Fields
        private int _IdEstatus;
        private string _Nombre;
        private string _Descripcion;
        #endregion

        #region Properties
        public int IdEstatus
        {
            get { return _IdEstatus; }
            set { _IdEstatus = value; }
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
        #endregion
    }
}