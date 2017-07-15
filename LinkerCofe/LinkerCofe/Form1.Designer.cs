namespace LinkerCofe
{
    partial class frmWelcome
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
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnCashier = new System.Windows.Forms.Button();
            this.btnChief = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackgroundImage = global::LinkerCofe.Properties.Resources.Button_1_01;
            this.btnCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCustomer.Location = new System.Drawing.Point(298, 328);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(91, 90);
            this.btnCustomer.TabIndex = 3;
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnCashier
            // 
            this.btnCashier.BackgroundImage = global::LinkerCofe.Properties.Resources.Button_2_01;
            this.btnCashier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCashier.Location = new System.Drawing.Point(403, 328);
            this.btnCashier.Name = "btnCashier";
            this.btnCashier.Size = new System.Drawing.Size(91, 90);
            this.btnCashier.TabIndex = 3;
            this.btnCashier.UseVisualStyleBackColor = true;
            this.btnCashier.Click += new System.EventHandler(this.btnCashier_Click);
            // 
            // btnChief
            // 
            this.btnChief.BackgroundImage = global::LinkerCofe.Properties.Resources.Button_3_01;
            this.btnChief.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChief.Location = new System.Drawing.Point(508, 328);
            this.btnChief.Name = "btnChief";
            this.btnChief.Size = new System.Drawing.Size(91, 90);
            this.btnChief.TabIndex = 3;
            this.btnChief.UseVisualStyleBackColor = true;
            this.btnChief.Click += new System.EventHandler(this.btnChief_Click);
            // 
            // frmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImage = global::LinkerCofe.Properties.Resources.Loading_01;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.btnChief);
            this.Controls.Add(this.btnCashier);
            this.Controls.Add(this.btnCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(900, 550);
            this.MinimumSize = new System.Drawing.Size(900, 550);
            this.Name = "frmWelcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnCashier;
        private System.Windows.Forms.Button btnChief;
    }
}

