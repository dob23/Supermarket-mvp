namespace Supermarket_mvp.Views
{
    partial class PayModeView
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabPagePayModeLIst = new TabPage();
            tabPagePayModelDetail = new TabPage();
            label2 = new Label();
            TxtSearch = new TextBox();
            BtnSearch = new Button();
            DgPayMode = new DataGridView();
            BtnNew = new Button();
            BtnEdit = new Button();
            button1 = new Button();
            button2 = new Button();
            BtnSave = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            button3 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPagePayModeLIst.SuspendLayout();
            tabPagePayModelDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(142, 28);
            label1.Name = "label1";
            label1.Size = new Size(140, 34);
            label1.TabIndex = 0;
            label1.Text = "Pay Mode";
            label1.UseCompatibleTextRendering = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.buy;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPagePayModeLIst);
            tabControl1.Controls.Add(tabPagePayModelDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 100);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 350);
            tabControl1.TabIndex = 1;
            // 
            // tabPagePayModeLIst
            // 
            tabPagePayModeLIst.Controls.Add(button2);
            tabPagePayModeLIst.Controls.Add(button1);
            tabPagePayModeLIst.Controls.Add(BtnEdit);
            tabPagePayModeLIst.Controls.Add(BtnNew);
            tabPagePayModeLIst.Controls.Add(DgPayMode);
            tabPagePayModeLIst.Controls.Add(BtnSearch);
            tabPagePayModeLIst.Controls.Add(TxtSearch);
            tabPagePayModeLIst.Controls.Add(label2);
            tabPagePayModeLIst.Location = new Point(4, 24);
            tabPagePayModeLIst.Name = "tabPagePayModeLIst";
            tabPagePayModeLIst.Padding = new Padding(3);
            tabPagePayModeLIst.Size = new Size(792, 322);
            tabPagePayModeLIst.TabIndex = 0;
            tabPagePayModeLIst.Text = "Pay Mode List";
            tabPagePayModeLIst.UseVisualStyleBackColor = true;
            // 
            // tabPagePayModelDetail
            // 
            tabPagePayModelDetail.Controls.Add(button3);
            tabPagePayModelDetail.Controls.Add(textBox3);
            tabPagePayModelDetail.Controls.Add(label5);
            tabPagePayModelDetail.Controls.Add(textBox2);
            tabPagePayModelDetail.Controls.Add(label4);
            tabPagePayModelDetail.Controls.Add(label3);
            tabPagePayModelDetail.Controls.Add(textBox1);
            tabPagePayModelDetail.Controls.Add(BtnSave);
            tabPagePayModelDetail.Location = new Point(4, 24);
            tabPagePayModelDetail.Name = "tabPagePayModelDetail";
            tabPagePayModelDetail.Padding = new Padding(3);
            tabPagePayModelDetail.Size = new Size(792, 322);
            tabPagePayModelDetail.TabIndex = 1;
            tabPagePayModelDetail.Text = "Pay Mode Detail";
            tabPagePayModelDetail.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 14);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 0;
            label2.Text = "Search Pay Mode";
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(16, 41);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to Search";
            TxtSearch.Size = new Size(552, 23);
            TxtSearch.TabIndex = 1;
            // 
            // BtnSearch
            // 
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(574, 18);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(42, 46);
            BtnSearch.TabIndex = 2;
            BtnSearch.TextImageRelation = TextImageRelation.TextAboveImage;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // DgPayMode
            // 
            DgPayMode.AllowUserToAddRows = false;
            DgPayMode.AllowUserToDeleteRows = false;
            DgPayMode.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgPayMode.Location = new Point(16, 70);
            DgPayMode.Name = "DgPayMode";
            DgPayMode.ReadOnly = true;
            DgPayMode.Size = new Size(600, 234);
            DgPayMode.TabIndex = 3;
            // 
            // BtnNew
            // 
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(617, 70);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(167, 48);
            BtnNew.TabIndex = 4;
            BtnNew.TextImageRelation = TextImageRelation.TextAboveImage;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(619, 124);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(167, 48);
            BtnEdit.TabIndex = 5;
            BtnEdit.TextImageRelation = TextImageRelation.TextAboveImage;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.delete;
            button1.Location = new Point(619, 178);
            button1.Name = "button1";
            button1.Size = new Size(167, 48);
            button1.TabIndex = 6;
            button1.TextImageRelation = TextImageRelation.TextAboveImage;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.cerrar;
            button2.Location = new Point(619, 232);
            button2.Name = "button2";
            button2.Size = new Size(167, 48);
            button2.TabIndex = 7;
            button2.TextImageRelation = TextImageRelation.TextAboveImage;
            button2.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(50, 246);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(83, 42);
            BtnSave.TabIndex = 0;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(48, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(173, 23);
            textBox1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 30);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 2;
            label3.Text = "Pay Mode Id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 83);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 3;
            label4.Text = "Pay Mode Name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(50, 101);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Pay Mode Name";
            textBox2.Size = new Size(228, 23);
            textBox2.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 141);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 5;
            label5.Text = "Pay Mode Name";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(50, 159);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Pay Mode Description";
            textBox3.Size = new Size(228, 51);
            textBox3.TabIndex = 6;
            // 
            // button3
            // 
            button3.Image = Properties.Resources.cancel;
            button3.Location = new Point(173, 246);
            button3.Name = "button3";
            button3.Size = new Size(83, 42);
            button3.TabIndex = 7;
            button3.UseVisualStyleBackColor = true;
            // 
            // PayModeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "PayModeView";
            Text = "Pa yMode Management";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPagePayModeLIst.ResumeLayout(false);
            tabPagePayModeLIst.PerformLayout();
            tabPagePayModelDetail.ResumeLayout(false);
            tabPagePayModelDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPagePayModeLIst;
        private TabPage tabPagePayModelDetail;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label label2;
        private Button BtnNew;
        private DataGridView DgPayMode;
        private Button button2;
        private Button button1;
        private Button BtnEdit;
        private Button BtnSave;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox2;
        private Label label4;
        private Label label3;
        private TextBox textBox1;
        private Button button3;
    }
}