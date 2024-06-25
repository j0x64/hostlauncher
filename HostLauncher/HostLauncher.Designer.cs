namespace HostLauncher
{
    partial class HostLauncher
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
            panel1 = new Panel();
            MinimizeButton = new Button();
            ExitButton = new Button();
            label2 = new Label();
            LaunchButton = new Button();
            UpdateButton = new Button();
            RemoveButton = new Button();
            DiscordButton = new Button();
            IpTextBox = new TextBox();
            TopMostCheck = new CheckBox();
            OnUpdateCheck = new CheckBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(MinimizeButton);
            panel1.Controls.Add(ExitButton);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(-4, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(782, 47);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // MinimizeButton
            // 
            MinimizeButton.BackColor = Color.FromArgb(24, 30, 54);
            MinimizeButton.FlatAppearance.BorderSize = 0;
            MinimizeButton.FlatStyle = FlatStyle.Flat;
            MinimizeButton.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MinimizeButton.ForeColor = Color.White;
            MinimizeButton.Location = new Point(682, 1);
            MinimizeButton.Name = "MinimizeButton";
            MinimizeButton.Size = new Size(43, 36);
            MinimizeButton.TabIndex = 10;
            MinimizeButton.Text = "_";
            MinimizeButton.UseVisualStyleBackColor = false;
            MinimizeButton.Click += MinimizeButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.FromArgb(24, 30, 54);
            ExitButton.FlatAppearance.BorderSize = 0;
            ExitButton.FlatStyle = FlatStyle.Flat;
            ExitButton.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitButton.ForeColor = Color.White;
            ExitButton.Location = new Point(731, 4);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(43, 36);
            ExitButton.TabIndex = 9;
            ExitButton.Text = "X";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(15, 13);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 9;
            label2.Text = "HostLauncher";
            // 
            // LaunchButton
            // 
            LaunchButton.BackColor = Color.FromArgb(24, 30, 54);
            LaunchButton.FlatAppearance.BorderSize = 0;
            LaunchButton.FlatStyle = FlatStyle.Flat;
            LaunchButton.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LaunchButton.ForeColor = Color.White;
            LaunchButton.Location = new Point(12, 365);
            LaunchButton.Name = "LaunchButton";
            LaunchButton.Size = new Size(124, 65);
            LaunchButton.TabIndex = 1;
            LaunchButton.Text = "Launch";
            LaunchButton.UseVisualStyleBackColor = false;
            LaunchButton.Click += LaunchButton_Click_1;
            // 
            // UpdateButton
            // 
            UpdateButton.BackColor = Color.FromArgb(24, 30, 54);
            UpdateButton.FlatAppearance.BorderSize = 0;
            UpdateButton.FlatStyle = FlatStyle.Flat;
            UpdateButton.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateButton.ForeColor = Color.White;
            UpdateButton.Location = new Point(151, 365);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(124, 65);
            UpdateButton.TabIndex = 2;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = false;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.BackColor = Color.FromArgb(24, 30, 54);
            RemoveButton.FlatAppearance.BorderSize = 0;
            RemoveButton.FlatStyle = FlatStyle.Flat;
            RemoveButton.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RemoveButton.ForeColor = Color.White;
            RemoveButton.Location = new Point(291, 365);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(124, 65);
            RemoveButton.TabIndex = 3;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = false;
            // 
            // DiscordButton
            // 
            DiscordButton.BackColor = Color.FromArgb(24, 30, 54);
            DiscordButton.FlatAppearance.BorderSize = 0;
            DiscordButton.FlatStyle = FlatStyle.Flat;
            DiscordButton.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DiscordButton.ForeColor = Color.White;
            DiscordButton.Location = new Point(639, 365);
            DiscordButton.Name = "DiscordButton";
            DiscordButton.Size = new Size(124, 65);
            DiscordButton.TabIndex = 4;
            DiscordButton.Text = "Github";
            DiscordButton.UseVisualStyleBackColor = false;
            DiscordButton.Click += DiscordButton_Click;
            // 
            // IpTextBox
            // 
            IpTextBox.BackColor = Color.FromArgb(24, 30, 54);
            IpTextBox.BorderStyle = BorderStyle.None;
            IpTextBox.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IpTextBox.ForeColor = Color.White;
            IpTextBox.Location = new Point(12, 138);
            IpTextBox.Name = "IpTextBox";
            IpTextBox.Size = new Size(403, 18);
            IpTextBox.TabIndex = 5;
            IpTextBox.TextChanged += textBox1_TextChanged;
            // 
            // TopMostCheck
            // 
            TopMostCheck.AutoSize = true;
            TopMostCheck.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TopMostCheck.ForeColor = Color.White;
            TopMostCheck.Location = new Point(12, 175);
            TopMostCheck.Name = "TopMostCheck";
            TopMostCheck.Size = new Size(148, 24);
            TopMostCheck.TabIndex = 6;
            TopMostCheck.Text = "Always On Top";
            TopMostCheck.UseVisualStyleBackColor = true;
            // 
            // OnUpdateCheck
            // 
            OnUpdateCheck.AutoSize = true;
            OnUpdateCheck.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OnUpdateCheck.ForeColor = Color.White;
            OnUpdateCheck.Location = new Point(12, 205);
            OnUpdateCheck.Name = "OnUpdateCheck";
            OnUpdateCheck.Size = new Size(103, 24);
            OnUpdateCheck.TabIndex = 7;
            OnUpdateCheck.Text = "OnUpdate";
            OnUpdateCheck.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 105);
            label1.Name = "label1";
            label1.Size = new Size(162, 20);
            label1.TabIndex = 8;
            label1.Text = "Insert IP Address";
            // 
            // HostLauncher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(775, 442);
            Controls.Add(label1);
            Controls.Add(OnUpdateCheck);
            Controls.Add(TopMostCheck);
            Controls.Add(IpTextBox);
            Controls.Add(DiscordButton);
            Controls.Add(RemoveButton);
            Controls.Add(UpdateButton);
            Controls.Add(LaunchButton);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HostLauncher";
            Text = "HostLauncher";
            Load += HostLauncher_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button LaunchButton;
        private Button UpdateButton;
        private Button RemoveButton;
        private Button DiscordButton;
        private TextBox IpTextBox;
        private CheckBox TopMostCheck;
        private CheckBox OnUpdateCheck;
        private Label label1;
        private Label label2;
        private Button MinimizeButton;
        private Button ExitButton;
    }
}
