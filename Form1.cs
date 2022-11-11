using FastReport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fast_report_demo_issue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Report report = new Report();
        private bool lockSelect = false;

        private void Form1_Load(object sender, EventArgs e)
        {

            string report_name_1 = "report 1.frx";
            string report_name_2 = "report 2.frx";
            string report_name_3 = "report 3.frx";

            this.treeView1.Nodes.Add(report_name_1);
            this.treeView1.Nodes.Add(report_name_2);
            this.treeView1.Nodes.Add(report_name_3);
           
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

            try
            {
                report.Load(this.treeView1.SelectedNode.Text);
                this.designerControl1.Report = report;
                this.designerControl1.RefreshLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
