﻿namespace UltimateGarage
{
    partial class THEMTIENCONG
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(THEMTIENCONG));
            thembtn = new Button();
            thoatbtn = new Button();
            label7 = new Label();
            label8 = new Label();
            TenChuXe = new Label();
            panel1 = new Panel();
            VatTuPhuTung_Title = new Label();
            matctxtbox = new Guna.UI2.WinForms.Guna2TextBox();
            tctxtbox = new Guna.UI2.WinForms.Guna2TextBox();
            ndtxtbox = new Guna.UI2.WinForms.Guna2TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // thembtn
            // 
            thembtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            thembtn.Location = new Point(427, 160);
            thembtn.Name = "thembtn";
            thembtn.Size = new Size(94, 29);
            thembtn.TabIndex = 68;
            thembtn.Text = "Thêm";
            thembtn.UseVisualStyleBackColor = true;
            thembtn.Click += thembtn_Click;
            // 
            // thoatbtn
            // 
            thoatbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            thoatbtn.Location = new Point(527, 160);
            thoatbtn.Name = "thoatbtn";
            thoatbtn.Size = new Size(94, 29);
            thoatbtn.TabIndex = 69;
            thoatbtn.Text = "Thoát";
            thoatbtn.UseVisualStyleBackColor = true;
            thoatbtn.Click += thoatbtn_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F);
            label7.Location = new Point(33, 93);
            label7.Name = "label7";
            label7.Size = new Size(119, 31);
            label7.TabIndex = 65;
            label7.Text = "Tiền công:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F);
            label8.Location = new Point(33, 60);
            label8.Name = "label8";
            label8.Size = new Size(197, 31);
            label8.TabIndex = 66;
            label8.Text = "Mã loại tiền công:";
            // 
            // TenChuXe
            // 
            TenChuXe.Anchor = AnchorStyles.Top;
            TenChuXe.AutoSize = true;
            TenChuXe.Font = new Font("Segoe UI", 13.8F);
            TenChuXe.Location = new Point(33, 126);
            TenChuXe.Name = "TenChuXe";
            TenChuXe.Size = new Size(115, 31);
            TenChuXe.TabIndex = 67;
            TenChuXe.Text = "Nội dung:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(VatTuPhuTung_Title);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(634, 60);
            panel1.TabIndex = 70;
            // 
            // VatTuPhuTung_Title
            // 
            VatTuPhuTung_Title.Anchor = AnchorStyles.Top;
            VatTuPhuTung_Title.AutoSize = true;
            VatTuPhuTung_Title.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold);
            VatTuPhuTung_Title.ForeColor = Color.White;
            VatTuPhuTung_Title.Location = new Point(143, 8);
            VatTuPhuTung_Title.Margin = new Padding(5, 0, 5, 0);
            VatTuPhuTung_Title.Name = "VatTuPhuTung_Title";
            VatTuPhuTung_Title.Size = new Size(382, 45);
            VatTuPhuTung_Title.TabIndex = 71;
            VatTuPhuTung_Title.Text = "THÊM LOẠI TIỀN CÔNG";
            // 
            // matctxtbox
            // 
            matctxtbox.BackColor = Color.Transparent;
            matctxtbox.BorderColor = Color.Black;
            matctxtbox.BorderRadius = 5;
            matctxtbox.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            matctxtbox.CustomizableEdges = customizableEdges1;
            matctxtbox.DefaultText = "";
            matctxtbox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            matctxtbox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            matctxtbox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            matctxtbox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            matctxtbox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            matctxtbox.Font = new Font("Segoe UI", 9F);
            matctxtbox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            matctxtbox.IconRightCursor = Cursors.AppStarting;
            matctxtbox.Location = new Point(235, 65);
            matctxtbox.Margin = new Padding(3, 4, 3, 4);
            matctxtbox.Name = "matctxtbox";
            matctxtbox.PlaceholderText = "";
            matctxtbox.SelectedText = "";
            matctxtbox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            matctxtbox.Size = new Size(360, 24);
            matctxtbox.TabIndex = 71;
            // 
            // tctxtbox
            // 
            tctxtbox.BackColor = Color.Transparent;
            tctxtbox.BorderColor = Color.Black;
            tctxtbox.BorderRadius = 5;
            tctxtbox.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            tctxtbox.CustomizableEdges = customizableEdges3;
            tctxtbox.DefaultText = "";
            tctxtbox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tctxtbox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tctxtbox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tctxtbox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tctxtbox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tctxtbox.Font = new Font("Segoe UI", 9F);
            tctxtbox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tctxtbox.IconRightCursor = Cursors.AppStarting;
            tctxtbox.Location = new Point(235, 98);
            tctxtbox.Margin = new Padding(3, 4, 3, 4);
            tctxtbox.Name = "tctxtbox";
            tctxtbox.PlaceholderText = "";
            tctxtbox.SelectedText = "";
            tctxtbox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            tctxtbox.Size = new Size(360, 24);
            tctxtbox.TabIndex = 72;
            // 
            // ndtxtbox
            // 
            ndtxtbox.BackColor = Color.Transparent;
            ndtxtbox.BorderColor = Color.Black;
            ndtxtbox.BorderRadius = 5;
            ndtxtbox.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            ndtxtbox.CustomizableEdges = customizableEdges5;
            ndtxtbox.DefaultText = "";
            ndtxtbox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            ndtxtbox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            ndtxtbox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            ndtxtbox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            ndtxtbox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            ndtxtbox.Font = new Font("Segoe UI", 9F);
            ndtxtbox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            ndtxtbox.IconRightCursor = Cursors.AppStarting;
            ndtxtbox.Location = new Point(235, 130);
            ndtxtbox.Margin = new Padding(3, 4, 3, 4);
            ndtxtbox.Name = "ndtxtbox";
            ndtxtbox.PlaceholderText = "";
            ndtxtbox.SelectedText = "";
            ndtxtbox.ShadowDecoration.CustomizableEdges = customizableEdges6;
            ndtxtbox.Size = new Size(360, 24);
            ndtxtbox.TabIndex = 73;
            // 
            // THEMTIENCONG
            // 
            AcceptButton = thembtn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            CancelButton = thoatbtn;
            ClientSize = new Size(633, 201);
            Controls.Add(ndtxtbox);
            Controls.Add(tctxtbox);
            Controls.Add(matctxtbox);
            Controls.Add(panel1);
            Controls.Add(thembtn);
            Controls.Add(thoatbtn);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(TenChuXe);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "THEMTIENCONG";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm loại tiền công";
            Load += THEMTIENCONG_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button thembtn;
        private Button thoatbtn;
        private Label label7;
        private Label label8;
        private Label TenChuXe;
        private Panel panel1;
        private Label VatTuPhuTung_Title;
        private Guna.UI2.WinForms.Guna2TextBox matctxtbox;
        private Guna.UI2.WinForms.Guna2TextBox tctxtbox;
        private Guna.UI2.WinForms.Guna2TextBox ndtxtbox;
    }
}