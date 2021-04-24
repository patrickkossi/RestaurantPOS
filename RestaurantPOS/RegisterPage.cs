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
    public partial class RegisterPage : Form
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string ime = txtBxIme.Text;
            string prezime = txtBxPrezime.Text;
            string oib = txtBxOib.Text;
            string username = txtBxUsername.Text;
            string password = txtBxPassword.Text;

            //  using (var context = new restoranDBEntities())
            //{
            //  var query = from k in context.korisniks where k.korisnickoIme == username select k;
            // 
            //  }
            var context = new restoranDBEntities1();

            
                var query = from k in context.korisniks select k;
                int id = query.Count() + 1;
                korisnik korisnik = new korisnik() { korisnikID = id, ime = ime, korisnickoIme = username, prezime = prezime, oib = oib, lozinka = password, tipKorisnika = "konobar", racuns = null };
                context.korisniks.Add(korisnik);
            
                context.SaveChanges();
                Console.WriteLine(korisnik);
            var query2 = from k in context.korisniks where k.ime == ime select k;
            Console.WriteLine(query2.First().ime);

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
