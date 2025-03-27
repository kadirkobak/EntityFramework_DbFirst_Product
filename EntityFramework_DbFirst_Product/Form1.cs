using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework_DbFirst_Product
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        EntityDbFirstEntities db = new EntityDbFirstEntities();

        void CategoryList()
        {
            dataGridView1.DataSource = db.TblCategory.ToList();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            CategoryList();
        }
    }
}
