
namespace pets
{
    partial class Pets
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cat = new System.Windows.Forms.RadioButton();
            this.dog = new System.Windows.Forms.RadioButton();
            this.rabbit = new System.Windows.Forms.RadioButton();
            this.pig = new System.Windows.Forms.RadioButton();
            this.bird = new System.Windows.Forms.RadioButton();
            this.grp_bird = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cat);
            this.groupBox1.Controls.Add(this.dog);
            this.groupBox1.Controls.Add(this.rabbit);
            this.groupBox1.Controls.Add(this.pig);
            this.groupBox1.Controls.Add(this.bird);
            this.groupBox1.Location = new System.Drawing.Point(39, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(111, 199);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cat
            // 
            this.cat.AutoSize = true;
            this.cat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cat.Location = new System.Drawing.Point(29, 54);
            this.cat.Name = "cat";
            this.cat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cat.Size = new System.Drawing.Size(49, 22);
            this.cat.TabIndex = 6;
            this.cat.TabStop = true;
            this.cat.Text = "Cat";
            this.cat.UseVisualStyleBackColor = true;
            this.cat.CheckedChanged += new System.EventHandler(this.cat_CheckedChanged);
            // 
            // dog
            // 
            this.dog.AutoSize = true;
            this.dog.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dog.Location = new System.Drawing.Point(24, 86);
            this.dog.Name = "dog";
            this.dog.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dog.Size = new System.Drawing.Size(54, 22);
            this.dog.TabIndex = 5;
            this.dog.TabStop = true;
            this.dog.Text = "Dog";
            this.dog.UseVisualStyleBackColor = true;
            this.dog.CheckedChanged += new System.EventHandler(this.dog_CheckedChanged);
            // 
            // rabbit
            // 
            this.rabbit.AutoSize = true;
            this.rabbit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rabbit.Location = new System.Drawing.Point(10, 116);
            this.rabbit.Name = "rabbit";
            this.rabbit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rabbit.Size = new System.Drawing.Size(68, 22);
            this.rabbit.TabIndex = 4;
            this.rabbit.TabStop = true;
            this.rabbit.Text = "Rabbit";
            this.rabbit.UseVisualStyleBackColor = true;
            this.rabbit.CheckedChanged += new System.EventHandler(this.rabbit_CheckedChanged);
            // 
            // pig
            // 
            this.pig.AutoSize = true;
            this.pig.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pig.Location = new System.Drawing.Point(31, 150);
            this.pig.Name = "pig";
            this.pig.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pig.Size = new System.Drawing.Size(47, 22);
            this.pig.TabIndex = 2;
            this.pig.TabStop = true;
            this.pig.Text = "Pig";
            this.pig.UseVisualStyleBackColor = true;
            this.pig.CheckedChanged += new System.EventHandler(this.pig_CheckedChanged);
            // 
            // bird
            // 
            this.bird.AutoSize = true;
            this.bird.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bird.Location = new System.Drawing.Point(26, 19);
            this.bird.Name = "bird";
            this.bird.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bird.Size = new System.Drawing.Size(52, 22);
            this.bird.TabIndex = 1;
            this.bird.TabStop = true;
            this.bird.Text = "Bird";
            this.bird.UseVisualStyleBackColor = true;
            this.bird.CheckedChanged += new System.EventHandler(this.bird_CheckedChanged);
            // 
            // grp_bird
            // 
            this.grp_bird.BackgroundImage = global::pets.Properties.Resources.bird;
            this.grp_bird.Location = new System.Drawing.Point(173, 21);
            this.grp_bird.Name = "grp_bird";
            this.grp_bird.Size = new System.Drawing.Size(451, 339);
            this.grp_bird.TabIndex = 3;
            this.grp_bird.TabStop = false;
            // 
            // Pets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 369);
            this.Controls.Add(this.grp_bird);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RADIO BUTTON DEMO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton bird;
        private System.Windows.Forms.RadioButton cat;
        private System.Windows.Forms.RadioButton dog;
        private System.Windows.Forms.RadioButton rabbit;
        private System.Windows.Forms.RadioButton pig;
        private System.Windows.Forms.GroupBox grp_bird;
    }
}

