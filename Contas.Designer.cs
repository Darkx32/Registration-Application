namespace System_Application
{
    partial class Contas
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnRegister = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnTools = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnRegister
            // 
            this.BtnRegister.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnRegister.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnRegister.FlatAppearance.BorderSize = 0;
            this.BtnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegister.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnRegister.ForeColor = System.Drawing.Color.White;
            this.BtnRegister.Location = new System.Drawing.Point(12, 40);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(150, 51);
            this.BtnRegister.TabIndex = 0;
            this.BtnRegister.Text = "Cadastrar";
            this.BtnRegister.UseVisualStyleBackColor = false;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Mono", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(168, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Esse butão abre uma janela de cadastro. \r\nPodendo adicionar novos usuários ao pro" +
    "grama.\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Mono", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(168, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(465, 52);
            this.label3.TabIndex = 5;
            this.label3.Text = "Esse butão te dá acesso a várias ferramentas para editar, \r\nolhar, mexer, informa" +
    "r, etc. \r\nSobre algum cliente registrado no programa.\r\n\r\n";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(2, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(747, 2);
            this.label4.TabIndex = 4;
            // 
            // BtnTools
            // 
            this.BtnTools.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnTools.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnTools.FlatAppearance.BorderSize = 0;
            this.BtnTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTools.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnTools.ForeColor = System.Drawing.Color.White;
            this.BtnTools.Location = new System.Drawing.Point(12, 113);
            this.BtnTools.Name = "BtnTools";
            this.BtnTools.Size = new System.Drawing.Size(150, 51);
            this.BtnTools.TabIndex = 3;
            this.BtnTools.Text = "Ferrementas";
            this.BtnTools.UseVisualStyleBackColor = false;
            this.BtnTools.Click += new System.EventHandler(this.BtnTools_Click);
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(747, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "Contas";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Contas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnTools);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnRegister);
            this.Name = "Contas";
            this.Size = new System.Drawing.Size(747, 568);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnRegister;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button BtnTools;
        private Label label5;
    }
}
