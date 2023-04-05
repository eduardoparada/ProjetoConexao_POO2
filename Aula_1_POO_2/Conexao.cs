using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Linq.Expressions;





namespace Aula_1_POO_2
{
    internal class Conexao
    {
        static private string servidor = "localhost";
        static private string banco = "bd_aula3";
        static private string usuario = "root";
        static private string senha = "Armazem@94";
        static public string strConn = $"server{servidor};" + $"database ={banco}; User Id={usuario};"
            + $"password={senha}";

        MySqlConnection cn;




        private bool Conectar() ////descomentar após instalação do MYSQL.Data nuget
        {
            bool result;
            try
            {
                cn = new MySqlConnection(strConn);
                cn.Open();
                result = true;
            }
            catch
            {
                result = false;
            }
            return result;
        }
        private void Desconectar()
        {
            if (cn.State == System.Data.ConnectionState.Open)
            {
                cn.Close();

            }
        }
        public bool Executar(string sql)
        {
            bool resultado = false;
            if (Conectar())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(sql, cn);
                    cmd.ExecuteNonQuery();
                    resultado = true;
                }
                catch 
                {
                    resultado = false;
                }
                finally
                {
                    Desconectar();
                }
            }
            return resultado;
        }
        public DataTable Retorna(string sql)
        {
            Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, cn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable data = new DataTable();
                da.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            { 
                Desconectar();
            }
    }
    } 
}

    

