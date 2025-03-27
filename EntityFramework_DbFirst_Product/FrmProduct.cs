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
    public partial class FrmProduct: Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }

        EntityDbFirstEntities db = new EntityDbFirstEntities();

        void ProductList()
        {
            dataGridView1.DataSource = db.TblProduct.ToList();
        }


        private void btnList_Click(object sender, EventArgs e)
        {
            ProductList();
        }
    }
}
