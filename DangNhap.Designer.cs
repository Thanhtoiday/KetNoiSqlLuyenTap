namespace KetNoiSqlLuyenTap
{
    partial class DangNhap
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
            this.username_txt = new System.Windows.Forms.TextBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.sigiin_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // username_txt
            // 
            this.username_txt.Location = new System.Drawing.Point(325, 116);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(171, 22);
            this.username_txt.TabIndex = 2;
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(325, 193);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(171, 22);
            this.password_txt.TabIndex = 3;
            this.password_txt.TextChanged += new System.EventHandler(this.password_txt_TextChanged);
            // 
            // sigiin_btn
            // 
            this.sigiin_btn.Location = new System.Drawing.Point(205, 292);
            this.sigiin_btn.Name = "sigiin_btn";
            this.sigiin_btn.Size = new System.Drawing.Size(99, 43);
            this.sigiin_btn.TabIndex = 4;
            this.sigiin_btn.Text = "Đăng nhập";
            this.sigiin_btn.UseVisualStyleBackColor = true;
            this.sigiin_btn.Click += new System.EventHandler(this.sigiin_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exit_btn.Location = new System.Drawing.Point(448, 292);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(99, 44);
            this.exit_btn.TabIndex = 5;
            this.exit_btn.Text = "Thoát";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // DangNhap
            // 
            this.AcceptButton = this.sigiin_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exit_btn;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.sigiin_btn);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.username_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangNhap";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Button sigiin_btn;
        private System.Windows.Forms.Button exit_btn;
    }
}