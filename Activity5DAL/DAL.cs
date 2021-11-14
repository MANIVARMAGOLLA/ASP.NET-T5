using Activity5DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity5DAL
{
    public class DAL
    {
        SqlConnection sqlConObj;
        SqlCommand sqlCmdObj;
        public DAL()
        {
            sqlConObj = new SqlConnection();
            sqlCmdObj = new SqlCommand();

        }


        public int InsertIntoPro(DTO newdto)
        {

            try
            {
                sqlConObj.ConnectionString = ConfigurationManager.ConnectionStrings["AdvWorksDBConnStr"].ConnectionString;
                sqlCmdObj.CommandText = @"[dbo].[usp_InsertDataIntoProduct]";
                sqlCmdObj.CommandType = CommandType.StoredProcedure;
                sqlCmdObj.Connection = sqlConObj;
                sqlCmdObj.Parameters.AddWithValue("@IP1", newdto.Name);
                sqlCmdObj.Parameters.AddWithValue("@IP2", newdto.GroupName);



                SqlParameter prmReturn = new SqlParameter();
                prmReturn.Direction = ParameterDirection.ReturnValue;
                prmReturn.SqlDbType = SqlDbType.Int;
                sqlCmdObj.Parameters.Add(prmReturn);
                sqlConObj.Open();
                sqlCmdObj.ExecuteNonQuery();
                return Convert.ToInt32(prmReturn.Value);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
