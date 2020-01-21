namespace DB2_ZH.Views.WinForms
{
    partial class ZHForm
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
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.textBox_egyenleg = new System.Windows.Forms.TextBox();
            this.label_egyenleg = new System.Windows.Forms.Label();
            this.textBox_kartyaszam = new System.Windows.Forms.TextBox();
            this.label_kartyaszam = new System.Windows.Forms.Label();
            this.textBox_nev = new System.Windows.Forms.TextBox();
            this.label_nev = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_insert = new System.Windows.Forms.Button();
            this.dataGridView_recrods = new System.Windows.Forms.DataGridView();
            this.panel_bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_recrods)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_bottom
            // 
            this.panel_bottom.Controls.Add(this.textBox_egyenleg);
            this.panel_bottom.Controls.Add(this.label_egyenleg);
            this.panel_bottom.Controls.Add(this.textBox_kartyaszam);
            this.panel_bottom.Controls.Add(this.label_kartyaszam);
            this.panel_bottom.Controls.Add(this.textBox_nev);
            this.panel_bottom.Controls.Add(this.label_nev);
            this.panel_bottom.Controls.Add(this.button_delete);
            this.panel_bottom.Controls.Add(this.button_insert);
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_bottom.Location = new System.Drawing.Point(752, 0);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(300, 527);
            this.panel_bottom.TabIndex = 0;
            // 
            // textBox_egyenleg
            // 
            this.textBox_egyenleg.Location = new System.Drawing.Point(8, 97);
            this.textBox_egyenleg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_egyenleg.Name = "textBox_egyenleg";
            this.textBox_egyenleg.Size = new System.Drawing.Size(284, 20);
            this.textBox_egyenleg.TabIndex = 7;
            // 
            // label_egyenleg
            // 
            this.label_egyenleg.AutoSize = true;
            this.label_egyenleg.Location = new System.Drawing.Point(5, 80);
            this.label_egyenleg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_egyenleg.Name = "label_egyenleg";
            this.label_egyenleg.Size = new System.Drawing.Size(51, 13);
            this.label_egyenleg.TabIndex = 6;
            this.label_egyenleg.Text = "Egyenleg";
            // 
            // textBox_kartyaszam
            // 
            this.textBox_kartyaszam.Location = new System.Drawing.Point(8, 60);
            this.textBox_kartyaszam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_kartyaszam.Name = "textBox_kartyaszam";
            this.textBox_kartyaszam.Size = new System.Drawing.Size(284, 20);
            this.textBox_kartyaszam.TabIndex = 5;
            this.textBox_kartyaszam.TextChanged += new System.EventHandler(this.textBox_kartyaszam_TextChanged);
            // 
            // label_kartyaszam
            // 
            this.label_kartyaszam.AutoSize = true;
            this.label_kartyaszam.Location = new System.Drawing.Point(5, 44);
            this.label_kartyaszam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_kartyaszam.Name = "label_kartyaszam";
            this.label_kartyaszam.Size = new System.Drawing.Size(64, 13);
            this.label_kartyaszam.TabIndex = 4;
            this.label_kartyaszam.Text = "Kártyaszám:";
            // 
            // textBox_nev
            // 
            this.textBox_nev.Location = new System.Drawing.Point(8, 24);
            this.textBox_nev.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_nev.Name = "textBox_nev";
            this.textBox_nev.Size = new System.Drawing.Size(284, 20);
            this.textBox_nev.TabIndex = 3;
            // 
            // label_nev
            // 
            this.label_nev.AutoSize = true;
            this.label_nev.Location = new System.Drawing.Point(5, 7);
            this.label_nev.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_nev.Name = "label_nev";
            this.label_nev.Size = new System.Drawing.Size(30, 13);
            this.label_nev.TabIndex = 2;
            this.label_nev.Text = "Név:";
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(213, 492);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 1;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_insert
            // 
            this.button_insert.Location = new System.Drawing.Point(13, 492);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(75, 23);
            this.button_insert.TabIndex = 0;
            this.button_insert.Text = "Insert";
            this.button_insert.UseVisualStyleBackColor = true;
            this.button_insert.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // dataGridView_recrods
            // 
            this.dataGridView_recrods.AllowUserToAddRows = false;
            this.dataGridView_recrods.AllowUserToDeleteRows = false;
            this.dataGridView_recrods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_recrods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_recrods.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView_recrods.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_recrods.Name = "dataGridView_recrods";
            this.dataGridView_recrods.ReadOnly = true;
            this.dataGridView_recrods.RowHeadersWidth = 51;
            this.dataGridView_recrods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_recrods.ShowCellErrors = false;
            this.dataGridView_recrods.ShowCellToolTips = false;
            this.dataGridView_recrods.ShowEditingIcon = false;
            this.dataGridView_recrods.ShowRowErrors = false;
            this.dataGridView_recrods.Size = new System.Drawing.Size(752, 527);
            this.dataGridView_recrods.TabIndex = 1;
            // 
            // ZHForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 527);
            this.Controls.Add(this.dataGridView_recrods);
            this.Controls.Add(this.panel_bottom);
            this.Name = "ZHForm";
            this.Text = "ZHForm";
            this.Load += new System.EventHandler(this.ZHForm_Load);
            this.Shown += new System.EventHandler(this.ZHForm_Shown);
            this.panel_bottom.ResumeLayout(false);
            this.panel_bottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_recrods)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_bottom;
        private System.Windows.Forms.DataGridView dataGridView_recrods;
        private System.Windows.Forms.Button button_insert;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.TextBox textBox_egyenleg;
        private System.Windows.Forms.Label label_egyenleg;
        private System.Windows.Forms.TextBox textBox_kartyaszam;
        private System.Windows.Forms.Label label_kartyaszam;
        private System.Windows.Forms.TextBox textBox_nev;
        private System.Windows.Forms.Label label_nev;
    }
}