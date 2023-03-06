namespace Minesweeper
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_remaining_bombs = new System.Windows.Forms.Label();
            this.label_player = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label_time = new System.Windows.Forms.Label();
            this.but_reset = new System.Windows.Forms.Button();
            this.but_close = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_time);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label_player);
            this.panel1.Controls.Add(this.label_remaining_bombs);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(88, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 82);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(614, 11);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Minesweeper.Properties.Resources.clock;
            this.pictureBox1.Location = new System.Drawing.Point(422, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 59);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label_remaining_bombs
            // 
            this.label_remaining_bombs.AutoSize = true;
            this.label_remaining_bombs.Font = new System.Drawing.Font("Snap ITC", 16F, System.Drawing.FontStyle.Bold);
            this.label_remaining_bombs.Location = new System.Drawing.Point(75, 23);
            this.label_remaining_bombs.Name = "label_remaining_bombs";
            this.label_remaining_bombs.Size = new System.Drawing.Size(52, 29);
            this.label_remaining_bombs.TabIndex = 3;
            this.label_remaining_bombs.Text = "50";
            // 
            // label_player
            // 
            this.label_player.AutoSize = true;
            this.label_player.Font = new System.Drawing.Font("Snap ITC", 16F, System.Drawing.FontStyle.Bold);
            this.label_player.Location = new System.Drawing.Point(258, 23);
            this.label_player.Name = "label_player";
            this.label_player.Size = new System.Drawing.Size(102, 29);
            this.label_player.TabIndex = 4;
            this.label_player.Text = "Player";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Minesweeper.Properties.Resources.bombCropped50;
            this.pictureBox2.InitialImage = global::Minesweeper.Properties.Resources.bombCropped50;
            this.pictureBox2.Location = new System.Drawing.Point(19, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 60);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Font = new System.Drawing.Font("Snap ITC", 16F, System.Drawing.FontStyle.Bold);
            this.label_time.Location = new System.Drawing.Point(494, 23);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(99, 29);
            this.label_time.TabIndex = 6;
            this.label_time.Text = "20:20";
            // 
            // but_reset
            // 
            this.but_reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.but_reset.Font = new System.Drawing.Font("Snap ITC", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_reset.Location = new System.Drawing.Point(17, 30);
            this.but_reset.Name = "but_reset";
            this.but_reset.Size = new System.Drawing.Size(141, 45);
            this.but_reset.TabIndex = 4;
            this.but_reset.Text = "Reset";
            this.but_reset.UseVisualStyleBackColor = true;
            // 
            // but_close
            // 
            this.but_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.but_close.Font = new System.Drawing.Font("Snap ITC", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_close.Location = new System.Drawing.Point(258, 30);
            this.but_close.Name = "but_close";
            this.but_close.Size = new System.Drawing.Size(141, 45);
            this.but_close.TabIndex = 5;
            this.but_close.Text = "Close";
            this.but_close.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.but_reset);
            this.panel3.Controls.Add(this.but_close);
            this.panel3.Location = new System.Drawing.Point(188, 629);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(416, 89);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(416, 14);
            this.panel4.TabIndex = 6;
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(819, 716);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label_player;
        private System.Windows.Forms.Label label_remaining_bombs;
        private System.Windows.Forms.Button but_close;
        private System.Windows.Forms.Button but_reset;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}