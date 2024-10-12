using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Groomy
{
    public partial class AccountsInfo : Form
    {
        public AccountsInfo()
        {
            InitializeComponent();
        }

        private void groomyDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void AccountsInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groomyDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.groomyDataSet.Users);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
