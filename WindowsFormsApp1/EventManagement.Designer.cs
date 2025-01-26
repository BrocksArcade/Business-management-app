namespace WindowsFormsApp1
{
    partial class EventManagement
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonDateTimePicker1 = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.InsertRow = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.DataGridEvent = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEvent)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.kryptonDateTimePicker1);
            this.panel1.Controls.Add(this.InsertRow);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 579);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1284, 102);
            this.panel1.TabIndex = 3;
            // 
            // kryptonDateTimePicker1
            // 
            this.kryptonDateTimePicker1.Location = new System.Drawing.Point(25, 65);
            this.kryptonDateTimePicker1.Name = "kryptonDateTimePicker1";
            this.kryptonDateTimePicker1.Size = new System.Drawing.Size(144, 28);
            this.kryptonDateTimePicker1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.kryptonDateTimePicker1.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.kryptonDateTimePicker1.StateCommon.Content.Font = new System.Drawing.Font("FZYaoTi", 15F);
            this.kryptonDateTimePicker1.TabIndex = 4;
            this.kryptonDateTimePicker1.ValueChanged += new System.EventHandler(this.kryptonDateTimePicker1_ValueChanged);
            // 
            // InsertRow
            // 
            this.InsertRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.InsertRow.AutoSize = true;
            this.InsertRow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.InsertRow.Location = new System.Drawing.Point(192, 64);
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
            // DataGridEvent
            // 
            this.DataGridEvent.AllowUserToAddRows = false;
            this.DataGridEvent.AllowUserToOrderColumns = true;
            this.DataGridEvent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DataGridEvent.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridEvent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridEvent.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.DataGridEvent.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.DataGridEvent.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.DataGridEvent.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.DataGridEvent.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.DataGridEvent.Location = new System.Drawing.Point(0, 0);
            this.DataGridEvent.Name = "DataGridEvent";
            this.DataGridEvent.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridEvent.Size = new System.Drawing.Size(1284, 681);
            this.DataGridEvent.StateCommon.Background.Color1 = System.Drawing.Color.Transparent;
            this.DataGridEvent.StateCommon.Background.Color2 = System.Drawing.Color.Transparent;
            this.DataGridEvent.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.DataGridEvent.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.DataGridEvent.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.Transparent;
            this.DataGridEvent.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.White;
            this.DataGridEvent.StateCommon.DataCell.Border.Color2 = System.Drawing.Color.White;
            this.DataGridEvent.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DataGridEvent.StateCommon.DataCell.Border.Rounding = 3;
            this.DataGridEvent.StateCommon.DataCell.Border.Width = 1;
            this.DataGridEvent.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.White;
            this.DataGridEvent.StateCommon.DataCell.Content.Font = new System.Drawing.Font("FZYaoTi", 15F);
            this.DataGridEvent.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.DataGridEvent.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.DataGridEvent.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.White;
            this.DataGridEvent.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.White;
            this.DataGridEvent.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DataGridEvent.StateCommon.HeaderColumn.Border.Width = 1;
            this.DataGridEvent.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.DataGridEvent.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.White;
            this.DataGridEvent.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("FZYaoTi", 20F);
            this.DataGridEvent.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.Transparent;
            this.DataGridEvent.StateCommon.HeaderRow.Back.Color2 = System.Drawing.Color.Transparent;
            this.DataGridEvent.StateCommon.HeaderRow.Border.Color1 = System.Drawing.Color.White;
            this.DataGridEvent.StateCommon.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DataGridEvent.StateCommon.HeaderRow.Border.Width = 3;
            this.DataGridEvent.StateCommon.HeaderRow.Content.Color1 = System.Drawing.Color.White;
            this.DataGridEvent.StateCommon.HeaderRow.Content.Color2 = System.Drawing.Color.White;
            this.DataGridEvent.StateCommon.HeaderRow.Content.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.DataGridEvent.StateCommon.HeaderRow.Content.Font = new System.Drawing.Font("FZYaoTi", 20F);
            this.DataGridEvent.StateCommon.HeaderRow.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.DataGridEvent.StateCommon.HeaderRow.Content.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.DataGridEvent.StatePressed.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.DataGridEvent.StatePressed.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.DataGridEvent.StatePressed.HeaderRow.Back.Color1 = System.Drawing.Color.SkyBlue;
            this.DataGridEvent.StatePressed.HeaderRow.Content.Color1 = System.Drawing.Color.Black;
            this.DataGridEvent.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.DataGridEvent.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.DataGridEvent.StateSelected.DataCell.Border.Color1 = System.Drawing.Color.SkyBlue;
            this.DataGridEvent.StateSelected.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DataGridEvent.StateSelected.DataCell.Border.Width = 4;
            this.DataGridEvent.StateSelected.DataCell.Content.Color1 = System.Drawing.Color.White;
            this.DataGridEvent.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(19, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = "Date";
            // 
            // EventManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1284, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DataGridEvent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EventManagement";
            this.Text = "EventManagement";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEvent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton InsertRow;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView DataGridEvent;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePicker1;
        private System.Windows.Forms.Label label4;
    }
}