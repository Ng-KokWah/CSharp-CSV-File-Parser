namespace CSVParserDGV
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.file1 = new System.Windows.Forms.TextBox();
            this.labelafterheader = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChoose = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errLabel = new System.Windows.Forms.Label();
            this.errLabel2 = new System.Windows.Forms.Label();
            this.errLabelHeader = new System.Windows.Forms.Label();
            this.labelheader = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // file1
            // 
            this.file1.Location = new System.Drawing.Point(87, 71);
            this.file1.Name = "file1";
            this.file1.ReadOnly = true;
            this.file1.Size = new System.Drawing.Size(374, 20);
            this.file1.TabIndex = 1;
            this.file1.TextChanged += new System.EventHandler(this.file1_TextChanged);
            // 
            // labelafterheader
            // 
            this.labelafterheader.AutoSize = true;
            this.labelafterheader.Location = new System.Drawing.Point(12, 14);
            this.labelafterheader.Name = "labelafterheader";
            this.labelafterheader.Size = new System.Drawing.Size(112, 13);
            this.labelafterheader.TabIndex = 2;
            this.labelafterheader.Text = "Row No After Header:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Input CSV File:";
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(467, 69);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(75, 23);
            this.btnChoose.TabIndex = 4;
            this.btnChoose.Text = "Choose File";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 99);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1241, 435);
            this.dataGridView1.TabIndex = 38;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errLabel
            // 
            this.errLabel.AutoSize = true;
            this.errLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errLabel.Location = new System.Drawing.Point(238, 11);
            this.errLabel.Name = "errLabel";
            this.errLabel.Size = new System.Drawing.Size(79, 16);
            this.errLabel.TabIndex = 39;
            this.errLabel.Text = "*Error Label";
            this.errLabel.Visible = false;
            // 
            // errLabel2
            // 
            this.errLabel2.AutoSize = true;
            this.errLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errLabel2.Location = new System.Drawing.Point(548, 72);
            this.errLabel2.Name = "errLabel2";
            this.errLabel2.Size = new System.Drawing.Size(79, 16);
            this.errLabel2.TabIndex = 40;
            this.errLabel2.Text = "*Error Label";
            this.errLabel2.Visible = false;
            // 
            // errLabelHeader
            // 
            this.errLabelHeader.AutoSize = true;
            this.errLabelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errLabelHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errLabelHeader.Location = new System.Drawing.Point(238, 42);
            this.errLabelHeader.Name = "errLabelHeader";
            this.errLabelHeader.Size = new System.Drawing.Size(79, 16);
            this.errLabelHeader.TabIndex = 43;
            this.errLabelHeader.Text = "*Error Label";
            this.errLabelHeader.Visible = false;
            // 
            // labelheader
            // 
            this.labelheader.AutoSize = true;
            this.labelheader.Location = new System.Drawing.Point(21, 45);
            this.labelheader.Name = "labelheader";
            this.labelheader.Size = new System.Drawing.Size(99, 13);
            this.labelheader.TabIndex = 42;
            this.labelheader.Text = "Row No of Header:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(126, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(106, 20);
            this.textBox2.TabIndex = 41;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(874, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "****NOTE: Row Number is always -1 of the actual row number";
            this.label1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 545);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.errLabelHeader);
            this.Controls.Add(this.labelheader);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.errLabel2);
            this.Controls.Add(this.errLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelafterheader);
            this.Controls.Add(this.file1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Parse CSV";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox file1;
        private System.Windows.Forms.Label labelafterheader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label errLabel;
        private System.Windows.Forms.Label errLabel2;
        private System.Windows.Forms.Label errLabelHeader;
        private System.Windows.Forms.Label labelheader;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
    }
}

