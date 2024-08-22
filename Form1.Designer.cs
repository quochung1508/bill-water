namespace Bill_Water
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            l = new Label();
            label2 = new Label();
            label3 = new Label();
            btnLogin = new Button();
            btnExit = new Button();
            tbName = new TextBox();
            tbPass = new TextBox();
            SuspendLayout();
            // 
            // l
            // 
            l.AutoSize = true;
            l.Location = new Point(210, 152);
            l.Name = "l";
            l.Size = new Size(120, 20);
            l.TabIndex = 0;
            l.Text = "Enter Your Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(210, 228);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 1;
            label2.Text = "Enter Your Pass";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.MenuHighlight;
            label3.Location = new Point(344, 19);
            label3.Name = "label3";
            label3.Size = new Size(135, 50);
            label3.TabIndex = 2;
            label3.Text = "LOGIN";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(289, 338);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(481, 338);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // tbName
            // 
            tbName.Location = new Point(368, 149);
            tbName.Name = "tbName";
            tbName.Size = new Size(207, 27);
            tbName.TabIndex = 0;
            // 
            // tbPass
            // 
            tbPass.Location = new Point(368, 225);
            tbPass.Name = "tbPass";
            tbPass.PasswordChar = '*';
            tbPass.Size = new Size(207, 27);
            tbPass.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(tbPass);
            Controls.Add(tbName);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(l);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label l;
        private Label label2;
        private Label label3;
        private Button btnLogin;
        private Button btnExit;
        private TextBox tbName;
        private TextBox tbPass;
    }
}
