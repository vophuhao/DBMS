using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS
{
    public partial class Kho : Form
    {
        public Kho()
        {
            InitializeComponent();
        }
        khoclass kho=new khoclass();
        private void Kho_Load(object sender, EventArgs e)
        {
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = kho.LayTatCaSPKho();
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[3];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }
    }
}
