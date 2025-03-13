namespace TronByDoczi
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
            components = new System.ComponentModel.Container();
            gameArea = new PictureBox();
            timer = new System.Windows.Forms.Timer(components);
            idoT = new Label();
            valosIdo = new System.Windows.Forms.Timer(components);
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            itsOverDude = new PictureBox();
            itsOverDude2 = new PictureBox();
            itsOverDude3 = new PictureBox();
            itsOverDude4 = new PictureBox();
            nyert = new Label();
            ((System.ComponentModel.ISupportInitialize)gameArea).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itsOverDude).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itsOverDude2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itsOverDude3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itsOverDude4).BeginInit();
            SuspendLayout();
            // 
            // gameArea
            // 
            gameArea.BackColor = Color.Black;
            gameArea.Location = new Point(22, 32);
            gameArea.Name = "gameArea";
            gameArea.Size = new Size(493, 406);
            gameArea.TabIndex = 0;
            gameArea.TabStop = false;
            gameArea.Paint += gameArea_Paint;
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // idoT
            // 
            idoT.AutoSize = true;
            idoT.Font = new Font("Segoe UI", 27F, FontStyle.Regular, GraphicsUnit.Point);
            idoT.Location = new Point(643, 17);
            idoT.Name = "idoT";
            idoT.Size = new Size(150, 48);
            idoT.TabIndex = 1;
            idoT.Text = "00:00:00";
            // 
            // valosIdo
            // 
            valosIdo.Interval = 1000;
            valosIdo.Tick += valosIdo_Tick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(733, 83);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(111, 23);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(603, 81);
            label1.Name = "label1";
            label1.Size = new Size(114, 25);
            label1.TabIndex = 3;
            label1.Text = "Első játékos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(576, 106);
            label2.Name = "label2";
            label2.Size = new Size(151, 25);
            label2.TabIndex = 5;
            label2.Text = "Második játékos:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(733, 108);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(111, 23);
            textBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(643, 148);
            button1.Name = "button1";
            button1.Size = new Size(143, 35);
            button1.TabIndex = 6;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Blue;
            pictureBox1.Location = new Point(566, 116);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(14, 10);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Green;
            pictureBox2.Location = new Point(585, 89);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(14, 10);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // itsOverDude
            // 
            itsOverDude.Location = new Point(12, -19);
            itsOverDude.Name = "itsOverDude";
            itsOverDude.Size = new Size(493, 18);
            itsOverDude.TabIndex = 9;
            itsOverDude.TabStop = false;
            // 
            // itsOverDude2
            // 
            itsOverDude2.Location = new Point(-4, 17);
            itsOverDude2.Name = "itsOverDude2";
            itsOverDude2.Size = new Size(11, 425);
            itsOverDude2.TabIndex = 10;
            itsOverDude2.TabStop = false;
            // 
            // itsOverDude3
            // 
            itsOverDude3.Location = new Point(-4, 448);
            itsOverDude3.Name = "itsOverDude3";
            itsOverDude3.Size = new Size(538, 27);
            itsOverDude3.TabIndex = 11;
            itsOverDude3.TabStop = false;
            // 
            // itsOverDude4
            // 
            itsOverDude4.Location = new Point(521, 17);
            itsOverDude4.Name = "itsOverDude4";
            itsOverDude4.Size = new Size(19, 425);
            itsOverDude4.TabIndex = 12;
            itsOverDude4.TabStop = false;
            // 
            // nyert
            // 
            nyert.AutoSize = true;
            nyert.BorderStyle = BorderStyle.FixedSingle;
            nyert.FlatStyle = FlatStyle.Popup;
            nyert.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            nyert.Location = new Point(556, 240);
            nyert.Name = "nyert";
            nyert.Size = new Size(67, 30);
            nyert.TabIndex = 13;
            nyert.Text = "label3";
            nyert.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 472);
            Controls.Add(nyert);
            Controls.Add(itsOverDude4);
            Controls.Add(itsOverDude3);
            Controls.Add(itsOverDude2);
            Controls.Add(itsOverDude);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(idoT);
            Controls.Add(gameArea);
            Name = "Form1";
            Text = "Trón";
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)gameArea).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)itsOverDude).EndInit();
            ((System.ComponentModel.ISupportInitialize)itsOverDude2).EndInit();
            ((System.ComponentModel.ISupportInitialize)itsOverDude3).EndInit();
            ((System.ComponentModel.ISupportInitialize)itsOverDude4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox gameArea;
        private System.Windows.Forms.Timer timer;
        private Label idoT;
        private System.Windows.Forms.Timer valosIdo;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Button button1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox itsOverDude;
        private PictureBox itsOverDude2;
        private PictureBox itsOverDude3;
        private PictureBox itsOverDude4;
        private Label nyert;
    }
}