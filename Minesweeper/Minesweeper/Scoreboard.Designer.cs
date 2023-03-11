namespace Minesweeper
{
    partial class Scoreboard
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.but_close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_player = new System.Windows.Forms.Label();
            this.list_scoreboard = new System.Windows.Forms.ListBox();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.but_close);
            this.panel3.Location = new System.Drawing.Point(58, 456);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(416, 89);
            this.panel3.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(416, 14);
            this.panel4.TabIndex = 6;
            // 
            // but_close
            // 
            this.but_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.but_close.Font = new System.Drawing.Font("Snap ITC", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_close.Location = new System.Drawing.Point(132, 29);
            this.but_close.Name = "but_close";
            this.but_close.Size = new System.Drawing.Size(141, 45);
            this.but_close.TabIndex = 5;
            this.but_close.Text = "Close";
            this.but_close.UseVisualStyleBackColor = true;
            this.but_close.Click += new System.EventHandler(this.but_close_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_player);
            this.panel1.Location = new System.Drawing.Point(58, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 89);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(58, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(416, 14);
            this.panel2.TabIndex = 6;
            // 
            // label_player
            // 
            this.label_player.AutoSize = true;
            this.label_player.Font = new System.Drawing.Font("Snap ITC", 16F, System.Drawing.FontStyle.Bold);
            this.label_player.Location = new System.Drawing.Point(127, 30);
            this.label_player.Name = "label_player";
            this.label_player.Size = new System.Drawing.Size(162, 29);
            this.label_player.TabIndex = 5;
            this.label_player.Text = "Scoreboard";
            // 
            // list_scoreboard
            // 
            this.list_scoreboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.list_scoreboard.FormattingEnabled = true;
            this.list_scoreboard.ItemHeight = 26;
            this.list_scoreboard.Location = new System.Drawing.Point(95, 116);
            this.list_scoreboard.Name = "list_scoreboard";
            this.list_scoreboard.Size = new System.Drawing.Size(354, 316);
            this.list_scoreboard.TabIndex = 9;
            // 
            // Scoreboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 542);
            this.Controls.Add(this.list_scoreboard);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "Scoreboard";
            this.Text = "Scoreboard";
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button but_close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_player;
        private System.Windows.Forms.ListBox list_scoreboard;
    }
}