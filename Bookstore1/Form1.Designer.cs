using System;
using System.IO;
using System.Windows.Forms;

namespace Bookstore1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.load = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.serialization = new System.Windows.Forms.Button();
            this.deserialization = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(3, 80);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(250, 367);
            this.treeView1.TabIndex = 0;
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(213, 27);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(102, 23);
            this.load.TabIndex = 1;
            this.load.Text = "Загрузить";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(106, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Показать";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(321, 27);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(103, 23);
            this.close.TabIndex = 3;
            this.close.Text = "Закрыть";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // serialization
            // 
            this.serialization.Location = new System.Drawing.Point(227, 382);
            this.serialization.Name = "serialization";
            this.serialization.Size = new System.Drawing.Size(131, 42);
            this.serialization.TabIndex = 5;
            this.serialization.Text = "Сериализация";
            this.serialization.UseVisualStyleBackColor = true;
            this.serialization.Click += new System.EventHandler(this.serialization_Click_1);
            // 
            // deserialization
            // 
            this.deserialization.Location = new System.Drawing.Point(381, 382);
            this.deserialization.Name = "deserialization";
            this.deserialization.Size = new System.Drawing.Size(133, 42);
            this.deserialization.TabIndex = 6;
            this.deserialization.Text = "Десериализация";
            this.deserialization.UseVisualStyleBackColor = true;
            // 
            // picture
            // 
            this.picture.Image = global::Bookstore1.Properties.Resources._784409125462555559867;
            this.picture.Location = new System.Drawing.Point(3, 3);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(117, 71);
            this.picture.TabIndex = 8;
            this.picture.Text = "button4";
            this.picture.UseVisualStyleBackColor = true;
            this.picture.Click += new System.EventHandler(this.picture_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(13, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(501, 122);
            this.dataGridView1.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 450);
            this.splitter1.TabIndex = 10;
            this.splitter1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            this.splitContainer1.Panel1.Controls.Add(this.picture);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.load);
            this.splitContainer1.Panel2.Controls.Add(this.serialization);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.Controls.Add(this.deserialization);
            this.splitContainer1.Panel2.Controls.Add(this.close);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Size = new System.Drawing.Size(810, 450);
            this.splitContainer1.SplitterDistance = 270;
            this.splitContainer1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.splitter1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Picture_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }



        private void Serialization_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button serialization;
        private System.Windows.Forms.Button deserialization;
        private System.Windows.Forms.Button picture;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Splitter splitter1;
        private SplitContainer splitContainer1;
    }
}

