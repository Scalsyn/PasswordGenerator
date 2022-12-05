namespace PasswordGenerator
{
    partial class PwGenForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.chbox_captialLetter = new System.Windows.Forms.CheckBox();
            this.chbox_symboles = new System.Windows.Forms.CheckBox();
            this.chbox_number = new System.Windows.Forms.CheckBox();
            this.txtbox_password = new System.Windows.Forms.TextBox();
            this.btn_generate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.num_length = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_length)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(154, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(663, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password Generator";
            // 
            // chbox_captialLetter
            // 
            this.chbox_captialLetter.AutoSize = true;
            this.chbox_captialLetter.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chbox_captialLetter.Location = new System.Drawing.Point(330, 209);
            this.chbox_captialLetter.Name = "chbox_captialLetter";
            this.chbox_captialLetter.Size = new System.Drawing.Size(265, 45);
            this.chbox_captialLetter.TabIndex = 1;
            this.chbox_captialLetter.Text = "Capital letters";
            this.chbox_captialLetter.UseVisualStyleBackColor = true;
            // 
            // chbox_symboles
            // 
            this.chbox_symboles.AutoSize = true;
            this.chbox_symboles.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chbox_symboles.Location = new System.Drawing.Point(330, 270);
            this.chbox_symboles.Name = "chbox_symboles";
            this.chbox_symboles.Size = new System.Drawing.Size(196, 45);
            this.chbox_symboles.TabIndex = 2;
            this.chbox_symboles.Text = "Symboles";
            this.chbox_symboles.UseVisualStyleBackColor = true;
            // 
            // chbox_number
            // 
            this.chbox_number.AutoSize = true;
            this.chbox_number.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chbox_number.Location = new System.Drawing.Point(330, 337);
            this.chbox_number.Name = "chbox_number";
            this.chbox_number.Size = new System.Drawing.Size(193, 45);
            this.chbox_number.TabIndex = 3;
            this.chbox_number.Text = "Numbers";
            this.chbox_number.UseVisualStyleBackColor = true;
            // 
            // txtbox_password
            // 
            this.txtbox_password.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbox_password.Location = new System.Drawing.Point(12, 565);
            this.txtbox_password.MaxLength = 20;
            this.txtbox_password.Name = "txtbox_password";
            this.txtbox_password.Size = new System.Drawing.Size(954, 55);
            this.txtbox_password.TabIndex = 4;
            // 
            // btn_generate
            // 
            this.btn_generate.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_generate.Location = new System.Drawing.Point(391, 480);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(190, 70);
            this.btn_generate.TabIndex = 5;
            this.btn_generate.Text = "Generate";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(330, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 41);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password length:";
            // 
            // num_length
            // 
            this.num_length.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num_length.Location = new System.Drawing.Point(617, 141);
            this.num_length.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.num_length.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.num_length.Name = "num_length";
            this.num_length.Size = new System.Drawing.Size(90, 55);
            this.num_length.TabIndex = 7;
            this.num_length.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(596, 789);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 60);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PwGenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(978, 944);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.num_length);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.txtbox_password);
            this.Controls.Add(this.chbox_number);
            this.Controls.Add(this.chbox_symboles);
            this.Controls.Add(this.chbox_captialLetter);
            this.Controls.Add(this.label1);
            this.Name = "PwGenForm";
            this.Text = "Password Generator";
            ((System.ComponentModel.ISupportInitialize)(this.num_length)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private CheckBox chbox_captialLetter;
        private CheckBox chbox_symboles;
        private CheckBox chbox_number;
        private TextBox txtbox_password;
        private Button btn_generate;
        private Label label2;
        private NumericUpDown num_length;
        private Button button1;
    }
}