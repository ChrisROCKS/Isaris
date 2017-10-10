using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;
using Isaris.Entities;
using Isaris.BusinessLayer;
using CrystalDecisions.CrystalReports.Engine;
using System.Drawing.Printing;
using CrystalDecisions.Shared;

namespace Isaris
{
    public partial class FindInvoiceForm : MetroForm
    {
        private readonly InvoiceManager invoiceManager;

        public FindInvoiceForm(InvoiceManager invoiceManager)
        {
            this.invoiceManager = invoiceManager;

            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var invoiceReport = new Report.Reports.MiniInvoiceReport();
            chooseAction(invoiceReport);
        }

        private void BtnDeliveryProof_Click(object sender, EventArgs e)
        {
            var invoiceReport = new Report.Reports.DeliveryProofReport();
            chooseAction(invoiceReport);        
        }

        void chooseAction(ReportDocument report)
        {
            if (this.chkShowInvoice.Checked)
                showDocument(report);
            else
                printDocument(report);
        }

        private void showDocument(ReportDocument report)
        {
            var viewer = new ViewerForm();
            var invoiceData = this.invoiceManager.FindInvoiceReportById(int.Parse(txtn.Text));

            report.SetDataSource(invoiceData);

            viewer.reporte.ReportSource = report;
            viewer.Show();
        }

        private void printDocument(ReportDocument report)
        {
            var invoiceData = this.invoiceManager.FindInvoiceReportById(int.Parse(txtn.Text));
            report.SetDataSource(invoiceData);
            report.PrintToPrinter(new PrinterSettings(), new PageSettings(), false, new PrintLayoutSettings { Centered = false });
        }
    }
}
