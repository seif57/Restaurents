using System.Data.SqlClient;

namespace Restaurents
{
    public class DataBaseConnection
    {
        public static SqlConnection SqlConnection
        {
            get
            {
                return new SqlConnection("Data Source=.;Initial Catalog=Testing 101;Integrated Security=True");
            }
        }
    }
}
