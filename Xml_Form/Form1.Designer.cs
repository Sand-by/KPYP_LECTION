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
            this.user_listbox1 = new System.Windows.Forms.ListBox();
            this.name_field1 = new System.Windows.Forms.TextBox();
            this.company_field = new System.Windows.Forms.TextBox();
            this.age_field = new System.Windows.Forms.TextBox();
            this.add_button = new MaterialSkin.Controls.MaterialButton();
            this.delete_user = new MaterialSkin.Controls.MaterialButton();
            this.restart_button = new MaterialSkin.Controls.MaterialButton();
            this.materialSwitch1 = new MaterialSkin.Controls.MaterialSwitch();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // user_listbox1
            // 
            this.user_listbox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.user_listbox1.FormattingEnabled = true;
            this.user_listbox1.ItemHeight = 20;
            this.user_listbox1.Location = new System.Drawing.Point(3, 3);
            this.user_listbox1.Name = "user_listbox1";
            this.user_listbox1.Size = new System.Drawing.Size(540, 381);
            this.user_listbox1.TabIndex = 0;
            // 
            // name_field1
            // 
            this.name_field1.Location = new System.Drawing.Point(5, 1);
            this.name_field1.Name = "name_field1";
            this.name_field1.PlaceholderText = "Имя";
            this.name_field1.Size = new System.Drawing.Size(192, 27);
            this.name_field1.TabIndex = 2;
            // 
            // company_field
            // 
            this.company_field.Location = new System.Drawing.Point(5, 34);
            this.company_field.Name = "company_field";
            this.company_field.PlaceholderText = "Компания";
            this.company_field.Size = new System.Drawing.Size(192, 27);
            this.company_field.TabIndex = 3;
            // 
            // age_field
            // 
            this.age_field.Location = new System.Drawing.Point(5, 67);
            this.age_field.Name = "age_field";
            this.age_field.PlaceholderText = "Вовзраст";
            this.age_field.Size = new System.Drawing.Size(192, 27);
            this.age_field.TabIndex = 4;
            this.age_field.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Age_field_KeyPress);
            // 
            // add_button
            // 
            this.add_button.AutoSize = false;
            this.add_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.add_button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.add_button.Depth = 0;
            this.add_button.HighEmphasis = true;
            this.add_button.Icon = null;
            this.add_button.Location = new System.Drawing.Point(5, 138);
            this.add_button.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.add_button.MouseState = MaterialSkin.MouseState.HOVER;
            this.add_button.Name = "add_button";
            this.add_button.NoAccentTextColor = System.Drawing.Color.Empty;
            this.add_button.Size = new System.Drawing.Size(192, 36);
            this.add_button.TabIndex = 7;
            this.add_button.Text = "Добавить";
            this.add_button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.add_button.UseAccentColor = false;
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // delete_user
            // 
            this.delete_user.AutoSize = false;
            this.delete_user.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.delete_user.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.delete_user.Depth = 0;
            this.delete_user.HighEmphasis = true;
            this.delete_user.Icon = null;
            this.delete_user.Location = new System.Drawing.Point(5, 186);
            this.delete_user.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.delete_user.MouseState = MaterialSkin.MouseState.HOVER;
            this.delete_user.Name = "delete_user";
            this.delete_user.NoAccentTextColor = System.Drawing.Color.Empty;
            this.delete_user.Size = new System.Drawing.Size(192, 36);
            this.delete_user.TabIndex = 8;
            this.delete_user.Text = "Удалить";
            this.delete_user.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.delete_user.UseAccentColor = false;
            this.delete_user.UseVisualStyleBackColor = true;
            this.delete_user.Click += new System.EventHandler(this.Delete_user_Click);
            // 
            // restart_button
            // 
            this.restart_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.restart_button.AutoSize = false;
            this.restart_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(this.restart_button, 2);
            this.restart_button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.restart_button.Depth = 0;
            this.restart_button.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.restart_button.HighEmphasis = true;
            this.restart_button.Icon = null;
            this.restart_button.Location = new System.Drawing.Point(4, 425);
            this.restart_button.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.restart_button.MaximumSize = new System.Drawing.Size(0, 53);
            this.restart_button.MouseState = MaterialSkin.MouseState.HOVER;
            this.restart_button.Name = "restart_button";
            this.restart_button.NoAccentTextColor = System.Drawing.Color.Empty;
            this.restart_button.Size = new System.Drawing.Size(772, 53);
            this.restart_button.TabIndex = 9;
            this.restart_button.Text = "Рестарт";
            this.restart_button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.restart_button.UseAccentColor = false;
            this.restart_button.UseVisualStyleBackColor = true;
            this.restart_button.Click += new System.EventHandler(this.Restart_button_Click);
            // 
            // materialSwitch1
            // 
            this.materialSwitch1.AutoSize = true;
            this.materialSwitch1.Depth = 0;
            this.materialSwitch1.Location = new System.Drawing.Point(5, 95);
            this.materialSwitch1.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitch1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitch1.Name = "materialSwitch1";
            this.materialSwitch1.Ripple = true;
            this.materialSwitch1.Size = new System.Drawing.Size(120, 37);
            this.materialSwitch1.TabIndex = 10;
            this.materialSwitch1.Text = "Светлая";
            this.materialSwitch1.UseVisualStyleBackColor = true;
            this.materialSwitch1.CheckedChanged += new System.EventHandler(this.materialSwitch1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.delete_user);
            this.groupBox1.Controls.Add(this.add_button);
            this.groupBox1.Controls.Add(this.materialSwitch1);
            this.groupBox1.Controls.Add(this.age_field);
            this.groupBox1.Controls.Add(this.company_field);
            this.groupBox1.Controls.Add(this.name_field1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(549, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 381);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.user_listbox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.restart_button, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(780, 484);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(794, 533);
            this.materialTabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.ImageKey = "dfg.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(786, 490);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Главная";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.ImageKey = "settings.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(786, 490);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Настройки";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XmlViewer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox user_listbox1;
        private System.Windows.Forms.TextBox name_field1;
        private System.Windows.Forms.TextBox company_field;
        private System.Windows.Forms.TextBox age_field;
        private MaterialSkin.Controls.MaterialButton add_button;
        private MaterialSkin.Controls.MaterialButton delete_user;
        private MaterialSkin.Controls.MaterialButton restart_button;
        private MaterialSkin.Controls.MaterialSwitch materialSwitch1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}
