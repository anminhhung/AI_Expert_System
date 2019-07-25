using System;

namespace ExpertSystem
{
    partial class TuVan
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
            this.label4 = new System.Windows.Forms.Label();
            this.cbHocLuc = new System.Windows.Forms.ComboBox();
            this.cbKhoi = new System.Windows.Forms.ComboBox();
            this.cbNhomNganh = new System.Windows.Forms.ComboBox();
            this.cbSoThich = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.richKQ = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Học lực của bạn:";
            this.label1.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Chọn khối bạn muốn thi:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(321, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Chọn nhóm ngành nghề bạn muốn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Chọn sở thích của bạn:";
            // 
            // cbHocLuc
            // 
            this.cbHocLuc.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cbHocLuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHocLuc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHocLuc.FormattingEnabled = true;
            this.cbHocLuc.Location = new System.Drawing.Point(396, 17);
            this.cbHocLuc.Name = "cbHocLuc";
            this.cbHocLuc.Size = new System.Drawing.Size(359, 30);
            this.cbHocLuc.TabIndex = 14;
            // 
            // cbKhoi
            // 
            this.cbKhoi.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cbKhoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhoi.FormattingEnabled = true;
            this.cbKhoi.Location = new System.Drawing.Point(396, 61);
            this.cbKhoi.Name = "cbKhoi";
            this.cbKhoi.Size = new System.Drawing.Size(359, 30);
            this.cbKhoi.TabIndex = 14;
            // 
            // cbNhomNganh
            // 
            this.cbNhomNganh.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cbNhomNganh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNhomNganh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNhomNganh.FormattingEnabled = true;
            this.cbNhomNganh.Location = new System.Drawing.Point(396, 102);
            this.cbNhomNganh.Name = "cbNhomNganh";
            this.cbNhomNganh.Size = new System.Drawing.Size(359, 30);
            this.cbNhomNganh.TabIndex = 14;
            // 
            // cbSoThich
            // 
            this.cbSoThich.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cbSoThich.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSoThich.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSoThich.FormattingEnabled = true;
            this.cbSoThich.Location = new System.Drawing.Point(396, 145);
            this.cbSoThich.Name = "cbSoThich";
            this.cbSoThich.Size = new System.Drawing.Size(359, 30);
            this.cbSoThich.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(396, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 39);
            this.button1.TabIndex = 22;
            this.button1.Text = "Tư Vấn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(613, 201);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(142, 39);
            this.btnReset.TabIndex = 23;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 36);
            this.label5.TabIndex = 24;
            this.label5.Text = "Kết quả:";
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.progressBar.Location = new System.Drawing.Point(296, 257);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(458, 27);
            this.progressBar.TabIndex = 25;
            // 
            // richKQ
            // 
            this.richKQ.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richKQ.Location = new System.Drawing.Point(296, 302);
            this.richKQ.Name = "richKQ";
            this.richKQ.Size = new System.Drawing.Size(458, 108);
            this.richKQ.TabIndex = 26;
            this.richKQ.Text = "";
            // 
            // TuVan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richKQ);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbSoThich);
            this.Controls.Add(this.cbNhomNganh);
            this.Controls.Add(this.cbKhoi);
            this.Controls.Add(this.cbHocLuc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TuVan";
            this.Text = "TuVan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbHocLuc;
        private System.Windows.Forms.ComboBox cbKhoi;
        private System.Windows.Forms.ComboBox cbNhomNganh;
        private System.Windows.Forms.ComboBox cbSoThich;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnReset;
        private EventHandler Button1_Click;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.RichTextBox richKQ;
        private EventHandler Label5_Click;
    }
}