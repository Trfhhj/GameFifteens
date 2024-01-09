namespace GameFifteens2
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            panel1 = new Panel();
            registerLabel = new Label();
            passField = new TextBox();
            userNameField = new TextBox();
            pictureBox5 = new PictureBox();
            pictureBox3 = new PictureBox();
            userSurnameField = new TextBox();
            pictureBox4 = new PictureBox();
            buttonRegister = new Button();
            loginField = new TextBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            closeButton = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(144, 180, 188);
            panel1.Controls.Add(registerLabel);
            panel1.Controls.Add(passField);
            panel1.Controls.Add(userNameField);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(userSurnameField);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(buttonRegister);
            panel1.Controls.Add(loginField);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1039, 548);
            panel1.TabIndex = 1;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // registerLabel
            // 
            registerLabel.AutoSize = true;
            registerLabel.Font = new Font("Comic Sans MS", 12F, FontStyle.Italic, GraphicsUnit.Point);
            registerLabel.ForeColor = Color.FromArgb(34, 39, 40);
            registerLabel.Location = new Point(442, 497);
            registerLabel.Name = "registerLabel";
            registerLabel.Size = new Size(130, 23);
            registerLabel.TabIndex = 11;
            registerLabel.Text = "Авторизоваться";
            registerLabel.TextAlign = ContentAlignment.MiddleCenter;
            registerLabel.Visible = false;
            registerLabel.Click += registerLabel_Click;
            // 
            // passField
            // 
            passField.BorderStyle = BorderStyle.None;
            passField.Font = new Font("Comic Sans MS", 26.25F, FontStyle.Italic, GraphicsUnit.Point);
            passField.ForeColor = Color.FromArgb(73, 89, 91);
            passField.Location = new Point(611, 271);
            passField.Name = "passField";
            passField.Size = new Size(364, 49);
            passField.TabIndex = 4;
            passField.TextChanged += passField_TextChanged;
            passField.Enter += passField_Enter;
            passField.Leave += passField_Leave;
            // 
            // userNameField
            // 
            userNameField.BorderStyle = BorderStyle.None;
            userNameField.Font = new Font("Comic Sans MS", 26.25F, FontStyle.Italic, GraphicsUnit.Point);
            userNameField.ForeColor = Color.FromArgb(73, 89, 91);
            userNameField.Location = new Point(123, 169);
            userNameField.Name = "userNameField";
            userNameField.Size = new Size(364, 49);
            userNameField.TabIndex = 1;
            userNameField.Enter += userNameField_Enter;
            userNameField.Leave += userNameField_Leave;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(53, 271);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(64, 64);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(541, 271);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(64, 64);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // userSurnameField
            // 
            userSurnameField.BorderStyle = BorderStyle.None;
            userSurnameField.Font = new Font("Comic Sans MS", 26.25F, FontStyle.Italic, GraphicsUnit.Point);
            userSurnameField.ForeColor = Color.FromArgb(73, 89, 91);
            userSurnameField.Location = new Point(611, 169);
            userSurnameField.Name = "userSurnameField";
            userSurnameField.Size = new Size(364, 49);
            userSurnameField.TabIndex = 2;
            userSurnameField.Enter += userSurnameField_Enter;
            userSurnameField.Leave += userSurnameField_Leave;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(541, 169);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(64, 64);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // buttonRegister
            // 
            buttonRegister.BackColor = SystemColors.Window;
            buttonRegister.Cursor = Cursors.Hand;
            buttonRegister.FlatAppearance.BorderSize = 0;
            buttonRegister.FlatStyle = FlatStyle.Flat;
            buttonRegister.Font = new Font("Comic Sans MS", 15F, FontStyle.Italic, GraphicsUnit.Point);
            buttonRegister.ForeColor = Color.FromArgb(73, 89, 91);
            buttonRegister.Location = new Point(394, 418);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(251, 55);
            buttonRegister.TabIndex = 5;
            buttonRegister.Text = "Зарегистрироваться";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // loginField
            // 
            loginField.BorderStyle = BorderStyle.None;
            loginField.Font = new Font("Comic Sans MS", 26.25F, FontStyle.Italic, GraphicsUnit.Point);
            loginField.ForeColor = Color.FromArgb(73, 89, 91);
            loginField.Location = new Point(123, 271);
            loginField.Name = "loginField";
            loginField.Size = new Size(364, 49);
            loginField.TabIndex = 3;
            loginField.Enter += loginField_Enter;
            loginField.Leave += loginField_Leave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(53, 169);
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
            panel2.Size = new Size(1039, 100);
            panel2.TabIndex = 0;
            // 
            // closeButton
            // 
            closeButton.AutoSize = true;
            closeButton.Cursor = Cursors.Hand;
            closeButton.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point);
            closeButton.ForeColor = Color.FromArgb(61, 74, 77);
            closeButton.Location = new Point(1010, 0);
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
            label1.Size = new Size(1039, 100);
            label1.TabIndex = 0;
            label1.Text = "Регистрация";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.MouseDown += panel1_MouseDown;
            label1.MouseMove += panel1_MouseMove;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 548);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox3;
        private TextBox userSurnameField;
        private PictureBox pictureBox4;
        private Button buttonRegister;
        private TextBox loginField;
        private Panel panel2;
        private Label closeButton;
        private Label label1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox1;
        private TextBox userNameField;
        private TextBox passField;
        private Label registerLabel;
    }
}