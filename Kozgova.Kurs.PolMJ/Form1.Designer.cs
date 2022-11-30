
namespace Kozgova.Kurs.PolMJ
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button2 = new System.Windows.Forms.Button();
            this.numMut = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.numCross = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.numTurn = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.numPop = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.numGen = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numMut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCross)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTurn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(93, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 77);
            this.button2.TabIndex = 35;
            this.button2.Text = "Старт";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numMut
            // 
            this.numMut.DecimalPlaces = 2;
            this.numMut.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numMut.Location = new System.Drawing.Point(212, 186);
            this.numMut.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMut.Name = "numMut";
            this.numMut.Size = new System.Drawing.Size(86, 22);
            this.numMut.TabIndex = 45;
            this.numMut.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 16);
            this.label13.TabIndex = 36;
            this.label13.Text = "Число поколений";
            // 
            // numCross
            // 
            this.numCross.DecimalPlaces = 2;
            this.numCross.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numCross.Location = new System.Drawing.Point(212, 146);
            this.numCross.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCross.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numCross.Name = "numCross";
            this.numCross.Size = new System.Drawing.Size(86, 22);
            this.numCross.TabIndex = 44;
            this.numCross.Value = new decimal(new int[] {
            9,
            0,
            0,
            65536});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 16);
            this.label12.TabIndex = 37;
            this.label12.Text = "Размер популяции";
            // 
            // numTurn
            // 
            this.numTurn.Location = new System.Drawing.Point(212, 107);
            this.numTurn.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numTurn.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numTurn.Name = "numTurn";
            this.numTurn.Size = new System.Drawing.Size(86, 22);
            this.numTurn.TabIndex = 43;
            this.numTurn.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 16);
            this.label11.TabIndex = 38;
            this.label11.Text = "Размер турнира";
            // 
            // numPop
            // 
            this.numPop.Location = new System.Drawing.Point(212, 66);
            this.numPop.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numPop.Name = "numPop";
            this.numPop.Size = new System.Drawing.Size(86, 22);
            this.numPop.TabIndex = 42;
            this.numPop.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 16);
            this.label10.TabIndex = 39;
            this.label10.Text = "Вероятность скрещивания";
            // 
            // numGen
            // 
            this.numGen.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numGen.Location = new System.Drawing.Point(212, 25);
            this.numGen.Name = "numGen";
            this.numGen.Size = new System.Drawing.Size(86, 22);
            this.numGen.TabIndex = 41;
            this.numGen.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 16);
            this.label9.TabIndex = 40;
            this.label9.Text = "Вероятность мутации";
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(351, 25);
            this.chart1.Name = "chart1";
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.Fuchsia;
            series5.Legend = "Legend1";
            series5.LegendText = "Минимум в популяции";
            series5.Name = "Series1";
            series6.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series6.BorderWidth = 3;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series6.Legend = "Legend1";
            series6.LegendText = "Среднее в популяции";
            series6.Name = "Series2";
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(859, 441);
            this.chart1.TabIndex = 46;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 16);
            this.label1.TabIndex = 47;
            this.label1.Text = "Минимальное найденное решение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 16);
            this.label2.TabIndex = 48;
            this.label2.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 582);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.numMut);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.numCross);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.numTurn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.numPop);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numGen);
            this.Controls.Add(this.label9);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numMut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCross)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTurn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numMut;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numCross;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numTurn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numPop;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numGen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

