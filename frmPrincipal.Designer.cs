namespace wpf_arquivos.txt
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_importar = new System.Windows.Forms.Button();
            this.btn_marcar_todos = new System.Windows.Forms.Button();
            this.btn_desmarcar_todos = new System.Windows.Forms.Button();
            this.dgv_arquivo = new System.Windows.Forms.DataGridView();
            this.btn_baixar_selecionado = new System.Windows.Forms.Button();
            this.lbl_info = new System.Windows.Forms.Label();
            this.ofd_arquivo = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_arquivo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_importar
            // 
            this.btn_importar.Location = new System.Drawing.Point(12, 12);
            this.btn_importar.Name = "btn_importar";
            this.btn_importar.Size = new System.Drawing.Size(151, 48);
            this.btn_importar.TabIndex = 0;
            this.btn_importar.Text = "Importar Arquivos";
            this.btn_importar.UseVisualStyleBackColor = true;
            this.btn_importar.Click += new System.EventHandler(this.btn_importar_Click);
            // 
            // btn_marcar_todos
            // 
            this.btn_marcar_todos.Location = new System.Drawing.Point(664, 12);
            this.btn_marcar_todos.Name = "btn_marcar_todos";
            this.btn_marcar_todos.Size = new System.Drawing.Size(151, 48);
            this.btn_marcar_todos.TabIndex = 1;
            this.btn_marcar_todos.Text = "Marcar Todos";
            this.btn_marcar_todos.UseVisualStyleBackColor = true;
            this.btn_marcar_todos.Click += new System.EventHandler(this.btn_marcar_todos_Click);
            // 
            // btn_desmarcar_todos
            // 
            this.btn_desmarcar_todos.Location = new System.Drawing.Point(821, 12);
            this.btn_desmarcar_todos.Name = "btn_desmarcar_todos";
            this.btn_desmarcar_todos.Size = new System.Drawing.Size(151, 48);
            this.btn_desmarcar_todos.TabIndex = 2;
            this.btn_desmarcar_todos.Text = "Desmarcar Todos";
            this.btn_desmarcar_todos.UseVisualStyleBackColor = true;
            this.btn_desmarcar_todos.Click += new System.EventHandler(this.btn_desmarcar_todos_Click);
            // 
            // dgv_arquivo
            // 
            this.dgv_arquivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_arquivo.Location = new System.Drawing.Point(12, 66);
            this.dgv_arquivo.Name = "dgv_arquivo";
            this.dgv_arquivo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_arquivo.Size = new System.Drawing.Size(960, 411);
            this.dgv_arquivo.TabIndex = 3;
            this.dgv_arquivo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_arquivo_CellClick);
            // 
            // btn_baixar_selecionado
            // 
            this.btn_baixar_selecionado.Location = new System.Drawing.Point(821, 483);
            this.btn_baixar_selecionado.Name = "btn_baixar_selecionado";
            this.btn_baixar_selecionado.Size = new System.Drawing.Size(151, 48);
            this.btn_baixar_selecionado.TabIndex = 4;
            this.btn_baixar_selecionado.Text = "Baixar Selecionado";
            this.btn_baixar_selecionado.UseVisualStyleBackColor = true;
            this.btn_baixar_selecionado.Click += new System.EventHandler(this.btn_baixar_selecionado_Click);
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.Location = new System.Drawing.Point(6, 493);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(452, 31);
            this.lbl_info.TabIndex = 5;
            this.lbl_info.Text = "Total: R$ 00,00 | Selecão: R$: 00,00";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 538);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.btn_baixar_selecionado);
            this.Controls.Add(this.dgv_arquivo);
            this.Controls.Add(this.btn_desmarcar_todos);
            this.Controls.Add(this.btn_marcar_todos);
            this.Controls.Add(this.btn_importar);
            this.Name = "frmPrincipal";
            this.Text = "Arquivos";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_arquivo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_importar;
        private System.Windows.Forms.Button btn_marcar_todos;
        private System.Windows.Forms.Button btn_desmarcar_todos;
        private System.Windows.Forms.DataGridView dgv_arquivo;
        private System.Windows.Forms.Button btn_baixar_selecionado;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.OpenFileDialog ofd_arquivo;
    }
}

