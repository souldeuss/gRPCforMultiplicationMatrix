namespace Kursach_project
{
    partial class Start
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
            this.label1 = new System.Windows.Forms.Label();
            this.next_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.random_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 40.07547F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(884, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "Виберіть файли з матрицями";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // next_btn
            // 
            this.next_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.next_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.next_btn.Font = new System.Drawing.Font("Segoe UI", 25.81132F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.next_btn.Location = new System.Drawing.Point(300, 15);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(284, 67);
            this.next_btn.TabIndex = 9;
            this.next_btn.Text = "Далі";
            this.next_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.next_btn.UseVisualStyleBackColor = true;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(577, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 68);
            this.button1.TabIndex = 10;
            this.button1.Text = "Обрати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(146, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 68);
            this.button2.TabIndex = 11;
            this.button2.Text = "Обрати";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.random_btn);
            this.panel1.Controls.Add(this.next_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 274);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(300, 15, 300, 15);
            this.panel1.Size = new System.Drawing.Size(884, 100);
            this.panel1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 24.84906F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(436, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label3.Size = new System.Drawing.Size(448, 196);
            this.label3.TabIndex = 18;
            this.label3.Text = "Друга матриця";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(0, 78);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label2.Size = new System.Drawing.Size(430, 196);
            this.label2.TabIndex = 17;
            this.label2.Text = "Перша матриця";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // random_btn
            // 
            this.random_btn.Font = new System.Drawing.Font("Segoe UI", 16.30189F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.random_btn.Location = new System.Drawing.Point(13, 16);
            this.random_btn.Name = "random_btn";
            this.random_btn.Size = new System.Drawing.Size(248, 67);
            this.random_btn.TabIndex = 19;
            this.random_btn.Text = "Випадкові матриці";
            this.random_btn.UseVisualStyleBackColor = true;
            this.random_btn.Click += new System.EventHandler(this.random_btn_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 374);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Start";
            this.Text = "Множення матриць";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button random_btn;
    }
}