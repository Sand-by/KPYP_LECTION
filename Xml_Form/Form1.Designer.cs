namespace Xml_Form
{
    partial class Form1
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
            this.user_listbox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.name_field = new System.Windows.Forms.TextBox();
            this.company_field = new System.Windows.Forms.TextBox();
            this.age_field = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // user_listbox
            // 
            this.user_listbox.FormattingEnabled = true;
            this.user_listbox.ItemHeight = 20;
            this.user_listbox.Location = new System.Drawing.Point(12, 27);
            this.user_listbox.Name = "user_listbox";
            this.user_listbox.Size = new System.Drawing.Size(300, 244);
            this.user_listbox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // name_field
            // 
            this.name_field.Location = new System.Drawing.Point(341, 27);
            this.name_field.Name = "name_field";
            this.name_field.PlaceholderText = "Имя";
            this.name_field.Size = new System.Drawing.Size(192, 27);
            this.name_field.TabIndex = 2;
            // 
            // company_field
            // 
            this.company_field.Location = new System.Drawing.Point(341, 75);
            this.company_field.Name = "company_field";
            this.company_field.PlaceholderText = "Компания";
            this.company_field.Size = new System.Drawing.Size(192, 27);
            this.company_field.TabIndex = 3;
            // 
            // age_field
            // 
            this.age_field.Location = new System.Drawing.Point(341, 123);
            this.age_field.Name = "age_field";
            this.age_field.PlaceholderText = "Вовзраст";
            this.age_field.Size = new System.Drawing.Size(192, 27);
            this.age_field.TabIndex = 4;
            this.age_field.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.age_field_KeyPress);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(341, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 51);
            this.button2.TabIndex = 5;
            this.button2.Text = "Удалить последнюю запись";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 289);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(521, 54);
            this.button3.TabIndex = 6;
            this.button3.Text = "Рестарт";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 353);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.age_field);
            this.Controls.Add(this.company_field);
            this.Controls.Add(this.name_field);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.user_listbox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(570, 400);
            this.MinimumSize = new System.Drawing.Size(570, 400);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox user_listbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox name_field;
        private System.Windows.Forms.TextBox company_field;
        private System.Windows.Forms.TextBox age_field;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
