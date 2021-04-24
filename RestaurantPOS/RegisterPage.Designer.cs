
namespace RestaurantPOS
{
    partial class RegisterPage
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtBxIme = new System.Windows.Forms.TextBox();
            this.txtBxPrezime = new System.Windows.Forms.TextBox();
            this.txtBxOib = new System.Windows.Forms.TextBox();
            this.txtBxUsername = new System.Windows.Forms.TextBox();
            this.txtBxPassword = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(318, 311);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Registriraj se";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtBxIme
            // 
            this.txtBxIme.Location = new System.Drawing.Point(293, 151);
            this.txtBxIme.Name = "txtBxIme";
            this.txtBxIme.Size = new System.Drawing.Size(100, 20);
            this.txtBxIme.TabIndex = 1;
            // 
            // txtBxPrezime
            // 
            this.txtBxPrezime.Location = new System.Drawing.Point(293, 177);
            this.txtBxPrezime.Name = "txtBxPrezime";
            this.txtBxPrezime.Size = new System.Drawing.Size(100, 20);
            this.txtBxPrezime.TabIndex = 2;
            // 
            // txtBxOib
            // 
            this.txtBxOib.Location = new System.Drawing.Point(293, 204);
            this.txtBxOib.Name = "txtBxOib";
            this.txtBxOib.Size = new System.Drawing.Size(100, 20);
            this.txtBxOib.TabIndex = 3;
            // 
            // txtBxUsername
            // 
            this.txtBxUsername.Location = new System.Drawing.Point(293, 231);
            this.txtBxUsername.Name = "txtBxUsername";
            this.txtBxUsername.Size = new System.Drawing.Size(100, 20);
            this.txtBxUsername.TabIndex = 4;
            // 
            // txtBxPassword
            // 
            this.txtBxPassword.Location = new System.Drawing.Point(293, 258);
            this.txtBxPassword.Name = "txtBxPassword";
            this.txtBxPassword.Size = new System.Drawing.Size(100, 20);
            this.txtBxPassword.TabIndex = 5;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(206, 329);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "Povratak";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // RegisterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.txtBxPassword);
            this.Controls.Add(this.txtBxUsername);
            this.Controls.Add(this.txtBxOib);
            this.Controls.Add(this.txtBxPrezime);
            this.Controls.Add(this.txtBxIme);
            this.Controls.Add(this.btnRegister);
            this.Name = "RegisterPage";
            this.Text = "RegisterPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtBxIme;
        private System.Windows.Forms.TextBox txtBxPrezime;
        private System.Windows.Forms.TextBox txtBxOib;
        private System.Windows.Forms.TextBox txtBxUsername;
        private System.Windows.Forms.TextBox txtBxPassword;
        private System.Windows.Forms.Button btnReturn;
    }
}