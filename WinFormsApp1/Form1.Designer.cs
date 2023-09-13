namespace WinFormsApp1
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
            conn_btn = new Button();
            led_on_btn = new Button();
            led_off_btn = new Button();
            comboBox1 = new ComboBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            led_txt = new TextBox();
            groupBox4 = new GroupBox();
            tmp_txt = new TextBox();
            groupBox5 = new GroupBox();
            light_txt = new TextBox();
            groupBox6 = new GroupBox();
            dis_txt = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // conn_btn
            // 
            conn_btn.Location = new Point(132, 25);
            conn_btn.Name = "conn_btn";
            conn_btn.Size = new Size(73, 23);
            conn_btn.TabIndex = 0;
            conn_btn.Text = "연결";
            conn_btn.UseVisualStyleBackColor = true;
            conn_btn.Click += conn_btn_Click;
            // 
            // led_on_btn
            // 
            led_on_btn.Location = new Point(31, 27);
            led_on_btn.Name = "led_on_btn";
            led_on_btn.Size = new Size(73, 23);
            led_on_btn.TabIndex = 1;
            led_on_btn.Text = "ON";
            led_on_btn.UseVisualStyleBackColor = true;
            led_on_btn.Click += led_on_btn_Click;
            // 
            // led_off_btn
            // 
            led_off_btn.Location = new Point(132, 27);
            led_off_btn.Name = "led_off_btn";
            led_off_btn.Size = new Size(73, 23);
            led_off_btn.TabIndex = 2;
            led_off_btn.Text = "OFF";
            led_off_btn.UseVisualStyleBackColor = true;
            led_off_btn.Click += led_off_btn_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8" });
            comboBox1.Location = new Point(31, 25);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(73, 23);
            comboBox1.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(conn_btn);
            groupBox1.Location = new Point(8, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(229, 70);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(led_off_btn);
            groupBox2.Controls.Add(led_on_btn);
            groupBox2.Location = new Point(8, 86);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(229, 68);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(led_txt);
            groupBox3.Location = new Point(8, 160);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(229, 46);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "점등 상태";
            // 
            // led_txt
            // 
            led_txt.Location = new Point(31, 16);
            led_txt.Name = "led_txt";
            led_txt.Size = new Size(174, 23);
            led_txt.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(tmp_txt);
            groupBox4.Location = new Point(8, 212);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(229, 46);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "온도 센서";
            // 
            // tmp_txt
            // 
            tmp_txt.Location = new Point(31, 16);
            tmp_txt.Name = "tmp_txt";
            tmp_txt.Size = new Size(174, 23);
            tmp_txt.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(light_txt);
            groupBox5.Location = new Point(8, 264);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(229, 46);
            groupBox5.TabIndex = 7;
            groupBox5.TabStop = false;
            groupBox5.Text = "조도 센서";
            // 
            // light_txt
            // 
            light_txt.Location = new Point(31, 17);
            light_txt.Name = "light_txt";
            light_txt.Size = new Size(174, 23);
            light_txt.TabIndex = 0;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(dis_txt);
            groupBox6.Location = new Point(8, 317);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(229, 46);
            groupBox6.TabIndex = 7;
            groupBox6.TabStop = false;
            groupBox6.Text = "초음파 센서";
            // 
            // dis_txt
            // 
            dis_txt.Location = new Point(31, 16);
            dis_txt.Name = "dis_txt";
            dis_txt.Size = new Size(174, 23);
            dis_txt.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(249, 378);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button conn_btn;
        private Button led_on_btn;
        private Button led_off_btn;
        private ComboBox comboBox1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox led_txt;
        private GroupBox groupBox4;
        private TextBox tmp_txt;
        private GroupBox groupBox5;
        private TextBox light_txt;
        private GroupBox groupBox6;
        private TextBox dis_txt;
    }
}