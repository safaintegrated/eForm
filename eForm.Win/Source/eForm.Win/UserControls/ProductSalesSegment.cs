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
    public partial class ProductSalesSegment : UserControl
    {
        public ProductSalesSegment()
        {
            InitializeComponent();
        }

        private void ProductSalesSegment_Load(object sender, EventArgs e)
        {
            this.chart1.Series.Clear();

            // Data arrays
            string[] seriesArray = { "Streamyx", "Unifi" };
            int[] pointsArray = { 900, 99 };

            // Set palette
            this.chart1.Palette = ChartColorPalette.EarthTones;

            // Set title
            this.chart1.Titles.Add("Products");

            // Add series.
            for (int i = 0; i < seriesArray.Length; i++)
            {
                Series series = this.chart1.Series.Add(seriesArray[i]);
                series.Points.Add(pointsArray[i]);
            }

            //string[] seriesArray = { "Unifi", "Streamyx" };
            //int[] pointsArray = { 1, 2 };

            //// Set palette.
            //this.chart1.Palette = ChartColorPalette.SeaGreen;

            //// Set title.
            //this.chart1.Titles.Add("Products");

            //// Add series.
            //for (int i = 0; i < seriesArray.Length; i++)
            //{
            //    // Add series.
            //    Series series = this.chart1.Series.Add(seriesArray[i]);

            //    // Add point.
            //    series.Points.Add(pointsArray[i]);
            //}
        }
    }
}
