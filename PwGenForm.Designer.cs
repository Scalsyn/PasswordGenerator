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
            this.btn_vaultAdd = new System.Windows.Forms.Button();
            this.btn_copy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbox_vault = new System.Windows.Forms.TextBox();
            this.lbl_message = new System.Windows.Forms.Label();
            this.btn_vaultClear = new System.Windows.Forms.Button();
            this.lbl_pwStrength = new System.Windows.Forms.Label();
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
            this.chbox_captialLetter.Location = new System.Drawing.Point(330, 202);
            this.chbox_captialLetter.Margin = new System.Windows.Forms.Padding(6);
            this.chbox_captialLetter.Name = "chbox_captialLetter";
            this.chbox_captialLetter.Size = new System.Drawing.Size(265, 45);
            this.chbox_captialLetter.TabIndex = 2;
            this.chbox_captialLetter.Text = "Capital letters";
            this.chbox_captialLetter.UseVisualStyleBackColor = true;
            // 
            // chbox_symboles
            // 
            this.chbox_symboles.AutoSize = true;
            this.chbox_symboles.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chbox_symboles.Location = new System.Drawing.Point(330, 259);
            this.chbox_symboles.Margin = new System.Windows.Forms.Padding(6);
            this.chbox_symboles.Name = "chbox_symboles";
            this.chbox_symboles.Size = new System.Drawing.Size(196, 45);
            this.chbox_symboles.TabIndex = 3;
            this.chbox_symboles.Text = "Symboles";
            this.chbox_symboles.UseVisualStyleBackColor = true;
            // 
            // chbox_number
            // 
            this.chbox_number.AutoSize = true;
            this.chbox_number.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chbox_number.Location = new System.Drawing.Point(330, 316);
            this.chbox_number.Margin = new System.Windows.Forms.Padding(6);
            this.chbox_number.Name = "chbox_number";
            this.chbox_number.Size = new System.Drawing.Size(193, 45);
            this.chbox_number.TabIndex = 4;
            this.chbox_number.Text = "Numbers";
            this.chbox_number.UseVisualStyleBackColor = true;
            // 
            // txtbox_password
            // 
            this.txtbox_password.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbox_password.Location = new System.Drawing.Point(12, 504);
            this.txtbox_password.MaxLength = 40;
            this.txtbox_password.Name = "txtbox_password";
            this.txtbox_password.ReadOnly = true;
            this.txtbox_password.Size = new System.Drawing.Size(954, 55);
            this.txtbox_password.TabIndex = 99;
            this.txtbox_password.TabStop = false;
            // 
            // btn_generate
            // 
            this.btn_generate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_generate.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_generate.Location = new System.Drawing.Point(392, 428);
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
            this.label2.Margin = new System.Windows.Forms.Padding(6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 41);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password length:";
            // 
            // num_length
            // 
            this.num_length.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num_length.Location = new System.Drawing.Point(627, 141);
            this.num_length.Maximum = new decimal(new int[] {
            40,
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
            this.num_length.TabIndex = 1;
            this.num_length.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // btn_vaultAdd
            // 
            this.btn_vaultAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_vaultAdd.Enabled = false;
            this.btn_vaultAdd.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_vaultAdd.Location = new System.Drawing.Point(579, 788);
            this.btn_vaultAdd.Name = "btn_vaultAdd";
            this.btn_vaultAdd.Size = new System.Drawing.Size(125, 60);
            this.btn_vaultAdd.TabIndex = 8;
            this.btn_vaultAdd.Text = "Add";
            this.btn_vaultAdd.UseVisualStyleBackColor = true;
            this.btn_vaultAdd.Click += new System.EventHandler(this.btn_vaultAdd_Click);
            // 
            // btn_copy
            // 
            this.btn_copy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_copy.Enabled = false;
            this.btn_copy.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_copy.Location = new System.Drawing.Point(826, 565);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(140, 60);
            this.btn_copy.TabIndex = 6;
            this.btn_copy.Text = "Copy";
            this.btn_copy.UseVisualStyleBackColor = true;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 662);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(691, 41);
            this.label3.TabIndex = 10;
            this.label3.Text = "Add passwordArray to vault:                                  \r\n";
            // 
            // txtbox_vault
            // 
            this.txtbox_vault.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbox_vault.Location = new System.Drawing.Point(12, 789);
            this.txtbox_vault.MaxLength = 20;
            this.txtbox_vault.Name = "txtbox_vault";
            this.txtbox_vault.PlaceholderText = "Save as";
            this.txtbox_vault.Size = new System.Drawing.Size(500, 55);
            this.txtbox_vault.TabIndex = 7;
            this.txtbox_vault.TextChanged += new System.EventHandler(this.txtbox_vault_TextChanged);
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_message.Location = new System.Drawing.Point(12, 886);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(0, 29);
            this.lbl_message.TabIndex = 100;
            // 
            // btn_vaultClear
            // 
            this.btn_vaultClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_vaultClear.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_vaultClear.Location = new System.Drawing.Point(579, 866);
            this.btn_vaultClear.Name = "btn_vaultClear";
            this.btn_vaultClear.Size = new System.Drawing.Size(207, 60);
            this.btn_vaultClear.TabIndex = 9;
            this.btn_vaultClear.Text = "Clear Vault";
            this.btn_vaultClear.UseVisualStyleBackColor = true;
            this.btn_vaultClear.Click += new System.EventHandler(this.btn_vaultClear_Click);
            // 
            // lbl_pwStrength
            // 
            this.lbl_pwStrength.AutoSize = true;
            this.lbl_pwStrength.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_pwStrength.Location = new System.Drawing.Point(12, 585);
            this.lbl_pwStrength.Name = "lbl_pwStrength";
            this.lbl_pwStrength.Size = new System.Drawing.Size(0, 29);
            this.lbl_pwStrength.TabIndex = 101;
            // 
            // PwGenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(978, 944);
            this.Controls.Add(this.lbl_pwStrength);
            this.Controls.Add(this.btn_vaultClear);
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.txtbox_vault);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_copy);
            this.Controls.Add(this.btn_vaultAdd);
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
        private Button btn_vaultAdd;
        private Button btn_copy;
        private Label label3;
        private TextBox txtbox_vault;
        private Label lbl_message;
        private Button btn_vaultClear;
        private Label lbl_pwStrength;
    }
}