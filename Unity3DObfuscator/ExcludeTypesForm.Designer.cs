namespace Unity3DObfuscator
{
    partial class ExcludeTypesForm
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
            this.MainTheme = new FormSkin.clsNeoBuxTheme();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchExcludedTypes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ExcludedTypesList = new System.Windows.Forms.ListBox();
            this.SearchTypesTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TypesList = new System.Windows.Forms.ListBox();
            this.CloseBtn = new FormSkin.clsButtonPurple();
            this.RemoveBtn = new FormSkin.clsButtonOrange();
            this.AddBtn = new FormSkin.clsButtonGreen();
            this.clsButtonBlue = new FormSkin.clsButtonOrange();
            this.MainTheme.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTheme
            // 
            this.MainTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.MainTheme.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainTheme.Controls.Add(this.clsButtonBlue);
            this.MainTheme.Controls.Add(this.label4);
            this.MainTheme.Controls.Add(this.label3);
            this.MainTheme.Controls.Add(this.SearchExcludedTypes);
            this.MainTheme.Controls.Add(this.label2);
            this.MainTheme.Controls.Add(this.ExcludedTypesList);
            this.MainTheme.Controls.Add(this.SearchTypesTxt);
            this.MainTheme.Controls.Add(this.label1);
            this.MainTheme.Controls.Add(this.TypesList);
            this.MainTheme.Controls.Add(this.CloseBtn);
            this.MainTheme.Controls.Add(this.RemoveBtn);
            this.MainTheme.Controls.Add(this.AddBtn);
            this.MainTheme.Customization = "AAAA/w==";
            this.MainTheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTheme.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MainTheme.Image = null;
            this.MainTheme.Location = new System.Drawing.Point(0, 0);
            this.MainTheme.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MainTheme.Movable = true;
            this.MainTheme.Name = "MainTheme";
            this.MainTheme.NoRounding = false;
            this.MainTheme.Sizable = false;
            this.MainTheme.Size = new System.Drawing.Size(1007, 552);
            this.MainTheme.SmartBounds = true;
            this.MainTheme.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MainTheme.TabIndex = 0;
            this.MainTheme.Text = "Exlude Types";
            this.MainTheme.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.MainTheme.Transparent = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(505, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Excluded Types:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Types:";
            // 
            // SearchExcludedTypes
            // 
            this.SearchExcludedTypes.Location = new System.Drawing.Point(809, 47);
            this.SearchExcludedTypes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SearchExcludedTypes.Name = "SearchExcludedTypes";
            this.SearchExcludedTypes.Size = new System.Drawing.Size(191, 27);
            this.SearchExcludedTypes.TabIndex = 10;
            this.SearchExcludedTypes.TextChanged += new System.EventHandler(this.SearchExcludedTypes_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(727, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "Search:";
            // 
            // ExcludedTypesList
            // 
            this.ExcludedTypesList.FormattingEnabled = true;
            this.ExcludedTypesList.ItemHeight = 20;
            this.ExcludedTypesList.Location = new System.Drawing.Point(508, 75);
            this.ExcludedTypesList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ExcludedTypesList.Name = "ExcludedTypesList";
            this.ExcludedTypesList.Size = new System.Drawing.Size(492, 384);
            this.ExcludedTypesList.TabIndex = 8;
            // 
            // SearchTypesTxt
            // 
            this.SearchTypesTxt.Location = new System.Drawing.Point(305, 47);
            this.SearchTypesTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SearchTypesTxt.Name = "SearchTypesTxt";
            this.SearchTypesTxt.Size = new System.Drawing.Size(191, 27);
            this.SearchTypesTxt.TabIndex = 7;
            this.SearchTypesTxt.TextChanged += new System.EventHandler(this.SearchTypesTxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search:";
            // 
            // TypesList
            // 
            this.TypesList.FormattingEnabled = true;
            this.TypesList.ItemHeight = 20;
            this.TypesList.Location = new System.Drawing.Point(4, 75);
            this.TypesList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TypesList.Name = "TypesList";
            this.TypesList.Size = new System.Drawing.Size(492, 384);
            this.TypesList.TabIndex = 5;
            this.TypesList.SelectedIndexChanged += new System.EventHandler(this.TypesList_SelectedIndexChanged);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Customization = "9fX1/6mpqf8=";
            this.CloseBtn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.Image = null;
            this.CloseBtn.Location = new System.Drawing.Point(4, 511);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.NoRounding = false;
            this.CloseBtn.Size = new System.Drawing.Size(996, 36);
            this.CloseBtn.TabIndex = 4;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.Transparent = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Customization = "9fX1/6mpqf8=";
            this.RemoveBtn.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveBtn.Image = null;
            this.RemoveBtn.Location = new System.Drawing.Point(318, 467);
            this.RemoveBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.NoRounding = false;
            this.RemoveBtn.Size = new System.Drawing.Size(361, 37);
            this.RemoveBtn.TabIndex = 2;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.Transparent = false;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Customization = "9fX1/6mpqf8=";
            this.AddBtn.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Image = null;
            this.AddBtn.Location = new System.Drawing.Point(4, 467);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.NoRounding = false;
            this.AddBtn.Size = new System.Drawing.Size(306, 37);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "Add";
            this.AddBtn.Transparent = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // clsButtonBlue
            // 
            this.clsButtonBlue.Customization = "9fX1/6mpqf8=";
            this.clsButtonBlue.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clsButtonBlue.Image = null;
            this.clsButtonBlue.Location = new System.Drawing.Point(687, 467);
            this.clsButtonBlue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.clsButtonBlue.Name = "clsButtonBlue";
            this.clsButtonBlue.NoRounding = false;
            this.clsButtonBlue.Size = new System.Drawing.Size(310, 37);
            this.clsButtonBlue.TabIndex = 13;
            this.clsButtonBlue.Text = "AddFromFile";
            this.clsButtonBlue.Transparent = false;
            this.clsButtonBlue.Click += new System.EventHandler(this.clsButtonBlue_Click);
            // 
            // ExcludeTypesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 552);
            this.Controls.Add(this.MainTheme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ExcludeTypesForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exclude Types";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.MainTheme.ResumeLayout(false);
            this.MainTheme.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FormSkin.clsNeoBuxTheme MainTheme;
        private FormSkin.clsButtonPurple CloseBtn;
        private FormSkin.clsButtonOrange RemoveBtn;
        private FormSkin.clsButtonGreen AddBtn;
        private System.Windows.Forms.ListBox TypesList;
        private System.Windows.Forms.TextBox SearchTypesTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchExcludedTypes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ExcludedTypesList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private FormSkin.clsButtonOrange clsButtonBlue;
    }
}