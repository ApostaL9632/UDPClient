namespace udpClient
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
            button1 = new Button();
            Text = new TextBox();
            IpTo = new TextBox();
            Command = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(555, 68);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Text
            // 
            Text.Location = new Point(394, 69);
            Text.Name = "Text";
            Text.Size = new Size(100, 23);
            Text.TabIndex = 1;
            // 
            // IpTo
            // 
            IpTo.Location = new Point(240, 69);
            IpTo.Name = "IpTo";
            IpTo.Size = new Size(100, 23);
            IpTo.TabIndex = 2;
            // 
            // Command
            // 
            Command.Location = new Point(93, 69);
            Command.Name = "Command";
            Command.Size = new Size(100, 23);
            Command.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(394, 51);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 4;
            label1.Text = "Text";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(240, 51);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 5;
            label2.Text = "IpTo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 51);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 6;
            label3.Text = "Command";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Command);
            Controls.Add(IpTo);
            Controls.Add(Text);
            Controls.Add(button1);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox Text;
        private TextBox IpTo;
        private TextBox Command;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
