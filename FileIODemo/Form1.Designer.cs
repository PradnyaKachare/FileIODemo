
namespace FileIODemo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.btnCreateDictionary = new System.Windows.Forms.Button();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnWriteStream = new System.Windows.Forms.Button();
            this.btnReadStream = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Name";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(276, 119);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(276, 163);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 3;
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(150, 270);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(69, 23);
            this.btnWrite.TabIndex = 4;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(301, 270);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 5;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter Location";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(276, 208);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(100, 20);
            this.txtLocation.TabIndex = 7;
            // 
            // btnCreateDictionary
            // 
            this.btnCreateDictionary.Location = new System.Drawing.Point(150, 331);
            this.btnCreateDictionary.Name = "btnCreateDictionary";
            this.btnCreateDictionary.Size = new System.Drawing.Size(82, 41);
            this.btnCreateDictionary.TabIndex = 8;
            this.btnCreateDictionary.Text = "Create Dictionary";
            this.btnCreateDictionary.UseVisualStyleBackColor = true;
            this.btnCreateDictionary.Click += new System.EventHandler(this.btnCreateDictionary_Click);
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Location = new System.Drawing.Point(301, 331);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(75, 41);
            this.btnCreateFile.TabIndex = 9;
            this.btnCreateFile.Text = "Create File";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(429, 119);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // btnWriteStream
            // 
            this.btnWriteStream.Location = new System.Drawing.Point(429, 270);
            this.btnWriteStream.Name = "btnWriteStream";
            this.btnWriteStream.Size = new System.Drawing.Size(115, 23);
            this.btnWriteStream.TabIndex = 11;
            this.btnWriteStream.Text = "Write using Stream";
            this.btnWriteStream.UseVisualStyleBackColor = true;
            this.btnWriteStream.Click += new System.EventHandler(this.btnWriteStream_Click);
            // 
            // btnReadStream
            // 
            this.btnReadStream.Location = new System.Drawing.Point(429, 331);
            this.btnReadStream.Name = "btnReadStream";
            this.btnReadStream.Size = new System.Drawing.Size(115, 28);
            this.btnReadStream.TabIndex = 12;
            this.btnReadStream.Text = "Read Using Stream";
            this.btnReadStream.UseVisualStyleBackColor = true;
            this.btnReadStream.Click += new System.EventHandler(this.btnReadStream_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 450);
            this.Controls.Add(this.btnReadStream);
            this.Controls.Add(this.btnWriteStream);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnCreateFile);
            this.Controls.Add(this.btnCreateDictionary);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Department Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button btnCreateDictionary;
        private System.Windows.Forms.Button btnCreateFile;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnWriteStream;
        private System.Windows.Forms.Button btnReadStream;
    }
}

