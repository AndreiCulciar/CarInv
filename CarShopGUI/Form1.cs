
using CarClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarShopGUI
{
    public partial class Form1 : Form
    {
        Store myStore = new Store();
        BindingSource carInventoryBindingSource = new BindingSource();
        BindingSource cartBindingSource=new BindingSource();
        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_make_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Create_a_car_Click(object sender, EventArgs e)
        {
            Car c = new Car(txt_make.Text, txt_Model.Text, decimal.Parse(txt_price.Text), txt_Color.Text, int.Parse(txt_Year.Text));
             txt_make.Text = null;
             txt_Model.Text = null;
            txt_price.Text = null;
            txt_Color.Text = null;
            txt_Year.Text = null;
            myStore.CarList.Add(c);
            carInventoryBindingSource.ResetBindings(false);
        }
        
        private void btn_Add_to_cart_Click(object sender, EventArgs e)
        {
            // get selected item from inv
            Car selected = (Car)lst_inventory.SelectedItem;
            myStore.ShopingList.Add(selected);
            //add to cart
            cartBindingSource.ResetBindings(false);
         
        }
        
        private void btn_Checkout_Click(object sender, EventArgs e)
        {
            decimal total = myStore.Checkout();
            lbl_total.Text = "$" + total.ToString();
            
            cartBindingSource.ResetBindings(false);
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carInventoryBindingSource.DataSource = myStore.CarList;

            cartBindingSource.DataSource = myStore.ShopingList;

            lst_inventory.DataSource = carInventoryBindingSource;
            lst_inventory.DisplayMember = ToString();

            lst_cart.DataSource = cartBindingSource;
            lst_cart.DisplayMember = ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Model_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txt_Year_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
