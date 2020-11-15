namespace Petals_Around_The_Rose
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
            this.lblGuess = new System.Windows.Forms.Label();
            this.txtbxGuess = new System.Windows.Forms.TextBox();
            this.txtbxResult = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnRoll = new System.Windows.Forms.Button();
            this.lblTotRolls = new System.Windows.Forms.Label();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxTotRolls = new System.Windows.Forms.TextBox();
            this.txtbxBestRun = new System.Windows.Forms.TextBox();
            this.txtbxNumCorrect = new System.Windows.Forms.TextBox();
            this.picBoxOne = new System.Windows.Forms.PictureBox();
            this.picBoxTwo = new System.Windows.Forms.PictureBox();
            this.picBoxFive = new System.Windows.Forms.PictureBox();
            this.picBoxFour = new System.Windows.Forms.PictureBox();
            this.picBoxThree = new System.Windows.Forms.PictureBox();
            this.txtbxDiceTwo = new System.Windows.Forms.TextBox();
            this.txtbxDiceOne = new System.Windows.Forms.TextBox();
            this.txtbxDiceThree = new System.Windows.Forms.TextBox();
            this.txtbxDiceFour = new System.Windows.Forms.TextBox();
            this.txtbxDiceFive = new System.Windows.Forms.TextBox();
            this.lblFirstDie = new System.Windows.Forms.Label();
            this.lblFifthDie = new System.Windows.Forms.Label();
            this.lblFourthDie = new System.Windows.Forms.Label();
            this.lblThirdDie = new System.Windows.Forms.Label();
            this.lblSecondDie = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxThree)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGuess
            // 
            this.lblGuess.AutoSize = true;
            this.lblGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuess.Location = new System.Drawing.Point(56, 411);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Size = new System.Drawing.Size(114, 24);
            this.lblGuess.TabIndex = 0;
            this.lblGuess.Text = "Your Guess:";
            // 
            // txtbxGuess
            // 
            this.txtbxGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxGuess.Location = new System.Drawing.Point(176, 408);
            this.txtbxGuess.Name = "txtbxGuess";
            this.txtbxGuess.Size = new System.Drawing.Size(78, 29);
            this.txtbxGuess.TabIndex = 1;
            // 
            // txtbxResult
            // 
            this.txtbxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxResult.Location = new System.Drawing.Point(60, 534);
            this.txtbxResult.Name = "txtbxResult";
            this.txtbxResult.ReadOnly = true;
            this.txtbxResult.Size = new System.Drawing.Size(359, 29);
            this.txtbxResult.TabIndex = 2;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(56, 507);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(67, 24);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Result:";
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(60, 454);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(110, 31);
            this.btnGuess.TabIndex = 4;
            this.btnGuess.Text = "Accept Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(176, 455);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(110, 30);
            this.btnRoll.TabIndex = 5;
            this.btnRoll.Text = "Roll Dice";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // lblTotRolls
            // 
            this.lblTotRolls.AutoSize = true;
            this.lblTotRolls.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotRolls.Location = new System.Drawing.Point(477, 411);
            this.lblTotRolls.Name = "lblTotRolls";
            this.lblTotRolls.Size = new System.Drawing.Size(102, 24);
            this.lblTotRolls.TabIndex = 6;
            this.lblTotRolls.Text = "Total Rolls:";
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrect.Location = new System.Drawing.Point(488, 446);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(91, 24);
            this.lblCorrect.TabIndex = 7;
            this.lblCorrect.Text = "# Correct:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(488, 481);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Best Run:";
            // 
            // txtbxTotRolls
            // 
            this.txtbxTotRolls.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxTotRolls.Location = new System.Drawing.Point(585, 408);
            this.txtbxTotRolls.Name = "txtbxTotRolls";
            this.txtbxTotRolls.ReadOnly = true;
            this.txtbxTotRolls.Size = new System.Drawing.Size(60, 29);
            this.txtbxTotRolls.TabIndex = 9;
            // 
            // txtbxBestRun
            // 
            this.txtbxBestRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxBestRun.Location = new System.Drawing.Point(585, 478);
            this.txtbxBestRun.Name = "txtbxBestRun";
            this.txtbxBestRun.ReadOnly = true;
            this.txtbxBestRun.Size = new System.Drawing.Size(60, 29);
            this.txtbxBestRun.TabIndex = 10;
            // 
            // txtbxNumCorrect
            // 
            this.txtbxNumCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxNumCorrect.Location = new System.Drawing.Point(585, 443);
            this.txtbxNumCorrect.Name = "txtbxNumCorrect";
            this.txtbxNumCorrect.ReadOnly = true;
            this.txtbxNumCorrect.Size = new System.Drawing.Size(60, 29);
            this.txtbxNumCorrect.TabIndex = 11;
            // 
            // picBoxOne
            // 
            this.picBoxOne.Location = new System.Drawing.Point(83, 180);
            this.picBoxOne.Name = "picBoxOne";
            this.picBoxOne.Size = new System.Drawing.Size(60, 60);
            this.picBoxOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxOne.TabIndex = 12;
            this.picBoxOne.TabStop = false;
            // 
            // picBoxTwo
            // 
            this.picBoxTwo.Location = new System.Drawing.Point(197, 180);
            this.picBoxTwo.Name = "picBoxTwo";
            this.picBoxTwo.Size = new System.Drawing.Size(60, 60);
            this.picBoxTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxTwo.TabIndex = 13;
            this.picBoxTwo.TabStop = false;
            // 
            // picBoxFive
            // 
            this.picBoxFive.Location = new System.Drawing.Point(539, 180);
            this.picBoxFive.Name = "picBoxFive";
            this.picBoxFive.Size = new System.Drawing.Size(60, 60);
            this.picBoxFive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxFive.TabIndex = 14;
            this.picBoxFive.TabStop = false;
            // 
            // picBoxFour
            // 
            this.picBoxFour.Location = new System.Drawing.Point(425, 180);
            this.picBoxFour.Name = "picBoxFour";
            this.picBoxFour.Size = new System.Drawing.Size(60, 60);
            this.picBoxFour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxFour.TabIndex = 15;
            this.picBoxFour.TabStop = false;
            // 
            // picBoxThree
            // 
            this.picBoxThree.Location = new System.Drawing.Point(311, 180);
            this.picBoxThree.Name = "picBoxThree";
            this.picBoxThree.Size = new System.Drawing.Size(60, 60);
            this.picBoxThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxThree.TabIndex = 16;
            this.picBoxThree.TabStop = false;
            // 
            // txtbxDiceTwo
            // 
            this.txtbxDiceTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxDiceTwo.Location = new System.Drawing.Point(212, 246);
            this.txtbxDiceTwo.Name = "txtbxDiceTwo";
            this.txtbxDiceTwo.ReadOnly = true;
            this.txtbxDiceTwo.Size = new System.Drawing.Size(29, 29);
            this.txtbxDiceTwo.TabIndex = 17;
            // 
            // txtbxDiceOne
            // 
            this.txtbxDiceOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxDiceOne.Location = new System.Drawing.Point(96, 246);
            this.txtbxDiceOne.Name = "txtbxDiceOne";
            this.txtbxDiceOne.ReadOnly = true;
            this.txtbxDiceOne.Size = new System.Drawing.Size(29, 29);
            this.txtbxDiceOne.TabIndex = 18;
            // 
            // txtbxDiceThree
            // 
            this.txtbxDiceThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxDiceThree.Location = new System.Drawing.Point(328, 246);
            this.txtbxDiceThree.Name = "txtbxDiceThree";
            this.txtbxDiceThree.ReadOnly = true;
            this.txtbxDiceThree.Size = new System.Drawing.Size(29, 29);
            this.txtbxDiceThree.TabIndex = 19;
            // 
            // txtbxDiceFour
            // 
            this.txtbxDiceFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxDiceFour.Location = new System.Drawing.Point(442, 246);
            this.txtbxDiceFour.Name = "txtbxDiceFour";
            this.txtbxDiceFour.ReadOnly = true;
            this.txtbxDiceFour.Size = new System.Drawing.Size(29, 29);
            this.txtbxDiceFour.TabIndex = 20;
            // 
            // txtbxDiceFive
            // 
            this.txtbxDiceFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxDiceFive.Location = new System.Drawing.Point(558, 246);
            this.txtbxDiceFive.Name = "txtbxDiceFive";
            this.txtbxDiceFive.ReadOnly = true;
            this.txtbxDiceFive.Size = new System.Drawing.Size(29, 29);
            this.txtbxDiceFive.TabIndex = 21;
            // 
            // lblFirstDie
            // 
            this.lblFirstDie.AutoSize = true;
            this.lblFirstDie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstDie.Location = new System.Drawing.Point(85, 150);
            this.lblFirstDie.Name = "lblFirstDie";
            this.lblFirstDie.Size = new System.Drawing.Size(54, 18);
            this.lblFirstDie.TabIndex = 22;
            this.lblFirstDie.Text = "1st Die";
            // 
            // lblFifthDie
            // 
            this.lblFifthDie.AutoSize = true;
            this.lblFifthDie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFifthDie.Location = new System.Drawing.Point(540, 150);
            this.lblFifthDie.Name = "lblFifthDie";
            this.lblFifthDie.Size = new System.Drawing.Size(54, 18);
            this.lblFifthDie.TabIndex = 23;
            this.lblFifthDie.Text = "5th Die";
            // 
            // lblFourthDie
            // 
            this.lblFourthDie.AutoSize = true;
            this.lblFourthDie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFourthDie.Location = new System.Drawing.Point(428, 150);
            this.lblFourthDie.Name = "lblFourthDie";
            this.lblFourthDie.Size = new System.Drawing.Size(54, 18);
            this.lblFourthDie.TabIndex = 24;
            this.lblFourthDie.Text = "4th Die";
            // 
            // lblThirdDie
            // 
            this.lblThirdDie.AutoSize = true;
            this.lblThirdDie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThirdDie.Location = new System.Drawing.Point(314, 150);
            this.lblThirdDie.Name = "lblThirdDie";
            this.lblThirdDie.Size = new System.Drawing.Size(55, 18);
            this.lblThirdDie.TabIndex = 25;
            this.lblThirdDie.Text = "3rd Die";
            // 
            // lblSecondDie
            // 
            this.lblSecondDie.AutoSize = true;
            this.lblSecondDie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondDie.Location = new System.Drawing.Point(200, 150);
            this.lblSecondDie.Name = "lblSecondDie";
            this.lblSecondDie.Size = new System.Drawing.Size(58, 18);
            this.lblSecondDie.TabIndex = 26;
            this.lblSecondDie.Text = "2nd Die";
            // 
            // lblInstructions
            // 
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(121, 32);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(441, 105);
            this.lblInstructions.TabIndex = 27;
            this.lblInstructions.Text = resources.GetString("lblInstructions.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(683, 634);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblSecondDie);
            this.Controls.Add(this.lblThirdDie);
            this.Controls.Add(this.lblFourthDie);
            this.Controls.Add(this.lblFifthDie);
            this.Controls.Add(this.lblFirstDie);
            this.Controls.Add(this.txtbxDiceFive);
            this.Controls.Add(this.txtbxDiceFour);
            this.Controls.Add(this.txtbxDiceThree);
            this.Controls.Add(this.txtbxDiceOne);
            this.Controls.Add(this.txtbxDiceTwo);
            this.Controls.Add(this.picBoxThree);
            this.Controls.Add(this.picBoxFour);
            this.Controls.Add(this.picBoxFive);
            this.Controls.Add(this.picBoxTwo);
            this.Controls.Add(this.picBoxOne);
            this.Controls.Add(this.txtbxNumCorrect);
            this.Controls.Add(this.txtbxBestRun);
            this.Controls.Add(this.txtbxTotRolls);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.lblTotRolls);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtbxResult);
            this.Controls.Add(this.txtbxGuess);
            this.Controls.Add(this.lblGuess);
            this.Name = "Form1";
            this.Text = "Petals Around the Rose";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxThree)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGuess;
        private System.Windows.Forms.TextBox txtbxGuess;
        private System.Windows.Forms.TextBox txtbxResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Label lblTotRolls;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxTotRolls;
        private System.Windows.Forms.TextBox txtbxBestRun;
        private System.Windows.Forms.TextBox txtbxNumCorrect;
        private System.Windows.Forms.PictureBox picBoxOne;
        private System.Windows.Forms.PictureBox picBoxTwo;
        private System.Windows.Forms.PictureBox picBoxFive;
        private System.Windows.Forms.PictureBox picBoxFour;
        private System.Windows.Forms.PictureBox picBoxThree;
        private System.Windows.Forms.TextBox txtbxDiceTwo;
        private System.Windows.Forms.TextBox txtbxDiceOne;
        private System.Windows.Forms.TextBox txtbxDiceThree;
        private System.Windows.Forms.TextBox txtbxDiceFour;
        private System.Windows.Forms.TextBox txtbxDiceFive;
        private System.Windows.Forms.Label lblFirstDie;
        private System.Windows.Forms.Label lblFifthDie;
        private System.Windows.Forms.Label lblFourthDie;
        private System.Windows.Forms.Label lblThirdDie;
        private System.Windows.Forms.Label lblSecondDie;
        private System.Windows.Forms.Label lblInstructions;
    }
}

