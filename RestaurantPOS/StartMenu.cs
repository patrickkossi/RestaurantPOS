using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantPOS
{
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();
            loadData();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Form loginPage = new LoginPage();
            //loginPage.Show();
            //this.Hide();
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form registerPage = new RegisterPage();
            registerPage.ShowDialog();
            this.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void loadData()
        {

            using (var context = new restoranDBEntities1())
            {
                var query = from k in context.korisniks select k;
                dataGridView1.DataSource = query.ToList();
            }
        }
    }
}
