namespace Crud3CamadasFormSqlServer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_pesquisa = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_codigo = new System.Windows.Forms.TextBox();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.grade_bairros = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grade_bairros)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formulario para Esninar CRUD em 3 Camadas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pesquisa:";
            // 
            // tb_pesquisa
            // 
            this.tb_pesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_pesquisa.Location = new System.Drawing.Point(120, 70);
            this.tb_pesquisa.Name = "tb_pesquisa";
            this.tb_pesquisa.Size = new System.Drawing.Size(248, 20);
            this.tb_pesquisa.TabIndex = 2;
            this.tb_pesquisa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(399, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "COD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nome: ";
            // 
            // tb_codigo
            // 
            this.tb_codigo.Location = new System.Drawing.Point(120, 105);
            this.tb_codigo.Name = "tb_codigo";
            this.tb_codigo.Size = new System.Drawing.Size(248, 20);
            this.tb_codigo.TabIndex = 6;
            // 
            // tb_descricao
            // 
            this.tb_descricao.Location = new System.Drawing.Point(120, 140);
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.Size = new System.Drawing.Size(248, 20);
            this.tb_descricao.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(54, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Novo Registro";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(155, 199);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Gravar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(258, 198);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Excluir";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(354, 198);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "Alterar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // grade_bairros
            // 
            this.grade_bairros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade_bairros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grade_bairros.Location = new System.Drawing.Point(54, 247);
            this.grade_bairros.Name = "grade_bairros";
            this.grade_bairros.Size = new System.Drawing.Size(375, 150);
            this.grade_bairros.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 460);
            this.Controls.Add(this.grade_bairros);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tb_descricao);
            this.Controls.Add(this.tb_codigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_pesquisa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Formulario para Esninar CRUD em 3 Camadas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grade_bairros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_pesquisa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_codigo;
        private System.Windows.Forms.TextBox tb_descricao;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView grade_bairros;
    }
}

