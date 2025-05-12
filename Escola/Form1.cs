using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Dapper;

namespace Escola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var connection = new MySqlConnection(LigacaoDB.GetConnectionString()))
            {
                int n = connection.ExecuteScalar<int>("SELECT COUNT(*) FROM alunos");
                NumeroRegistos.Text = $"{n} alunos";
            }
        }
    }
}
