namespace ytdl_gui
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(131, 32);
            label1.TabIndex = 0;
            label1.Text = "Changelog";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(24, 177);
            label2.Name = "label2";
            label2.Size = new Size(222, 17);
            label2.TabIndex = 1;
            label2.Text = "Wersja 1.0.1 (Kompilacja: 30.05.2024)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(46, 210);
            label3.Name = "label3";
            label3.Size = new Size(535, 105);
            label3.TabIndex = 2;
            label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label4.ForeColor = Color.DarkCyan;
            label4.Location = new Point(24, 332);
            label4.Name = "label4";
            label4.Size = new Size(222, 17);
            label4.TabIndex = 3;
            label4.Text = "Wersja 1.0.0 (Kompilacja: 19.05.2024)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(46, 85);
            label5.Name = "label5";
            label5.Size = new Size(554, 75);
            label5.TabIndex = 4;
            label5.Text = resources.GetString("label5.Text");
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label6.ForeColor = Color.DarkCyan;
            label6.Location = new Point(24, 53);
            label6.Name = "label6";
            label6.Size = new Size(224, 17);
            label6.TabIndex = 5;
            label6.Text = "Wersja 1.0.2 (Kompilacja: 30.07.2024)";
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 401);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(660, 440);
            MinimizeBox = false;
            MinimumSize = new Size(660, 440);
            Name = "Form8";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ostatnie zmiany ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}