
namespace FileIODemo
{
    partial class Form2
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.btnBinarWrite = new System.Windows.Forms.Button();
            this.btnXMLWrite = new System.Windows.Forms.Button();
            this.btnSOAPWrite = new System.Windows.Forms.Button();
            this.btnJSONWrite = new System.Windows.Forms.Button();
            this.btnBinaryRead = new System.Windows.Forms.Button();
            this.btnXMLRead = new System.Windows.Forms.Button();
            this.btnSoapRread = new System.Windows.Forms.Button();
            this.btnJSONRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Emp Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Emp Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Emp Salary";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(351, 62);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(351, 109);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(351, 151);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 20);
            this.txtSalary.TabIndex = 5;
            // 
            // btnBinarWrite
            // 
            this.btnBinarWrite.Location = new System.Drawing.Point(143, 260);
            this.btnBinarWrite.Name = "btnBinarWrite";
            this.btnBinarWrite.Size = new System.Drawing.Size(75, 23);
            this.btnBinarWrite.TabIndex = 6;
            this.btnBinarWrite.Text = "Binary Write";
            this.btnBinarWrite.UseVisualStyleBackColor = true;
            this.btnBinarWrite.Click += new System.EventHandler(this.btnBinarWrite_Click);
            // 
            // btnXMLWrite
            // 
            this.btnXMLWrite.Location = new System.Drawing.Point(224, 260);
            this.btnXMLWrite.Name = "btnXMLWrite";
            this.btnXMLWrite.Size = new System.Drawing.Size(75, 23);
            this.btnXMLWrite.TabIndex = 7;
            this.btnXMLWrite.Text = "XML Write";
            this.btnXMLWrite.UseVisualStyleBackColor = true;
            this.btnXMLWrite.Click += new System.EventHandler(this.btnXMLWrite_Click);
            // 
            // btnSOAPWrite
            // 
            this.btnSOAPWrite.Location = new System.Drawing.Point(318, 260);
            this.btnSOAPWrite.Name = "btnSOAPWrite";
            this.btnSOAPWrite.Size = new System.Drawing.Size(75, 23);
            this.btnSOAPWrite.TabIndex = 8;
            this.btnSOAPWrite.Text = "SOAP Write";
            this.btnSOAPWrite.UseVisualStyleBackColor = true;
            this.btnSOAPWrite.Click += new System.EventHandler(this.btnSOAPWrite_Click);
            // 
            // btnJSONWrite
            // 
            this.btnJSONWrite.Location = new System.Drawing.Point(412, 260);
            this.btnJSONWrite.Name = "btnJSONWrite";
            this.btnJSONWrite.Size = new System.Drawing.Size(75, 23);
            this.btnJSONWrite.TabIndex = 9;
            this.btnJSONWrite.Text = "JSON Write";
            this.btnJSONWrite.UseVisualStyleBackColor = true;
            this.btnJSONWrite.Click += new System.EventHandler(this.btnJSONWrite_Click);
            // 
            // btnBinaryRead
            // 
            this.btnBinaryRead.Location = new System.Drawing.Point(143, 305);
            this.btnBinaryRead.Name = "btnBinaryRead";
            this.btnBinaryRead.Size = new System.Drawing.Size(75, 23);
            this.btnBinaryRead.TabIndex = 10;
            this.btnBinaryRead.Text = "Binary Read";
            this.btnBinaryRead.UseVisualStyleBackColor = true;
            this.btnBinaryRead.Click += new System.EventHandler(this.btnBinaryRead_Click_1);
            // 
            // btnXMLRead
            // 
            this.btnXMLRead.Location = new System.Drawing.Point(224, 305);
            this.btnXMLRead.Name = "btnXMLRead";
            this.btnXMLRead.Size = new System.Drawing.Size(75, 23);
            this.btnXMLRead.TabIndex = 11;
            this.btnXMLRead.Text = "XML Read";
            this.btnXMLRead.UseVisualStyleBackColor = true;
            this.btnXMLRead.Click += new System.EventHandler(this.btnXMLRead_Click);
            // 
            // btnSoapRread
            // 
            this.btnSoapRread.Location = new System.Drawing.Point(318, 305);
            this.btnSoapRread.Name = "btnSoapRread";
            this.btnSoapRread.Size = new System.Drawing.Size(75, 23);
            this.btnSoapRread.TabIndex = 12;
            this.btnSoapRread.Text = "SOAP Read";
            this.btnSoapRread.UseVisualStyleBackColor = true;
            this.btnSoapRread.Click += new System.EventHandler(this.btnSoapRread_Click);
            // 
            // btnJSONRead
            // 
            this.btnJSONRead.Location = new System.Drawing.Point(412, 305);
            this.btnJSONRead.Name = "btnJSONRead";
            this.btnJSONRead.Size = new System.Drawing.Size(75, 23);
            this.btnJSONRead.TabIndex = 13;
            this.btnJSONRead.Text = "JSON Read";
            this.btnJSONRead.UseVisualStyleBackColor = true;
            this.btnJSONRead.Click += new System.EventHandler(this.btnJSONRead_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnJSONRead);
            this.Controls.Add(this.btnSoapRread);
            this.Controls.Add(this.btnXMLRead);
            this.Controls.Add(this.btnBinaryRead);
            this.Controls.Add(this.btnJSONWrite);
            this.Controls.Add(this.btnSOAPWrite);
            this.Controls.Add(this.btnXMLWrite);
            this.Controls.Add(this.btnBinarWrite);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Serialisation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Button btnBinarWrite;
        private System.Windows.Forms.Button btnXMLWrite;
        private System.Windows.Forms.Button btnSOAPWrite;
        private System.Windows.Forms.Button btnJSONWrite;
        private System.Windows.Forms.Button btnBinaryRead;
        private System.Windows.Forms.Button btnXMLRead;
        private System.Windows.Forms.Button btnSoapRread;
        private System.Windows.Forms.Button btnJSONRead;
    }
}