using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;

namespace Menaxhuesi_i_Artikujve
{
    class lidhjadb
    {
        private OleDbDataAdapter adapteri;
        private OleDbConnection konektimi;
        private DataTable tabela;
        private string kyqja = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=artikujt.accdb;Jet OLEDB:Database Password=trimi12345";

        public void komando(string sqlkomanda)
        {
            try
            {
                using (konektimi = new OleDbConnection())
                {
                    konektimi.ConnectionString = kyqja;
                    konektimi.Open();
                    using (adapteri = new OleDbDataAdapter(sqlkomanda, konektimi))
                    {
                        tabela = new DataTable();
                        adapteri.Fill(tabela);
                    }
                }
                konektimi.Close();
                konektimi.Dispose();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Gabim!\nErrori: " + ex.Message);
            }
        }
        
        public DataTable ktheTabela()
        {
            return tabela;
        }
    }
}
