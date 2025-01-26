namespace WindowsFormsApp1
{
    partial class FinanceReport
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.nGODBDataSet = new WindowsFormsApp1.NGODBDataSet();
            this.nGODBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enxpensechart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.barchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGODBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGODBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enxpensechart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barchart)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.chart1.BorderlineWidth = 2;
            this.chart1.BorderSkin.BackColor = System.Drawing.Color.Black;
            this.chart1.BorderSkin.BorderWidth = 2;
            chartArea5.AxisX.Title = "Dates";
            chartArea5.AxisY.Title = "Income";
            chartArea5.BorderWidth = 3;
            chartArea5.Name = "ChartArea1";
            chartArea5.ShadowColor = System.Drawing.Color.Transparent;
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(63, 31);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.EmptyPointStyle.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            series6.LabelBackColor = System.Drawing.Color.Gray;
            series6.LabelBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series6.LabelForeColor = System.Drawing.Color.Red;
            series6.Legend = "Legend1";
            series6.Name = "Income";
            series6.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series6.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(637, 402);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(73, -3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = "Income Chart";
            // 
            // nGODBDataSet
            // 
            this.nGODBDataSet.DataSetName = "NGODBDataSet";
            this.nGODBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nGODBDataSetBindingSource
            // 
            this.nGODBDataSetBindingSource.DataSource = this.nGODBDataSet;
            this.nGODBDataSetBindingSource.Position = 0;
            // 
            // enxpensechart
            // 
            this.enxpensechart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.enxpensechart.BorderlineWidth = 2;
            this.enxpensechart.BorderSkin.BackColor = System.Drawing.Color.Black;
            this.enxpensechart.BorderSkin.BorderWidth = 2;
            chartArea6.AxisX.Title = "Dates";
            chartArea6.AxisX.ToolTip = "Dates of Expenses";
            chartArea6.AxisY.Title = "Expenses";
            chartArea6.BorderWidth = 3;
            chartArea6.Name = "ChartArea1";
            chartArea6.ShadowColor = System.Drawing.Color.Transparent;
            this.enxpensechart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.enxpensechart.Legends.Add(legend6);
            this.enxpensechart.Location = new System.Drawing.Point(856, 31);
            this.enxpensechart.Name = "enxpensechart";
            this.enxpensechart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.EmptyPointStyle.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            series7.LabelBackColor = System.Drawing.Color.Gray;
            series7.LabelBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series7.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            series7.Legend = "Legend1";
            series7.Name = "Expense";
            series7.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series7.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            this.enxpensechart.Series.Add(series7);
            this.enxpensechart.Size = new System.Drawing.Size(637, 402);
            this.enxpensechart.TabIndex = 0;
            this.enxpensechart.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(850, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Expense Chart";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(57, 476);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "Income Expense PIE chart";
            // 
            // pie
            // 
            chartArea7.Name = "ChartArea1";
            this.pie.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.pie.Legends.Add(legend7);
            this.pie.Location = new System.Drawing.Point(63, 526);
            this.pie.Name = "pie";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.pie.Series.Add(series8);
            this.pie.Size = new System.Drawing.Size(637, 415);
            this.pie.TabIndex = 10;
            this.pie.Text = "IncomeExpense";
            // 
            // barchart
            // 
            chartArea8.Name = "ChartArea1";
            this.barchart.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.barchart.Legends.Add(legend8);
            this.barchart.Location = new System.Drawing.Point(856, 526);
            this.barchart.Name = "barchart";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Series2";
            this.barchart.Series.Add(series9);
            this.barchart.Series.Add(series10);
            this.barchart.Size = new System.Drawing.Size(637, 415);
            this.barchart.TabIndex = 10;
            this.barchart.Text = "Bar chart";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(850, 476);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "Income Expense Notes";
            // 
            // FinanceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1434, 968);
            this.Controls.Add(this.barchart);
            this.Controls.Add(this.pie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.enxpensechart);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FinanceReport";
            this.Text = "FinanceReport";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGODBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGODBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enxpensechart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barchart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label4;
        private NGODBDataSet nGODBDataSet;
        private System.Windows.Forms.BindingSource nGODBDataSetBindingSource;
        private System.Windows.Forms.DataVisualization.Charting.Chart enxpensechart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart pie;
        private System.Windows.Forms.DataVisualization.Charting.Chart barchart;
        private System.Windows.Forms.Label label3;
    }
}