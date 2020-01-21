using DB2_ZH.Models.Records;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB2_ZH.Models.Managers
{
    class OracleManager
    {
        private OracleConnection getConnection()
        {
            OracleConnection kapcsolat = new OracleConnection();
            string kapcsolatiString = @"Data Source=193.225.33.71;User Id=RE1D25;Password=szelektcsillag;";

            kapcsolat.ConnectionString = kapcsolatiString;

            kapcsolat.Open();

            return kapcsolat;
        }

        public bool CheckData(string data)
        {
            OracleCommand parancs = new OracleCommand();
            parancs.Connection = getConnection();
            parancs.CommandType = System.Data.CommandType.StoredProcedure;
            parancs.CommandText = "M5APWK_check_data";

            OracleParameter check = new OracleParameter();
            check.DbType = System.Data.DbType.String;
            check.Direction = System.Data.ParameterDirection.ReturnValue;

            parancs.Parameters.Add(check);
            object obj = parancs.ExecuteScalar();
            bool valueCheck = obj != null && obj != DBNull.Value;
            return valueCheck;
        }

        public int Insert(Record record)
        {
            OracleCommand p = new OracleCommand();

            p.Connection = getConnection();
            p.CommandType = System.Data.CommandType.Text;
            p.CommandText = "INSERT INTO szamlak(id,nev,bankartyaszam,egyenleg) VALUES(:id, :nev, :bankartyaszam, :egyenleg)";

            OracleParameter pId = new OracleParameter();
            pId.ParameterName = ":id";
            pId.OracleDbType = OracleDbType.Long;
            pId.Direction = System.Data.ParameterDirection.Input;
            pId.Value = record.Id;

            OracleParameter pNev = new OracleParameter();
            pNev.ParameterName = ":nev";
            pNev.OracleDbType = OracleDbType.Varchar2;
            pNev.Direction = System.Data.ParameterDirection.Input;
            pNev.Value = record.Nev;

            OracleParameter pBankartyaszam = new OracleParameter();
            pBankartyaszam.ParameterName = ":bankartyaszam";
            pBankartyaszam.OracleDbType = OracleDbType.Varchar2;
            pBankartyaszam.Direction = System.Data.ParameterDirection.Input;
            pBankartyaszam.Value = record.Bankartyaszam;

            OracleParameter pEgyenleg = new OracleParameter();
            pEgyenleg.ParameterName = ":egyenleg";
            pEgyenleg.OracleDbType = OracleDbType.Long;
            pEgyenleg.Direction = System.Data.ParameterDirection.Input;
            pEgyenleg.Value = record.Egyenleg;

            p.Parameters.Add(pId);
            p.Parameters.Add(pNev);
            p.Parameters.Add(pBankartyaszam);
            p.Parameters.Add(pEgyenleg);

            return p.ExecuteNonQuery();


        }

        public int Delete(Record record)
        {
            OracleCommand parancs = new OracleCommand();
            parancs.Connection = getConnection();
            parancs.CommandType = System.Data.CommandType.Text;
            parancs.CommandText = "DELETE FROM szamlak WHERE id = :id";

            OracleParameter pId = new OracleParameter();
            pId.ParameterName = ":id";
            pId.OracleDbType = OracleDbType.Long;
            pId.Direction = System.Data.ParameterDirection.Input;

            pId.Value = record.Id;

            parancs.Parameters.Add(pId);

            return parancs.ExecuteNonQuery();
        }

        public List<Record> Select()
        {
            List<Record> szamlak = new List<Record>();

            OracleCommand parancs = new OracleCommand();

            parancs.Connection = getConnection();
            parancs.CommandType = System.Data.CommandType.Text;
            parancs.CommandText = @"SELECT id, nev, bankartyaszam, egyenleg FROM szamlak ORDER BY nev";
            OracleDataReader reader = parancs.ExecuteReader();
            while (reader.Read())
            {
                Record ujRecord = new Record();
                ujRecord.Id = int.Parse(reader["id"].ToString());
                ujRecord.Nev = reader["nev"].ToString();
                ujRecord.Bankartyaszam = reader["bankartyaszam"].ToString();
                ujRecord.Egyenleg = int.Parse(reader["egyenleg"].ToString());

                szamlak.Add(ujRecord);

            }
            reader.Close();
            return szamlak;

        }









    }
}
