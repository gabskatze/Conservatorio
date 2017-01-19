using ServiceStack.OrmLite;


namespace Conservatorio.DS
{
    public class Conexion
    {
        public static OrmLiteConnectionFactory EstablecerConexion()
        {
            return new
                OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
        }
    }
}
