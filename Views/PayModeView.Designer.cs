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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPagePayModeLIst = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgPayMode = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabPagePayModelDetail = new TabPage();
            BtnCancel = new Button();
            TxtPayModeObservation = new TextBox();
            label5 = new Label();
            TxtPayModeName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            TxtPayModeId = new TextBox();
            BtnSave = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPagePayModeLIst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).BeginInit();
            tabPagePayModelDetail.SuspendLayout();
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
            tabPagePayModeLIst.Controls.Add(BtnClose);
            tabPagePayModeLIst.Controls.Add(BtnDelete);
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
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(619, 232);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(167, 48);
            BtnClose.TabIndex = 7;
            BtnClose.TextImageRelation = TextImageRelation.TextAboveImage;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(619, 178);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(167, 48);
            BtnDelete.TabIndex = 6;
            BtnDelete.TextImageRelation = TextImageRelation.TextAboveImage;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(619, 124);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(167, 48);
            BtnEdit.TabIndex = 5;
            BtnEdit.TextImageRelation = TextImageRelation.TextAboveImage;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(617, 70);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(167, 48);
            BtnNew.TabIndex = 4;
            BtnNew.TextImageRelation = TextImageRelation.TextAboveImage;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgPayMode
            // 
            DgPayMode.AllowUserToAddRows = false;
            DgPayMode.AllowUserToDeleteRows = false;
            DgPayMode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgPayMode.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgPayMode.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgPayMode.Location = new Point(16, 70);
            DgPayMode.Name = "DgPayMode";
            DgPayMode.ReadOnly = true;
            DgPayMode.Size = new Size(600, 234);
            DgPayMode.TabIndex = 3;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(574, 18);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(42, 46);
            BtnSearch.TabIndex = 2;
            BtnSearch.TextImageRelation = TextImageRelation.TextAboveImage;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(16, 41);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to Search";
            TxtSearch.Size = new Size(552, 23);
            TxtSearch.TabIndex = 1;
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
            // tabPagePayModelDetail
            // 
            tabPagePayModelDetail.Controls.Add(BtnCancel);
            tabPagePayModelDetail.Controls.Add(TxtPayModeObservation);
            tabPagePayModelDetail.Controls.Add(label5);
            tabPagePayModelDetail.Controls.Add(TxtPayModeName);
            tabPagePayModelDetail.Controls.Add(label4);
            tabPagePayModelDetail.Controls.Add(label3);
            tabPagePayModelDetail.Controls.Add(TxtPayModeId);
            tabPagePayModelDetail.Controls.Add(BtnSave);
            tabPagePayModelDetail.Location = new Point(4, 24);
            tabPagePayModelDetail.Name = "tabPagePayModelDetail";
            tabPagePayModelDetail.Padding = new Padding(3);
            tabPagePayModelDetail.Size = new Size(792, 322);
            tabPagePayModelDetail.TabIndex = 1;
            tabPagePayModelDetail.Text = "Pay Mode Detail";
            tabPagePayModelDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(173, 246);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(83, 42);
            BtnCancel.TabIndex = 7;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // TxtPayModeObservation
            // 
            TxtPayModeObservation.Location = new Point(50, 159);
            TxtPayModeObservation.Multiline = true;
            TxtPayModeObservation.Name = "TxtPayModeObservation";
            TxtPayModeObservation.PlaceholderText = "Pay Mode Description";
            TxtPayModeObservation.Size = new Size(228, 51);
            TxtPayModeObservation.TabIndex = 6;
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
            // TxtPayModeName
            // 
            TxtPayModeName.Location = new Point(50, 101);
            TxtPayModeName.Name = "TxtPayModeName";
            TxtPayModeName.PlaceholderText = "Pay Mode Name";
            TxtPayModeName.Size = new Size(228, 23);
            TxtPayModeName.TabIndex = 4;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 30);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 2;
            label3.Text = "Pay Mode Id";
            // 
            // TxtPayModeId
            // 
            TxtPayModeId.Location = new Point(48, 48);
            TxtPayModeId.Name = "TxtPayModeId";
            TxtPayModeId.ReadOnly = true;
            TxtPayModeId.Size = new Size(173, 23);
            TxtPayModeId.TabIndex = 1;
            TxtPayModeId.Text = "0";
            TxtPayModeId.TextAlign = HorizontalAlignment.Right;
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
            // PayModeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "PayModeView";
            Text = "Pa yMode Management";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPagePayModeLIst.ResumeLayout(false);
            tabPagePayModeLIst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).EndInit();
            tabPagePayModelDetail.ResumeLayout(false);
            tabPagePayModelDetail.PerformLayout();
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
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnSave;
        private TextBox TxtPayModeObservation;
        private Label label5;
        private TextBox TxtPayModeName;
        private Label label4;
        private Label label3;
        private TextBox TxtPayModeId;
        private Button BtnCancel;
    }
}