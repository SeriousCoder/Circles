namespace Circles
{
    partial class App
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CheckButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.X1 = new System.Windows.Forms.TextBox();
            this.Y1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.R1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.X2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Y2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.R2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CheckButton
            // 
            this.CheckButton.Location = new System.Drawing.Point(486, 396);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(173, 64);
            this.CheckButton.TabIndex = 0;
            this.CheckButton.Text = "Check";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "x";
            // 
            // X1
            // 
            this.X1.Location = new System.Drawing.Point(56, 396);
            this.X1.Name = "X1";
            this.X1.Size = new System.Drawing.Size(100, 20);
            this.X1.TabIndex = 2;
            // 
            // Y1
            // 
            this.Y1.Location = new System.Drawing.Point(210, 396);
            this.Y1.Name = "Y1";
            this.Y1.Size = new System.Drawing.Size(100, 20);
            this.Y1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "y";
            // 
            // R1
            // 
            this.R1.Location = new System.Drawing.Point(368, 396);
            this.R1.Name = "R1";
            this.R1.Size = new System.Drawing.Size(100, 20);
            this.R1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "radius";
            // 
            // X2
            // 
            this.X2.Location = new System.Drawing.Point(56, 432);
            this.X2.Name = "X2";
            this.X2.Size = new System.Drawing.Size(100, 20);
            this.X2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "x";
            // 
            // Y2
            // 
            this.Y2.Location = new System.Drawing.Point(210, 435);
            this.Y2.Name = "Y2";
            this.Y2.Size = new System.Drawing.Size(100, 20);
            this.Y2.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 438);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "y";
            // 
            // R2
            // 
            this.R2.Location = new System.Drawing.Point(368, 435);
            this.R2.Name = "R2";
            this.R2.Size = new System.Drawing.Size(100, 20);
            this.R2.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(327, 438);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "radius";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(709, 422);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(74, 13);
            this.resultLabel.TabIndex = 13;
            this.resultLabel.Text = "Enter the data";
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(18, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(798, 378);
            this.pictureBox.TabIndex = 14;
            this.pictureBox.TabStop = false;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 470);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.R2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Y2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.X2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.R1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Y1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.X1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckButton);
            this.Name = "App";
            this.Text = "Circles";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox X1;
        private System.Windows.Forms.TextBox Y1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox R1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox X2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Y2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox R2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

