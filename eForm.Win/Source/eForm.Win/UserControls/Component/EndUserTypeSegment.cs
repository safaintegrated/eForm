using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace eForm.Win.UserControls
{
    public partial class EndUserTypeSegment : UserControl
    {
        public EndUserTypeSegment()
        {
            InitializeComponent();
        }

        private void EndUserTypeSegment_Load(object sender, EventArgs e)
        {
            this.chart1.Series.Clear();

            // Data arrays
            string[] seriesArray = { "Business", "Residentials" };
            int[] pointsArray = { 400, 599 };

            // Set palette
            this.chart1.Palette = ChartColorPalette.EarthTones;

            // Set title
            this.chart1.Titles.Add("Products");

            // Add series.
            for (int i = 0; i < seriesArray.Length; i++)
            {
                Series series = this.chart1.Series.Add(seriesArray[i]);
                //series.Name = "Business";
                series.ChartType = SeriesChartType.Pie;
                series.Points.Add(pointsArray[i]);
            }
        }
    }
}
