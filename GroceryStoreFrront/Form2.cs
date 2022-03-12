using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Store.Core;
using System.Data.SqlClient;

namespace GroceryStoreFrront
{
    public partial class Form2 : Form 
    {

        public Form2()
        {
            
            InitializeComponent();
        }

       

        private void Log_In_Btn_Click(object sender, EventArgs e)
        {
            
           if(Database.CheckUserValidation(Username_TextBox.Text, Password_TextBox.Text).Count == 2 && Username_TextBox.Text == "emeka")
            {
                this.Hide();
                Grocery_store store = new Grocery_store(new Store.Core.Store(), new User("m"));
                store.Show();
           }
           else if(Database.CheckUserValidation(Username_TextBox.Text, Password_TextBox.Text).Count == 2)
           {
                this.Hide();
                Grocery_store store = new Grocery_store(new Store.Core.Store(), new User("f"));
                store.Show();
                
           }
           else
           {
                MessageBox.Show("invalid input");
           }
        }

        private void Val_Text_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Username_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void password_Click(object sender, EventArgs e)
        {
            
        }
        //public static implicit operator Form2(Grocery_store v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
