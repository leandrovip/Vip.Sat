namespace Vip.Sat.Demo
{
    partial class frmPrincipal
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
            this.btnGerarCFe = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnEnviarCFe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGerarCFe
            // 
            this.btnGerarCFe.Location = new System.Drawing.Point(12, 12);
            this.btnGerarCFe.Name = "btnGerarCFe";
            this.btnGerarCFe.Size = new System.Drawing.Size(105, 44);
            this.btnGerarCFe.TabIndex = 0;
            this.btnGerarCFe.Text = "Gerar CFe";
            this.btnGerarCFe.UseVisualStyleBackColor = true;
            this.btnGerarCFe.Click += new System.EventHandler(this.btnGerarCFe_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 282);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(753, 198);
            this.webBrowser1.TabIndex = 1;
            // 
            // btnEnviarCFe
            // 
            this.btnEnviarCFe.Location = new System.Drawing.Point(123, 12);
            this.btnEnviarCFe.Name = "btnEnviarCFe";
            this.btnEnviarCFe.Size = new System.Drawing.Size(105, 44);
            this.btnEnviarCFe.TabIndex = 0;
            this.btnEnviarCFe.Text = "Enviar CFe";
            this.btnEnviarCFe.UseVisualStyleBackColor = true;
            this.btnEnviarCFe.Click += new System.EventHandler(this.btnEnviarCFe_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(777, 492);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btnEnviarCFe);
            this.Controls.Add(this.btnGerarCFe);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vip.Sat - Biblioteca para emissão de Cupom Fiscal Eletrônico";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGerarCFe;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnEnviarCFe;
    }
}

