namespace UserLoginApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.txtPasswordRegister = new System.Windows.Forms.TextBox();
            this.txtEmailRegister = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegisterRegister = new System.Windows.Forms.Button();
            this.comboBoxRegister = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPasswordRegister
            // 
            this.txtPasswordRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtPasswordRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPasswordRegister.Location = new System.Drawing.Point(43, 229);
            this.txtPasswordRegister.Name = "txtPasswordRegister";
            this.txtPasswordRegister.PasswordChar = '*';
            this.txtPasswordRegister.Size = new System.Drawing.Size(300, 26);
            this.txtPasswordRegister.TabIndex = 7;
            this.txtPasswordRegister.TextChanged += new System.EventHandler(this.txtPasswordRegister_TextChanged);
            // 
            // txtEmailRegister
            // 
            this.txtEmailRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtEmailRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEmailRegister.Location = new System.Drawing.Point(43, 102);
            this.txtEmailRegister.Name = "txtEmailRegister";
            this.txtEmailRegister.Size = new System.Drawing.Size(300, 26);
            this.txtEmailRegister.TabIndex = 6;
            this.txtEmailRegister.TextChanged += new System.EventHandler(this.txtEmailRegister_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(41, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(40, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "E-mail";
            // 
            // btnRegisterRegister
            // 
            this.btnRegisterRegister.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegisterRegister.BackgroundImage")));
            this.btnRegisterRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegisterRegister.Location = new System.Drawing.Point(46, 362);
            this.btnRegisterRegister.Name = "btnRegisterRegister";
            this.btnRegisterRegister.Size = new System.Drawing.Size(172, 43);
            this.btnRegisterRegister.TabIndex = 8;
            this.btnRegisterRegister.Text = "Register";
            this.btnRegisterRegister.UseVisualStyleBackColor = true;
            this.btnRegisterRegister.Click += new System.EventHandler(this.btnRegisterRegister_Click);
            // 
            // comboBoxRegister
            // 
            this.comboBoxRegister.FormattingEnabled = true;
            this.comboBoxRegister.Items.AddRange(new object[] {
            "100",
            "200",
            "500",
            "1000"});
            this.comboBoxRegister.Location = new System.Drawing.Point(43, 313);
            this.comboBoxRegister.Name = "comboBoxRegister";
            this.comboBoxRegister.Size = new System.Drawing.Size(175, 21);
            this.comboBoxRegister.TabIndex = 9;
            this.comboBoxRegister.SelectedIndexChanged += new System.EventHandler(this.comboBoxRegister_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(38, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Select Balance";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxRegister);
            this.Controls.Add(this.btnRegisterRegister);
            this.Controls.Add(this.txtPasswordRegister);
            this.Controls.Add(this.txtEmailRegister);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPasswordRegister;
        private System.Windows.Forms.TextBox txtEmailRegister;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegisterRegister;
        private System.Windows.Forms.ComboBox comboBoxRegister;
        private System.Windows.Forms.Label label3;
    }
}