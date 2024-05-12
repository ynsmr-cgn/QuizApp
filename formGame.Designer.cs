namespace QuizApp
{
    partial class formGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formGame));
            this.MinimizeButton = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.moveableBar = new System.Windows.Forms.Label();
            this.bottomBar = new System.Windows.Forms.Label();
            this.lblQuestionNumber = new System.Windows.Forms.Label();
            this.btnA = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.lblQuestions = new System.Windows.Forms.Label();
            this.btnB = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.SuspendLayout();
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("MinimizeButton.Image")));
            this.MinimizeButton.Location = new System.Drawing.Point(656, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(40, 40);
            this.MinimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MinimizeButton.TabIndex = 14;
            this.MinimizeButton.TabStop = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.Location = new System.Drawing.Point(693, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(40, 40);
            this.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseButton.TabIndex = 13;
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // moveableBar
            // 
            this.moveableBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.moveableBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.moveableBar.Location = new System.Drawing.Point(0, 0);
            this.moveableBar.Name = "moveableBar";
            this.moveableBar.Size = new System.Drawing.Size(745, 40);
            this.moveableBar.TabIndex = 12;
            this.moveableBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.moveableBar_MouseMove);
            // 
            // bottomBar
            // 
            this.bottomBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.bottomBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomBar.Location = new System.Drawing.Point(0, 489);
            this.bottomBar.Name = "bottomBar";
            this.bottomBar.Size = new System.Drawing.Size(745, 16);
            this.bottomBar.TabIndex = 15;
            // 
            // lblQuestionNumber
            // 
            this.lblQuestionNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.lblQuestionNumber.Location = new System.Drawing.Point(54, 78);
            this.lblQuestionNumber.Name = "lblQuestionNumber";
            this.lblQuestionNumber.Size = new System.Drawing.Size(316, 28);
            this.lblQuestionNumber.TabIndex = 16;
            this.lblQuestionNumber.Text = "Soru 1";
            this.lblQuestionNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(171)))), ((int)(((byte)(174)))));
            this.btnA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnA.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnA.FlatAppearance.BorderSize = 0;
            this.btnA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnA.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnA.ForeColor = System.Drawing.Color.Beige;
            this.btnA.Location = new System.Drawing.Point(59, 300);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(300, 60);
            this.btnA.TabIndex = 1;
            this.btnA.Text = "Jupiter";
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.btnOption_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(171)))), ((int)(((byte)(174)))));
            this.btnC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnC.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnC.FlatAppearance.BorderSize = 0;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnC.ForeColor = System.Drawing.Color.Beige;
            this.btnC.Location = new System.Drawing.Point(59, 389);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(300, 60);
            this.btnC.TabIndex = 3;
            this.btnC.Text = "Venüs";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnOption_Click);
            // 
            // lblQuestions
            // 
            this.lblQuestions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.lblQuestions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.lblQuestions.Location = new System.Drawing.Point(54, 122);
            this.lblQuestions.Name = "lblQuestions";
            this.lblQuestions.Size = new System.Drawing.Size(634, 147);
            this.lblQuestions.TabIndex = 20;
            this.lblQuestions.Text = "Hangi gezegen Güneş Sistemi\'ndeki en büyük gezegendir?";
            this.lblQuestions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnB
            // 
            this.btnB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(171)))), ((int)(((byte)(174)))));
            this.btnB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnB.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnB.FlatAppearance.BorderSize = 0;
            this.btnB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnB.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnB.ForeColor = System.Drawing.Color.Beige;
            this.btnB.Location = new System.Drawing.Point(388, 300);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(300, 60);
            this.btnB.TabIndex = 2;
            this.btnB.Text = "Mars";
            this.btnB.UseVisualStyleBackColor = false;
            this.btnB.Click += new System.EventHandler(this.btnOption_Click);
            // 
            // btnD
            // 
            this.btnD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(171)))), ((int)(((byte)(174)))));
            this.btnD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnD.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnD.FlatAppearance.BorderSize = 0;
            this.btnD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnD.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnD.ForeColor = System.Drawing.Color.Beige;
            this.btnD.Location = new System.Drawing.Point(388, 389);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(300, 60);
            this.btnD.TabIndex = 4;
            this.btnD.Text = "Neptün";
            this.btnD.UseVisualStyleBackColor = false;
            this.btnD.Click += new System.EventHandler(this.btnOption_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.lblTimer.Location = new System.Drawing.Point(376, 78);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(312, 28);
            this.lblTimer.TabIndex = 21;
            this.lblTimer.Text = "Sure";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // formGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(745, 505);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.lblQuestions);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.lblQuestionNumber);
            this.Controls.Add(this.bottomBar);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.moveableBar);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "formGame";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formGame";
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MinimizeButton;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.Label moveableBar;
        private System.Windows.Forms.Label bottomBar;
        private System.Windows.Forms.Label lblQuestionNumber;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Label lblQuestions;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Label lblTimer;
    }
}