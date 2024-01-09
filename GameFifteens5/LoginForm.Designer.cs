namespace GameFifteens2
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            registerLabel = new Label();
            passField = new TextBox();
            loginField = new TextBox();
            buttonLogin = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            closeButton = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(144, 180, 188);
            panel1.Controls.Add(registerLabel);
            panel1.Controls.Add(passField);
            panel1.Controls.Add(loginField);
            panel1.Controls.Add(buttonLogin);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(737, 551);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // registerLabel
            // 
            registerLabel.AutoSize = true;
            registerLabel.Cursor = Cursors.Hand;
            registerLabel.Font = new Font("Comic Sans MS", 12F, FontStyle.Italic, GraphicsUnit.Point);
            registerLabel.ForeColor = Color.Blue;
            registerLabel.Location = new Point(298, 492);
            registerLabel.Name = "registerLabel";
            registerLabel.Size = new Size(151, 23);
            registerLabel.TabIndex = 8;
            registerLabel.Text = "Ещё нет аккаунта?";
            registerLabel.TextAlign = ContentAlignment.MiddleCenter;
            registerLabel.Click += registerLabel_Click_1;
            // 
            // passField
            // 
            passField.BorderStyle = BorderStyle.None;
            passField.Font = new Font("Comic Sans MS", 26.25F, FontStyle.Italic, GraphicsUnit.Point);
            passField.ForeColor = Color.FromArgb(73, 89, 91);
            passField.Location = new Point(216, 282);
            passField.Name = "passField";
            passField.Size = new Size(364, 49);
            passField.TabIndex = 4;
            passField.TextChanged += passField_TextChanged;
            passField.Enter += passField_Enter;
            passField.Leave += passField_Leave;
            // 
            // loginField
            // 
            loginField.BorderStyle = BorderStyle.None;
            loginField.Font = new Font("Comic Sans MS", 26.25F, FontStyle.Italic, GraphicsUnit.Point);
            loginField.ForeColor = Color.FromArgb(73, 89, 91);
            loginField.Location = new Point(216, 183);
            loginField.Name = "loginField";
            loginField.Size = new Size(364, 49);
            loginField.TabIndex = 3;
            loginField.Enter += loginField_Enter;
            loginField.Leave += loginField_Leave;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = SystemColors.Window;
            buttonLogin.Cursor = Cursors.Hand;
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Comic Sans MS", 15F, FontStyle.Italic, GraphicsUnit.Point);
            buttonLogin.ForeColor = Color.FromArgb(73, 89, 91);
            buttonLogin.Location = new Point(256, 410);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(233, 59);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Войти";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(135, 282);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(135, 183);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(132, 174, 184);
            panel2.Controls.Add(closeButton);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(737, 100);
            panel2.TabIndex = 0;
            // 
            // closeButton
            // 
            closeButton.AutoSize = true;
            closeButton.Cursor = Cursors.Hand;
            closeButton.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point);
            closeButton.ForeColor = Color.FromArgb(61, 74, 77);
            closeButton.Location = new Point(708, 0);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(29, 33);
            closeButton.TabIndex = 1;
            closeButton.Text = "x";
            closeButton.Click += closeButton_Click;
            closeButton.MouseEnter += closeButton_MouseEnter;
            closeButton.MouseLeave += closeButton_MouseLeave;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Comic Sans MS", 32F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(73, 89, 91);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(737, 100);
            label1.TabIndex = 0;
            label1.Text = "Авторизация";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.MouseDown += panel1_MouseDown;
            label1.MouseMove += panel1_MouseMove;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 551);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label closeButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button buttonLogin;
        private TextBox loginField;
        private TextBox passField;
        private Label registerLabel;
    }
}