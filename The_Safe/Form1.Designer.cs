namespace The_Safe
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
            this.Txt_Status = new System.Windows.Forms.TextBox();
            this.Btn_Set_Combination = new System.Windows.Forms.Button();
            this.Test_Key = new System.Windows.Forms.Button();
            this.Enter_Key = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Txt_Status
            // 
            this.Txt_Status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Txt_Status.Location = new System.Drawing.Point(79, 31);
            this.Txt_Status.Name = "Txt_Status";
            this.Txt_Status.ReadOnly = true;
            this.Txt_Status.Size = new System.Drawing.Size(113, 20);
            this.Txt_Status.TabIndex = 0;
            this.Txt_Status.Text = "Combination Not Set";
            this.Txt_Status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_Status.TextChanged += new System.EventHandler(this.Txt_Status_TextChanged);
            // 
            // Btn_Set_Combination
            // 
            this.Btn_Set_Combination.Location = new System.Drawing.Point(68, 189);
            this.Btn_Set_Combination.Name = "Btn_Set_Combination";
            this.Btn_Set_Combination.Size = new System.Drawing.Size(136, 23);
            this.Btn_Set_Combination.TabIndex = 1;
            this.Btn_Set_Combination.Text = "Set The Combination";
            this.Btn_Set_Combination.UseVisualStyleBackColor = true;
            this.Btn_Set_Combination.Click += new System.EventHandler(this.Btn_Set_Combination_Click);
            // 
            // Test_Key
            // 
            this.Test_Key.Location = new System.Drawing.Point(95, 160);
            this.Test_Key.Name = "Test_Key";
            this.Test_Key.Size = new System.Drawing.Size(75, 23);
            this.Test_Key.TabIndex = 2;
            this.Test_Key.UseVisualStyleBackColor = true;
            this.Test_Key.Click += new System.EventHandler(this.Test_Key_Click);
            // 
            // Enter_Key
            // 
            this.Enter_Key.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Enter_Key.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Enter_Key.Location = new System.Drawing.Point(79, 123);
            this.Enter_Key.Name = "Enter_Key";
            this.Enter_Key.PasswordChar = '*';
            this.Enter_Key.Size = new System.Drawing.Size(113, 13);
            this.Enter_Key.TabIndex = 3;
            this.Enter_Key.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Enter_Key.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(92, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 13);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Safe Status";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.textBox2.Location = new System.Drawing.Point(79, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Enter The Key";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Enter_Key);
            this.Controls.Add(this.Test_Key);
            this.Controls.Add(this.Btn_Set_Combination);
            this.Controls.Add(this.Txt_Status);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Status;
        private System.Windows.Forms.Button Btn_Set_Combination;
        private System.Windows.Forms.Button Test_Key;
        private System.Windows.Forms.TextBox Enter_Key;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

