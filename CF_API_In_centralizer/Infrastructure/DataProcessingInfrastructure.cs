using System.Data.OleDb;
using CF_API_In_centralizer.Repository;

namespace CF_API_In_centralizer.Infrastructure
{
    public class DataProcessingInfrastructure
    {
        public static bool ProcessingData(string product, double price, string supermarket)
        {
            try
            {
                OleDbConnection oleDbConnection = new OleDbConnection();
                oleDbConnection.ConnectionString = "Provider=SQLOLEDB.1;Password=Insp1r0n@;Persist Security Info=True;User ID=sa;Initial Catalog=DBCOMPREFACIL;Data Source=RS\\SQLEXPRESS";


                int idProduct = RepositoryDB.GetIdProduct(oleDbConnection);

                RepositoryDB.PostProductDB(oleDbConnection, idProduct, product, price, supermarket);                

                return true;
            }
            catch
            {
                return false;
            }

            

        }
    }
}
