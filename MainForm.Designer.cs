namespace Assignment3
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            dealButton = new Button();
            saveHandButton = new Button();
            loadHandButton = new Button();
            keep1CheckBox = new CheckBox();
            keep2CheckBox = new CheckBox();
            keep3CheckBox = new CheckBox();
            keep4CheckBox = new CheckBox();
            keep5CheckBox = new CheckBox();
            cardImageList = new ImageList(components);
            card1PictureBox = new PictureBox();
            card2PictureBox = new PictureBox();
            card3PictureBox = new PictureBox();
            card4PictureBox = new PictureBox();
            card5PictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)card1PictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)card2PictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)card3PictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)card4PictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)card5PictureBox).BeginInit();
            SuspendLayout();
            // 
            // dealButton
            // 
            dealButton.Location = new Point(29, 19);
            dealButton.Name = "dealButton";
            dealButton.Size = new Size(113, 64);
            dealButton.TabIndex = 0;
            dealButton.Text = "&Deal";
            dealButton.UseVisualStyleBackColor = true;
            dealButton.Click += dealButtonClick;
            // 
            // saveHandButton
            // 
            saveHandButton.Location = new Point(525, 18);
            saveHandButton.Name = "saveHandButton";
            saveHandButton.Size = new Size(113, 65);
            saveHandButton.TabIndex = 1;
            saveHandButton.Text = "&Save Hand";
            saveHandButton.UseVisualStyleBackColor = true;
            saveHandButton.Click += SaveHandButtonClick;
            // 
            // loadHandButton
            // 
            loadHandButton.Location = new Point(662, 19);
            loadHandButton.Name = "loadHandButton";
            loadHandButton.Size = new Size(113, 65);
            loadHandButton.TabIndex = 2;
            loadHandButton.Text = "&Load Hand";
            loadHandButton.UseVisualStyleBackColor = true;
            loadHandButton.Click += LoadHandButtonClick;
            // 
            // keep1CheckBox
            // 
            keep1CheckBox.AutoSize = true;
            keep1CheckBox.Location = new Point(29, 168);
            keep1CheckBox.Name = "keep1CheckBox";
            keep1CheckBox.Size = new Size(77, 24);
            keep1CheckBox.TabIndex = 3;
            keep1CheckBox.Text = "Keep &1";
            keep1CheckBox.UseVisualStyleBackColor = true;
            // 
            // keep2CheckBox
            // 
            keep2CheckBox.AutoSize = true;
            keep2CheckBox.Location = new Point(188, 168);
            keep2CheckBox.Name = "keep2CheckBox";
            keep2CheckBox.Size = new Size(77, 24);
            keep2CheckBox.TabIndex = 4;
            keep2CheckBox.Text = "Keep &2";
            keep2CheckBox.UseVisualStyleBackColor = true;
            // 
            // keep3CheckBox
            // 
            keep3CheckBox.AutoSize = true;
            keep3CheckBox.Location = new Point(340, 168);
            keep3CheckBox.Name = "keep3CheckBox";
            keep3CheckBox.Size = new Size(75, 24);
            keep3CheckBox.TabIndex = 5;
            keep3CheckBox.Text = "keep &3";
            keep3CheckBox.UseVisualStyleBackColor = true;
            // 
            // keep4CheckBox
            // 
            keep4CheckBox.AutoSize = true;
            keep4CheckBox.Location = new Point(493, 168);
            keep4CheckBox.Name = "keep4CheckBox";
            keep4CheckBox.Size = new Size(77, 24);
            keep4CheckBox.TabIndex = 6;
            keep4CheckBox.Text = "Keep &4";
            keep4CheckBox.UseVisualStyleBackColor = true;
            // 
            // keep5CheckBox
            // 
            keep5CheckBox.AutoSize = true;
            keep5CheckBox.Location = new Point(650, 168);
            keep5CheckBox.Name = "keep5CheckBox";
            keep5CheckBox.Size = new Size(77, 24);
            keep5CheckBox.TabIndex = 7;
            keep5CheckBox.Text = "Keep &5";
            keep5CheckBox.UseVisualStyleBackColor = true;
            // 
            // cardImageList
            // 
            cardImageList.ColorDepth = ColorDepth.Depth32Bit;
            cardImageList.ImageStream = (ImageListStreamer)resources.GetObject("cardImageList.ImageStream");
            cardImageList.TransparentColor = Color.Transparent;
            cardImageList.Images.SetKeyName(0, "p0.png");
            cardImageList.Images.SetKeyName(1, "p1.png");
            cardImageList.Images.SetKeyName(2, "p2.png");
            cardImageList.Images.SetKeyName(3, "p3.png");
            cardImageList.Images.SetKeyName(4, "p4.png");
            cardImageList.Images.SetKeyName(5, "p5.png");
            cardImageList.Images.SetKeyName(6, "p6.png");
            cardImageList.Images.SetKeyName(7, "p7.png");
            cardImageList.Images.SetKeyName(8, "p8.png");
            cardImageList.Images.SetKeyName(9, "p9.png");
            cardImageList.Images.SetKeyName(10, "p10.png");
            cardImageList.Images.SetKeyName(11, "p11.png");
            cardImageList.Images.SetKeyName(12, "p12.png");
            cardImageList.Images.SetKeyName(13, "p13.png");
            cardImageList.Images.SetKeyName(14, "p14.png");
            cardImageList.Images.SetKeyName(15, "p15.png");
            cardImageList.Images.SetKeyName(16, "p16.png");
            cardImageList.Images.SetKeyName(17, "p17.png");
            cardImageList.Images.SetKeyName(18, "p18.png");
            cardImageList.Images.SetKeyName(19, "p19.png");
            cardImageList.Images.SetKeyName(20, "p20.png");
            cardImageList.Images.SetKeyName(21, "p21.png");
            cardImageList.Images.SetKeyName(22, "p22.png");
            cardImageList.Images.SetKeyName(23, "p23.png");
            cardImageList.Images.SetKeyName(24, "p24.png");
            cardImageList.Images.SetKeyName(25, "p25.png");
            cardImageList.Images.SetKeyName(26, "p26.png");
            cardImageList.Images.SetKeyName(27, "p27.png");
            cardImageList.Images.SetKeyName(28, "p28.png");
            cardImageList.Images.SetKeyName(29, "p29.png");
            cardImageList.Images.SetKeyName(30, "p30.png");
            cardImageList.Images.SetKeyName(31, "p31.png");
            cardImageList.Images.SetKeyName(32, "p32.png");
            cardImageList.Images.SetKeyName(33, "p33.png");
            cardImageList.Images.SetKeyName(34, "p34.png");
            cardImageList.Images.SetKeyName(35, "p35.png");
            cardImageList.Images.SetKeyName(36, "p36.png");
            cardImageList.Images.SetKeyName(37, "p37.png");
            cardImageList.Images.SetKeyName(38, "p38.png");
            cardImageList.Images.SetKeyName(39, "p39.png");
            cardImageList.Images.SetKeyName(40, "p40.png");
            cardImageList.Images.SetKeyName(41, "p41.png");
            cardImageList.Images.SetKeyName(42, "p42.png");
            cardImageList.Images.SetKeyName(43, "p43.png");
            cardImageList.Images.SetKeyName(44, "p44.png");
            cardImageList.Images.SetKeyName(45, "p45.png");
            cardImageList.Images.SetKeyName(46, "p46.png");
            cardImageList.Images.SetKeyName(47, "p47.png");
            cardImageList.Images.SetKeyName(48, "p48.png");
            cardImageList.Images.SetKeyName(49, "p49.png");
            cardImageList.Images.SetKeyName(50, "p50.png");
            cardImageList.Images.SetKeyName(51, "p51.png");
            // 
            // card1PictureBox
            // 
            card1PictureBox.Location = new Point(29, 198);
            card1PictureBox.Name = "card1PictureBox";
            card1PictureBox.Size = new Size(125, 181);
            card1PictureBox.TabIndex = 8;
            card1PictureBox.TabStop = false;
            // 
            // card2PictureBox
            // 
            card2PictureBox.Location = new Point(188, 198);
            card2PictureBox.Name = "card2PictureBox";
            card2PictureBox.Size = new Size(125, 181);
            card2PictureBox.TabIndex = 9;
            card2PictureBox.TabStop = false;
            // 
            // card3PictureBox
            // 
            card3PictureBox.Location = new Point(340, 198);
            card3PictureBox.Name = "card3PictureBox";
            card3PictureBox.Size = new Size(125, 181);
            card3PictureBox.TabIndex = 10;
            card3PictureBox.TabStop = false;
            // 
            // card4PictureBox
            // 
            card4PictureBox.Location = new Point(493, 198);
            card4PictureBox.Name = "card4PictureBox";
            card4PictureBox.Size = new Size(125, 181);
            card4PictureBox.TabIndex = 11;
            card4PictureBox.TabStop = false;
            // 
            // card5PictureBox
            // 
            card5PictureBox.Location = new Point(650, 198);
            card5PictureBox.Name = "card5PictureBox";
            card5PictureBox.Size = new Size(125, 181);
            card5PictureBox.TabIndex = 12;
            card5PictureBox.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(card5PictureBox);
            Controls.Add(card4PictureBox);
            Controls.Add(card3PictureBox);
            Controls.Add(card2PictureBox);
            Controls.Add(card1PictureBox);
            Controls.Add(keep5CheckBox);
            Controls.Add(keep4CheckBox);
            Controls.Add(keep3CheckBox);
            Controls.Add(keep2CheckBox);
            Controls.Add(keep1CheckBox);
            Controls.Add(loadHandButton);
            Controls.Add(saveHandButton);
            Controls.Add(dealButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Poker Hand Simulator";
            ((System.ComponentModel.ISupportInitialize)card1PictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)card2PictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)card3PictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)card4PictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)card5PictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button dealButton;
        private Button saveHandButton;
        private Button loadHandButton;
        private CheckBox keep1CheckBox;
        private CheckBox keep2CheckBox;
        private CheckBox keep3CheckBox;
        private CheckBox keep4CheckBox;
        private CheckBox keep5CheckBox;
        private ImageList cardImageList;
        private PictureBox card1PictureBox;
        private PictureBox card2PictureBox;
        private PictureBox card3PictureBox;
        private PictureBox card4PictureBox;
        private PictureBox card5PictureBox;
    }
}
