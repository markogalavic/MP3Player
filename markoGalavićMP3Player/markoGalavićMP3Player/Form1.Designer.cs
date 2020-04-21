namespace markoGalavićMP3Player
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.folder = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.play = new System.Windows.Forms.Button();
            this.forward = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkRed;
            this.panel2.Controls.Add(this.exit);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(896, 100);
            this.panel2.TabIndex = 0;
            // 
            // folder
            // 
            this.folder.Image = ((System.Drawing.Image)(resources.GetObject("folder.Image")));
            this.folder.Location = new System.Drawing.Point(12, 173);
            this.folder.Name = "folder";
            this.folder.Size = new System.Drawing.Size(200, 224);
            this.folder.TabIndex = 1;
            this.folder.UseVisualStyleBackColor = true;
            this.folder.Click += new System.EventHandler(this.folder_Click);
            // 
            // back
            // 
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.Location = new System.Drawing.Point(242, 240);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(130, 104);
            this.back.TabIndex = 2;
            this.back.UseVisualStyleBackColor = true;
            // 
            // play
            // 
            this.play.Image = ((System.Drawing.Image)(resources.GetObject("play.Image")));
            this.play.Location = new System.Drawing.Point(402, 209);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(153, 157);
            this.play.TabIndex = 3;
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // forward
            // 
            this.forward.Image = ((System.Drawing.Image)(resources.GetObject("forward.Image")));
            this.forward.Location = new System.Drawing.Point(574, 209);
            this.forward.Name = "forward";
            this.forward.Size = new System.Drawing.Size(98, 135);
            this.forward.TabIndex = 4;
            this.forward.UseVisualStyleBackColor = true;
            // 
            // stop
            // 
            this.stop.Image = ((System.Drawing.Image)(resources.GetObject("stop.Image")));
            this.stop.Location = new System.Drawing.Point(716, 209);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(108, 135);
            this.stop.TabIndex = 5;
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkRed;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(75, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "MP3 Player";
            // 
            // exit
            // 
            this.exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.exit.ForeColor = System.Drawing.Color.DarkRed;
            this.exit.Location = new System.Drawing.Point(788, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(108, 100);
            this.exit.TabIndex = 6;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(896, 603);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.forward);
            this.Controls.Add(this.play);
            this.Controls.Add(this.back);
            this.Controls.Add(this.folder);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button folder;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button forward;
        private System.Windows.Forms.Button stop;
    }
}

