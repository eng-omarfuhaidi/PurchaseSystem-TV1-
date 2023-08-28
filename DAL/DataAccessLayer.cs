using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
namespace PurchaseSystem.DAL
{
    class DataAccessLayer
    {
         OracleConnection oracleConnection;

        // This Constructor initializes the connection object
        public DataAccessLayer()
        {
 //           string connectionString = @" (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1522)) (CONNECT_DATA =(SERVER = DEDICATED)" +
 // "(SERVICE_NAME = orclpdb)" +
 //" ); User Id=purchase;password=purchase;";

       //   string connectionString = "Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1522))(CONNECT_DATA = (SERVICE_NAME = orclpdb))); User Id = Purchases; Password = Purchase; ";
           
            oracleConnection = new OracleConnection("Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1522))(CONNECT_DATA = (SERVICE_NAME = orclpdb))); User Id = Purchases; Password = Purchase; ");
            
        }

        // Method to open the connection
        public void Open()
        {
            if (oracleConnection.State != ConnectionState.Open)
            {
                oracleConnection.Open();
               
            }
        }

        // Method to close the connection
        public void Close()
        {
            if (oracleConnection.State == ConnectionState.Open)
            {
                oracleConnection.Close();
            }
        }


        public OracleDataReader ExecuteDataReader(string stored_procedure)
        {
            OracleCommand oracleCommand = new OracleCommand();
            oracleCommand.CommandType = CommandType.StoredProcedure;
            oracleCommand.CommandText = stored_procedure;
            oracleCommand.Connection = oracleConnection;

        

            if (oracleCommand.Connection.State != ConnectionState.Open)
            {
                oracleCommand.Connection.Open();
            }
            oracleCommand.ExecuteNonQuery();

            OracleDataReader reader = oracleCommand.ExecuteReader(CommandBehavior.CloseConnection);
            return reader;
        }




        public OracleDataAdapter PopoulateCombo(string stored_procedure, string param)
        {
      

                OracleCommand objCmd = new OracleCommand();
                objCmd.Connection = oracleConnection;
                objCmd.CommandText = stored_procedure;
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.Parameters.Add(param, OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            //   OracleDataReader objReader = objCmd.ExecuteReader();
            OracleDataAdapter da = new OracleDataAdapter(objCmd);
            return da;
        }


        public OracleDataAdapter SelectData(string stored_procedure, string param)
        {


            OracleCommand objCmd = new OracleCommand();
            objCmd.Connection = oracleConnection;
            objCmd.CommandText = stored_procedure;
            objCmd.CommandType = CommandType.StoredProcedure;
            objCmd.Parameters.Add(param, OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            //   OracleDataReader objReader = objCmd.ExecuteReader();
            OracleDataAdapter da = new OracleDataAdapter(objCmd);
            return da;
        }


        public OracleDataAdapter SelectDataById(string stored_procedure, string param1,string param2,int Id)
        {


            OracleCommand objCmd = new OracleCommand();
            objCmd.Connection = oracleConnection;
            objCmd.CommandText = stored_procedure;
            objCmd.CommandType = CommandType.StoredProcedure;

            // Add input parameter for orderId
            OracleParameter orderIdParam = new OracleParameter(param1, OracleDbType.Int32);
            orderIdParam.Direction = ParameterDirection.Input;
            orderIdParam.Value = Id;
            objCmd.Parameters.Add(orderIdParam);

            // Add output parameter for the cursor

            objCmd.Parameters.Add(param2, OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            //   OracleDataReader objReader = objCmd.ExecuteReader();
            OracleDataAdapter da = new OracleDataAdapter(objCmd);
            return da;
        }


        // Method to Read Data From Database
        public DataTable SelectData(string stored_procedure, OracleParameter[] param)
        {
            OracleCommand oracleCommand = new OracleCommand();
            oracleCommand.CommandType = CommandType.StoredProcedure;
            oracleCommand.CommandText = stored_procedure;
            oracleCommand.Connection = oracleConnection;

            if (param != null)
            {
                oracleCommand.Parameters.AddRange(param);
            }

            OracleDataAdapter da = new OracleDataAdapter(oracleCommand);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // Method to Insert, Update, and Delete Data From Database
        public void ExecuteCommand(string stored_procedure, OracleParameter[] param)
        {
            OracleCommand oracleCommand = new OracleCommand();
            oracleCommand.CommandType = CommandType.StoredProcedure;
            oracleCommand.CommandText = stored_procedure;
            oracleCommand.Connection = oracleConnection;

            if (param != null)
            {
                oracleCommand.Parameters.AddRange(param);
            }

            oracleCommand.ExecuteNonQuery();
        }

    }
}
