using ExamSubject1.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ExamSubject1
{
    public partial class ChartForm : Form
    {
        public ChartForm(List<Registration> registrations, List<AccessPackage> accessPackages)
        {
            InitializeComponent();
            DrawChart(registrations, accessPackages);
        }

        private void DrawChart(List<Registration> registrations, List<AccessPackage> accessPackages)
        {
            var packageCounts = registrations
                .GroupBy(r => r.AccessPackageId)
                .Select(g => new
                {
                    AccessPackageId = g.Key,
                    Count = g.Count()
                })
                .Join(accessPackages, g => g.AccessPackageId, p => p.Id, (g, p) => new
                {
                    PackageName = p.Name,
                    g.Count
                })
                .ToList();

            chartRegistrations.Series.Clear();

            var series = new Series
            {
                Name = "Registrations",
                ChartType = SeriesChartType.Column
            };

            chartRegistrations.Series.Add(series);

            foreach (var package in packageCounts)
            {
                series.Points.AddXY(package.PackageName, package.Count);
            }

            chartRegistrations.ChartAreas[0].RecalculateAxesScale();
        }
    }
}
