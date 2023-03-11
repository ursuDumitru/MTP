namespace Minesweeper
{
    partial class Form1
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
            this.comboBox_Size = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.but_start = new System.Windows.Forms.Button();
            this.but_close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.text_player = new System.Windows.Forms.TextBox();
            this.but_scoreboard = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minesweeper";
            // 
            // comboBox_Size
            // 
            this.comboBox_Size.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.comboBox_Size.FormattingEnabled = true;
            this.comboBox_Size.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "15"});
            this.comboBox_Size.Location = new System.Drawing.Point(38, 42);
            this.comboBox_Size.Margin = new System.Windows.Forms.Padding(0);
            this.comboBox_Size.Name = "comboBox_Size";
            this.comboBox_Size.Size = new System.Drawing.Size(174, 34);
            this.comboBox_Size.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Snap ITC", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(21, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Size :";
            // 
            // but_start
            // 
            this.but_start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.but_start.Font = new System.Drawing.Font("Snap ITC", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_start.Location = new System.Drawing.Point(38, 165);
            this.but_start.Name = "but_start";
            this.but_start.Size = new System.Drawing.Size(174, 45);
            this.but_start.TabIndex = 3;
            this.but_start.Text = "Start";
            this.but_start.UseVisualStyleBackColor = true;
            this.but_start.Click += new System.EventHandler(this.but_start_Click);
            // 
            // but_close
            // 
            this.but_close.Font = new System.Drawing.Font("Snap ITC", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_close.Location = new System.Drawing.Point(38, 266);
            this.but_close.Name = "but_close";
            this.but_close.Size = new System.Drawing.Size(174, 45);
            this.but_close.TabIndex = 4;
            this.but_close.Text = "Close";
            this.but_close.UseVisualStyleBackColor = true;
            this.but_close.Click += new System.EventHandler(this.but_close_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 70);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(30, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(338, 77);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.but_scoreboard);
            this.panel3.Controls.Add(this.text_player);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.comboBox_Size);
            this.panel3.Controls.Add(this.but_start);
            this.panel3.Controls.Add(this.but_close);
            this.panel3.Location = new System.Drawing.Point(83, 149);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 314);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(240, 10);
            this.panel4.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Snap ITC", 16F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(21, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter Name :";
            // 
            // text_player
            // 
            this.text_player.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.text_player.Location = new System.Drawing.Point(38, 123);
            this.text_player.Multiline = true;
            this.text_player.Name = "text_player";
            this.text_player.Size = new System.Drawing.Size(174, 36);
            this.text_player.TabIndex = 7;
            // 
            // but_scoreboard
            // 
            this.but_scoreboard.Font = new System.Drawing.Font("Snap ITC", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_scoreboard.Location = new System.Drawing.Point(38, 216);
            this.but_scoreboard.Name = "but_scoreboard";
            this.but_scoreboard.Size = new System.Drawing.Size(174, 45);
            this.but_scoreboard.TabIndex = 8;
            this.but_scoreboard.Text = "Scoreboard";
            this.but_scoreboard.UseVisualStyleBackColor = true;
            this.but_scoreboard.Click += new System.EventHandler(this.button_scoreboard_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 461);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Size;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button but_start;
        private System.Windows.Forms.Button but_close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox text_player;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button but_scoreboard;
    }
}

