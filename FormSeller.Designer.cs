
namespace ProjectXYZ
{
    partial class FormSeller
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvfoodinfo = new System.Windows.Forms.DataGridView();
            this.fid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fquantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAutoSearch = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rdbCakes = new System.Windows.Forms.RadioButton();
            this.rdbBread = new System.Windows.Forms.RadioButton();
            this.rdbBiscuits = new System.Windows.Forms.RadioButton();
            this.cmbselectitem = new System.Windows.Forms.ComboBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnsellinginfo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfoodinfo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvfoodinfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 257);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 265);
            this.panel1.TabIndex = 0;
            // 
            // dgvfoodinfo
            // 
            this.dgvfoodinfo.AllowUserToAddRows = false;
            this.dgvfoodinfo.AllowUserToDeleteRows = false;
            this.dgvfoodinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfoodinfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fid,
            this.fname,
            this.fprice,
            this.fquantity,
            this.total});
            this.dgvfoodinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvfoodinfo.Location = new System.Drawing.Point(0, 0);
            this.dgvfoodinfo.Name = "dgvfoodinfo";
            this.dgvfoodinfo.ReadOnly = true;
            this.dgvfoodinfo.RowHeadersWidth = 51;
            this.dgvfoodinfo.RowTemplate.Height = 24;
            this.dgvfoodinfo.Size = new System.Drawing.Size(828, 265);
            this.dgvfoodinfo.TabIndex = 0;
            // 
            // fid
            // 
            this.fid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fid.DataPropertyName = "fid";
            this.fid.HeaderText = "Food ID";
            this.fid.MinimumWidth = 6;
            this.fid.Name = "fid";
            this.fid.ReadOnly = true;
            // 
            // fname
            // 
            this.fname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fname.DataPropertyName = "fname";
            this.fname.HeaderText = "Food Name";
            this.fname.MinimumWidth = 6;
            this.fname.Name = "fname";
            this.fname.ReadOnly = true;
            // 
            // fprice
            // 
            this.fprice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fprice.DataPropertyName = "fprice";
            this.fprice.HeaderText = "Food Price";
            this.fprice.MinimumWidth = 6;
            this.fprice.Name = "fprice";
            this.fprice.ReadOnly = true;
            // 
            // fquantity
            // 
            this.fquantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fquantity.DataPropertyName = "fquantity";
            this.fquantity.HeaderText = "Quantity";
            this.fquantity.MinimumWidth = 6;
            this.fquantity.Name = "fquantity";
            this.fquantity.ReadOnly = true;
            // 
            // total
            // 
            this.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.total.DataPropertyName = "ftotal";
            this.total.HeaderText = "Total";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnsellinginfo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtAutoSearch);
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(828, 58);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search By Name";
            // 
            // txtAutoSearch
            // 
            this.txtAutoSearch.Location = new System.Drawing.Point(182, 18);
            this.txtAutoSearch.Name = "txtAutoSearch";
            this.txtAutoSearch.Size = new System.Drawing.Size(128, 23);
            this.txtAutoSearch.TabIndex = 1;
            this.txtAutoSearch.TextChanged += new System.EventHandler(this.txtAutoSearch_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(710, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(108, 50);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh>>";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Item";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Item Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(349, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(349, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Total";
            // 
            // rdbCakes
            // 
            this.rdbCakes.AutoSize = true;
            this.rdbCakes.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCakes.Location = new System.Drawing.Point(43, 21);
            this.rdbCakes.Name = "rdbCakes";
            this.rdbCakes.Size = new System.Drawing.Size(81, 27);
            this.rdbCakes.TabIndex = 7;
            this.rdbCakes.TabStop = true;
            this.rdbCakes.Text = "Cakes";
            this.rdbCakes.UseVisualStyleBackColor = true;
            this.rdbCakes.CheckedChanged += new System.EventHandler(this.rdbCakes_CheckedChanged);
            // 
            // rdbBread
            // 
            this.rdbBread.AutoSize = true;
            this.rdbBread.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbBread.Location = new System.Drawing.Point(130, 21);
            this.rdbBread.Name = "rdbBread";
            this.rdbBread.Size = new System.Drawing.Size(81, 27);
            this.rdbBread.TabIndex = 8;
            this.rdbBread.TabStop = true;
            this.rdbBread.Text = "Bread";
            this.rdbBread.UseVisualStyleBackColor = true;
            this.rdbBread.CheckedChanged += new System.EventHandler(this.rdbBread_CheckedChanged);
            // 
            // rdbBiscuits
            // 
            this.rdbBiscuits.AutoSize = true;
            this.rdbBiscuits.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbBiscuits.Location = new System.Drawing.Point(213, 21);
            this.rdbBiscuits.Name = "rdbBiscuits";
            this.rdbBiscuits.Size = new System.Drawing.Size(98, 27);
            this.rdbBiscuits.TabIndex = 9;
            this.rdbBiscuits.TabStop = true;
            this.rdbBiscuits.Text = "Biscuits";
            this.rdbBiscuits.UseVisualStyleBackColor = true;
            this.rdbBiscuits.CheckedChanged += new System.EventHandler(this.rdbBiscuits_CheckedChanged);
            // 
            // cmbselectitem
            // 
            this.cmbselectitem.FormattingEnabled = true;
            this.cmbselectitem.Location = new System.Drawing.Point(172, 115);
            this.cmbselectitem.Name = "cmbselectitem";
            this.cmbselectitem.Size = new System.Drawing.Size(122, 23);
            this.cmbselectitem.TabIndex = 10;
            this.cmbselectitem.SelectedIndexChanged += new System.EventHandler(this.cmbselectitem_SelectedIndexChanged);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(172, 66);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(122, 23);
            this.txtid.TabIndex = 11;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(413, 67);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(88, 23);
            this.txtPrice.TabIndex = 12;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(710, 11);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 47);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(710, 69);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 47);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(172, 155);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(122, 23);
            this.txtquantity.TabIndex = 16;
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(413, 123);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(88, 23);
            this.txttotal.TabIndex = 17;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(710, 128);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(108, 47);
            this.btnLogout.TabIndex = 18;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnsellinginfo
            // 
            this.btnsellinginfo.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsellinginfo.Location = new System.Drawing.Point(562, 3);
            this.btnsellinginfo.Name = "btnsellinginfo";
            this.btnsellinginfo.Size = new System.Drawing.Size(133, 51);
            this.btnsellinginfo.TabIndex = 19;
            this.btnsellinginfo.Text = "Selling Info";
            this.btnsellinginfo.UseVisualStyleBackColor = true;
            this.btnsellinginfo.Click += new System.EventHandler(this.btnsellinginfo_Click);
            // 
            // FormSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(828, 522);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.cmbselectitem);
            this.Controls.Add(this.rdbBiscuits);
            this.Controls.Add(this.rdbBread);
            this.Controls.Add(this.rdbCakes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormSeller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSeller";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvfoodinfo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvfoodinfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fid;
        private System.Windows.Forms.DataGridViewTextBoxColumn fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn fprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn fquantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.TextBox txtAutoSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdbCakes;
        private System.Windows.Forms.RadioButton rdbBread;
        private System.Windows.Forms.RadioButton rdbBiscuits;
        private System.Windows.Forms.ComboBox cmbselectitem;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnsellinginfo;
    }
}