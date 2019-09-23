namespace _2_sayiyi_toplama
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
            this.lblBirinciSayi = new System.Windows.Forms.Label();
            this.lblİkinciSayi = new System.Windows.Forms.Label();
            this.txtboxBirinciSayi = new System.Windows.Forms.TextBox();
            this.txtboxİkinciSayi = new System.Windows.Forms.TextBox();
            this.btnToplama = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lvLog = new System.Windows.Forms.ListView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBirinciSayi
            // 
            this.lblBirinciSayi.AutoSize = true;
            this.lblBirinciSayi.Location = new System.Drawing.Point(63, 65);
            this.lblBirinciSayi.Name = "lblBirinciSayi";
            this.lblBirinciSayi.Size = new System.Drawing.Size(58, 13);
            this.lblBirinciSayi.TabIndex = 0;
            this.lblBirinciSayi.Text = "Birinci Sayi";
            // 
            // lblİkinciSayi
            // 
            this.lblİkinciSayi.AutoSize = true;
            this.lblİkinciSayi.Location = new System.Drawing.Point(63, 114);
            this.lblİkinciSayi.Name = "lblİkinciSayi";
            this.lblİkinciSayi.Size = new System.Drawing.Size(55, 13);
            this.lblİkinciSayi.TabIndex = 1;
            this.lblİkinciSayi.Text = "İkinci Sayi";
            // 
            // txtboxBirinciSayi
            // 
            this.txtboxBirinciSayi.Location = new System.Drawing.Point(141, 62);
            this.txtboxBirinciSayi.Name = "txtboxBirinciSayi";
            this.txtboxBirinciSayi.Size = new System.Drawing.Size(100, 20);
            this.txtboxBirinciSayi.TabIndex = 2;
            this.txtboxBirinciSayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxBirinciSayi_KeyPress);
            // 
            // txtboxİkinciSayi
            // 
            this.txtboxİkinciSayi.Location = new System.Drawing.Point(141, 111);
            this.txtboxİkinciSayi.Name = "txtboxİkinciSayi";
            this.txtboxİkinciSayi.Size = new System.Drawing.Size(100, 20);
            this.txtboxİkinciSayi.TabIndex = 3;
            this.txtboxİkinciSayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxİkinciSayi_KeyPress);
            // 
            // btnToplama
            // 
            this.btnToplama.Location = new System.Drawing.Point(66, 151);
            this.btnToplama.Name = "btnToplama";
            this.btnToplama.Size = new System.Drawing.Size(175, 23);
            this.btnToplama.TabIndex = 4;
            this.btnToplama.Text = "Topla";
            this.btnToplama.UseVisualStyleBackColor = true;
            this.btnToplama.Click += new System.EventHandler(this.btnToplama_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(329, 297);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtboxİkinciSayi);
            this.tabPage1.Controls.Add(this.lblİkinciSayi);
            this.tabPage1.Controls.Add(this.txtboxBirinciSayi);
            this.tabPage1.Controls.Add(this.btnToplama);
            this.tabPage1.Controls.Add(this.lblBirinciSayi);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(321, 271);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Toplama";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lvLog);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(321, 271);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Log";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lvLog
            // 
            this.lvLog.Location = new System.Drawing.Point(6, 0);
            this.lvLog.Name = "lvLog";
            this.lvLog.Size = new System.Drawing.Size(309, 265);
            this.lvLog.TabIndex = 0;
            this.lvLog.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 412);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toplama Uygulaması";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBirinciSayi;
        private System.Windows.Forms.Label lblİkinciSayi;
        private System.Windows.Forms.TextBox txtboxBirinciSayi;
        private System.Windows.Forms.TextBox txtboxİkinciSayi;
        private System.Windows.Forms.Button btnToplama;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView lvLog;
    }
}

