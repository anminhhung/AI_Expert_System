namespace ExpertSystem
{
    partial class Main
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
            this.btnSuKien = new System.Windows.Forms.Button();
            this.btnTuVan = new System.Windows.Forms.Button();
            this.btnLuat = new System.Windows.Forms.Button();
            this.btnThongTin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSuKien
            // 
            this.btnSuKien.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSuKien.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuKien.Location = new System.Drawing.Point(640, 323);
            this.btnSuKien.Name = "btnSuKien";
            this.btnSuKien.Size = new System.Drawing.Size(133, 53);
            this.btnSuKien.TabIndex = 0;
            this.btnSuKien.Text = "Quản Lý Sự Kiện";
            this.btnSuKien.UseVisualStyleBackColor = false;
            this.btnSuKien.Click += new System.EventHandler(this.BtnSuKien_Click);
            // 
            // btnTuVan
            // 
            this.btnTuVan.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnTuVan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTuVan.Location = new System.Drawing.Point(276, 323);
            this.btnTuVan.Name = "btnTuVan";
            this.btnTuVan.Size = new System.Drawing.Size(133, 53);
            this.btnTuVan.TabIndex = 1;
            this.btnTuVan.Text = "Tư Vấn Ngành Nghề";
            this.btnTuVan.UseVisualStyleBackColor = false;
            this.btnTuVan.Click += new System.EventHandler(this.BtnTuVan_Click);
            // 
            // btnLuat
            // 
            this.btnLuat.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnLuat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuat.Location = new System.Drawing.Point(457, 323);
            this.btnLuat.Name = "btnLuat";
            this.btnLuat.Size = new System.Drawing.Size(133, 53);
            this.btnLuat.TabIndex = 2;
            this.btnLuat.Text = "Quản Lý Luật";
            this.btnLuat.UseVisualStyleBackColor = false;
            this.btnLuat.Click += new System.EventHandler(this.BtnLuat_Click);
            // 
            // btnThongTin
            // 
            this.btnThongTin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnThongTin.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.btnThongTin.Location = new System.Drawing.Point(93, 323);
            this.btnThongTin.Name = "btnThongTin";
            this.btnThongTin.Size = new System.Drawing.Size(133, 53);
            this.btnThongTin.TabIndex = 3;
            this.btnThongTin.Text = "Thông Tin Chung";
            this.btnThongTin.UseVisualStyleBackColor = false;
            this.btnThongTin.Click += new System.EventHandler(this.BtnThongTin_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = global::ExpertSystem.Properties.Resources.Ai_final;
            this.ClientSize = new System.Drawing.Size(814, 456);
            this.Controls.Add(this.btnThongTin);
            this.Controls.Add(this.btnLuat);
            this.Controls.Add(this.btnTuVan);
            this.Controls.Add(this.btnSuKien);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSuKien;
        private System.Windows.Forms.Button btnTuVan;
        private System.Windows.Forms.Button btnLuat;
        private System.Windows.Forms.Button btnThongTin;
    }
}

