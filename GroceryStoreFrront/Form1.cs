using Store.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;

namespace GroceryStoreFrront
{
    public partial class Grocery_store : Form
    {
        public IStore _store;
        public IUser _user;
        public List<Product> CurrentCart { get; set; } = new List<Product>();
        public List<decimal> Totals = new List<decimal>();

        public  int ProdCount { get; set; }
        public Grocery_store(IStore store, IUser user)
        {   
            InitializeComponent();
            _store = store;
            _user = user;
            ProdCount = 0;
            Product_Count.Text = ProdCount.ToString();
            Prod_Disp_Screen.Text = PrintProds(Database.GetAllProduct());
            if (_user.UserRole == Role.Manager)
                panel2.Hide();


        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            ProdCount++;
            Product_Count.Text = ProdCount.ToString();
        }

        private void Product_textBox_TextChanged(object sender, EventArgs e)
        {   if (Product_textBox.Text.Length > 8)
            {
                ProdCount = 1;
                Product_Count.Text = ProdCount.ToString();
            }
            
        }

        private void Minus_Button_Click(object sender, EventArgs e)
        {   if (ProdCount > 0)
            ProdCount--;
            Product_Count.Text = ProdCount.ToString();
            Print_Status.Text = "";
        }

        //update product in the database
        private void Enter_Btn_Click(object sender, EventArgs e)
        {
            string productId = Product_textBox.Text.Trim();
            Product formerProduct = Database.GetOneProduct(productId);
            if (formerProduct.Quantity >= Convert.ToInt32(Product_Count.Text))
            {
                Product updatedProduct = Database.UpdateProduct(productId, Convert.ToInt32(Product_Count.Text), formerProduct.Quantity);
                AddProdToCurCart(formerProduct, Convert.ToInt32(Product_Count.Text));
            }
            else
            {
                MessageBox.Show("Currently low on supply..please reduce quantity");
                Product_textBox.Text = "";
            }
            Prod_Disp_Screen.Text = PrintProds(Database.GetAllProduct());
            if (formerProduct == null)
                return;

            RenderCart();
            
            //cart_tot_text.Text = "Cart Total: ₦ " + CurrentCart.Sum(prod => (prod.Quantity * prod.Price));
            Totals.Clear();


            Reset();
        }
        public void Reset()
        {
            ProdCount = 0;
            Product_Count.Text = ProdCount.ToString();
            Product_textBox.Text = "";
        }

        public string  PrintProds(List<Product> e)
        {
            var counter = 1;
            var outputString = "";
            foreach (var item in e)
            {
               outputString +=  counter +". "+"Name: "+item.Name +"\n" + "Id: " + item.Id.ToString() + "\n" + "Price: ₦" + item.Price + "\n" + "Qty: " + item.Quantity +"\n\n";
                counter++;
            }
            return outputString;
        }
        // adds new product to the database
        private void Add_New_Prod_Btn_Click(object sender, EventArgs e)
        {
            if (_user.UserRole == Role.Manager)
            {
                Product prod = new Product(New_ProdName_TextBox.Text, (int)quantity_input_box.Value) { Price = Convert.ToDecimal(New_ProdPrice_TextBox.Text) };
                Database.InsertIntoDatabase(prod);
                Prod_Disp_Screen.Text = PrintProds(Database.GetAllProduct());
                New_ProdName_TextBox.Text = "";
                New_ProdPrice_TextBox.Text = "";
                quantity_input_box.Value = 0;

                MessageBox.Show("Product Added Succesfully");

            }
            
        }

        // checks for manager or staff
        private void Grocery_store_Load(object sender, EventArgs e)
        {
            if (_user.UserRole == Role.Manager)
                Status.Text = "Signed in as Manager";
            else
                Status.Text = "Signed in as Staff";
        }

        //prints the reciept of purchase
        private void Print_Btn_Click(object sender, EventArgs e)
        {   if (Display_screen.Text.Trim() != "")
            {
                var fileUniqueName = Guid.NewGuid().ToString().Substring(0, 5);
                FileHandler.PrintFile(Display_screen.Text + "\n\n" + cart_tot_text.Text, fileUniqueName);
                Display_screen.Text = "";

                cart_tot_text.Text = "Cart Total: 0";
                MessageBox.Show($"A new File {fileUniqueName} Printed Successfully");
                CurrentCart.Clear();
            }  
        }

        //deletes a product from the database
        private void Remove_Btn_Click(object sender, EventArgs e)
        {
            string prodRemId = RemoveProd_TextBox.Text.Trim();
            
            MessageBox.Show(Database.DeleteProduct(prodRemId));
            Prod_Disp_Screen.Text = PrintProds(Database.GetAllProduct());

        }
        public void RenderCart()
        {
            
            Display_screen.Text = "";
            foreach (Product product in CurrentCart)
            {
                Display_screen.Text += $"{product.Name} \n @ ₦{product.Price} X {product.Quantity} \n Total Price : ₦{product.Price * product.Quantity}\n\n";
            }
            


        }
        public void AddProdToCurCart(Product pd, int value)
        {
            var prodToCheck = CurrentCart.Find(k => k.Id == pd.Id);

            if (prodToCheck == null)
            {
                //pd.Quantity = ProdCount;
                CurrentCart.Add(new Product(pd.Name, pd.Id.ToString(), pd.Price, value)); 
            }
                
            else
                prodToCheck.Quantity += ProdCount;
        }
        private void Cart_Clear_Btn_Click(object sender, EventArgs e)
        {
            if (Display_screen.Text.Trim() != "")
            {
                foreach (var prod in CurrentCart)
                {
                    var dInt = _store.Products.FindIndex((item) => item.Id == prod.Id);

                    _store.Products[dInt].Quantity += prod.Quantity;
                }

                Prod_Disp_Screen.Text = PrintProds(_store.Products);
                Display_screen.Text = "";
                CurrentCart.Clear();
                cart_tot_text.Text = "Cart Total: 0";
                MessageBox.Show("Cart Cleared");

            }
        }

        private void Available_Prod_Click(object sender, EventArgs e)
        {
            
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Product_Count_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void Prod_Disp_Screen_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_3(object sender, EventArgs e)
        {

        }

        private void New_ProdName_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void New_ProdPrice_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Val2_Label_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Status_Click(object sender, EventArgs e)
        {

        }

        private void Print_Status_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        
        private void RemoveProd_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }


}
