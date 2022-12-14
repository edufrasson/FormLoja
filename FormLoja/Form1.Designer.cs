namespace FormLoja
{
    partial class Form1
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
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.colCheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnMarcarTodos = new System.Windows.Forms.Button();
            this.btnDesmarcarTodos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPorcentagem = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.ofdProdutos = new System.Windows.Forms.OpenFileDialog();
            this.btnExcluirSelecionados = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToOrderColumns = true;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCheckBox,
            this.colId,
            this.colEan,
            this.colNome,
            this.colValorCompra,
            this.colValorVenda,
            this.colEstoque});
            this.dgvProdutos.Location = new System.Drawing.Point(49, 195);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.Size = new System.Drawing.Size(757, 300);
            this.dgvProdutos.TabIndex = 0;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellClick);
            // 
            // colCheckBox
            // 
            this.colCheckBox.HeaderText = "OK";
            this.colCheckBox.Name = "colCheckBox";
            this.colCheckBox.ReadOnly = true;
            this.colCheckBox.Width = 40;
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colEan
            // 
            this.colEan.HeaderText = "EAN";
            this.colEan.Name = "colEan";
            this.colEan.ReadOnly = true;
            // 
            // colNome
            // 
            this.colNome.HeaderText = "Nome Do Produto";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            // 
            // colValorCompra
            // 
            this.colValorCompra.HeaderText = "Valor de Compra";
            this.colValorCompra.Name = "colValorCompra";
            this.colValorCompra.ReadOnly = true;
            // 
            // colValorVenda
            // 
            this.colValorVenda.HeaderText = "Valor de Venda";
            this.colValorVenda.Name = "colValorVenda";
            this.colValorVenda.ReadOnly = true;
            // 
            // colEstoque
            // 
            this.colEstoque.HeaderText = "Estoque";
            this.colEstoque.Name = "colEstoque";
            this.colEstoque.ReadOnly = true;
            // 
            // btnImportar
            // 
            this.btnImportar.BackColor = System.Drawing.Color.Transparent;
            this.btnImportar.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnImportar.FlatAppearance.BorderSize = 4;
            this.btnImportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.btnImportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.btnImportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportar.Location = new System.Drawing.Point(48, 113);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(181, 40);
            this.btnImportar.TabIndex = 1;
            this.btnImportar.Text = "Importar Arquivo";
            this.btnImportar.UseVisualStyleBackColor = false;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnMarcarTodos
            // 
            this.btnMarcarTodos.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnMarcarTodos.FlatAppearance.BorderSize = 4;
            this.btnMarcarTodos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.btnMarcarTodos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.btnMarcarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarcarTodos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcarTodos.Location = new System.Drawing.Point(427, 113);
            this.btnMarcarTodos.Name = "btnMarcarTodos";
            this.btnMarcarTodos.Size = new System.Drawing.Size(130, 40);
            this.btnMarcarTodos.TabIndex = 2;
            this.btnMarcarTodos.Text = "Marcar Todos";
            this.btnMarcarTodos.UseVisualStyleBackColor = true;
            this.btnMarcarTodos.Click += new System.EventHandler(this.btnMarcarTodos_Click);
            // 
            // btnDesmarcarTodos
            // 
            this.btnDesmarcarTodos.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnDesmarcarTodos.FlatAppearance.BorderSize = 4;
            this.btnDesmarcarTodos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.btnDesmarcarTodos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.btnDesmarcarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesmarcarTodos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesmarcarTodos.Location = new System.Drawing.Point(662, 113);
            this.btnDesmarcarTodos.Name = "btnDesmarcarTodos";
            this.btnDesmarcarTodos.Size = new System.Drawing.Size(143, 40);
            this.btnDesmarcarTodos.TabIndex = 3;
            this.btnDesmarcarTodos.Text = "Desmarcar Todos";
            this.btnDesmarcarTodos.UseVisualStyleBackColor = true;
            this.btnDesmarcarTodos.Click += new System.EventHandler(this.btnDesmarcarTodos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 548);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Alteração do Preço (%)";
            // 
            // txtPorcentagem
            // 
            this.txtPorcentagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorcentagem.Location = new System.Drawing.Point(273, 546);
            this.txtPorcentagem.Name = "txtPorcentagem";
            this.txtPorcentagem.Size = new System.Drawing.Size(100, 26);
            this.txtPorcentagem.TabIndex = 5;
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnAlterar.FlatAppearance.BorderSize = 4;
            this.btnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.btnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(427, 538);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAlterar.Size = new System.Drawing.Size(130, 40);
            this.btnAlterar.TabIndex = 6;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnLimpar.FlatAppearance.BorderSize = 4;
            this.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(670, 538);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(135, 40);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar Dados";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnClose.FlatAppearance.BorderSize = 4;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(670, 619);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(135, 40);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Fechar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ofdProdutos
            // 
            this.ofdProdutos.FileName = "openFileDialog";
            // 
            // btnExcluirSelecionados
            // 
            this.btnExcluirSelecionados.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnExcluirSelecionados.FlatAppearance.BorderSize = 4;
            this.btnExcluirSelecionados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.btnExcluirSelecionados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.btnExcluirSelecionados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirSelecionados.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirSelecionados.Location = new System.Drawing.Point(54, 619);
            this.btnExcluirSelecionados.Name = "btnExcluirSelecionados";
            this.btnExcluirSelecionados.Size = new System.Drawing.Size(181, 40);
            this.btnExcluirSelecionados.TabIndex = 9;
            this.btnExcluirSelecionados.Text = "Excluir Selecionados";
            this.btnExcluirSelecionados.UseVisualStyleBackColor = true;
            this.btnExcluirSelecionados.Click += new System.EventHandler(this.btnExcluirSelecionados_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-4, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 77);
            this.panel1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(51, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Form Loja";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(873, 686);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExcluirSelecionados);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.txtPorcentagem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDesmarcarTodos);
            this.Controls.Add(this.btnMarcarTodos);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.dgvProdutos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnMarcarTodos;
        private System.Windows.Forms.Button btnDesmarcarTodos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPorcentagem;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.OpenFileDialog ofdProdutos;
        private System.Windows.Forms.Button btnExcluirSelecionados;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstoque;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}

