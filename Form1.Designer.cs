namespace AntiArcanoid
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(AntiArcanoid.Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.kupi = new System.Windows.Forms.PictureBox();
            this.firstHeart = new System.Windows.Forms.PictureBox();
            this.secondHeart = new System.Windows.Forms.PictureBox();
            this.Message = new System.Windows.Forms.Label();
            this.NumGoals = new System.Windows.Forms.Label();
            this.backGround = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.kupi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.firstHeart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.secondHeart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.backGround)).BeginInit();
            this.SuspendLayout();
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.kupi);
            this.panel1.Controls.Add(this.firstHeart);
            this.panel1.Controls.Add(this.secondHeart);
            this.panel1.Controls.Add(this.Message);
            this.panel1.Controls.Add(this.NumGoals);
            this.panel1.Controls.Add(this.backGround);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 642);
            this.panel1.TabIndex = 0;
            this.kupi.BackColor = System.Drawing.Color.Transparent;
            this.kupi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.kupi.Location = new System.Drawing.Point(206, 533);
            this.kupi.Name = "kupi";
            this.kupi.Size = new System.Drawing.Size(114, 84);
            this.kupi.TabIndex = 0;
            this.kupi.TabStop = false;
            this.firstHeart.BackColor = System.Drawing.Color.Transparent;
            this.firstHeart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.firstHeart.Image = ((System.Drawing.Image) (resources.GetObject("firstHeart.Image")));
            this.firstHeart.Location = new System.Drawing.Point(111, 100);
            this.firstHeart.Name = "firstHeart";
            this.firstHeart.Size = new System.Drawing.Size(54, 42);
            this.firstHeart.TabIndex = 0;
            this.firstHeart.TabStop = false;
            this.secondHeart.BackColor = System.Drawing.Color.Transparent;
            this.secondHeart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.secondHeart.Location = new System.Drawing.Point(421, 66);
            this.secondHeart.Name = "secondHeart";
            this.secondHeart.Size = new System.Drawing.Size(51, 42);
            this.secondHeart.TabIndex = 2;
            this.secondHeart.TabStop = false;
            this.Message.AutoSize = true;
            this.Message.Location = new System.Drawing.Point(260, 317);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(0, 15);
            this.Message.TabIndex = 5;
            this.NumGoals.AutoSize = true;
            this.NumGoals.Location = new System.Drawing.Point(33, 24);
            this.NumGoals.Name = "NumGoals";
            this.NumGoals.Size = new System.Drawing.Size(0, 15);
            this.NumGoals.TabIndex = 4;
            this.backGround.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backGround.Location = new System.Drawing.Point(0, 0);
            this.backGround.Name = "backGround";
            this.backGround.Size = new System.Drawing.Size(497, 642);
            this.backGround.TabIndex = 3;
            this.backGround.TabStop = false;
            this.timer1.Interval = 30;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(497, 642);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.kupi)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.firstHeart)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.secondHeart)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.backGround)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox kupi;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox secondHeart;
        private System.Windows.Forms.PictureBox firstHeart;
        private System.Windows.Forms.PictureBox backGround;
        public System.Windows.Forms.Label Message;
        public System.Windows.Forms.Label NumGoals;
    }
}

