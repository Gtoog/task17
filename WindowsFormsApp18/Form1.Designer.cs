using System.Windows.Forms;

namespace WindowsFormsApp18
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnSelectFiles;
        private Button btnZip;
        private Button btnUnzip;
        private TextBox txtZipPath;
        private TextBox txtUnzipPath;
        private Label lblZipPath;
        private Label lblUnzipPath;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnSelectFiles = new System.Windows.Forms.Button();
            this.btnZip = new System.Windows.Forms.Button();
            this.btnUnzip = new System.Windows.Forms.Button();
            this.txtZipPath = new System.Windows.Forms.TextBox();
            this.txtUnzipPath = new System.Windows.Forms.TextBox();
            this.lblZipPath = new System.Windows.Forms.Label();
            this.lblUnzipPath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSelectFiles
            // 
            this.btnSelectFiles.Location = new System.Drawing.Point(30, 30);
            this.btnSelectFiles.Name = "btnSelectFiles";
            this.btnSelectFiles.Size = new System.Drawing.Size(200, 40);
            this.btnSelectFiles.TabIndex = 0;
            this.btnSelectFiles.Text = "Выбрать файлы для сжатия";
            this.btnSelectFiles.Click += new System.EventHandler(this.btnSelectFiles_Click);
            // 
            // btnZip
            // 
            this.btnZip.Location = new System.Drawing.Point(30, 90);
            this.btnZip.Name = "btnZip";
            this.btnZip.Size = new System.Drawing.Size(200, 40);
            this.btnZip.TabIndex = 1;
            this.btnZip.Text = "Сжать в ZIP";
            this.btnZip.Click += new System.EventHandler(this.btnZip_Click);
            // 
            // btnUnzip
            // 
            this.btnUnzip.Location = new System.Drawing.Point(30, 200);
            this.btnUnzip.Name = "btnUnzip";
            this.btnUnzip.Size = new System.Drawing.Size(200, 40);
            this.btnUnzip.TabIndex = 2;
            this.btnUnzip.Text = "Распаковать ZIP";
            this.btnUnzip.Click += new System.EventHandler(this.btnUnzip_Click);
            // 
            // txtZipPath
            // 
            this.txtZipPath.Location = new System.Drawing.Point(30, 160);
            this.txtZipPath.Name = "txtZipPath";
            this.txtZipPath.Size = new System.Drawing.Size(400, 20);
            this.txtZipPath.TabIndex = 3;
            // 
            // txtUnzipPath
            // 
            this.txtUnzipPath.Location = new System.Drawing.Point(30, 270);
            this.txtUnzipPath.Name = "txtUnzipPath";
            this.txtUnzipPath.Size = new System.Drawing.Size(400, 20);
            this.txtUnzipPath.TabIndex = 4;
            // 
            // lblZipPath
            // 
            this.lblZipPath.Location = new System.Drawing.Point(30, 130);
            this.lblZipPath.Name = "lblZipPath";
            this.lblZipPath.Size = new System.Drawing.Size(200, 20);
            this.lblZipPath.TabIndex = 5;
            this.lblZipPath.Text = "Путь ZIP файла:";
            // 
            // lblUnzipPath
            // 
            this.lblUnzipPath.Location = new System.Drawing.Point(30, 240);
            this.lblUnzipPath.Name = "lblUnzipPath";
            this.lblUnzipPath.Size = new System.Drawing.Size(200, 20);
            this.lblUnzipPath.TabIndex = 6;
            this.lblUnzipPath.Text = "Путь для распаковки:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(442, 310);
            this.Controls.Add(this.btnSelectFiles);
            this.Controls.Add(this.btnZip);
            this.Controls.Add(this.btnUnzip);
            this.Controls.Add(this.txtZipPath);
            this.Controls.Add(this.txtUnzipPath);
            this.Controls.Add(this.lblZipPath);
            this.Controls.Add(this.lblUnzipPath);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
