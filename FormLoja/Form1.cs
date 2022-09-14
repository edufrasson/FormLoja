using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLoja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            dgvProdutos.RowCount = 0;

            ofdProdutos.FileName = "";
            ofdProdutos.ShowDialog();

            StreamReader arquivo = File.OpenText(ofdProdutos.FileName);

            String linha;

            while((linha = arquivo.ReadLine()) != null)
            {
                string[] data = linha.Split(';');
                dgvProdutos.Rows.Add(false, data[0], data[1], data[2], data[3], data[4], data[5]);
            }
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProdutos.Rows.Count > 0 && e.ColumnIndex == 0)
            {
                if (Convert.ToBoolean(dgvProdutos.CurrentRow.Cells[0].Value) == false)
                {
                    dgvProdutos.CurrentRow.Cells[0].Value = true;
                    
                }
                else
                {
                    dgvProdutos.CurrentRow.Cells[0].Value = false;
                }
            }         
                       
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            double porcentagem = double.Parse(txtPorcentagem.Text) / 100;

            foreach(DataGridViewRow row in dgvProdutos.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                { 
                    row.Cells[5].Value = Convert.ToDouble(row.Cells[5].Value) + (Convert.ToDouble(row.Cells[5].Value) * porcentagem);
               
                    if (Convert.ToDouble(row.Cells[5].Value) < Convert.ToDouble(row.Cells[4].Value))
                        row.DefaultCellStyle.ForeColor = Color.Red;
                    else
                        row.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }

        private void btnMarcarTodos_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvProdutos.Rows)
                row.Cells[0].Value = true;
        }

        private void btnDesmarcarTodos_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvProdutos.Rows)
                row.Cells[0].Value = false;
        }

        private void btnExcluirSelecionados_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvProdutos.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    dgvProdutos.Rows.RemoveAt(row.Index);
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            dgvProdutos.Rows.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
