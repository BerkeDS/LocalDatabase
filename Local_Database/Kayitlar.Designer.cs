﻿namespace Local_Database
{
    partial class Kayitlar
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrencilerDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrencilerDataSet = new Local_Database.OgrencilerDataSet();
            this.ogrenciTableAdapter = new Local_Database.OgrencilerDataSetTableAdapters.OgrenciTableAdapter();
            this.ogrenciBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciTableAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrencilerDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrencilerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciTableAdapterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(846, 312);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // ogrenciBindingSource
            // 
            this.ogrenciBindingSource.DataMember = "Ogrenci";
            this.ogrenciBindingSource.DataSource = this.ogrencilerDataSetBindingSource;
            // 
            // ogrencilerDataSetBindingSource
            // 
            this.ogrencilerDataSetBindingSource.DataSource = this.ogrencilerDataSet;
            this.ogrencilerDataSetBindingSource.Position = 0;
            // 
            // ogrencilerDataSet
            // 
            this.ogrencilerDataSet.DataSetName = "OgrencilerDataSet";
            this.ogrencilerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciTableAdapter
            // 
            this.ogrenciTableAdapter.ClearBeforeFill = true;
            // 
            // ogrenciBindingSource1
            // 
            this.ogrenciBindingSource1.DataSource = typeof(Local_Database.Ogrenci);
            // 
            // ogrenciTableAdapterBindingSource
            // 
            this.ogrenciTableAdapterBindingSource.DataSource = typeof(Local_Database.OgrencilerDataSetTableAdapters.OgrenciTableAdapter);
            // 
            // Kayitlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 400);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Kayitlar";
            this.Text = "Kayitlar";
            this.Load += new System.EventHandler(this.Kayitlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrencilerDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrencilerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciTableAdapterBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource ogrencilerDataSetBindingSource;
        private OgrencilerDataSet ogrencilerDataSet;
        private System.Windows.Forms.BindingSource ogrenciBindingSource;
        private OgrencilerDataSetTableAdapters.OgrenciTableAdapter ogrenciTableAdapter;
        private System.Windows.Forms.BindingSource ogrenciTableAdapterBindingSource;
        private System.Windows.Forms.BindingSource ogrenciBindingSource1;
    }
}