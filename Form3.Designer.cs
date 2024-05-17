namespace ytdl_gui
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox1 = new TextBox();
            label6 = new Label();
            label11 = new Label();
            label9 = new Label();
            panel2 = new Panel();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            label3 = new Label();
            textBox10 = new TextBox();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            label10 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(404, 32);
            label1.TabIndex = 0;
            label1.Text = "Najczęściej zadawane pytania (FAQ)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(15, 9);
            label2.Name = "label2";
            label2.Size = new Size(199, 19);
            label2.TabIndex = 2;
            label2.Text = "Jaki format audio wybrać?";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoScrollMargin = new Size(0, 50);
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(610, 296);
            panel1.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Location = new Point(20, 1234);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(561, 89);
            textBox5.TabIndex = 30;
            textBox5.Text = resources.GetString("textBox5.Text");
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(20, 1056);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(561, 116);
            textBox4.TabIndex = 29;
            textBox4.Text = "Moduł pobierania Spotify nie obsługuje tego formatu, dlatego w przypadu wybrania określonego formatu, \r\nzostanie on zamieniony na inny według tej listy:\r\n\r\nAAC -> MP3\r\nALAC -> M4A\r\nVORBIS -> OGG\r\n\r\n";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(16, 979);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(561, 40);
            textBox3.TabIndex = 28;
            textBox3.Text = "Jeżeli zmieniłeś domyślne ustawienia pobierania, poprzez wybór innego formatu, jakości wideo, \r\ndodaniem napisów lub ograniczeniem prędkości sieci, pobranie filmu może się wydłużyć.";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(15, 553);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(561, 389);
            textBox2.TabIndex = 27;
            textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label4.Location = new Point(15, 521);
            label4.Name = "label4";
            label4.Size = new Size(202, 19);
            label4.TabIndex = 16;
            label4.Text = "Jaki format wideo wybrać?";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(15, 40);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(561, 478);
            textBox1.TabIndex = 23;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label6.Location = new Point(16, 945);
            label6.Name = "label6";
            label6.Size = new Size(285, 19);
            label6.TabIndex = 26;
            label6.Text = "Dlaczego pobieranie filmu jest wolne?";
            // 
            // label11
            // 
            label11.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label11.Location = new Point(20, 1175);
            label11.Name = "label11";
            label11.Size = new Size(561, 46);
            label11.TabIndex = 21;
            label11.Text = "[Spotify/YouTube Music] Podczas pobierania wyświetla się komunikat o ograniczeniu jakości. Jak to naprawić?";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label9.Location = new Point(15, 1022);
            label9.Name = "label9";
            label9.Size = new Size(574, 19);
            label9.TabIndex = 19;
            label9.Text = "[Spotify] Dlaczego po wybraniu formatu ALAC, AAC mam pobrany inny format?";
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.AutoScrollMargin = new Size(0, 50);
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(textBox8);
            panel2.Controls.Add(textBox9);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox10);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label10);
            panel2.Enabled = false;
            panel2.Location = new Point(12, 53);
            panel2.Name = "panel2";
            panel2.Size = new Size(610, 296);
            panel2.TabIndex = 4;
            panel2.Visible = false;
            // 
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Location = new Point(15, 1124);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(561, 89);
            textBox6.TabIndex = 30;
            textBox6.Text = resources.GetString("textBox6.Text");
            // 
            // textBox7
            // 
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Location = new Point(15, 960);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(561, 98);
            textBox7.TabIndex = 29;
            textBox7.Text = "Spotify's download module does not support this format, so if you select a certain format, it will be converted to another according to this list: \r\n\r\nAAC - MP3, \r\nALAC - M4A, \r\nVORBIS -> OGG";
            // 
            // textBox8
            // 
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Location = new Point(15, 868);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(561, 40);
            textBox8.TabIndex = 28;
            textBox8.Text = "If you have changed the default download settings, by choosing a different format, video quality, adding subtitles or limiting network speed, downloading the video may take longer.";
            // 
            // textBox9
            // 
            textBox9.BorderStyle = BorderStyle.None;
            textBox9.Location = new Point(15, 484);
            textBox9.Multiline = true;
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(561, 347);
            textBox9.TabIndex = 27;
            textBox9.Text = resources.GetString("textBox9.Text");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.Location = new Point(15, 452);
            label3.Name = "label3";
            label3.Size = new Size(266, 19);
            label3.TabIndex = 16;
            label3.Text = "What video format should I choose?";
            // 
            // textBox10
            // 
            textBox10.BorderStyle = BorderStyle.None;
            textBox10.Location = new Point(15, 40);
            textBox10.Multiline = true;
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(561, 409);
            textBox10.TabIndex = 23;
            textBox10.Text = resources.GetString("textBox10.Text");
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label5.Location = new Point(15, 834);
            label5.Name = "label5";
            label5.Size = new Size(268, 19);
            label5.TabIndex = 26;
            label5.Text = "Why is the video downloading slow?";
            // 
            // label7
            // 
            label7.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label7.Location = new Point(15, 1064);
            label7.Name = "label7";
            label7.Size = new Size(561, 46);
            label7.TabIndex = 21;
            label7.Text = "[Spotify/YouTube Music] A quality limitation message is displayed during download. How to fix it?";
            // 
            // label8
            // 
            label8.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label8.Location = new Point(15, 911);
            label8.Name = "label8";
            label8.Size = new Size(531, 46);
            label8.TabIndex = 19;
            label8.Text = "[Spotify] Why do I have another format downloaded after selecting ALAC, AAC format?";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label10.Location = new Point(15, 9);
            label10.Name = "label10";
            label10.Size = new Size(274, 19);
            label10.TabIndex = 2;
            label10.Text = "Which audio format should I choose?";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 361);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(650, 400);
            MinimizeBox = false;
            MinimumSize = new Size(650, 400);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pomoc techniczna";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label9;
        private Label label4;
        private Label label11;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label6;
        private TextBox textBox5;
        private TextBox textBox4;
        private Panel panel2;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private Label label3;
        private TextBox textBox10;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label10;
    }
}