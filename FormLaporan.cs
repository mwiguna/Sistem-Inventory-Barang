using DGVPrinterHelper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventaris
{
    public partial class FormLaporan : Form
    {

        public FormLaporan()
        {
            InitializeComponent();
            dataGridView.DataSource = UCPersediaan.data;
        }

        public void printDoc()
        {
            DGVPrinter printer = new DGVPrinter();

            printer.Title = "Laporan Persediaan Barang";
            printer.SubTitle = string.Format("{0}", DateTime.Now.ToString("dd/MM/yyyy"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;

            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;

            printer.Footer = "Sistem Inventaris Barang";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridView);
        }
    }
}