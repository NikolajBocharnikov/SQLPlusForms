
namespace SQLPlusForms.Forms
{
    partial class RegForm
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
            this.RegBtn = new System.Windows.Forms.Button();
            this.NewPassBox = new System.Windows.Forms.TextBox();
            this.NewLoginBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.BackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RegBtn
            // 
            this.RegBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.RegBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegBtn.Location = new System.Drawing.Point(46, 258);
            this.RegBtn.Name = "RegBtn";
            this.RegBtn.Size = new System.Drawing.Size(100, 30);
            this.RegBtn.TabIndex = 0;
            this.RegBtn.Text = "Registration";
            this.RegBtn.UseVisualStyleBackColor = false;
            this.RegBtn.Click += new System.EventHandler(this.RegBtn_Click);
            // 
            // NewPassBox
            // 
            this.NewPassBox.Location = new System.Drawing.Point(104, 102);
            this.NewPassBox.Name = "NewPassBox";
            this.NewPassBox.Size = new System.Drawing.Size(100, 22);
            this.NewPassBox.TabIndex = 2;
            this.NewPassBox.Text = "Password";
            // 
            // NewLoginBox
            // 
            this.NewLoginBox.Location = new System.Drawing.Point(104, 74);
            this.NewLoginBox.Name = "NewLoginBox";
            this.NewLoginBox.Size = new System.Drawing.Size(100, 22);
            this.NewLoginBox.TabIndex = 3;
            this.NewLoginBox.Text = "Login";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(104, 130);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 22);
            this.NameBox.TabIndex = 4;
            this.NameBox.Text = "Name";
            // 
            // SurnameBox
            // 
            this.SurnameBox.Location = new System.Drawing.Point(104, 158);
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(100, 22);
            this.SurnameBox.TabIndex = 5;
            this.SurnameBox.Text = "Surname";
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(104, 186);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(100, 22);
            this.PhoneBox.TabIndex = 6;
            this.PhoneBox.Text = "PhoneNumber";
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Location = new System.Drawing.Point(152, 258);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(100, 30);
            this.BackBtn.TabIndex = 1;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(296, 314);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.SurnameBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.NewLoginBox);
            this.Controls.Add(this.NewPassBox);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.RegBtn);
            this.Name = "RegForm";
            this.Text = "RegForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RegBtn;
        private System.Windows.Forms.TextBox NewPassBox;
        private System.Windows.Forms.TextBox NewLoginBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox SurnameBox;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.Button BackBtn;
    }
}