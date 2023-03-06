namespace XANDO
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
            this.but_pvp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.but_pvc = new System.Windows.Forms.Button();
            this.but_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 26.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(283, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "X and O";
            // 
            // but_pvp
            // 
            this.but_pvp.Font = new System.Drawing.Font("Snap ITC", 15.25F);
            this.but_pvp.Location = new System.Drawing.Point(236, 202);
            this.but_pvp.Name = "but_pvp";
            this.but_pvp.Size = new System.Drawing.Size(271, 45);
            this.but_pvp.TabIndex = 1;
            this.but_pvp.Text = "Player vs Player";
            this.but_pvp.UseVisualStyleBackColor = true;
            this.but_pvp.Click += new System.EventHandler(this.but_pvp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Snap ITC", 26.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(240, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "Game Style";
            // 
            // but_pvc
            // 
            this.but_pvc.Font = new System.Drawing.Font("Snap ITC", 15.25F);
            this.but_pvc.Location = new System.Drawing.Point(236, 270);
            this.but_pvc.Name = "but_pvc";
            this.but_pvc.Size = new System.Drawing.Size(271, 45);
            this.but_pvc.TabIndex = 3;
            this.but_pvc.Text = "Player vs Computer";
            this.but_pvc.UseVisualStyleBackColor = true;
            this.but_pvc.Click += new System.EventHandler(this.but_pvc_Click);
            // 
            // but_close
            // 
            this.but_close.Font = new System.Drawing.Font("Snap ITC", 15.25F);
            this.but_close.Location = new System.Drawing.Point(659, 12);
            this.but_close.Name = "but_close";
            this.but_close.Size = new System.Drawing.Size(129, 45);
            this.but_close.TabIndex = 4;
            this.but_close.Text = "Close";
            this.but_close.UseVisualStyleBackColor = true;
            this.but_close.Click += new System.EventHandler(this.but_close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.but_close);
            this.Controls.Add(this.but_pvc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.but_pvp);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button but_pvp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button but_pvc;
        private System.Windows.Forms.Button but_close;
    }
}

