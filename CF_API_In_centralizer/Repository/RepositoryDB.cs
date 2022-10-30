using CF_API_In_centralizer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Data.SqlClient;
using System.Data.OleDb;

namespace CF_API_In_centralizer.Repository
{
    public class RepositoryDB
    {
        public static int GetIdProduct(OleDbConnection oleDbConnection)
        {
            int id;
            string query = string.Empty;
            object result;


            oleDbConnection.Open();    
            
            query = "select TOP 1  ID FROM CFPRODUCTS ORDER BY ID DESC";

            OleDbCommand command = new OleDbCommand(query, oleDbConnection);

            id = Convert.ToInt32((result = command.ExecuteScalar())); 

            oleDbConnection.Close();          

            return (id+1);
        }

        public static void PostProductDB(OleDbConnection oleDbConnection, int idProduct, string product, double price,string supermarket)
        {
            string query = string.Empty;

            oleDbConnection.Open();           

            query += System.Environment.NewLine + "INSERT INTO CFPRODUCTS ("         ;
            query += System.Environment.NewLine + "ID"                               ;
            query += System.Environment.NewLine + ",PRODUTO"                         ;
            query += System.Environment.NewLine + ",PRECO"                           ;
            query += System.Environment.NewLine + ",DATA_OCORRENCIA"                 ;
            query += System.Environment.NewLine + ",SUPERMERCADO"                    ;
            query += System.Environment.NewLine + ") VALUES ("                       ;
            query += System.Environment.NewLine + "'"+ idProduct + "'"               ;
            query += System.Environment.NewLine + ",'"+ product + "'"                   ;
            query += System.Environment.NewLine + ",'"+ price + "'";
            query += System.Environment.NewLine + ",GETDATE()"                       ;
            query += System.Environment.NewLine + ",'"+ supermarket + "')";

            OleDbCommand command = new OleDbCommand(query, oleDbConnection);

            command.ExecuteNonQuery();

            oleDbConnection.Close();

        }

    }
}
