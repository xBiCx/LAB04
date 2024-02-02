namespace LAB04
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
            pictureBox1 = new PictureBox();
            labelname = new Label();
            button_LoadPokemon = new Button();
            pictureBox = new PictureBox();
            labelname2 = new Label();
            button_LoadPokemon1 = new Button();
            button_LoadPokemon2 = new Button();
            button_LoadPokemon3 = new Button();
            button_LoadPokemon4 = new Button();
            button_LoadPokemon5 = new Button();
            button_LoadPokemon6 = new Button();
            labelname1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(358, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 287);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // labelname
            // 
            labelname.AutoSize = true;
            labelname.Location = new Point(420, 330);
            labelname.Name = "labelname";
            labelname.Size = new Size(83, 15);
            labelname.TabIndex = 1;
            labelname.Text = "Pick Pokemon";
            // 
            // button_LoadPokemon
            // 
            button_LoadPokemon.Location = new Point(358, 348);
            button_LoadPokemon.Name = "button_LoadPokemon";
            button_LoadPokemon.Size = new Size(201, 23);
            button_LoadPokemon.TabIndex = 2;
            button_LoadPokemon.Text = "Pick Pikachu";
            button_LoadPokemon.UseVisualStyleBackColor = true;
            button_LoadPokemon.Click += button_LoadPokemon_Click;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(687, 31);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(201, 287);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 3;
            pictureBox.TabStop = false;
            // 
            // labelname2
            // 
            labelname2.AutoSize = true;
            labelname2.Location = new Point(747, 330);
            labelname2.Name = "labelname2";
            labelname2.Size = new Size(0, 15);
            labelname2.TabIndex = 4;
            // 
            // button_LoadPokemon1
            // 
            button_LoadPokemon1.Location = new Point(358, 383);
            button_LoadPokemon1.Name = "button_LoadPokemon1";
            button_LoadPokemon1.Size = new Size(201, 23);
            button_LoadPokemon1.TabIndex = 5;
            button_LoadPokemon1.Text = "Pick Mewtwo";
            button_LoadPokemon1.UseVisualStyleBackColor = true;
            button_LoadPokemon1.Click += button_LoadPokemon1_Click;
            // 
            // button_LoadPokemon2
            // 
            button_LoadPokemon2.Location = new Point(358, 418);
            button_LoadPokemon2.Name = "button_LoadPokemon2";
            button_LoadPokemon2.Size = new Size(201, 23);
            button_LoadPokemon2.TabIndex = 6;
            button_LoadPokemon2.Text = "Pick Mimikyu";
            button_LoadPokemon2.UseVisualStyleBackColor = true;
            button_LoadPokemon2.Click += button_LoadPokemon2_Click;
            // 
            // button_LoadPokemon3
            // 
            button_LoadPokemon3.Location = new Point(358, 454);
            button_LoadPokemon3.Name = "button_LoadPokemon3";
            button_LoadPokemon3.Size = new Size(201, 23);
            button_LoadPokemon3.TabIndex = 7;
            button_LoadPokemon3.Text = "Pick Geodude";
            button_LoadPokemon3.UseVisualStyleBackColor = true;
            button_LoadPokemon3.Click += button_LoadPokemon3_Click;
            // 
            // button_LoadPokemon4
            // 
            button_LoadPokemon4.Location = new Point(358, 490);
            button_LoadPokemon4.Name = "button_LoadPokemon4";
            button_LoadPokemon4.Size = new Size(201, 23);
            button_LoadPokemon4.TabIndex = 8;
            button_LoadPokemon4.Text = "Pick Onix";
            button_LoadPokemon4.UseVisualStyleBackColor = true;
            button_LoadPokemon4.Click += button_LoadPokemon4_Click;
            // 
            // button_LoadPokemon5
            // 
            button_LoadPokemon5.Location = new Point(358, 528);
            button_LoadPokemon5.Name = "button_LoadPokemon5";
            button_LoadPokemon5.Size = new Size(201, 23);
            button_LoadPokemon5.TabIndex = 9;
            button_LoadPokemon5.Text = "Pick Voltorb";
            button_LoadPokemon5.UseVisualStyleBackColor = true;
            button_LoadPokemon5.Click += button_LoadPokemon5_Click;
            // 
            // button_LoadPokemon6
            // 
            button_LoadPokemon6.Location = new Point(687, 348);
            button_LoadPokemon6.Name = "button_LoadPokemon6";
            button_LoadPokemon6.Size = new Size(201, 23);
            button_LoadPokemon6.TabIndex = 10;
            button_LoadPokemon6.Text = "Load Enemy";
            button_LoadPokemon6.UseVisualStyleBackColor = true;
            button_LoadPokemon6.Click += button_LoadPokemon6_Click;
            // 
            // labelname1
            // 
            labelname1.AutoSize = true;
            labelname1.Location = new Point(767, 330);
            labelname1.Name = "labelname1";
            labelname1.Size = new Size(43, 15);
            labelname1.TabIndex = 11;
            labelname1.Text = "Enemy";
            labelname1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1249, 568);
            Controls.Add(labelname1);
            Controls.Add(button_LoadPokemon6);
            Controls.Add(button_LoadPokemon5);
            Controls.Add(button_LoadPokemon4);
            Controls.Add(button_LoadPokemon3);
            Controls.Add(button_LoadPokemon2);
            Controls.Add(button_LoadPokemon1);
            Controls.Add(labelname2);
            Controls.Add(pictureBox);
            Controls.Add(button_LoadPokemon);
            Controls.Add(labelname);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelname;
        private Button button_LoadPokemon;
        private PictureBox pictureBox;
        private Label labelname2;
        private Button button_LoadPokemon1;
        private Button button_LoadPokemon2;
        private Button button_LoadPokemon3;
        private Button button_LoadPokemon4;
        private Button button_LoadPokemon5;
        private Button button_LoadPokemon6;
        private Label labelname1;
    }
}
