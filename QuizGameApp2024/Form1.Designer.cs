namespace QuizGameApp2024
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnAnswer2 = new System.Windows.Forms.Button();
            this.btnAnswer3 = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAnswer1 = new System.Windows.Forms.Button();
            this.lblyourscore = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.picBoxCorrect = new System.Windows.Forms.PictureBox();
            this.picBoxIncorrect = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.lblPresentation = new System.Windows.Forms.Label();
            this.lblPresent2 = new System.Windows.Forms.Label();
            this.picMathlady = new System.Windows.Forms.PictureBox();
            this.btnAnswer4 = new System.Windows.Forms.Button();
            this.lblFinish = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIncorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMathlady)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.BackgroundImage = global::QuizGameApp2024.Properties.Resources._2quiz_button;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(272, 205);
            this.btnStart.Margin = new System.Windows.Forms.Padding(0);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(770, 302);
            this.btnStart.TabIndex = 1;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.BackColor = System.Drawing.Color.Linen;
            this.lblQuestion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblQuestion.Font = new System.Drawing.Font("Yu Gothic UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(94, 58);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(1108, 170);
            this.lblQuestion.TabIndex = 2;
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblQuestion.Visible = false;
            // 
            // btnAnswer2
            // 
            this.btnAnswer2.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer2.Location = new System.Drawing.Point(377, 268);
            this.btnAnswer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnswer2.Name = "btnAnswer2";
            this.btnAnswer2.Size = new System.Drawing.Size(250, 150);
            this.btnAnswer2.TabIndex = 3;
            this.btnAnswer2.UseVisualStyleBackColor = true;
            this.btnAnswer2.Visible = false;
            this.btnAnswer2.Click += new System.EventHandler(this.checkAnswer_Click);
            // 
            // btnAnswer3
            // 
            this.btnAnswer3.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer3.Location = new System.Drawing.Point(667, 268);
            this.btnAnswer3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnswer3.Name = "btnAnswer3";
            this.btnAnswer3.Size = new System.Drawing.Size(250, 150);
            this.btnAnswer3.TabIndex = 4;
            this.btnAnswer3.UseVisualStyleBackColor = true;
            this.btnAnswer3.Visible = false;
            this.btnAnswer3.Click += new System.EventHandler(this.checkAnswer_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Location = new System.Drawing.Point(952, 509);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(282, 94);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next Question";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAnswer1
            // 
            this.btnAnswer1.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer1.Location = new System.Drawing.Point(94, 268);
            this.btnAnswer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnswer1.Name = "btnAnswer1";
            this.btnAnswer1.Size = new System.Drawing.Size(250, 150);
            this.btnAnswer1.TabIndex = 7;
            this.btnAnswer1.UseVisualStyleBackColor = true;
            this.btnAnswer1.Visible = false;
            this.btnAnswer1.Click += new System.EventHandler(this.checkAnswer_Click);
            // 
            // lblyourscore
            // 
            this.lblyourscore.BackColor = System.Drawing.Color.Gold;
            this.lblyourscore.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyourscore.Location = new System.Drawing.Point(109, 504);
            this.lblyourscore.Name = "lblyourscore";
            this.lblyourscore.Size = new System.Drawing.Size(188, 45);
            this.lblyourscore.TabIndex = 8;
            this.lblyourscore.Text = "Your score:";
            this.lblyourscore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblyourscore.Visible = false;
            // 
            // lblPoints
            // 
            this.lblPoints.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.Location = new System.Drawing.Point(109, 552);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(188, 51);
            this.lblPoints.TabIndex = 9;
            this.lblPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPoints.Visible = false;
            // 
            // lblAnswer
            // 
            this.lblAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAnswer.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblAnswer.Location = new System.Drawing.Point(540, 437);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(225, 80);
            this.lblAnswer.TabIndex = 10;
            this.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAnswer.Visible = false;
            // 
            // picBoxCorrect
            // 
            this.picBoxCorrect.Image = global::QuizGameApp2024.Properties.Resources.blow_mind_mind_blown;
            this.picBoxCorrect.Location = new System.Drawing.Point(443, 535);
            this.picBoxCorrect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBoxCorrect.Name = "picBoxCorrect";
            this.picBoxCorrect.Size = new System.Drawing.Size(427, 297);
            this.picBoxCorrect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxCorrect.TabIndex = 11;
            this.picBoxCorrect.TabStop = false;
            this.picBoxCorrect.Visible = false;
            // 
            // picBoxIncorrect
            // 
            this.picBoxIncorrect.Image = global::QuizGameApp2024.Properties.Resources.noplease;
            this.picBoxIncorrect.Location = new System.Drawing.Point(508, 533);
            this.picBoxIncorrect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBoxIncorrect.Name = "picBoxIncorrect";
            this.picBoxIncorrect.Size = new System.Drawing.Size(290, 299);
            this.picBoxIncorrect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxIncorrect.TabIndex = 12;
            this.picBoxIncorrect.TabStop = false;
            this.picBoxIncorrect.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnExit.Location = new System.Drawing.Point(107, 669);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(223, 96);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit Game";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.LightPink;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearBtn.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.clearBtn.Location = new System.Drawing.Point(952, 509);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(282, 99);
            this.clearBtn.TabIndex = 14;
            this.clearBtn.Text = "Play Again";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Visible = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click_1);
            // 
            // lblPresentation
            // 
            this.lblPresentation.BackColor = System.Drawing.Color.LightPink;
            this.lblPresentation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPresentation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblPresentation.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblPresentation.Location = new System.Drawing.Point(394, 494);
            this.lblPresentation.Name = "lblPresentation";
            this.lblPresentation.Size = new System.Drawing.Size(511, 72);
            this.lblPresentation.TabIndex = 15;
            this.lblPresentation.Text = "Created by Choo && Daiana";
            this.lblPresentation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPresent2
            // 
            this.lblPresent2.BackColor = System.Drawing.Color.LightPink;
            this.lblPresent2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPresent2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblPresent2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblPresent2.Location = new System.Drawing.Point(540, 566);
            this.lblPresent2.Name = "lblPresent2";
            this.lblPresent2.Size = new System.Drawing.Size(225, 68);
            this.lblPresent2.TabIndex = 16;
            this.lblPresent2.Text = "Have fun!";
            this.lblPresent2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picMathlady
            // 
            this.picMathlady.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picMathlady.Image = global::QuizGameApp2024.Properties.Resources.mathlady;
            this.picMathlady.Location = new System.Drawing.Point(508, 36);
            this.picMathlady.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picMathlady.Name = "picMathlady";
            this.picMathlady.Size = new System.Drawing.Size(279, 201);
            this.picMathlady.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMathlady.TabIndex = 17;
            this.picMathlady.TabStop = false;
            // 
            // btnAnswer4
            // 
            this.btnAnswer4.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer4.Location = new System.Drawing.Point(952, 268);
            this.btnAnswer4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnswer4.Name = "btnAnswer4";
            this.btnAnswer4.Size = new System.Drawing.Size(250, 150);
            this.btnAnswer4.TabIndex = 5;
            this.btnAnswer4.UseVisualStyleBackColor = true;
            this.btnAnswer4.Visible = false;
            this.btnAnswer4.Click += new System.EventHandler(this.checkAnswer_Click);
            // 
            // lblFinish
            // 
            this.lblFinish.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFinish.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinish.Location = new System.Drawing.Point(369, 429);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(557, 88);
            this.lblFinish.TabIndex = 18;
            this.lblFinish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFinish.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::QuizGameApp2024.Properties.Resources.hand_drawn_question_mark_pattern_23_2149416651;
            this.ClientSize = new System.Drawing.Size(1310, 944);
            this.Controls.Add(this.lblFinish);
            this.Controls.Add(this.picMathlady);
            this.Controls.Add(this.lblPresent2);
            this.Controls.Add(this.lblPresentation);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.picBoxIncorrect);
            this.Controls.Add(this.picBoxCorrect);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblyourscore);
            this.Controls.Add(this.btnAnswer1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnAnswer4);
            this.Controls.Add(this.btnAnswer3);
            this.Controls.Add(this.btnAnswer2);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btnStart);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Quiz Game";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIncorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMathlady)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnAnswer2;
        private System.Windows.Forms.Button btnAnswer3;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAnswer1;
        private System.Windows.Forms.Label lblyourscore;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.PictureBox picBoxCorrect;
        private System.Windows.Forms.PictureBox picBoxIncorrect;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button clearBtn;
        public System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblPresentation;
        private System.Windows.Forms.Label lblPresent2;
        private System.Windows.Forms.PictureBox picMathlady;
        private System.Windows.Forms.Button btnAnswer4;
        private System.Windows.Forms.Label lblFinish;
    }
}

