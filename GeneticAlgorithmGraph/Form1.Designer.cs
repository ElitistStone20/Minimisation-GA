namespace GeneticAlgorithmGraph
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.GAChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ListBoxResults = new System.Windows.Forms.ListBox();
            this.ExecuteGA = new System.Windows.Forms.Button();
            this.txtGenerations = new System.Windows.Forms.TextBox();
            this.txtMutationProb = new System.Windows.Forms.TextBox();
            this.txtPopulationSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMutAlteration = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumGenes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GAChart)).BeginInit();
            this.SuspendLayout();
            // 
            // GAChart
            // 
            this.GAChart.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.GAChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.GAChart.Legends.Add(legend1);
            this.GAChart.Location = new System.Drawing.Point(43, 12);
            this.GAChart.Name = "GAChart";
            this.GAChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Average Fitness";
            series1.ShadowColor = System.Drawing.Color.Red;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Global Fitness";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Best Fitness";
            this.GAChart.Series.Add(series1);
            this.GAChart.Series.Add(series2);
            this.GAChart.Series.Add(series3);
            this.GAChart.Size = new System.Drawing.Size(708, 652);
            this.GAChart.TabIndex = 0;
            this.GAChart.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.White;
            title1.Name = "Genetic Algorithm";
            title1.Text = "Genetic Algorithm";
            this.GAChart.Titles.Add(title1);
            // 
            // ListBoxResults
            // 
            this.ListBoxResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxResults.FormattingEnabled = true;
            this.ListBoxResults.ItemHeight = 20;
            this.ListBoxResults.Location = new System.Drawing.Point(805, 79);
            this.ListBoxResults.Name = "ListBoxResults";
            this.ListBoxResults.Size = new System.Drawing.Size(905, 344);
            this.ListBoxResults.TabIndex = 1;
            // 
            // ExecuteGA
            // 
            this.ExecuteGA.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExecuteGA.Location = new System.Drawing.Point(1035, 709);
            this.ExecuteGA.Name = "ExecuteGA";
            this.ExecuteGA.Size = new System.Drawing.Size(135, 55);
            this.ExecuteGA.TabIndex = 2;
            this.ExecuteGA.Text = "Execute GA";
            this.ExecuteGA.UseVisualStyleBackColor = true;
            this.ExecuteGA.Click += new System.EventHandler(this.ExecuteGA_Click);
            // 
            // txtGenerations
            // 
            this.txtGenerations.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenerations.Location = new System.Drawing.Point(987, 460);
            this.txtGenerations.Name = "txtGenerations";
            this.txtGenerations.Size = new System.Drawing.Size(240, 29);
            this.txtGenerations.TabIndex = 3;
            // 
            // txtMutationProb
            // 
            this.txtMutationProb.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMutationProb.Location = new System.Drawing.Point(987, 509);
            this.txtMutationProb.Name = "txtMutationProb";
            this.txtMutationProb.Size = new System.Drawing.Size(240, 29);
            this.txtMutationProb.TabIndex = 4;
            // 
            // txtPopulationSize
            // 
            this.txtPopulationSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPopulationSize.Location = new System.Drawing.Point(987, 560);
            this.txtPopulationSize.Name = "txtPopulationSize";
            this.txtPopulationSize.Size = new System.Drawing.Size(240, 29);
            this.txtPopulationSize.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(830, 464);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Generations";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(757, 513);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mutation Probability";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(793, 562);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Population Size";
            // 
            // txtMutAlteration
            // 
            this.txtMutAlteration.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMutAlteration.Location = new System.Drawing.Point(987, 614);
            this.txtMutAlteration.Name = "txtMutAlteration";
            this.txtMutAlteration.Size = new System.Drawing.Size(240, 29);
            this.txtMutAlteration.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(768, 616);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mutation Alteration";
            // 
            // txtNumGenes
            // 
            this.txtNumGenes.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumGenes.Location = new System.Drawing.Point(987, 665);
            this.txtNumGenes.Name = "txtNumGenes";
            this.txtNumGenes.Size = new System.Drawing.Size(240, 29);
            this.txtNumGenes.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(784, 667);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Number of Genes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1753, 895);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNumGenes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMutAlteration);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPopulationSize);
            this.Controls.Add(this.txtMutationProb);
            this.Controls.Add(this.txtGenerations);
            this.Controls.Add(this.ExecuteGA);
            this.Controls.Add(this.ListBoxResults);
            this.Controls.Add(this.GAChart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GAChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart GAChart;
        private System.Windows.Forms.ListBox ListBoxResults;
        private System.Windows.Forms.Button ExecuteGA;
        private System.Windows.Forms.TextBox txtGenerations;
        private System.Windows.Forms.TextBox txtMutationProb;
        private System.Windows.Forms.TextBox txtPopulationSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMutAlteration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumGenes;
        private System.Windows.Forms.Label label5;
    }
}

