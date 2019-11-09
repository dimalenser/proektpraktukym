namespace proekt_v_viknah
{
    partial class Home
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGoToRegistration = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonRating = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1359, 48);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 54.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(308, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(819, 87);
            this.label1.TabIndex = 1;
            this.label1.Text = "Тест на тему: \" Якась тема \"";
            // 
            // buttonGoToRegistration
            // 
            this.buttonGoToRegistration.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonGoToRegistration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGoToRegistration.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonGoToRegistration.Font = new System.Drawing.Font("Arial Narrow", 54.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGoToRegistration.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonGoToRegistration.Location = new System.Drawing.Point(435, 457);
            this.buttonGoToRegistration.Name = "buttonGoToRegistration";
            this.buttonGoToRegistration.Size = new System.Drawing.Size(514, 103);
            this.buttonGoToRegistration.TabIndex = 2;
            this.buttonGoToRegistration.Text = "Розпочати тест";
            this.buttonGoToRegistration.UseVisualStyleBackColor = false;
            this.buttonGoToRegistration.Click += new System.EventHandler(this.buttonGoToRegistration_Click);
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
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Вихід";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
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
            this.buttonRating.Location = new System.Drawing.Point(-1, -7);
            this.buttonRating.Name = "buttonRating";
            this.buttonRating.Size = new System.Drawing.Size(198, 55);
            this.buttonRating.TabIndex = 4;
            this.buttonRating.Text = "Рейтинг";
            this.buttonRating.UseVisualStyleBackColor = false;
            this.buttonRating.Click += new System.EventHandler(this.buttonRating_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRating);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonGoToRegistration);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGoToRegistration;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonRating;
    }
}

