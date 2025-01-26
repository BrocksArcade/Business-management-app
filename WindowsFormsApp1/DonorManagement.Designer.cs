namespace WindowsFormsApp1
{
    partial class DonorManagement
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
            this.DataGridDonor = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.nGODBDataSet = new WindowsFormsApp1.NGODBDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.InsertRow = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDonor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGODBDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridDonor
            // 
            this.DataGridDonor.AllowUserToAddRows = false;
            this.DataGridDonor.AllowUserToOrderColumns = true;
            this.DataGridDonor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridDonor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridDonor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridDonor.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.DataGridDonor.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.DataGridDonor.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.DataGridDonor.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.DataGridDonor.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.DataGridDonor.Location = new System.Drawing.Point(3, 21);
            this.DataGridDonor.Name = "DataGridDonor";
            this.DataGridDonor.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridDonor.Size = new System.Drawing.Size(1056, 664);
            this.DataGridDonor.StateCommon.Background.Color1 = System.Drawing.Color.Transparent;
            this.DataGridDonor.StateCommon.Background.Color2 = System.Drawing.Color.Transparent;
            this.DataGridDonor.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.DataGridDonor.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.DataGridDonor.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.Transparent;
            this.DataGridDonor.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.White;
            this.DataGridDonor.StateCommon.DataCell.Border.Color2 = System.Drawing.Color.White;
            this.DataGridDonor.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DataGridDonor.StateCommon.DataCell.Border.Rounding = 3;
            this.DataGridDonor.StateCommon.DataCell.Border.Width = 1;
            this.DataGridDonor.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.White;
            this.DataGridDonor.StateCommon.DataCell.Content.Font = new System.Drawing.Font("FZYaoTi", 15F);
            this.DataGridDonor.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.DataGridDonor.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.DataGridDonor.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.White;
            this.DataGridDonor.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.White;
            this.DataGridDonor.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DataGridDonor.StateCommon.HeaderColumn.Border.Width = 1;
            this.DataGridDonor.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.DataGridDonor.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.White;
            this.DataGridDonor.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("FZYaoTi", 20F);
            this.DataGridDonor.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.Transparent;
            this.DataGridDonor.StateCommon.HeaderRow.Back.Color2 = System.Drawing.Color.Transparent;
            this.DataGridDonor.StateCommon.HeaderRow.Border.Color1 = System.Drawing.Color.White;
            this.DataGridDonor.StateCommon.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DataGridDonor.StateCommon.HeaderRow.Border.Width = 3;
            this.DataGridDonor.StateCommon.HeaderRow.Content.Color1 = System.Drawing.Color.White;
            this.DataGridDonor.StateCommon.HeaderRow.Content.Color2 = System.Drawing.Color.White;
            this.DataGridDonor.StateCommon.HeaderRow.Content.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.DataGridDonor.StateCommon.HeaderRow.Content.Font = new System.Drawing.Font("FZYaoTi", 20F);
            this.DataGridDonor.StateCommon.HeaderRow.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.DataGridDonor.StateCommon.HeaderRow.Content.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.DataGridDonor.StatePressed.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.DataGridDonor.StatePressed.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.DataGridDonor.StatePressed.HeaderRow.Back.Color1 = System.Drawing.Color.SkyBlue;
            this.DataGridDonor.StatePressed.HeaderRow.Content.Color1 = System.Drawing.Color.Black;
            this.DataGridDonor.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.DataGridDonor.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.DataGridDonor.StateSelected.DataCell.Border.Color1 = System.Drawing.Color.SkyBlue;
            this.DataGridDonor.StateSelected.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DataGridDonor.StateSelected.DataCell.Border.Width = 4;
            this.DataGridDonor.StateSelected.DataCell.Content.Color1 = System.Drawing.Color.White;
            this.DataGridDonor.TabIndex = 0;
            // 
            // nGODBDataSet
            // 
            this.nGODBDataSet.DataSetName = "NGODBDataSet";
            this.nGODBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.InsertRow);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1046, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 720);
            this.panel1.TabIndex = 1;
            // 
            // InsertRow
            // 
            this.InsertRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.InsertRow.AutoSize = true;
            this.InsertRow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.InsertRow.Location = new System.Drawing.Point(78, 20);
            this.InsertRow.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.InsertRow.Name = "InsertRow";
            this.InsertRow.OverrideDefault.Back.Color1 = System.Drawing.Color.Black;
            this.InsertRow.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.InsertRow.OverrideDefault.Border.Color1 = System.Drawing.Color.Gray;
            this.InsertRow.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.InsertRow.Size = new System.Drawing.Size(144, 34);
            this.InsertRow.StateCommon.Back.Color1 = System.Drawing.Color.Black;
            this.InsertRow.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.InsertRow.StateCommon.Back.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.InsertRow.StateCommon.Back.ColorAngle = 15F;
            this.InsertRow.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear25;
            this.InsertRow.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.InsertRow.StateCommon.Border.Color1 = System.Drawing.Color.DimGray;
            this.InsertRow.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.InsertRow.StateCommon.Border.Rounding = 2;
            this.InsertRow.StateCommon.Border.Width = 2;
            this.InsertRow.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.InsertRow.StateCommon.Content.ShortText.Font = new System.Drawing.Font("FZYaoTi", 15F);
            this.InsertRow.StateCommon.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAliasGridFit;
            this.InsertRow.StateCommon.Content.ShortText.Prefix = ComponentFactory.Krypton.Toolkit.PaletteTextHotkeyPrefix.None;
            this.InsertRow.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.InsertRow.TabIndex = 3;
            this.InsertRow.Values.Text = "Insert New Row";
            this.InsertRow.Click += new System.EventHandler(this.InsertRow_Click);
            // 
            // DonorManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1270, 720);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DataGridDonor);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DonorManagement";
            this.Text = "DonorManagement";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDonor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGODBDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView DataGridDonor;
        private NGODBDataSet nGODBDataSet;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton InsertRow;
    }
}