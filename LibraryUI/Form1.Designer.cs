namespace LibraryUI
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grdbooks = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAname = new DevExpress.XtraEditors.TextEdit();
            this.btnNewauthor = new DevExpress.XtraEditors.SimpleButton();
            this.txtAsurname = new DevExpress.XtraEditors.TextEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtnewname = new DevExpress.XtraEditors.TextEdit();
            this.btnadd = new DevExpress.XtraEditors.SimpleButton();
            this.txtnewauthor = new DevExpress.XtraEditors.TextEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bnAdelete = new DevExpress.XtraEditors.SimpleButton();
            this.txtdelauthor = new DevExpress.XtraEditors.TextEdit();
            this.txtdelAsurname = new DevExpress.XtraEditors.TextEdit();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtdelBookA = new DevExpress.XtraEditors.TextEdit();
            this.txtDbook = new DevExpress.XtraEditors.TextEdit();
            this.btndelBook = new DevExpress.XtraEditors.SimpleButton();
            this.grdauthors = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.grdbooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAsurname.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtnewname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnewauthor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtdelauthor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdelAsurname.Properties)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtdelBookA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDbook.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdauthors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // grdbooks
            // 
            this.grdbooks.Location = new System.Drawing.Point(3, 12);
            this.grdbooks.MainView = this.gridView1;
            this.grdbooks.Name = "grdbooks";
            this.grdbooks.Size = new System.Drawing.Size(701, 357);
            this.grdbooks.TabIndex = 0;
            this.grdbooks.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.CornflowerBlue;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.grdbooks;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Controls.Add(this.groupBox2);
            this.groupControl1.Controls.Add(this.groupBox1);
            this.groupControl1.Location = new System.Drawing.Point(710, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(525, 357);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "ADD";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.txtAname);
            this.groupBox2.Controls.Add(this.btnNewauthor);
            this.groupBox2.Controls.Add(this.txtAsurname);
            this.groupBox2.Location = new System.Drawing.Point(14, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(494, 151);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Author";
            // 
            // txtAname
            // 
            this.txtAname.EditValue = "";
            this.txtAname.Location = new System.Drawing.Point(6, 36);
            this.txtAname.Name = "txtAname";
            this.txtAname.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtAname.Properties.Appearance.Options.UseBackColor = true;
            this.txtAname.Size = new System.Drawing.Size(206, 22);
            this.txtAname.TabIndex = 0;
            // 
            // btnNewauthor
            // 
            this.btnNewauthor.Appearance.BackColor = System.Drawing.Color.Green;
            this.btnNewauthor.Appearance.Options.UseBackColor = true;
            this.btnNewauthor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNewauthor.ImageOptions.Image")));
            this.btnNewauthor.Location = new System.Drawing.Point(299, 84);
            this.btnNewauthor.Name = "btnNewauthor";
            this.btnNewauthor.Size = new System.Drawing.Size(171, 38);
            this.btnNewauthor.TabIndex = 2;
            this.btnNewauthor.Text = "Add";
            this.btnNewauthor.Click += new System.EventHandler(this.btnNewauthor_Click);
            // 
            // txtAsurname
            // 
            this.txtAsurname.EditValue = "";
            this.txtAsurname.Location = new System.Drawing.Point(264, 36);
            this.txtAsurname.Name = "txtAsurname";
            this.txtAsurname.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtAsurname.Properties.Appearance.Options.UseBackColor = true;
            this.txtAsurname.Size = new System.Drawing.Size(206, 22);
            this.txtAsurname.TabIndex = 3;
//            this.txtAsurname.EditValueChanged += new System.EventHandler(this.txtAsurname_EditValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtnewname);
            this.groupBox1.Controls.Add(this.btnadd);
            this.groupBox1.Controls.Add(this.txtnewauthor);
            this.groupBox1.Location = new System.Drawing.Point(14, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 164);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book";
            // 
            // txtnewname
            // 
            this.txtnewname.EditValue = "";
            this.txtnewname.Location = new System.Drawing.Point(6, 53);
            this.txtnewname.Name = "txtnewname";
            this.txtnewname.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtnewname.Properties.Appearance.Options.UseBackColor = true;
            this.txtnewname.Size = new System.Drawing.Size(206, 22);
            this.txtnewname.TabIndex = 0;
            // 
            // btnadd
            // 
            this.btnadd.Appearance.BackColor = System.Drawing.Color.Green;
            this.btnadd.Appearance.Options.UseBackColor = true;
            this.btnadd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.ImageOptions.Image")));
            this.btnadd.Location = new System.Drawing.Point(299, 110);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(171, 38);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "Add";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtnewauthor
            // 
            this.txtnewauthor.EditValue = "";
            this.txtnewauthor.Location = new System.Drawing.Point(272, 53);
            this.txtnewauthor.Name = "txtnewauthor";
            this.txtnewauthor.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtnewauthor.Properties.Appearance.Options.UseBackColor = true;
            this.txtnewauthor.Size = new System.Drawing.Size(206, 22);
            this.txtnewauthor.TabIndex = 3;
            // 
            // groupControl3
            // 
            this.groupControl3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupControl3.Appearance.Options.UseBackColor = true;
            this.groupControl3.Controls.Add(this.groupBox4);
            this.groupControl3.Controls.Add(this.groupBox3);
            this.groupControl3.Location = new System.Drawing.Point(710, 375);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(508, 357);
            this.groupControl3.TabIndex = 3;
            this.groupControl3.Text = "Delete";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox4.Controls.Add(this.bnAdelete);
            this.groupBox4.Controls.Add(this.txtdelauthor);
            this.groupBox4.Controls.Add(this.txtdelAsurname);
            this.groupBox4.Location = new System.Drawing.Point(14, 210);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(494, 151);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Author";
            // 
            // bnAdelete
            // 
            this.bnAdelete.Appearance.BackColor = System.Drawing.Color.Crimson;
            this.bnAdelete.Appearance.Options.UseBackColor = true;
            this.bnAdelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bnAdelete.ImageOptions.Image")));
            this.bnAdelete.Location = new System.Drawing.Point(299, 90);
            this.bnAdelete.Name = "bnAdelete";
            this.bnAdelete.Size = new System.Drawing.Size(171, 38);
            this.bnAdelete.TabIndex = 4;
            this.bnAdelete.Text = "Delete";
            this.bnAdelete.Click += new System.EventHandler(this.bnAdelete_Click);
            // 
            // txtdelauthor
            // 
            this.txtdelauthor.EditValue = "";
            this.txtdelauthor.Location = new System.Drawing.Point(6, 36);
            this.txtdelauthor.Name = "txtdelauthor";
            this.txtdelauthor.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtdelauthor.Properties.Appearance.Options.UseBackColor = true;
            this.txtdelauthor.Size = new System.Drawing.Size(206, 22);
            this.txtdelauthor.TabIndex = 0;
            // 
            // txtdelAsurname
            // 
            this.txtdelAsurname.EditValue = "";
            this.txtdelAsurname.Location = new System.Drawing.Point(264, 36);
            this.txtdelAsurname.Name = "txtdelAsurname";
            this.txtdelAsurname.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtdelAsurname.Properties.Appearance.Options.UseBackColor = true;
            this.txtdelAsurname.Size = new System.Drawing.Size(206, 22);
            this.txtdelAsurname.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtdelBookA);
            this.groupBox3.Controls.Add(this.txtDbook);
            this.groupBox3.Controls.Add(this.btndelBook);
            this.groupBox3.Location = new System.Drawing.Point(14, 40);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(494, 164);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Book";
            // 
            // txtdelBookA
            // 
            this.txtdelBookA.EditValue = "";
            this.txtdelBookA.Location = new System.Drawing.Point(264, 36);
            this.txtdelBookA.Name = "txtdelBookA";
            this.txtdelBookA.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtdelBookA.Properties.Appearance.Options.UseBackColor = true;
            this.txtdelBookA.Size = new System.Drawing.Size(206, 22);
            this.txtdelBookA.TabIndex = 3;
            // 
            // txtDbook
            // 
            this.txtDbook.EditValue = "";
            this.txtDbook.Location = new System.Drawing.Point(6, 36);
            this.txtDbook.Name = "txtDbook";
            this.txtDbook.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtDbook.Properties.Appearance.Options.UseBackColor = true;
            this.txtDbook.Size = new System.Drawing.Size(206, 22);
            this.txtDbook.TabIndex = 0;
            // 
            // btndelBook
            // 
            this.btndelBook.Appearance.BackColor = System.Drawing.Color.Crimson;
            this.btndelBook.Appearance.Options.UseBackColor = true;
            this.btndelBook.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btndelBook.ImageOptions.Image")));
            this.btndelBook.Location = new System.Drawing.Point(299, 84);
            this.btndelBook.Name = "btndelBook";
            this.btndelBook.Size = new System.Drawing.Size(171, 38);
            this.btndelBook.TabIndex = 2;
            this.btndelBook.Text = "Delete";
            this.btndelBook.Click += new System.EventHandler(this.btndelBook_Click);
            // 
            // grdauthors
            // 
            this.grdauthors.Location = new System.Drawing.Point(3, 375);
            this.grdauthors.MainView = this.gridView2;
            this.grdauthors.Name = "grdauthors";
            this.grdauthors.Size = new System.Drawing.Size(701, 357);
            this.grdauthors.TabIndex = 4;
            this.grdauthors.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView2.Appearance.Row.BackColor2 = System.Drawing.Color.CornflowerBlue;
            this.gridView2.Appearance.Row.Options.UseBackColor = true;
            this.gridView2.GridControl = this.grdauthors;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageGroup5.ImageOptions.Image")));
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "New Author";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 734);
            this.Controls.Add(this.grdauthors);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.grdbooks);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdbooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtAname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAsurname.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtnewname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnewauthor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtdelauthor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdelAsurname.Properties)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtdelBookA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDbook.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdauthors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdbooks;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtnewname;
        private DevExpress.XtraEditors.SimpleButton btnadd;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl grdauthors;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.TextEdit txtAname;
        private DevExpress.XtraEditors.SimpleButton btnNewauthor;
        private DevExpress.XtraEditors.TextEdit txtAsurname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraEditors.TextEdit txtdelauthor;
        private DevExpress.XtraEditors.TextEdit txtdelAsurname;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.TextEdit txtDbook;
        private DevExpress.XtraEditors.SimpleButton btndelBook;
        private DevExpress.XtraEditors.SimpleButton bnAdelete;
        private DevExpress.XtraEditors.TextEdit txtdelBookA;
        private DevExpress.XtraEditors.TextEdit txtnewauthor;
    }
}

