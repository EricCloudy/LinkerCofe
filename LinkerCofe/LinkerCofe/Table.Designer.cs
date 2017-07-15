namespace LinkerCofe
{
    partial class Table
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
            this.combTableNum = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btChoose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // combTableNum
            // 
            this.combTableNum.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.combTableNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combTableNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combTableNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.combTableNum.FormattingEnabled = true;
            this.combTableNum.Location = new System.Drawing.Point(139, 51);
            this.combTableNum.Name = "combTableNum";
            this.combTableNum.Size = new System.Drawing.Size(96, 26);
            this.combTableNum.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(135, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "TABLE";
            // 
            // btChoose
            // 
            this.btChoose.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChoose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btChoose.Location = new System.Drawing.Point(139, 86);
            this.btChoose.Name = "btChoose";
            this.btChoose.Size = new System.Drawing.Size(75, 26);
            this.btChoose.TabIndex = 2;
            this.btChoose.Text = "Choose";
            this.btChoose.UseVisualStyleBackColor = true;
            this.btChoose.Click += new System.EventHandler(this.btChoose_Click);
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackgroundImage = global::LinkerCofe.Properties.Resources.Linker_Cofe;
            this.ClientSize = new System.Drawing.Size(286, 142);
            this.Controls.Add(this.btChoose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combTableNum);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "Table";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table";
            this.Load += new System.EventHandler(this.Table_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btChoose;
        internal string table;
        public System.Windows.Forms.ComboBox combTableNum;
    }
}