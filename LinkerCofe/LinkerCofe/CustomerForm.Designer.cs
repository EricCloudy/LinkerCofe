namespace LinkerCofe
{
    partial class CustomerForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Coffee = new System.Windows.Forms.TabPage();
            this.SoftDrink = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Food = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.Coffee);
            this.tabControl1.Controls.Add(this.SoftDrink);
            this.tabControl1.Controls.Add(this.Food);
            this.tabControl1.Location = new System.Drawing.Point(13, 104);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(538, 394);
            this.tabControl1.TabIndex = 0;
            // 
            // Coffee
            // 
            this.Coffee.Location = new System.Drawing.Point(4, 30);
            this.Coffee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Coffee.Name = "Coffee";
            this.Coffee.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Coffee.Size = new System.Drawing.Size(530, 360);
            this.Coffee.TabIndex = 0;
            this.Coffee.Text = "Coffee";
            this.Coffee.UseVisualStyleBackColor = true;
            // 
            // SoftDrink
            // 
            this.SoftDrink.Location = new System.Drawing.Point(4, 30);
            this.SoftDrink.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SoftDrink.Name = "SoftDrink";
            this.SoftDrink.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SoftDrink.Size = new System.Drawing.Size(530, 360);
            this.SoftDrink.TabIndex = 1;
            this.SoftDrink.Text = "Soft Drink";
            this.SoftDrink.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(559, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(313, 319);
            this.dataGridView1.TabIndex = 1;
            // 
            // Food
            // 
            this.Food.Location = new System.Drawing.Point(4, 30);
            this.Food.Name = "Food";
            this.Food.Padding = new System.Windows.Forms.Padding(3);
            this.Food.Size = new System.Drawing.Size(530, 360);
            this.Food.TabIndex = 2;
            this.Food.Text = "Food";
            this.Food.UseVisualStyleBackColor = true;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(900, 550);
            this.MinimumSize = new System.Drawing.Size(900, 550);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Coffee;
        private System.Windows.Forms.TabPage SoftDrink;
        private System.Windows.Forms.TabPage Food;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}