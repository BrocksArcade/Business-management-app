namespace WindowsFormsApp1
{
    partial class FinancialManagement
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddExpense = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.AddIncome = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.kryptonDateTimePicker1 = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.ShowTable = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.InsertRow = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.DataGridFinance = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridFinance)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AddExpense);
            this.panel1.Controls.Add(this.AddIncome);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.kryptonDateTimePicker1);
            this.panel1.Controls.Add(this.ShowTable);
            this.panel1.Controls.Add(this.InsertRow);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 677);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 123);
            this.panel1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(483, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(273, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Add Expense";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(67, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Add Income";
            // 
            // AddExpense
            // 
            this.AddExpense.Location = new System.Drawing.Point(286, 89);
            this.AddExpense.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.AddExpense.Name = "AddExpense";
            this.AddExpense.Size = new System.Drawing.Size(161, 29);
            this.AddExpense.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.AddExpense.StateCommon.Content.Color1 = System.Drawing.Color.Lavender;
            this.AddExpense.StateCommon.Content.Font = new System.Drawing.Font("FZYaoTi", 15F, System.Drawing.FontStyle.Bold);
            this.AddExpense.TabIndex = 7;
            this.AddExpense.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AddExpense.ValueChanged += new System.EventHandler(this.AddExpense_ValueChanged);
            // 
            // AddIncome
            // 
            this.AddIncome.Location = new System.Drawing.Point(69, 89);
            this.AddIncome.Name = "AddIncome";
            this.AddIncome.Size = new System.Drawing.Size(161, 29);
            this.AddIncome.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.AddIncome.StateCommon.Content.Color1 = System.Drawing.Color.Lavender;
            this.AddIncome.StateCommon.Content.Font = new System.Drawing.Font("FZYaoTi", 15F, System.Drawing.FontStyle.Bold);
            this.AddIncome.TabIndex = 7;
            this.AddIncome.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AddIncome.ThousandsSeparator = true;
            this.AddIncome.ValueChanged += new System.EventHandler(this.AddIncome_ValueChanged);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("FZYaoTi", 15F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1298, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Table Fields";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kryptonDateTimePicker1
            // 
            this.kryptonDateTimePicker1.Location = new System.Drawing.Point(489, 90);
            this.kryptonDateTimePicker1.Name = "kryptonDateTimePicker1";
            this.kryptonDateTimePicker1.Size = new System.Drawing.Size(144, 28);
            this.kryptonDateTimePicker1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.kryptonDateTimePicker1.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.kryptonDateTimePicker1.StateCommon.Content.Font = new System.Drawing.Font("FZYaoTi", 15F);
            this.kryptonDateTimePicker1.TabIndex = 4;
            this.kryptonDateTimePicker1.ValueChanged += new System.EventHandler(this.kryptonDateTimePicker1_ValueChanged);
            // 
            // ShowTable
            // 
            this.ShowTable.AutoSize = true;
            this.ShowTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ShowTable.Location = new System.Drawing.Point(893, 81);
            this.ShowTable.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.ShowTable.Name = "ShowTable";
            this.ShowTable.OverrideDefault.Back.Color1 = System.Drawing.Color.Black;
            this.ShowTable.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.ShowTable.OverrideDefault.Border.Color1 = System.Drawing.Color.Gray;
            this.ShowTable.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ShowTable.Size = new System.Drawing.Size(107, 34);
            this.ShowTable.StateCommon.Back.Color1 = System.Drawing.Color.Black;
            this.ShowTable.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.ShowTable.StateCommon.Back.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.ShowTable.StateCommon.Back.ColorAngle = 15F;
            this.ShowTable.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear25;
            this.ShowTable.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.ShowTable.StateCommon.Border.Color1 = System.Drawing.Color.DimGray;
            this.ShowTable.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ShowTable.StateCommon.Border.Rounding = 2;
            this.ShowTable.StateCommon.Border.Width = 2;
            this.ShowTable.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.ShowTable.StateCommon.Content.ShortText.Font = new System.Drawing.Font("FZYaoTi", 15F);
            this.ShowTable.StateCommon.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAliasGridFit;
            this.ShowTable.StateCommon.Content.ShortText.Prefix = ComponentFactory.Krypton.Toolkit.PaletteTextHotkeyPrefix.None;
            this.ShowTable.StateCommon.Content.ShortText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.ShowTable.TabIndex = 3;
            this.ShowTable.Values.Text = "Show Stats";
            this.ShowTable.Click += new System.EventHandler(this.ShowTable_Click);
            // 
            // InsertRow
            // 
            this.InsertRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.InsertRow.AutoSize = true;
            this.InsertRow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.InsertRow.Location = new System.Drawing.Point(678, 81);
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
            // DataGridFinance
            // 
            this.DataGridFinance.AllowUserToAddRows = false;
            this.DataGridFinance.AllowUserToOrderColumns = true;
            this.DataGridFinance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DataGridFinance.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridFinance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridFinance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridFinance.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.DataGridFinance.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.DataGridFinance.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.DataGridFinance.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.DataGridFinance.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.DataGridFinance.Location = new System.Drawing.Point(0, 0);
            this.DataGridFinance.Name = "DataGridFinance";
            this.DataGridFinance.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridFinance.Size = new System.Drawing.Size(1300, 800);
            this.DataGridFinance.StateCommon.Background.Color1 = System.Drawing.Color.Transparent;
            this.DataGridFinance.StateCommon.Background.Color2 = System.Drawing.Color.Transparent;
            this.DataGridFinance.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.DataGridFinance.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.DataGridFinance.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.Transparent;
            this.DataGridFinance.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.White;
            this.DataGridFinance.StateCommon.DataCell.Border.Color2 = System.Drawing.Color.White;
            this.DataGridFinance.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DataGridFinance.StateCommon.DataCell.Border.Rounding = 3;
            this.DataGridFinance.StateCommon.DataCell.Border.Width = 1;
            this.DataGridFinance.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.White;
            this.DataGridFinance.StateCommon.DataCell.Content.Font = new System.Drawing.Font("FZYaoTi", 15F);
            this.DataGridFinance.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.DataGridFinance.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.DataGridFinance.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.White;
            this.DataGridFinance.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.White;
            this.DataGridFinance.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DataGridFinance.StateCommon.HeaderColumn.Border.Width = 1;
            this.DataGridFinance.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.DataGridFinance.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.White;
            this.DataGridFinance.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("FZYaoTi", 20F);
            this.DataGridFinance.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.Transparent;
            this.DataGridFinance.StateCommon.HeaderRow.Back.Color2 = System.Drawing.Color.Transparent;
            this.DataGridFinance.StateCommon.HeaderRow.Border.Color1 = System.Drawing.Color.White;
            this.DataGridFinance.StateCommon.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DataGridFinance.StateCommon.HeaderRow.Border.Width = 3;
            this.DataGridFinance.StateCommon.HeaderRow.Content.Color1 = System.Drawing.Color.White;
            this.DataGridFinance.StateCommon.HeaderRow.Content.Color2 = System.Drawing.Color.White;
            this.DataGridFinance.StateCommon.HeaderRow.Content.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.DataGridFinance.StateCommon.HeaderRow.Content.Font = new System.Drawing.Font("FZYaoTi", 20F);
            this.DataGridFinance.StateCommon.HeaderRow.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.DataGridFinance.StateCommon.HeaderRow.Content.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.DataGridFinance.StatePressed.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.DataGridFinance.StatePressed.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.DataGridFinance.StatePressed.HeaderRow.Back.Color1 = System.Drawing.Color.SkyBlue;
            this.DataGridFinance.StatePressed.HeaderRow.Content.Color1 = System.Drawing.Color.Black;
            this.DataGridFinance.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.DataGridFinance.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.DataGridFinance.StateSelected.DataCell.Border.Color1 = System.Drawing.Color.SkyBlue;
            this.DataGridFinance.StateSelected.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DataGridFinance.StateSelected.DataCell.Border.Width = 4;
            this.DataGridFinance.StateSelected.DataCell.Content.Color1 = System.Drawing.Color.White;
            this.DataGridFinance.TabIndex = 4;
            this.DataGridFinance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridFinance_CellContentClick);
            // 
            // FinancialManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1300, 800);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DataGridFinance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FinancialManagement";
            this.Text = "FinancialManagement";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridFinance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePicker1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton InsertRow;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView DataGridFinance;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown AddIncome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown AddExpense;
        private ComponentFactory.Krypton.Toolkit.KryptonButton ShowTable;
    }
}