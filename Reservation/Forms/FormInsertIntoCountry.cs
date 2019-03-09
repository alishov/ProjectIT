using Reservation.Controlers;
using Reservation.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservation.Forms
{
    public partial class FormInsertIntoCountry : Form
    {
        public FormInsertIntoCountry()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertControler insert = new InsertControler();
            MessageApp message = new MessageApp();
            string countryName = textBox1.Text;
            bool isAdd = false;
            if (countryName!=string.Empty)
            {
                isAdd = insert.InsertIntoCoutries(countryName);
                if (isAdd == true)
                {
                    MessageBox.Show(message.MessageInsertCoutryTrue(countryName));
                }
                else
                {
                    MessageBox.Show(message.MessageInsertCoutryFalse(countryName));
                }
                textBox1.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Въведи име на държава!");
            }            
           
        }

        private void FormInsertIntoCountry_Load(object sender, EventArgs e)
        {
             
        }
    }
}
