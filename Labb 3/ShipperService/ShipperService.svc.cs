using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ShipperService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ShipperService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ShipperService.svc or ShipperService.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IShipperService
    {
        public Shipper GetShipperByID(int id)
        {
            var con = ConfigurationManager.ConnectionStrings["TestDB"].ToString();

            Shipper matchingShipper = new Shipper();
            matchingShipper.ShipperID = id;
            using (SqlConnection myConnection = new SqlConnection(con))
            {
                string oString = "select * from Shippers a where a.ShipperID = @shipperID";
                SqlCommand oCmd = new SqlCommand(oString, myConnection);
                oCmd.Parameters.AddWithValue("@shipperID", id);
                myConnection.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        matchingShipper.CompanyName = oReader["CompanyName"].ToString();
                        matchingShipper.Phone = oReader["Phone"].ToString();
                    }

                    myConnection.Close();
                }
            }
            return matchingShipper;
        }

        public void SaveNewShipper(int id, string companyName, string phone)
        {
            var con = ConfigurationManager.ConnectionStrings["TestDB"].ToString();

            using (SqlConnection connection = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("update Shippers set CompanyName=@Name, Phone=@Phone WHERE ShipperID = @ShipperID");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@Name", companyName);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@ShipperID", id);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
