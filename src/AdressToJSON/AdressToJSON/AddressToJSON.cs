using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Web.Script.Serialization;
using System.Windows.Forms;



namespace AdressToJSON
{
    public class AddressToJSON
    {
        static void Main(string[] args)
        {
            string queryString = "SELECT  U_NAVN,U_GODSADR,U_POSTNR,U_POSTSTED,U_LKODE,U_KONTAKT,U_EMAIL,U_TELEFON,U_REGNRFSK  FROM  [dbo].[U_GAN]";
            string connectionString = File.ReadAllText("./connectionstring.txt");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                try
                {
                    List<JSONObject> list = new List<JSONObject>();
                    while (reader.Read())
                    {
                       JSONObject row = new JSONObject();
                       row.CompanyName = reader["U_NAVN"].ToString();
                       row.Street = reader["U_GODSADR"].ToString();
                       row.PostalCode = reader["U_POSTNR"].ToString();
                       row.PostalPlace = reader["U_POSTSTED"].ToString();
                       row.CountryCode = reader["U_LKODE"].ToString();
                       row.ContactName = reader["U_KONTAKT"].ToString();
                       row.ContactEmail = reader["U_EMAIL"].ToString();
                       row.ContactPhone  =reader["U_TELEFON"].ToString();
                       row.OrgId = reader["U_REGNRFSK"].ToString();
                       list.Add(row);

                    }
                    var jsonSerialiser = new JavaScriptSerializer();
                    jsonSerialiser.MaxJsonLength = int.MaxValue;
                    var json = jsonSerialiser.Serialize(list);
                    File.WriteAllText("./JSON.txt",json);
                }
                finally
                {
                    // Always call Close when done reading.
                    reader.Close();
                }
            }
        }
    }
}
