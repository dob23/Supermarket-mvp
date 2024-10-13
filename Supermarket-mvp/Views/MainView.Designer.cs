namespace Supermarket_mvp.Views
{
    partial class MainView
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
            panel1 = new Panel();
            BtnCustomers = new Button();
            BtnProducts = new Button();
            BtnExit = new Button();
            BtnPayMode = new Button();
            pictureBox1 = new PictureBox();
            BtnCategory = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnCategory);
            panel1.Controls.Add(BtnCustomers);
            panel1.Controls.Add(BtnProducts);
            panel1.Controls.Add(BtnExit);
            panel1.Controls.Add(BtnPayMode);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(150, 450);
            panel1.TabIndex = 0;
            // 
            // BtnCustomers
            // 
            BtnCustomers.BackgroundImage = Properties.Resources.providers;
            BtnCustomers.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCustomers.Location = new Point(3, 234);
            BtnCustomers.Name = "BtnCustomers";
            BtnCustomers.Size = new Size(147, 62);
            BtnCustomers.TabIndex = 4;
            BtnCustomers.UseVisualStyleBackColor = true;
            // 
            // BtnProducts
            // 
            BtnProducts.BackgroundImage = Properties.Resources.products;
            BtnProducts.BackgroundImageLayout = ImageLayout.Zoom;
            BtnProducts.Location = new Point(3, 159);
            BtnProducts.Name = "BtnProducts";
            BtnProducts.Size = new Size(147, 69);
            BtnProducts.TabIndex = 3;
            BtnProducts.UseVisualStyleBackColor = true;
            // 
            // BtnExit
            // 
            BtnExit.BackgroundImage = Properties.Resources.salida;
            BtnExit.BackgroundImageLayout = ImageLayout.Zoom;
            BtnExit.Dock = DockStyle.Bottom;
            BtnExit.Location = new Point(0, 369);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(150, 81);
            BtnExit.TabIndex = 2;
            BtnExit.UseVisualStyleBackColor = true;
            // 
            // BtnPayMode
            // 
            BtnPayMode.BackgroundImage = Properties.Resources.buy;
            BtnPayMode.BackgroundImageLayout = ImageLayout.Zoom;
            BtnPayMode.Location = new Point(0, 72);
            BtnPayMode.Name = "BtnPayMode";
            BtnPayMode.Size = new Size(147, 81);
            BtnPayMode.TabIndex = 1;
            BtnPayMode.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.sell;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 66);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // BtnCategory
            // 
            BtnCategory.BackgroundImage = Properties.Resources.Categorie;
            BtnCategory.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCategory.Location = new Point(3, 301);
            BtnCategory.Name = "BtnCategory";
            BtnCategory.Size = new Size(147, 62);
            BtnCategory.TabIndex = 5;
            BtnCategory.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "MainView";
            Text = "Supermarket";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BtnPayMode;
        private PictureBox pictureBox1;
        private Button BtnExit;
        private Button BtnProducts;
        private Button BtnCustomers;
        private Button BtnCategory;
    }
}