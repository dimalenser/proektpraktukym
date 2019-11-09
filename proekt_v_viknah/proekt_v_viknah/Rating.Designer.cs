namespace proekt_v_viknah
{
    partial class Rating
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRating = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonGoToTest = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1359, 48);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 54.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(398, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 87);
            this.label1.TabIndex = 13;
            this.label1.Text = "Рейтинг студетів";
            // 
            // buttonRating
            // 
            this.buttonRating.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonRating.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonRating.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRating.FlatAppearance.BorderSize = 0;
            this.buttonRating.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRating.Font = new System.Drawing.Font("Arial Narrow", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRating.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonRating.Location = new System.Drawing.Point(0, -7);
            this.buttonRating.Name = "buttonRating";
            this.buttonRating.Size = new System.Drawing.Size(198, 55);
            this.buttonRating.TabIndex = 16;
            this.buttonRating.Text = "Рейтинг";
            this.buttonRating.UseVisualStyleBackColor = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Arial Narrow", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonExit.Location = new System.Drawing.Point(1186, -9);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(198, 57);
            this.buttonExit.TabIndex = 15;
            this.buttonExit.Text = "Вихід";
            this.buttonExit.UseVisualStyleBackColor = false;
            // 
            // buttonGoToTest
            // 
            this.buttonGoToTest.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonGoToTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGoToTest.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonGoToTest.Font = new System.Drawing.Font("Arial Narrow", 54.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGoToTest.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonGoToTest.Location = new System.Drawing.Point(401, 614);
            this.buttonGoToTest.Name = "buttonGoToTest";
            this.buttonGoToTest.Size = new System.Drawing.Size(514, 103);
            this.buttonGoToTest.TabIndex = 14;
            this.buttonGoToTest.Text = "Розпочати тест";
            this.buttonGoToTest.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(145, 167);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1111, 424);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "№   Бал   Група  ПІБ\n1      4       П-32    Тодосійчук Дмитро Ігорович";
            // 
            // Rating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRating);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonGoToTest);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Rating";
            this.Text = "Rating";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRating;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonGoToTest;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}