namespace System_Application.src.CustonsWindows
{
    partial class MessageBoxCustom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageBoxCustom));
            this.LbText = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnYes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbText
            // 
            resources.ApplyResources(this.LbText, "LbText");
            this.LbText.ForeColor = System.Drawing.Color.White;
            this.LbText.Name = "LbText";
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            resources.ApplyResources(this.BtnCancel, "BtnCancel");
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnYes
            // 
            this.BtnYes.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnYes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            resources.ApplyResources(this.BtnYes, "BtnYes");
            this.BtnYes.ForeColor = System.Drawing.Color.White;
            this.BtnYes.Name = "BtnYes";
            this.BtnYes.UseVisualStyleBackColor = false;
            this.BtnYes.Click += new System.EventHandler(this.BtnYes_Click);
            // 
            // MessageBoxCustom
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.Controls.Add(this.BtnYes);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.LbText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MessageBoxCustom";
            this.ResumeLayout(false);

        }

        #endregion

        private Label LbText;
        private Button BtnCancel;
        private Button BtnYes;
    }
}