using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace wpf_arquivos.txt
{
    public partial class frmPrincipal : Form
    {
        double total = 0, selecao = 0;

        public frmPrincipal()
        {
            InitializeComponent();

            // Criando as colunas e definindo seu tipo respectivamente 
            dgv_arquivo.Columns.Insert(0, new DataGridViewCheckBoxColumn());
            dgv_arquivo.Columns.Insert(1, new DataGridViewTextBoxColumn());
            dgv_arquivo.Columns.Insert(2, new DataGridViewTextBoxColumn());
            dgv_arquivo.Columns.Insert(3, new DataGridViewTextBoxColumn());

            // Renomeando as colunas
            dgv_arquivo.Columns[0].Name = "OK";
            dgv_arquivo.Columns[1].Name = "CODIGO";
            dgv_arquivo.Columns[2].Name = "DESCRICAO";
            dgv_arquivo.Columns[3].Name = "VALOR";

            // Configurando a DataGridView
            dgv_arquivo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv_arquivo.ReadOnly = true;
            dgv_arquivo.AllowUserToAddRows = false;
            dgv_arquivo.AllowUserToDeleteRows = false;
            dgv_arquivo.AllowUserToOrderColumns = true;

            // Configurando a coluna de valor e formatando a linha
            dgv_arquivo.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_arquivo.Columns[3].DefaultCellStyle.Format = "###,###,##0.00";
        }

        private void btn_importar_Click(object sender, EventArgs e)
        {
            dgv_arquivo.RowCount = 0;

            ofd_arquivo.FileName = "";
            ofd_arquivo.ShowDialog();
            StreamReader arq = File.OpenText(ofd_arquivo.FileName);
            string linha;

            while((linha = arq.ReadLine()) != null)
            {
                string[] dados = linha.Split(';');
                string codigo = dados[0];
                string descricao = dados[1];
                double valor = double.Parse(dados[2]);

                dgv_arquivo.Rows.Add(false, codigo, descricao, valor);
                total += valor;
            }

            lbl_info.Text = $"Total: {total.ToString("C")} | Selecão: {selecao.ToString("C")}";
        }

        private void btn_marcar_todos_Click(object sender, EventArgs e)
        {
            selecao = 0;
            foreach(DataGridViewRow l in dgv_arquivo.Rows)
            {
                l.Cells[0].Value = true;
                selecao += Convert.ToDouble(l.Cells[3].Value);
            }
            lbl_info.Text = lbl_info.Text = $"Total: {total.ToString("C")} | Selecão: {selecao.ToString("C")}";
        }

        private void btn_desmarcar_todos_Click(object sender, EventArgs e)
        {
            selecao = 0;
            foreach (DataGridViewRow l in dgv_arquivo.Rows)
                l.Cells[0].Value = false;
            lbl_info.Text = $"Total: {total.ToString("C")} | Selecão: {selecao.ToString("C")}";
        }

        private void btn_baixar_selecionado_Click(object sender, EventArgs e)
        {
            for (int i = dgv_arquivo.RowCount - 1; i >= 0; i--)
            {
                if (Convert.ToBoolean(dgv_arquivo.Rows[i].Cells[0].Value) == true)
                {
                    selecao -= Convert.ToDouble(dgv_arquivo.Rows[i].Cells[3].Value);
                    total -= Convert.ToDouble(dgv_arquivo.Rows[i].Cells[3].Value);
                    dgv_arquivo.Rows.Remove(dgv_arquivo.Rows[i]);
                }
            }

            lbl_info.Text = $"Total: {total.ToString("C")} | Selecão: {selecao.ToString("C")}";
        }

        private void dgv_arquivo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_arquivo.RowCount > 0 && e.ColumnIndex == 0)
            {
                if (Convert.ToBoolean(dgv_arquivo.CurrentRow.Cells[0].Value) == false)
                {
                    dgv_arquivo.CurrentRow.Cells[0].Value = true;
                    selecao += Convert.ToDouble(dgv_arquivo.CurrentRow.Cells[3].Value);

                } else
                {
                    dgv_arquivo.CurrentRow.Cells[0].Value = false;
                    selecao -= Convert.ToDouble(dgv_arquivo.CurrentRow.Cells[3].Value);
                }
                lbl_info.Text = $"Total: {total.ToString("C")} | Selecão: {selecao.ToString("C")}";
            }
        }
    }
}
