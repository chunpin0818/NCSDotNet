namespace Q1___ADO.NET_CRUD
{
    partial class Form1
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
            this.Insert = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Display = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.movieIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nCS2020DataSet = new Q1___ADO.NET_CRUD.NCS2020DataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.movieTableAdapter = new Q1___ADO.NET_CRUD.NCS2020DataSetTableAdapters.MovieTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCS2020DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(1063, 24);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(124, 68);
            this.Insert.TabIndex = 0;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(1063, 111);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(124, 71);
            this.Update.TabIndex = 1;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.button2_Click);
            // 
            // Display
            // 
            this.Display.Location = new System.Drawing.Point(1230, 24);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(131, 68);
            this.Display.TabIndex = 2;
            this.Display.Text = "Display";
            this.Display.UseVisualStyleBackColor = true;
            this.Display.Click += new System.EventHandler(this.Form1_Load);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(1230, 111);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(131, 71);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.movieIdDataGridViewTextBoxColumn,
            this.actorIdDataGridViewTextBoxColumn,
            this.movieNameDataGridViewTextBoxColumn,
            this.movieYearDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.movieBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(30, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1377, 395);
            this.dataGridView1.TabIndex = 4;
            // 
            // movieIdDataGridViewTextBoxColumn
            // 
            this.movieIdDataGridViewTextBoxColumn.DataPropertyName = "movie_Id";
            this.movieIdDataGridViewTextBoxColumn.HeaderText = "movie_Id";
            this.movieIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.movieIdDataGridViewTextBoxColumn.Name = "movieIdDataGridViewTextBoxColumn";
            this.movieIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.movieIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // actorIdDataGridViewTextBoxColumn
            // 
            this.actorIdDataGridViewTextBoxColumn.DataPropertyName = "actor_Id";
            this.actorIdDataGridViewTextBoxColumn.HeaderText = "actor_Id";
            this.actorIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.actorIdDataGridViewTextBoxColumn.Name = "actorIdDataGridViewTextBoxColumn";
            this.actorIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // movieNameDataGridViewTextBoxColumn
            // 
            this.movieNameDataGridViewTextBoxColumn.DataPropertyName = "movie_Name";
            this.movieNameDataGridViewTextBoxColumn.HeaderText = "movie_Name";
            this.movieNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.movieNameDataGridViewTextBoxColumn.Name = "movieNameDataGridViewTextBoxColumn";
            this.movieNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // movieYearDataGridViewTextBoxColumn
            // 
            this.movieYearDataGridViewTextBoxColumn.DataPropertyName = "movie_Year";
            this.movieYearDataGridViewTextBoxColumn.HeaderText = "movie_Year";
            this.movieYearDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.movieYearDataGridViewTextBoxColumn.Name = "movieYearDataGridViewTextBoxColumn";
            this.movieYearDataGridViewTextBoxColumn.Width = 150;
            // 
            // movieBindingSource
            // 
            this.movieBindingSource.DataMember = "Movie";
            this.movieBindingSource.DataSource = this.nCS2020DataSet;
            // 
            // nCS2020DataSet
            // 
            this.nCS2020DataSet.DataSetName = "NCS2020DataSet";
            this.nCS2020DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Movie_Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Movie_Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Actor_ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Movie_ID";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(376, 156);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(266, 26);
            this.textBox4.TabIndex = 22;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(376, 45);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(266, 26);
            this.textBox3.TabIndex = 21;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(61, 156);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(266, 26);
            this.textBox2.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(266, 26);
            this.textBox1.TabIndex = 18;
            // 
            // movieTableAdapter
            // 
            this.movieTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 638);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Insert);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCS2020DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Display;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private NCS2020DataSet nCS2020DataSet;
        private System.Windows.Forms.BindingSource movieBindingSource;
        private NCS2020DataSetTableAdapters.MovieTableAdapter movieTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieYearDataGridViewTextBoxColumn;
    }
}

