namespace WindowsFormsApp1
{
    partial class UserManagement
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
            this.DataGridUser = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DeleteUser = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SetAdminButton = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridUser)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridUser
            // 
            this.DataGridUser.AllowUserToAddRows = false;
            this.DataGridUser.AllowUserToDeleteRows = false;
            this.DataGridUser.AllowUserToOrderColumns = true;
            this.DataGridUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DataGridUser.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.DataGridUser.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.DataGridUser.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.DataGridUser.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.DataGridUser.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.DataGridUser.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.DataGridUser.Location = new System.Drawing.Point(0, 0);
            this.DataGridUser.Name = "DataGridUser";
            this.DataGridUser.ReadOnly = true;
            this.DataGridUser.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridUser.Size = new System.Drawing.Size(1045, 720);
            this.DataGridUser.StateCommon.Background.Color1 = System.Drawing.Color.Transparent;
            this.DataGridUser.StateCommon.Background.Color2 = System.Drawing.Color.Transparent;
            this.DataGridUser.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.DataGridUser.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.DataGridUser.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.Transparent;
            this.DataGridUser.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.White;
            this.DataGridUser.StateCommon.DataCell.Border.Color2 = System.Drawing.Color.White;
            this.DataGridUser.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DataGridUser.StateCommon.DataCell.Border.Rounding = 3;
            this.DataGridUser.StateCommon.DataCell.Border.Width = 1;
            this.DataGridUser.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.White;
            this.DataGridUser.StateCommon.DataCell.Content.Font = new System.Drawing.Font("FZYaoTi", 15F);
            this.DataGridUser.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.DataGridUser.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.DataGridUser.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.White;
            this.DataGridUser.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.White;
            this.DataGridUser.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DataGridUser.StateCommon.HeaderColumn.Border.Width = 1;
            this.DataGridUser.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.DataGridUser.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.White;
            this.DataGridUser.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("FZYaoTi", 20F);
            this.DataGridUser.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.Transparent;
            this.DataGridUser.StateCommon.HeaderRow.Back.Color2 = System.Drawing.Color.Transparent;
            this.DataGridUser.StateCommon.HeaderRow.Border.Color1 = System.Drawing.Color.White;
            this.DataGridUser.StateCommon.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DataGridUser.StateCommon.HeaderRow.Border.Width = 3;
            this.DataGridUser.StateCommon.HeaderRow.Content.Color1 = System.Drawing.Color.White;
            this.DataGridUser.StateCommon.HeaderRow.Content.Color2 = System.Drawing.Color.White;
            this.DataGridUser.StateCommon.HeaderRow.Content.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.DataGridUser.StateCommon.HeaderRow.Content.Font = new System.Drawing.Font("FZYaoTi", 20F);
            this.DataGridUser.StateCommon.HeaderRow.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.DataGridUser.StateCommon.HeaderRow.Content.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.DataGridUser.StatePressed.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.DataGridUser.StatePressed.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.DataGridUser.StatePressed.HeaderRow.Back.Color1 = System.Drawing.Color.SkyBlue;
            this.DataGridUser.StatePressed.HeaderRow.Content.Color1 = System.Drawing.Color.Black;
            this.DataGridUser.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.DataGridUser.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.DataGridUser.StateSelected.DataCell.Border.Color1 = System.Drawing.Color.SkyBlue;
            this.DataGridUser.StateSelected.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DataGridUser.StateSelected.DataCell.Border.Width = 4;
            this.DataGridUser.StateSelected.DataCell.Content.Color1 = System.Drawing.Color.White;
            this.DataGridUser.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SetAdminButton);
            this.panel1.Controls.Add(this.DeleteUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1065, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 720);
            this.panel1.TabIndex = 2;
            // 
            // DeleteUser
            // 
            this.DeleteUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteUser.AutoSize = true;
            this.DeleteUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteUser.Location = new System.Drawing.Point(30, 156);
            this.DeleteUser.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.OverrideDefault.Back.Color1 = System.Drawing.Color.Black;
            this.DeleteUser.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.DeleteUser.OverrideDefault.Border.Color1 = System.Drawing.Color.Gray;
            this.DeleteUser.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DeleteUser.Size = new System.Drawing.Size(162, 42);
            this.DeleteUser.StateCommon.Back.Color1 = System.Drawing.Color.Black;
            this.DeleteUser.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.DeleteUser.StateCommon.Back.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.DeleteUser.StateCommon.Back.ColorAngle = 15F;
            this.DeleteUser.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear25;
            this.DeleteUser.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.DeleteUser.StateCommon.Border.Color1 = System.Drawing.Color.DimGray;
            this.DeleteUser.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DeleteUser.StateCommon.Border.Rounding = 2;
            this.DeleteUser.StateCommon.Border.Width = 2;
            this.DeleteUser.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.DeleteUser.StateCommon.Content.ShortText.Font = new System.Drawing.Font("FZYaoTi", 20F);
            this.DeleteUser.StateCommon.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAliasGridFit;
            this.DeleteUser.StateCommon.Content.ShortText.Prefix = ComponentFactory.Krypton.Toolkit.PaletteTextHotkeyPrefix.None;
            this.DeleteUser.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.DeleteUser.TabIndex = 3;
            this.DeleteUser.Values.Text = "Remove User";
            this.DeleteUser.Click += new System.EventHandler(this.DeleteUser_Click);
            // 
            // SetAdminButton
            // 
            this.SetAdminButton.AutoSize = true;
            this.SetAdminButton.Location = new System.Drawing.Point(22, 36);
            this.SetAdminButton.Name = "SetAdminButton";
            this.SetAdminButton.Size = new System.Drawing.Size(167, 42);
            this.SetAdminButton.StateCheckedNormal.Back.Color1 = System.Drawing.Color.Black;
            this.SetAdminButton.StateCheckedNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.SetAdminButton.StateCheckedPressed.Back.Color1 = System.Drawing.Color.White;
            this.SetAdminButton.StateCheckedPressed.Back.Color2 = System.Drawing.Color.Black;
            this.SetAdminButton.StateCommon.Back.Color1 = System.Drawing.Color.Black;
            this.SetAdminButton.StateCommon.Back.Color2 = System.Drawing.Color.Black;
            this.SetAdminButton.StateCommon.Back.ColorAngle = -180F;
            this.SetAdminButton.StateCommon.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.SetAdminButton.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.SetAdminButton.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.SetAdminButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SetAdminButton.StateCommon.Border.Rounding = 3;
            this.SetAdminButton.StateCommon.Border.Width = 2;
            this.SetAdminButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.SetAdminButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("FZYaoTi", 20F);
            this.SetAdminButton.TabIndex = 4;
            this.SetAdminButton.Values.Text = "Toggle Admin";
            this.SetAdminButton.Click += new System.EventHandler(this.SetAdminButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "User Permissions";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "User Management";
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1270, 720);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DataGridUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserManagement";
            this.Text = "UserManagement";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridUser)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView DataGridUser;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton SetAdminButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton DeleteUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}