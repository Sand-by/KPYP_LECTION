﻿namespace Xml_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.user_listbox1 = new System.Windows.Forms.ListBox();
            this.add_button = new MaterialSkin.Controls.MaterialButton();
            this.delete_user = new MaterialSkin.Controls.MaterialButton();
            this.restart_button = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.name_field = new MaterialSkin.Controls.MaterialTextBox();
            this.company_field = new MaterialSkin.Controls.MaterialTextBox();
            this.age_field = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialRadioButton3 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialRadioButton2 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialRadioButton1 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialSwitch1 = new MaterialSkin.Controls.MaterialSwitch();
            this.pic = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // user_listbox1
            // 
            this.user_listbox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.user_listbox1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.user_listbox1.FormattingEnabled = true;
            this.user_listbox1.ItemHeight = 37;
            this.user_listbox1.Items.AddRange(new object[] {
            "cvbc"});
            this.user_listbox1.Location = new System.Drawing.Point(3, 3);
            this.user_listbox1.Name = "user_listbox1";
            this.user_listbox1.Size = new System.Drawing.Size(723, 381);
            this.user_listbox1.TabIndex = 0;
            // 
            // add_button
            // 
            this.add_button.AutoSize = false;
            this.add_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.add_button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.add_button.Depth = 0;
            this.add_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add_button.HighEmphasis = true;
            this.add_button.Icon = null;
            this.add_button.Location = new System.Drawing.Point(4, 310);
            this.add_button.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.add_button.MouseState = MaterialSkin.MouseState.HOVER;
            this.add_button.Name = "add_button";
            this.add_button.NoAccentTextColor = System.Drawing.Color.Empty;
            this.add_button.Size = new System.Drawing.Size(299, 65);
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
            this.delete_user.Dock = System.Windows.Forms.DockStyle.Fill;
            this.delete_user.HighEmphasis = true;
            this.delete_user.Icon = null;
            this.delete_user.Location = new System.Drawing.Point(4, 234);
            this.delete_user.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.delete_user.MouseState = MaterialSkin.MouseState.HOVER;
            this.delete_user.Name = "delete_user";
            this.delete_user.NoAccentTextColor = System.Drawing.Color.Empty;
            this.delete_user.Size = new System.Drawing.Size(299, 64);
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
            this.restart_button.Size = new System.Drawing.Size(1034, 53);
            this.restart_button.TabIndex = 9;
            this.restart_button.Text = "Рестарт";
            this.restart_button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.restart_button.UseAccentColor = false;
            this.restart_button.UseVisualStyleBackColor = true;
            this.restart_button.Click += new System.EventHandler(this.Restart_button_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.user_listbox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.restart_button, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1042, 484);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(732, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 381);
            this.panel1.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.name_field, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.add_button, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.company_field, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.delete_user, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.age_field, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(307, 381);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // name_field
            // 
            this.name_field.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.name_field.AnimateReadOnly = false;
            this.name_field.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_field.Depth = 0;
            this.name_field.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.name_field.Hint = "Имя";
            this.name_field.LeadingIcon = null;
            this.name_field.Location = new System.Drawing.Point(3, 3);
            this.name_field.MaxLength = 50;
            this.name_field.MouseState = MaterialSkin.MouseState.OUT;
            this.name_field.Multiline = false;
            this.name_field.Name = "name_field";
            this.name_field.Size = new System.Drawing.Size(301, 50);
            this.name_field.TabIndex = 9;
            this.name_field.Text = "";
            this.name_field.TrailingIcon = null;
            // 
            // company_field
            // 
            this.company_field.AnimateReadOnly = false;
            this.company_field.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.company_field.Depth = 0;
            this.company_field.Dock = System.Windows.Forms.DockStyle.Fill;
            this.company_field.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.company_field.Hint = "Компания";
            this.company_field.LeadingIcon = null;
            this.company_field.Location = new System.Drawing.Point(3, 79);
            this.company_field.MaxLength = 50;
            this.company_field.MouseState = MaterialSkin.MouseState.OUT;
            this.company_field.Multiline = false;
            this.company_field.Name = "company_field";
            this.company_field.Size = new System.Drawing.Size(301, 50);
            this.company_field.TabIndex = 10;
            this.company_field.Text = "";
            this.company_field.TrailingIcon = null;
            // 
            // age_field
            // 
            this.age_field.AnimateReadOnly = false;
            this.age_field.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.age_field.Depth = 0;
            this.age_field.Dock = System.Windows.Forms.DockStyle.Fill;
            this.age_field.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.age_field.Hint = "Возраст";
            this.age_field.LeadingIcon = null;
            this.age_field.Location = new System.Drawing.Point(3, 155);
            this.age_field.MaxLength = 50;
            this.age_field.MouseState = MaterialSkin.MouseState.OUT;
            this.age_field.Multiline = false;
            this.age_field.Name = "age_field";
            this.age_field.Size = new System.Drawing.Size(301, 50);
            this.age_field.TabIndex = 11;
            this.age_field.Text = "";
            this.age_field.TrailingIcon = null;
            this.age_field.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Age_field_KeyPress);
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.pic;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1056, 533);
            this.materialTabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.ImageKey = "sdf.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1048, 490);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Главная";
            this.tabPage1.ToolTipText = "Главная";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.tableLayoutPanel3);
            this.tabPage2.ImageKey = "sety.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1048, 490);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Настройки";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.materialCard2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.materialCard1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1042, 484);
            this.tableLayoutPanel3.TabIndex = 13;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.materialCard2.Depth = 0;
            this.materialCard2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(535, 14);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(493, 456);
            this.materialCard2.TabIndex = 13;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.materialCard1.Controls.Add(this.materialButton1);
            this.materialCard1.Controls.Add(this.groupBox1);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(14, 14);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(493, 456);
            this.materialCard1.TabIndex = 12;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(17, 389);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(198, 45);
            this.materialButton1.TabIndex = 15;
            this.materialButton1.Text = "Сохранить настройки";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.materialRadioButton3);
            this.groupBox1.Controls.Add(this.materialRadioButton2);
            this.groupBox1.Controls.Add(this.materialRadioButton1);
            this.groupBox1.Controls.Add(this.materialSwitch1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.groupBox1.Location = new System.Drawing.Point(17, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 263);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Цветовая схема";
            // 
            // materialRadioButton3
            // 
            this.materialRadioButton3.AutoSize = true;
            this.materialRadioButton3.Depth = 0;
            this.materialRadioButton3.Location = new System.Drawing.Point(13, 142);
            this.materialRadioButton3.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton3.Name = "materialRadioButton3";
            this.materialRadioButton3.Ripple = true;
            this.materialRadioButton3.Size = new System.Drawing.Size(76, 37);
            this.materialRadioButton3.TabIndex = 14;
            this.materialRadioButton3.TabStop = true;
            this.materialRadioButton3.Text = "Green";
            this.materialRadioButton3.UseVisualStyleBackColor = true;
            this.materialRadioButton3.CheckedChanged += new System.EventHandler(this.materialRadioButton3_CheckedChanged);
            // 
            // materialRadioButton2
            // 
            this.materialRadioButton2.AutoSize = true;
            this.materialRadioButton2.Depth = 0;
            this.materialRadioButton2.Location = new System.Drawing.Point(13, 105);
            this.materialRadioButton2.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton2.Name = "materialRadioButton2";
            this.materialRadioButton2.Ripple = true;
            this.materialRadioButton2.Size = new System.Drawing.Size(86, 37);
            this.materialRadioButton2.TabIndex = 13;
            this.materialRadioButton2.TabStop = true;
            this.materialRadioButton2.Text = "Orange";
            this.materialRadioButton2.UseVisualStyleBackColor = true;
            this.materialRadioButton2.CheckedChanged += new System.EventHandler(this.materialRadioButton2_CheckedChanged);
            // 
            // materialRadioButton1
            // 
            this.materialRadioButton1.AutoSize = true;
            this.materialRadioButton1.Depth = 0;
            this.materialRadioButton1.Location = new System.Drawing.Point(13, 68);
            this.materialRadioButton1.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton1.Name = "materialRadioButton1";
            this.materialRadioButton1.Ripple = true;
            this.materialRadioButton1.Size = new System.Drawing.Size(66, 37);
            this.materialRadioButton1.TabIndex = 12;
            this.materialRadioButton1.TabStop = true;
            this.materialRadioButton1.Text = "Blue";
            this.materialRadioButton1.UseVisualStyleBackColor = true;
            this.materialRadioButton1.CheckedChanged += new System.EventHandler(this.materialRadioButton1_CheckedChanged);
            // 
            // materialSwitch1
            // 
            this.materialSwitch1.AutoSize = true;
            this.materialSwitch1.Depth = 0;
            this.materialSwitch1.Location = new System.Drawing.Point(13, 22);
            this.materialSwitch1.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitch1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitch1.Name = "materialSwitch1";
            this.materialSwitch1.Ripple = true;
            this.materialSwitch1.Size = new System.Drawing.Size(103, 37);
            this.materialSwitch1.TabIndex = 11;
            this.materialSwitch1.Text = "LIGHT";
            this.materialSwitch1.UseVisualStyleBackColor = true;
            this.materialSwitch1.CheckedChanged += new System.EventHandler(this.materialSwitch1_CheckedChanged_1);
            // 
            // pic
            // 
            this.pic.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.pic.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("pic.ImageStream")));
            this.pic.TransparentColor = System.Drawing.Color.Transparent;
            this.pic.Images.SetKeyName(0, "sdf.png");
            this.pic.Images.SetKeyName(1, "sety.png");
            this.pic.Images.SetKeyName(2, "sdf.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 600);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerBackgroundWithAccent = true;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XmlViewer";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox user_listbox1;
        private MaterialSkin.Controls.MaterialButton add_button;
        private MaterialSkin.Controls.MaterialButton delete_user;
        private MaterialSkin.Controls.MaterialButton restart_button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList pic;
        private MaterialSkin.Controls.MaterialSwitch materialSwitch1;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialTextBox name_field;
        private MaterialSkin.Controls.MaterialTextBox age_field;
        private MaterialSkin.Controls.MaterialTextBox company_field;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton3;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton2;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}
