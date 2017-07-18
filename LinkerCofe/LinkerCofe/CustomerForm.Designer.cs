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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Coffee = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SoftDrink = new System.Windows.Forms.TabPage();
            this.Food = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.swichToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbSellCode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbGrandTotal = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lvInvoice = new System.Windows.Forms.ListView();
            this.colProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl.SuspendLayout();
            this.Coffee.SuspendLayout();
            this.SoftDrink.SuspendLayout();
            this.Food.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl.Controls.Add(this.Coffee);
            this.tabControl.Controls.Add(this.SoftDrink);
            this.tabControl.Controls.Add(this.Food);
            this.tabControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl.Location = new System.Drawing.Point(32, 178);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(505, 320);
            this.tabControl.TabIndex = 0;
            // 
            // Coffee
            // 
            this.Coffee.AllowDrop = true;
            this.Coffee.AutoScroll = true;
            this.Coffee.Controls.Add(this.flowLayoutPanel1);
            this.Coffee.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Coffee.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coffee.ForeColor = System.Drawing.Color.White;
            this.Coffee.Location = new System.Drawing.Point(4, 30);
            this.Coffee.Margin = new System.Windows.Forms.Padding(4);
            this.Coffee.Name = "Coffee";
            this.Coffee.Padding = new System.Windows.Forms.Padding(4);
            this.Coffee.Size = new System.Drawing.Size(497, 286);
            this.Coffee.TabIndex = 0;
            this.Coffee.Text = "Coffee";
            this.Coffee.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(489, 278);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // SoftDrink
            // 
            this.SoftDrink.AutoScroll = true;
            this.SoftDrink.Controls.Add(this.flowLayoutPanel2);
            this.SoftDrink.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SoftDrink.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.SoftDrink.ForeColor = System.Drawing.Color.SandyBrown;
            this.SoftDrink.Location = new System.Drawing.Point(4, 30);
            this.SoftDrink.Margin = new System.Windows.Forms.Padding(4);
            this.SoftDrink.Name = "SoftDrink";
            this.SoftDrink.Padding = new System.Windows.Forms.Padding(4);
            this.SoftDrink.Size = new System.Drawing.Size(497, 286);
            this.SoftDrink.TabIndex = 1;
            this.SoftDrink.Text = "Soft Drink";
            this.SoftDrink.UseVisualStyleBackColor = true;
            // 
            // Food
            // 
            this.Food.AutoScroll = true;
            this.Food.Controls.Add(this.flowLayoutPanel3);
            this.Food.Cursor = System.Windows.Forms.Cursors.Default;
            this.Food.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.Food.ForeColor = System.Drawing.Color.White;
            this.Food.Location = new System.Drawing.Point(4, 30);
            this.Food.Name = "Food";
            this.Food.Padding = new System.Windows.Forms.Padding(3);
            this.Food.Size = new System.Drawing.Size(497, 286);
            this.Food.TabIndex = 2;
            this.Food.Text = "Food";
            this.Food.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(900, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.swichToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // swichToolStripMenuItem
            // 
            this.swichToolStripMenuItem.Name = "swichToolStripMenuItem";
            this.swichToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.swichToolStripMenuItem.Text = "Swich";
            // 
            // lbSellCode
            // 
            this.lbSellCode.AutoSize = true;
            this.lbSellCode.BackColor = System.Drawing.Color.White;
            this.lbSellCode.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbSellCode.Location = new System.Drawing.Point(841, 131);
            this.lbSellCode.Name = "lbSellCode";
            this.lbSellCode.Size = new System.Drawing.Size(17, 18);
            this.lbSellCode.TabIndex = 4;
            this.lbSellCode.Text = "0";
            this.lbSellCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(685, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "GRAND TOTAL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.Location = new System.Drawing.Point(797, 402);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 32);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lbGrandTotal
            // 
            this.lbGrandTotal.AutoSize = true;
            this.lbGrandTotal.BackColor = System.Drawing.Color.Gainsboro;
            this.lbGrandTotal.ForeColor = System.Drawing.Color.Green;
            this.lbGrandTotal.Location = new System.Drawing.Point(825, 408);
            this.lbGrandTotal.Name = "lbGrandTotal";
            this.lbGrandTotal.Size = new System.Drawing.Size(53, 18);
            this.lbGrandTotal.TabIndex = 5;
            this.lbGrandTotal.Text = "0000$";
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOrder.Location = new System.Drawing.Point(596, 446);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(105, 37);
            this.btnOrder.TabIndex = 7;
            this.btnOrder.Text = "ORDER";
            this.btnOrder.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Location = new System.Drawing.Point(550, 446);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(42, 37);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "X";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // lvInvoice
            // 
            this.lvInvoice.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colProductName,
            this.colUPrice,
            this.colQty,
            this.colTotal});
            this.lvInvoice.Font = new System.Drawing.Font("Kh Siemreap", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvInvoice.Location = new System.Drawing.Point(550, 178);
            this.lvInvoice.Name = "lvInvoice";
            this.lvInvoice.Size = new System.Drawing.Size(338, 227);
            this.lvInvoice.TabIndex = 8;
            this.lvInvoice.UseCompatibleStateImageBehavior = false;
            this.lvInvoice.View = System.Windows.Forms.View.Details;
            // 
            // colProductName
            // 
            this.colProductName.Text = "PRODUCT";
            this.colProductName.Width = 130;
            // 
            // colUPrice
            // 
            this.colUPrice.Text = "PRICE";
            this.colUPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colUPrice.Width = 70;
            // 
            // colQty
            // 
            this.colQty.Text = "QTY";
            this.colQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colQty.Width = 50;
            // 
            // colTotal
            // 
            this.colTotal.Text = "TOTAL";
            this.colTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colTotal.Width = 84;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.ForeColor = System.Drawing.Color.White;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(489, 278);
            this.flowLayoutPanel2.TabIndex = 0;
            this.flowLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(491, 280);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LinkerCofe.Properties.Resources.Customer_Linker_Cofe_01;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.lvInvoice);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.lbGrandTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbSellCode);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(900, 550);
            this.MinimumSize = new System.Drawing.Size(900, 550);
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.tabControl.ResumeLayout(false);
            this.Coffee.ResumeLayout(false);
            this.SoftDrink.ResumeLayout(false);
            this.Food.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage SoftDrink;
        private System.Windows.Forms.TabPage Food;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label lbSellCode;
        private System.Windows.Forms.TabPage Coffee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbGrandTotal;
        private System.Windows.Forms.ToolStripMenuItem swichToolStripMenuItem;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListView lvInvoice;
        private System.Windows.Forms.ColumnHeader colProductName;
        private System.Windows.Forms.ColumnHeader colUPrice;
        private System.Windows.Forms.ColumnHeader colQty;
        private System.Windows.Forms.ColumnHeader colTotal;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
    }
}