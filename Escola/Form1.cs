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
        /// <summary>Dados dos alunos. </summary>
        private List<Aluno> Alunos;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Inicializar a ListView
            ListaAlunos.View = View.Details;
            ListaAlunos.FullRowSelect = true;
            ListaAlunos.Columns.Add("Processo", 60, HorizontalAlignment.Left);
            ListaAlunos.Columns.Add("Número", 50, HorizontalAlignment.Left);
            ListaAlunos.Columns.Add("Nome", 120, HorizontalAlignment.Left);
            ListaAlunos.Columns.Add("Data Nascimento", -2, HorizontalAlignment.Left);

            Inicializar();
        }
        private void Inicializar()
        {

            using (var connection = new MySqlConnection(LigacaoDB.GetConnectionString()))
            {
                int n = connection.ExecuteScalar<int>("SELECT COUNT(*) FROM alunos");
                NumeroRegistos.Text = $"{n} alunos";
            }   
        }
    }
}
