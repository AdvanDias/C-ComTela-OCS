
namespace Formulario
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
            this.tb_Codigo = new System.Windows.Forms.TextBox();
            this.lb_Codigo = new System.Windows.Forms.Label();
            this.lb_produto = new System.Windows.Forms.Label();
            this.lb_Qntd = new System.Windows.Forms.Label();
            this.tb_Produto = new System.Windows.Forms.TextBox();
            this.tb_Qntd = new System.Windows.Forms.TextBox();
            this.btn_Consultar = new System.Windows.Forms.Button();
            this.btn_Cadastra = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.lb_info = new System.Windows.Forms.Label();
            this.tb_OCSS = new System.Windows.Forms.TextBox();
            this.btn_OCS = new System.Windows.Forms.Button();
            this.btn_incluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_Codigo
            // 
            this.tb_Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Codigo.Location = new System.Drawing.Point(12, 48);
            this.tb_Codigo.Name = "tb_Codigo";
            this.tb_Codigo.Size = new System.Drawing.Size(124, 26);
            this.tb_Codigo.TabIndex = 2;
            // 
            // lb_Codigo
            // 
            this.lb_Codigo.AutoSize = true;
            this.lb_Codigo.Location = new System.Drawing.Point(12, 18);
            this.lb_Codigo.Name = "lb_Codigo";
            this.lb_Codigo.Size = new System.Drawing.Size(40, 13);
            this.lb_Codigo.TabIndex = 3;
            this.lb_Codigo.Text = "Codigo";
            // 
            // lb_produto
            // 
            this.lb_produto.AutoSize = true;
            this.lb_produto.Location = new System.Drawing.Point(162, 18);
            this.lb_produto.Name = "lb_produto";
            this.lb_produto.Size = new System.Drawing.Size(44, 13);
            this.lb_produto.TabIndex = 4;
            this.lb_produto.Text = "Produto";
            // 
            // lb_Qntd
            // 
            this.lb_Qntd.AutoSize = true;
            this.lb_Qntd.Location = new System.Drawing.Point(9, 88);
            this.lb_Qntd.Name = "lb_Qntd";
            this.lb_Qntd.Size = new System.Drawing.Size(30, 13);
            this.lb_Qntd.TabIndex = 5;
            this.lb_Qntd.Text = "Qntd";
            // 
            // tb_Produto
            // 
            this.tb_Produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Produto.Location = new System.Drawing.Point(165, 48);
            this.tb_Produto.Name = "tb_Produto";
            this.tb_Produto.Size = new System.Drawing.Size(244, 26);
            this.tb_Produto.TabIndex = 6;
            // 
            // tb_Qntd
            // 
            this.tb_Qntd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Qntd.Location = new System.Drawing.Point(12, 113);
            this.tb_Qntd.Name = "tb_Qntd";
            this.tb_Qntd.Size = new System.Drawing.Size(124, 26);
            this.tb_Qntd.TabIndex = 7;
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.Location = new System.Drawing.Point(12, 191);
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Size = new System.Drawing.Size(121, 35);
            this.btn_Consultar.TabIndex = 8;
            this.btn_Consultar.Text = "Consultar";
            this.btn_Consultar.UseVisualStyleBackColor = true;
            this.btn_Consultar.Click += new System.EventHandler(this.btn_Consultar_Click);
            // 
            // btn_Cadastra
            // 
            this.btn_Cadastra.Location = new System.Drawing.Point(165, 191);
            this.btn_Cadastra.Name = "btn_Cadastra";
            this.btn_Cadastra.Size = new System.Drawing.Size(121, 35);
            this.btn_Cadastra.TabIndex = 9;
            this.btn_Cadastra.Text = "Cadastrar";
            this.btn_Cadastra.UseVisualStyleBackColor = true;
            this.btn_Cadastra.Click += new System.EventHandler(this.btn_Cadastra_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Location = new System.Drawing.Point(316, 191);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(121, 35);
            this.btn_Alterar.TabIndex = 10;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = true;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // lb_info
            // 
            this.lb_info.AutoSize = true;
            this.lb_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_info.Location = new System.Drawing.Point(180, 116);
            this.lb_info.Name = "lb_info";
            this.lb_info.Size = new System.Drawing.Size(148, 20);
            this.lb_info.TabIndex = 11;
            this.lb_info.Text = "Informação do Item";
            // 
            // tb_OCSS
            // 
            this.tb_OCSS.Location = new System.Drawing.Point(483, 34);
            this.tb_OCSS.Multiline = true;
            this.tb_OCSS.Name = "tb_OCSS";
            this.tb_OCSS.Size = new System.Drawing.Size(294, 321);
            this.tb_OCSS.TabIndex = 12;
            // 
            // btn_OCS
            // 
            this.btn_OCS.Location = new System.Drawing.Point(483, 373);
            this.btn_OCS.Name = "btn_OCS";
            this.btn_OCS.Size = new System.Drawing.Size(141, 46);
            this.btn_OCS.TabIndex = 13;
            this.btn_OCS.Text = "Converter txt";
            this.btn_OCS.UseVisualStyleBackColor = true;
            this.btn_OCS.Click += new System.EventHandler(this.btn_OCS_Click);
            // 
            // btn_incluir
            // 
            this.btn_incluir.Location = new System.Drawing.Point(644, 371);
            this.btn_incluir.Name = "btn_incluir";
            this.btn_incluir.Size = new System.Drawing.Size(132, 47);
            this.btn_incluir.TabIndex = 14;
            this.btn_incluir.Text = "Incluir";
            this.btn_incluir.UseVisualStyleBackColor = true;
            this.btn_incluir.Click += new System.EventHandler(this.btn_incluir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_incluir);
            this.Controls.Add(this.btn_OCS);
            this.Controls.Add(this.tb_OCSS);
            this.Controls.Add(this.lb_info);
            this.Controls.Add(this.btn_Alterar);
            this.Controls.Add(this.btn_Cadastra);
            this.Controls.Add(this.btn_Consultar);
            this.Controls.Add(this.tb_Qntd);
            this.Controls.Add(this.tb_Produto);
            this.Controls.Add(this.lb_Qntd);
            this.Controls.Add(this.lb_produto);
            this.Controls.Add(this.lb_Codigo);
            this.Controls.Add(this.tb_Codigo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_Codigo;
        private System.Windows.Forms.Label lb_Codigo;
        private System.Windows.Forms.Label lb_produto;
        private System.Windows.Forms.Label lb_Qntd;
        private System.Windows.Forms.TextBox tb_Produto;
        private System.Windows.Forms.TextBox tb_Qntd;
        private System.Windows.Forms.Button btn_Consultar;
        private System.Windows.Forms.Button btn_Cadastra;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Label lb_info;
        private System.Windows.Forms.TextBox tb_OCSS;
        private System.Windows.Forms.Button btn_OCS;
        private System.Windows.Forms.Button btn_incluir;
    }
}

