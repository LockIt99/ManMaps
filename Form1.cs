using System;
using System.Text;
using System.Windows.Forms;

namespace ManMaps
{
    public partial class frm : Form
    {
        public frm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string street = txtBoxstrt.Text;
            string city = txtBoxCity.Text;  
            string state = txtBoxState.Text;
            string pinZip = txtBoxPin.Text;
            StringBuilder query = new StringBuilder();
            try
            {
                query.Append("https://maps.google.com/maps?q=");
                if (!string.IsNullOrEmpty(street))
                    query.Append(street + ",+");
                if (!string.IsNullOrEmpty(city))
                    query.Append(city + ",+");
                if (!string.IsNullOrEmpty(state))
                    query.Append(state + ",+");
                if (!string.IsNullOrEmpty(pinZip))
                    query.Append(pinZip);
                webbr.Navigate(query.ToString());
            }
            catch(Exception ex) 
            { MessageBox.Show("Error -" + ex.Message); }
        }
    }
}