namespace WindowsFormsApp1
{
    partial class BeneficiaryForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EmailTB = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.PHNOTB = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.SPTB = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.BNTB = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.BID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.InsertRow = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.DataGridBen = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridBen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.EmailTB);
            this.panel1.Controls.Add(this.PHNOTB);
            this.panel1.Controls.Add(this.SPTB);
            this.panel1.Controls.Add(this.BNTB);
            this.panel1.Controls.Add(this.BID);
            this.panel1.Controls.Add(this.InsertRow);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1007, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 720);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("FZYaoTi", 15F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Table Fields";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("FZYaoTi", 15F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(198, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("FZYaoTi", 15F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(170, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "PhoneNo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("FZYaoTi", 15F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(115, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "SupportProvided";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("FZYaoTi", 15F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(115, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "BeneficiaryName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("FZYaoTi", 15F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(143, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "BeneficiaryID";
            // 
            // EmailTB
            // 
            this.EmailTB.Location = new System.Drawing.Point(3, 398);
            this.EmailTB.MaxLength = 15;
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(248, 42);
            this.EmailTB.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(56)))));
            this.EmailTB.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.EmailTB.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.EmailTB.StateCommon.Border.Rounding = 15;
            this.EmailTB.StateCommon.Border.Width = 3;
            this.EmailTB.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.EmailTB.StateCommon.Content.Font = new System.Drawing.Font("FZYaoTi", 15F);
            this.EmailTB.TabIndex = 4;
            this.EmailTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PHNOTB
            // 
            this.PHNOTB.Location = new System.Drawing.Point(4, 324);
            this.PHNOTB.MaxLength = 10;
            this.PHNOTB.Name = "PHNOTB";
            this.PHNOTB.Size = new System.Drawing.Size(248, 42);
            this.PHNOTB.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(56)))));
            this.PHNOTB.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.PHNOTB.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.PHNOTB.StateCommon.Border.Rounding = 15;
            this.PHNOTB.StateCommon.Border.Width = 3;
            this.PHNOTB.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.PHNOTB.StateCommon.Content.Font = new System.Drawing.Font("FZYaoTi", 15F);
            this.PHNOTB.TabIndex = 4;
            this.PHNOTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PHNOTB.TextChanged += new System.EventHandler(this.PHNOTB_TextChanged);
            // 
            // SPTB
            // 
            this.SPTB.Location = new System.Drawing.Point(10, 247);
            this.SPTB.MaxLength = 15;
            this.SPTB.Name = "SPTB";
            this.SPTB.Size = new System.Drawing.Size(248, 42);
            this.SPTB.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(56)))));
            this.SPTB.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.SPTB.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SPTB.StateCommon.Border.Rounding = 15;
            this.SPTB.StateCommon.Border.Width = 3;
            this.SPTB.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.SPTB.StateCommon.Content.Font = new System.Drawing.Font("FZYaoTi", 15F);
            this.SPTB.TabIndex = 4;
            this.SPTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BNTB
            // 
            this.BNTB.Location = new System.Drawing.Point(10, 169);
            this.BNTB.MaxLength = 15;
            this.BNTB.Name = "BNTB";
            this.BNTB.Size = new System.Drawing.Size(248, 42);
            this.BNTB.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(56)))));
            this.BNTB.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.BNTB.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BNTB.StateCommon.Border.Rounding = 15;
            this.BNTB.StateCommon.Border.Width = 3;
            this.BNTB.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.BNTB.StateCommon.Content.Font = new System.Drawing.Font("FZYaoTi", 15F);
            this.BNTB.TabIndex = 4;
            this.BNTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BID
            // 
            this.BID.Location = new System.Drawing.Point(13, 89);
            this.BID.MaxLength = 7;
            this.BID.Name = "BID";
            this.BID.Size = new System.Drawing.Size(248, 42);
            this.BID.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(56)))));
            this.BID.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.BID.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BID.StateCommon.Border.Rounding = 15;
            this.BID.StateCommon.Border.Width = 3;
            this.BID.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.BID.StateCommon.Content.Font = new System.Drawing.Font("FZYaoTi", 15F);
            this.BID.TabIndex = 4;
            this.BID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InsertRow
            // 
            this.InsertRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.InsertRow.AutoSize = true;
            this.InsertRow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.InsertRow.Location = new System.Drawing.Point(148, 467);
            this.InsertRow.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.InsertRow.Name = "InsertRow";
            this.InsertRow.OverrideDefault.Back.Color1 = System.Drawing.Color.Black;
            this.InsertRow.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.InsertRow.OverrideDefault.Border.Color1 = System.Drawing.Color.Gray;
            this.InsertRow.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.InsertRow.Size = new System.Drawing.Size(104, 34);
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
            this.InsertRow.Values.Text = "Insert Row";
            this.InsertRow.Click += new System.EventHandler(this.InsertRow_Click);
            // 
            // DataGridBen
            // 
            this.DataGridBen.AllowUserToAddRows = false;
            this.DataGridBen.AllowUserToOrderColumns = true;
            this.DataGridBen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridBen.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridBen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridBen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridBen.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.DataGridBen.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.DataGridBen.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.DataGridBen.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.DataGridBen.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.DataGridBen.Location = new System.Drawing.Point(0, 0);
            this.DataGridBen.Name = "DataGridBen";
            this.DataGridBen.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridBen.ShowEditingIcon = false;
            this.DataGridBen.Size = new System.Drawing.Size(1007, 720);
            this.DataGridBen.StateCommon.Background.Color1 = System.Drawing.Color.Transparent;
            this.DataGridBen.StateCommon.Background.Color2 = System.Drawing.Color.Transparent;
            this.DataGridBen.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.DataGridBen.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.DataGridBen.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.Transparent;
            this.DataGridBen.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.White;
            this.DataGridBen.StateCommon.DataCell.Border.Color2 = System.Drawing.Color.White;
            this.DataGridBen.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DataGridBen.StateCommon.DataCell.Border.Rounding = 3;
            this.DataGridBen.StateCommon.DataCell.Border.Width = 1;
            this.DataGridBen.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.White;
            this.DataGridBen.StateCommon.DataCell.Content.Font = new System.Drawing.Font("FZYaoTi", 15F);
            this.DataGridBen.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.DataGridBen.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.DataGridBen.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.White;
            this.DataGridBen.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.White;
            this.DataGridBen.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DataGridBen.StateCommon.HeaderColumn.Border.Width = 1;
            this.DataGridBen.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.DataGridBen.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.White;
            this.DataGridBen.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("FZYaoTi", 20F);
            this.DataGridBen.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.Transparent;
            this.DataGridBen.StateCommon.HeaderRow.Back.Color2 = System.Drawing.Color.Transparent;
            this.DataGridBen.StateCommon.HeaderRow.Border.Color1 = System.Drawing.Color.White;
            this.DataGridBen.StateCommon.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DataGridBen.StateCommon.HeaderRow.Border.Width = 3;
            this.DataGridBen.StateCommon.HeaderRow.Content.Color1 = System.Drawing.Color.White;
            this.DataGridBen.StateCommon.HeaderRow.Content.Color2 = System.Drawing.Color.White;
            this.DataGridBen.StateCommon.HeaderRow.Content.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.DataGridBen.StateCommon.HeaderRow.Content.Font = new System.Drawing.Font("FZYaoTi", 20F);
            this.DataGridBen.StateCommon.HeaderRow.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.DataGridBen.StateCommon.HeaderRow.Content.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.DataGridBen.StatePressed.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.DataGridBen.StatePressed.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.DataGridBen.StatePressed.HeaderRow.Back.Color1 = System.Drawing.Color.SkyBlue;
            this.DataGridBen.StatePressed.HeaderRow.Content.Color1 = System.Drawing.Color.Black;
            this.DataGridBen.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.DataGridBen.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.DataGridBen.StateSelected.DataCell.Border.Color1 = System.Drawing.Color.SkyBlue;
            this.DataGridBen.StateSelected.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DataGridBen.StateSelected.DataCell.Border.Width = 4;
            this.DataGridBen.StateSelected.DataCell.Content.Color1 = System.Drawing.Color.White;
            this.DataGridBen.TabIndex = 3;
            // 
            // BeneficiaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1270, 720);
            this.ControlBox = false;
            this.Controls.Add(this.DataGridBen);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BeneficiaryForm";
            this.Tag = "Ben";
            this.Text = "BeneficiaryForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridBen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView DataGridBen;
        private ComponentFactory.Krypton.Toolkit.KryptonButton InsertRow;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox BID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox EmailTB;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox PHNOTB;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox SPTB;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox BNTB;
    }
}