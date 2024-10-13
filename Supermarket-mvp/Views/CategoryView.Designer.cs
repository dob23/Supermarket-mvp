namespace Supermarket_mvp.Views
{
    partial class CategoryView
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
            tabPageCategorieList = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgPayMode = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabPageCategorieDetail = new TabPage();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtCategoryDescription = new TextBox();
            TxtCategoryName = new TextBox();
            TxtCategoryId = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageCategorieList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).BeginInit();
            tabPageCategorieDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(746, 80);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(148, 22);
            label1.Name = "label1";
            label1.Size = new Size(129, 28);
            label1.TabIndex = 1;
            label1.Text = "Categorie";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Categorie;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(127, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCategorieList);
            tabControl1.Controls.Add(tabPageCategorieDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 80);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(746, 309);
            tabControl1.TabIndex = 1;
            // 
            // tabPageCategorieList
            // 
            tabPageCategorieList.Controls.Add(BtnClose);
            tabPageCategorieList.Controls.Add(BtnDelete);
            tabPageCategorieList.Controls.Add(BtnEdit);
            tabPageCategorieList.Controls.Add(BtnNew);
            tabPageCategorieList.Controls.Add(DgPayMode);
            tabPageCategorieList.Controls.Add(BtnSearch);
            tabPageCategorieList.Controls.Add(TxtSearch);
            tabPageCategorieList.Controls.Add(label2);
            tabPageCategorieList.Location = new Point(4, 24);
            tabPageCategorieList.Margin = new Padding(3, 2, 3, 2);
            tabPageCategorieList.Name = "tabPageCategorieList";
            tabPageCategorieList.Padding = new Padding(3, 2, 3, 2);
            tabPageCategorieList.Size = new Size(738, 281);
            tabPageCategorieList.TabIndex = 0;
            tabPageCategorieList.Text = "Categorie List ";
            tabPageCategorieList.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(582, 206);
            BtnClose.Margin = new Padding(3, 2, 3, 2);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(140, 37);
            BtnClose.TabIndex = 7;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(582, 162);
            BtnDelete.Margin = new Padding(3, 2, 3, 2);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(140, 40);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(582, 115);
            BtnEdit.Margin = new Padding(3, 2, 3, 2);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(140, 43);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(582, 74);
            BtnNew.Margin = new Padding(3, 2, 3, 2);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(140, 36);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgPayMode
            // 
            DgPayMode.AllowUserToAddRows = false;
            DgPayMode.AllowUserToDeleteRows = false;
            DgPayMode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgPayMode.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgPayMode.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgPayMode.Location = new Point(35, 74);
            DgPayMode.Margin = new Padding(3, 2, 3, 2);
            DgPayMode.Name = "DgPayMode";
            DgPayMode.ReadOnly = true;
            DgPayMode.RowHeadersWidth = 51;
            DgPayMode.Size = new Size(525, 169);
            DgPayMode.TabIndex = 3;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(512, 24);
            BtnSearch.Margin = new Padding(3, 2, 3, 2);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(48, 29);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(35, 33);
            TxtSearch.Margin = new Padding(3, 2, 3, 2);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(472, 23);
            TxtSearch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 11);
            label2.Name = "label2";
            label2.Size = new Size(153, 19);
            label2.TabIndex = 0;
            label2.Text = "Search Categorie";
            // 
            // tabPageCategorieDetail
            // 
            tabPageCategorieDetail.Controls.Add(BtnCancel);
            tabPageCategorieDetail.Controls.Add(BtnSave);
            tabPageCategorieDetail.Controls.Add(TxtCategoryDescription);
            tabPageCategorieDetail.Controls.Add(TxtCategoryName);
            tabPageCategorieDetail.Controls.Add(TxtCategoryId);
            tabPageCategorieDetail.Controls.Add(label6);
            tabPageCategorieDetail.Controls.Add(label5);
            tabPageCategorieDetail.Controls.Add(label4);
            tabPageCategorieDetail.Controls.Add(label3);
            tabPageCategorieDetail.Location = new Point(4, 24);
            tabPageCategorieDetail.Margin = new Padding(3, 2, 3, 2);
            tabPageCategorieDetail.Name = "tabPageCategorieDetail";
            tabPageCategorieDetail.Padding = new Padding(3, 2, 3, 2);
            tabPageCategorieDetail.Size = new Size(738, 281);
            tabPageCategorieDetail.TabIndex = 1;
            tabPageCategorieDetail.Text = "Categorie Detail";
            tabPageCategorieDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(172, 209);
            BtnCancel.Margin = new Padding(3, 2, 3, 2);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(102, 50);
            BtnCancel.TabIndex = 8;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(38, 209);
            BtnSave.Margin = new Padding(3, 2, 3, 2);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(102, 50);
            BtnSave.TabIndex = 7;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtCategoryDescription
            // 
            TxtCategoryDescription.Location = new Point(38, 142);
            TxtCategoryDescription.Margin = new Padding(3, 2, 3, 2);
            TxtCategoryDescription.Multiline = true;
            TxtCategoryDescription.Name = "TxtCategoryDescription";
            TxtCategoryDescription.PlaceholderText = "Categorie Description";
            TxtCategoryDescription.Size = new Size(182, 48);
            TxtCategoryDescription.TabIndex = 6;
            // 
            // TxtCategoryName
            // 
            TxtCategoryName.Location = new Point(38, 91);
            TxtCategoryName.Margin = new Padding(3, 2, 3, 2);
            TxtCategoryName.Name = "TxtCategoryName";
            TxtCategoryName.PlaceholderText = "Categorie Name";
            TxtCategoryName.Size = new Size(134, 23);
            TxtCategoryName.TabIndex = 5;
            // 
            // TxtCategoryId
            // 
            TxtCategoryId.Location = new Point(38, 43);
            TxtCategoryId.Margin = new Padding(3, 2, 3, 2);
            TxtCategoryId.Name = "TxtCategoryId";
            TxtCategoryId.ReadOnly = true;
            TxtCategoryId.Size = new Size(110, 23);
            TxtCategoryId.TabIndex = 4;
            TxtCategoryId.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(38, 124);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 3;
            label6.Text = "Description";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 124);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(38, 74);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 1;
            label4.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(38, 26);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 0;
            label3.Text = " Id";
            // 
            // CategoryView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 389);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CategoryView";
            Text = "Categorie Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageCategorieList.ResumeLayout(false);
            tabPageCategorieList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).EndInit();
            tabPageCategorieDetail.ResumeLayout(false);
            tabPageCategorieDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPageCategorieList;
        private TabPage tabPageCategorieDetail;
        private TextBox TxtSearch;
        private Label label2;
        private Button BtnEdit;
        private Button BtnNew;
        private DataGridView DgPayMode;
        private Button BtnSearch;
        private Button BtnClose;
        private Button BtnDelete;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox TxtCategoryDescription;
        private TextBox TxtCategoryName;
        private TextBox TxtCategoryId;
        private Label label6;
        private Button BtnCancel;
        private Button BtnSave;
    }
}