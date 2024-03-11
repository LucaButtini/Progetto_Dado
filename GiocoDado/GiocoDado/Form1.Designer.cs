namespace GiocoDado
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
            this.btnclose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rollbtn = new System.Windows.Forms.Button();
            this.dice1img = new System.Windows.Forms.PictureBox();
            this.dice2img = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.resultsbox = new System.Windows.Forms.GroupBox();
            this.risstato = new System.Windows.Forms.Label();
            this.risround = new System.Windows.Forms.Label();
            this.rispl2 = new System.Windows.Forms.Label();
            this.rispl1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblround = new System.Windows.Forms.Label();
            this.lblpl2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblpl1 = new System.Windows.Forms.Label();
            this.resetbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dice1img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice2img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.resultsbox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(920, 544);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 0;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inserisci nome PLAYER 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(733, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Inserisci nome PLAYER 2";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(81, 272);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(737, 272);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Conferma nome";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(737, 327);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Conferma nome";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(366, 438);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(248, 73);
            this.button2.TabIndex = 9;
            this.button2.Text = "START";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(214, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(549, 73);
            this.label4.TabIndex = 15;
            this.label4.Text = "THE DICE GAME";
            this.label4.Visible = false;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(214, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(549, 73);
            this.label3.TabIndex = 18;
            this.label3.Text = "THE DICE GAME";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(442, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Inserisci numero round";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(445, 261);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 20;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(445, 327);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "Conferma n° round";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(453, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 39);
            this.label6.TabIndex = 22;
            this.label6.Text = "VS";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(222, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 25);
            this.label7.TabIndex = 23;
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(660, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 25);
            this.label8.TabIndex = 24;
            this.label8.Visible = false;
            // 
            // rollbtn
            // 
            this.rollbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rollbtn.Image = global::GiocoDado.Properties.Resources.nero;
            this.rollbtn.Location = new System.Drawing.Point(433, 236);
            this.rollbtn.Name = "rollbtn";
            this.rollbtn.Size = new System.Drawing.Size(112, 61);
            this.rollbtn.TabIndex = 25;
            this.rollbtn.Text = "ROLL";
            this.rollbtn.UseVisualStyleBackColor = true;
            this.rollbtn.Visible = false;
            this.rollbtn.Click += new System.EventHandler(this.rollbtn_Click);
            // 
            // dice1img
            // 
            this.dice1img.Location = new System.Drawing.Point(187, 187);
            this.dice1img.Name = "dice1img";
            this.dice1img.Size = new System.Drawing.Size(180, 180);
            this.dice1img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dice1img.TabIndex = 26;
            this.dice1img.TabStop = false;
            this.dice1img.Visible = false;
            this.dice1img.Click += new System.EventHandler(this.dice1img_Click);
            // 
            // dice2img
            // 
            this.dice2img.Location = new System.Drawing.Point(618, 187);
            this.dice2img.Name = "dice2img";
            this.dice2img.Size = new System.Drawing.Size(180, 180);
            this.dice2img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dice2img.TabIndex = 27;
            this.dice2img.TabStop = false;
            this.dice2img.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GiocoDado.Properties.Resources.game_sfondo;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1015, 579);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // resultsbox
            // 
            this.resultsbox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.resultsbox.BackgroundImage = global::GiocoDado.Properties.Resources.paper;
            this.resultsbox.Controls.Add(this.risstato);
            this.resultsbox.Controls.Add(this.risround);
            this.resultsbox.Controls.Add(this.rispl2);
            this.resultsbox.Controls.Add(this.rispl1);
            this.resultsbox.Location = new System.Drawing.Point(297, 402);
            this.resultsbox.Name = "resultsbox";
            this.resultsbox.Size = new System.Drawing.Size(438, 137);
            this.resultsbox.TabIndex = 28;
            this.resultsbox.TabStop = false;
            this.resultsbox.Text = "Risultati";
            this.resultsbox.Visible = false;
            // 
            // risstato
            // 
            this.risstato.AutoSize = true;
            this.risstato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.risstato.Location = new System.Drawing.Point(6, 108);
            this.risstato.Name = "risstato";
            this.risstato.Size = new System.Drawing.Size(209, 20);
            this.risstato.TabIndex = 3;
            this.risstato.Text = "Partita ancora da iniziare";
            // 
            // risround
            // 
            this.risround.AutoSize = true;
            this.risround.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.risround.Location = new System.Drawing.Point(6, 78);
            this.risround.Name = "risround";
            this.risround.Size = new System.Drawing.Size(0, 20);
            this.risround.TabIndex = 2;
            // 
            // rispl2
            // 
            this.rispl2.AutoSize = true;
            this.rispl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rispl2.Location = new System.Drawing.Point(7, 47);
            this.rispl2.Name = "rispl2";
            this.rispl2.Size = new System.Drawing.Size(0, 20);
            this.rispl2.TabIndex = 1;
            this.rispl2.Click += new System.EventHandler(this.label10_Click);
            // 
            // rispl1
            // 
            this.rispl1.AutoSize = true;
            this.rispl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rispl1.Location = new System.Drawing.Point(7, 18);
            this.rispl1.Name = "rispl1";
            this.rispl1.Size = new System.Drawing.Size(0, 20);
            this.rispl1.TabIndex = 0;
            this.rispl1.Click += new System.EventHandler(this.label9_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblround);
            this.groupBox1.Controls.Add(this.lblpl2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lblpl1);
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(12, 414);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 131);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gara";
            // 
            // lblround
            // 
            this.lblround.AutoSize = true;
            this.lblround.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblround.ForeColor = System.Drawing.Color.Black;
            this.lblround.Location = new System.Drawing.Point(92, 90);
            this.lblround.Name = "lblround";
            this.lblround.Size = new System.Drawing.Size(0, 20);
            this.lblround.TabIndex = 3;
            // 
            // lblpl2
            // 
            this.lblpl2.AutoSize = true;
            this.lblpl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpl2.ForeColor = System.Drawing.Color.White;
            this.lblpl2.Location = new System.Drawing.Point(185, 36);
            this.lblpl2.Name = "lblpl2";
            this.lblpl2.Size = new System.Drawing.Size(0, 20);
            this.lblpl2.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(102, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 25);
            this.label10.TabIndex = 1;
            this.label10.Text = "VS";
            // 
            // lblpl1
            // 
            this.lblpl1.AutoSize = true;
            this.lblpl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpl1.ForeColor = System.Drawing.Color.White;
            this.lblpl1.Location = new System.Drawing.Point(19, 36);
            this.lblpl1.Name = "lblpl1";
            this.lblpl1.Size = new System.Drawing.Size(0, 20);
            this.lblpl1.TabIndex = 0;
            // 
            // resetbtn
            // 
            this.resetbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.resetbtn.Image = global::GiocoDado.Properties.Resources.nero;
            this.resetbtn.Location = new System.Drawing.Point(873, 445);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(112, 61);
            this.resetbtn.TabIndex = 30;
            this.resetbtn.Text = "Reset \r\nPartita";
            this.resetbtn.UseVisualStyleBackColor = true;
            this.resetbtn.Visible = false;
            this.resetbtn.Click += new System.EventHandler(this.resetbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1007, 578);
            this.Controls.Add(this.resetbtn);
            this.Controls.Add(this.resultsbox);
            this.Controls.Add(this.dice2img);
            this.Controls.Add(this.dice1img);
            this.Controls.Add(this.rollbtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "The Dice Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dice1img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice2img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.resultsbox.ResumeLayout(false);
            this.resultsbox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button rollbtn;
        private System.Windows.Forms.PictureBox dice1img;
        private System.Windows.Forms.PictureBox dice2img;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox resultsbox;
        private System.Windows.Forms.Label risstato;
        private System.Windows.Forms.Label risround;
        private System.Windows.Forms.Label rispl2;
        private System.Windows.Forms.Label rispl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblround;
        private System.Windows.Forms.Label lblpl2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblpl1;
        private System.Windows.Forms.Button resetbtn;
    }
}

