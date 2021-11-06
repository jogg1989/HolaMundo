
namespace HolaMundo
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.lblText1 = new System.Windows.Forms.Label();
            this.lblText2 = new System.Windows.Forms.Label();
            this.tbPw1 = new System.Windows.Forms.TextBox();
            this.tbPw2 = new System.Windows.Forms.TextBox();
            this.btnValidate = new System.Windows.Forms.Button();
            this.cbView1 = new System.Windows.Forms.CheckBox();
            this.cbView2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblText1
            // 
            this.lblText1.AutoSize = true;
            this.lblText1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblText1.Location = new System.Drawing.Point(108, 35);
            this.lblText1.Name = "lblText1";
            this.lblText1.Size = new System.Drawing.Size(132, 38);
            this.lblText1.TabIndex = 0;
            this.lblText1.Text = "Password";
            // 
            // lblText2
            // 
            this.lblText2.AutoSize = true;
            this.lblText2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblText2.Location = new System.Drawing.Point(12, 108);
            this.lblText2.Name = "lblText2";
            this.lblText2.Size = new System.Drawing.Size(228, 38);
            this.lblText2.TabIndex = 1;
            this.lblText2.Text = "Repetir Password";
            // 
            // tbPw1
            // 
            this.tbPw1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPw1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.tbPw1.Location = new System.Drawing.Point(246, 32);
            this.tbPw1.Name = "tbPw1";
            this.tbPw1.Size = new System.Drawing.Size(813, 45);
            this.tbPw1.TabIndex = 2;
            // 
            // tbPw2
            // 
            this.tbPw2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPw2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.tbPw2.Location = new System.Drawing.Point(246, 101);
            this.tbPw2.Name = "tbPw2";
            this.tbPw2.Size = new System.Drawing.Size(813, 45);
            this.tbPw2.TabIndex = 3;
            // 
            // btnValidate
            // 
            this.btnValidate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnValidate.AutoSize = true;
            this.btnValidate.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnValidate.Location = new System.Drawing.Point(527, 188);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(187, 65);
            this.btnValidate.TabIndex = 4;
            this.btnValidate.Text = "Validar";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // cbView1
            // 
            this.cbView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbView1.AutoSize = true;
            this.cbView1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cbView1.Location = new System.Drawing.Point(1100, 35);
            this.cbView1.Name = "cbView1";
            this.cbView1.Size = new System.Drawing.Size(83, 42);
            this.cbView1.TabIndex = 5;
            this.cbView1.Text = "Ver";
            this.cbView1.UseVisualStyleBackColor = true;
            this.cbView1.CheckedChanged += new System.EventHandler(this.cbView1_CheckedChanged);
            // 
            // cbView2
            // 
            this.cbView2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbView2.AutoSize = true;
            this.cbView2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cbView2.Location = new System.Drawing.Point(1100, 104);
            this.cbView2.Name = "cbView2";
            this.cbView2.Size = new System.Drawing.Size(83, 42);
            this.cbView2.TabIndex = 6;
            this.cbView2.Text = "Ver";
            this.cbView2.UseVisualStyleBackColor = true;
            this.cbView2.CheckedChanged += new System.EventHandler(this.cbView2_CheckedChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1231, 265);
            this.Controls.Add(this.cbView2);
            this.Controls.Add(this.cbView1);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.tbPw2);
            this.Controls.Add(this.tbPw1);
            this.Controls.Add(this.lblText2);
            this.Controls.Add(this.lblText1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "¡Hola Mundo!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText1;
        private System.Windows.Forms.Label lblText2;
        private System.Windows.Forms.TextBox tbPw1;
        private System.Windows.Forms.TextBox tbPw2;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.CheckBox cbView1;
        private System.Windows.Forms.CheckBox cbView2;
    }
}

