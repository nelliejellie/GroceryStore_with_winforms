namespace GroceryStoreFrront
{
    partial class Grocery_store
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ProductText = new System.Windows.Forms.Label();
            this.Product_textBox = new System.Windows.Forms.TextBox();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Minus_Button = new System.Windows.Forms.Button();
            this.Display_screen = new System.Windows.Forms.RichTextBox();
            this.Print_Btn = new System.Windows.Forms.Button();
            this.Enter_Btn = new System.Windows.Forms.Button();
            this.Product_Count = new System.Windows.Forms.Label();
            this.Available_Prod = new System.Windows.Forms.Label();
            this.Prod_Disp_Screen = new System.Windows.Forms.RichTextBox();
            this.Add_New_Prod_Btn = new System.Windows.Forms.Button();
            this.New_ProdName_TextBox = new System.Windows.Forms.TextBox();
            this.New_ProdPrice_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Val2_Label = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RemoveProd_TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Remove_Btn = new System.Windows.Forms.Button();
            this.quantity_input_box = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Cart_Clear_Btn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Print_Status = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cart_tot_text = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_input_box)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(316, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Check Out";
            // 
            // ProductText
            // 
            this.ProductText.AutoSize = true;
            this.ProductText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductText.ForeColor = System.Drawing.Color.Maroon;
            this.ProductText.Location = new System.Drawing.Point(39, 92);
            this.ProductText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProductText.Name = "ProductText";
            this.ProductText.Size = new System.Drawing.Size(138, 17);
            this.ProductText.TabIndex = 1;
            this.ProductText.Text = "Enter Product ID :";
            this.ProductText.Click += new System.EventHandler(this.label2_Click);
            // 
            // Product_textBox
            // 
            this.Product_textBox.Location = new System.Drawing.Point(43, 108);
            this.Product_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Product_textBox.Name = "Product_textBox";
            this.Product_textBox.Size = new System.Drawing.Size(239, 22);
            this.Product_textBox.TabIndex = 2;
            this.Product_textBox.TextChanged += new System.EventHandler(this.Product_textBox_TextChanged);
            // 
            // Add_Button
            // 
            this.Add_Button.BackColor = System.Drawing.Color.Salmon;
            this.Add_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Button.ForeColor = System.Drawing.SystemColors.Info;
            this.Add_Button.Location = new System.Drawing.Point(43, 142);
            this.Add_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(32, 28);
            this.Add_Button.TabIndex = 3;
            this.Add_Button.Text = "+";
            this.Add_Button.UseVisualStyleBackColor = false;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Minus_Button
            // 
            this.Minus_Button.BackColor = System.Drawing.Color.Salmon;
            this.Minus_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minus_Button.ForeColor = System.Drawing.SystemColors.Info;
            this.Minus_Button.Location = new System.Drawing.Point(84, 142);
            this.Minus_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Minus_Button.Name = "Minus_Button";
            this.Minus_Button.Size = new System.Drawing.Size(36, 28);
            this.Minus_Button.TabIndex = 4;
            this.Minus_Button.Text = "-";
            this.Minus_Button.UseVisualStyleBackColor = false;
            this.Minus_Button.Click += new System.EventHandler(this.Minus_Button_Click);
            // 
            // Display_screen
            // 
            this.Display_screen.Location = new System.Drawing.Point(415, 206);
            this.Display_screen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Display_screen.Name = "Display_screen";
            this.Display_screen.Size = new System.Drawing.Size(364, 314);
            this.Display_screen.TabIndex = 5;
            this.Display_screen.Text = "";
            this.Display_screen.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Print_Btn
            // 
            this.Print_Btn.BackColor = System.Drawing.Color.Salmon;
            this.Print_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Print_Btn.ForeColor = System.Drawing.SystemColors.Info;
            this.Print_Btn.Location = new System.Drawing.Point(680, 528);
            this.Print_Btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Print_Btn.Name = "Print_Btn";
            this.Print_Btn.Size = new System.Drawing.Size(100, 28);
            this.Print_Btn.TabIndex = 6;
            this.Print_Btn.Text = "Print";
            this.Print_Btn.UseVisualStyleBackColor = false;
            this.Print_Btn.Click += new System.EventHandler(this.Print_Btn_Click);
            // 
            // Enter_Btn
            // 
            this.Enter_Btn.BackColor = System.Drawing.Color.Salmon;
            this.Enter_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enter_Btn.ForeColor = System.Drawing.SystemColors.Info;
            this.Enter_Btn.Location = new System.Drawing.Point(220, 140);
            this.Enter_Btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Enter_Btn.Name = "Enter_Btn";
            this.Enter_Btn.Size = new System.Drawing.Size(61, 28);
            this.Enter_Btn.TabIndex = 7;
            this.Enter_Btn.Text = "Enter";
            this.Enter_Btn.UseVisualStyleBackColor = false;
            this.Enter_Btn.Click += new System.EventHandler(this.Enter_Btn_Click);
            // 
            // Product_Count
            // 
            this.Product_Count.AutoSize = true;
            this.Product_Count.Location = new System.Drawing.Point(165, 148);
            this.Product_Count.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Product_Count.Name = "Product_Count";
            this.Product_Count.Size = new System.Drawing.Size(16, 17);
            this.Product_Count.TabIndex = 8;
            this.Product_Count.Text = "0";
            this.Product_Count.Click += new System.EventHandler(this.Product_Count_Click);
            // 
            // Available_Prod
            // 
            this.Available_Prod.AutoSize = true;
            this.Available_Prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Available_Prod.ForeColor = System.Drawing.Color.Maroon;
            this.Available_Prod.Location = new System.Drawing.Point(39, 187);
            this.Available_Prod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Available_Prod.MaximumSize = new System.Drawing.Size(0, 123);
            this.Available_Prod.Name = "Available_Prod";
            this.Available_Prod.Size = new System.Drawing.Size(117, 17);
            this.Available_Prod.TabIndex = 9;
            this.Available_Prod.Text = "Available_Prod";
            this.Available_Prod.Click += new System.EventHandler(this.Available_Prod_Click);
            // 
            // Prod_Disp_Screen
            // 
            this.Prod_Disp_Screen.Location = new System.Drawing.Point(43, 206);
            this.Prod_Disp_Screen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Prod_Disp_Screen.Name = "Prod_Disp_Screen";
            this.Prod_Disp_Screen.Size = new System.Drawing.Size(339, 166);
            this.Prod_Disp_Screen.TabIndex = 10;
            this.Prod_Disp_Screen.Text = "";
            this.Prod_Disp_Screen.TextChanged += new System.EventHandler(this.Prod_Disp_Screen_TextChanged);
            // 
            // Add_New_Prod_Btn
            // 
            this.Add_New_Prod_Btn.BackColor = System.Drawing.Color.Maroon;
            this.Add_New_Prod_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_New_Prod_Btn.ForeColor = System.Drawing.SystemColors.Info;
            this.Add_New_Prod_Btn.Location = new System.Drawing.Point(227, 430);
            this.Add_New_Prod_Btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Add_New_Prod_Btn.Name = "Add_New_Prod_Btn";
            this.Add_New_Prod_Btn.Size = new System.Drawing.Size(155, 28);
            this.Add_New_Prod_Btn.TabIndex = 11;
            this.Add_New_Prod_Btn.Text = "Add New Product";
            this.Add_New_Prod_Btn.UseVisualStyleBackColor = false;
            this.Add_New_Prod_Btn.Click += new System.EventHandler(this.Add_New_Prod_Btn_Click);
            // 
            // New_ProdName_TextBox
            // 
            this.New_ProdName_TextBox.Location = new System.Drawing.Point(96, 398);
            this.New_ProdName_TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.New_ProdName_TextBox.Name = "New_ProdName_TextBox";
            this.New_ProdName_TextBox.Size = new System.Drawing.Size(121, 22);
            this.New_ProdName_TextBox.TabIndex = 12;
            this.New_ProdName_TextBox.TextChanged += new System.EventHandler(this.New_ProdName_TextBox_TextChanged);
            // 
            // New_ProdPrice_TextBox
            // 
            this.New_ProdPrice_TextBox.Location = new System.Drawing.Point(285, 398);
            this.New_ProdPrice_TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.New_ProdPrice_TextBox.Name = "New_ProdPrice_TextBox";
            this.New_ProdPrice_TextBox.Size = new System.Drawing.Size(93, 22);
            this.New_ProdPrice_TextBox.TabIndex = 13;
            this.New_ProdPrice_TextBox.TextChanged += new System.EventHandler(this.New_ProdPrice_TextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 401);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click_3);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(227, 401);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Price";
            // 
            // Val2_Label
            // 
            this.Val2_Label.AutoSize = true;
            this.Val2_Label.ForeColor = System.Drawing.Color.Red;
            this.Val2_Label.Location = new System.Drawing.Point(88, 441);
            this.Val2_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Val2_Label.Name = "Val2_Label";
            this.Val2_Label.Size = new System.Drawing.Size(0, 17);
            this.Val2_Label.TabIndex = 16;
            this.Val2_Label.Click += new System.EventHandler(this.Val2_Label_Click);
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.ForeColor = System.Drawing.Color.Green;
            this.Status.Location = new System.Drawing.Point(596, 89);
            this.Status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(0, 17);
            this.Status.TabIndex = 17;
            this.Status.Click += new System.EventHandler(this.Status_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(39, 377);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Add New :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Salmon;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 78);
            this.panel1.TabIndex = 20;
            // 
            // RemoveProd_TextBox
            // 
            this.RemoveProd_TextBox.Location = new System.Drawing.Point(133, 492);
            this.RemoveProd_TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RemoveProd_TextBox.Name = "RemoveProd_TextBox";
            this.RemoveProd_TextBox.Size = new System.Drawing.Size(245, 22);
            this.RemoveProd_TextBox.TabIndex = 21;
            this.RemoveProd_TextBox.TextChanged += new System.EventHandler(this.RemoveProd_TextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 496);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Product ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(40, 471);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Remove Product";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Remove_Btn
            // 
            this.Remove_Btn.BackColor = System.Drawing.Color.Maroon;
            this.Remove_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Remove_Btn.ForeColor = System.Drawing.SystemColors.Info;
            this.Remove_Btn.Location = new System.Drawing.Point(283, 528);
            this.Remove_Btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Remove_Btn.Name = "Remove_Btn";
            this.Remove_Btn.Size = new System.Drawing.Size(100, 28);
            this.Remove_Btn.TabIndex = 24;
            this.Remove_Btn.Text = "Remove";
            this.Remove_Btn.UseVisualStyleBackColor = false;
            this.Remove_Btn.Click += new System.EventHandler(this.Remove_Btn_Click);
            // 
            // quantity_input_box
            // 
            this.quantity_input_box.Location = new System.Drawing.Point(93, 434);
            this.quantity_input_box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.quantity_input_box.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.quantity_input_box.Name = "quantity_input_box";
            this.quantity_input_box.Size = new System.Drawing.Size(123, 22);
            this.quantity_input_box.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 439);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "Qty";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Salmon;
            this.panel3.Controls.Add(this.Cart_Clear_Btn);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(415, 159);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(365, 37);
            this.panel3.TabIndex = 28;
            // 
            // Cart_Clear_Btn
            // 
            this.Cart_Clear_Btn.BackColor = System.Drawing.Color.White;
            this.Cart_Clear_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cart_Clear_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cart_Clear_Btn.ForeColor = System.Drawing.Color.Maroon;
            this.Cart_Clear_Btn.Location = new System.Drawing.Point(285, 5);
            this.Cart_Clear_Btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cart_Clear_Btn.Name = "Cart_Clear_Btn";
            this.Cart_Clear_Btn.Size = new System.Drawing.Size(68, 27);
            this.Cart_Clear_Btn.TabIndex = 1;
            this.Cart_Clear_Btn.Text = "Clear";
            this.Cart_Clear_Btn.UseVisualStyleBackColor = false;
            this.Cart_Clear_Btn.Click += new System.EventHandler(this.Cart_Clear_Btn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(19, 5);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 31);
            this.label8.TabIndex = 0;
            this.label8.Text = "Cart";
            // 
            // Print_Status
            // 
            this.Print_Status.AutoSize = true;
            this.Print_Status.ForeColor = System.Drawing.Color.Green;
            this.Print_Status.Location = new System.Drawing.Point(676, 567);
            this.Print_Status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Print_Status.Name = "Print_Status";
            this.Print_Status.Size = new System.Drawing.Size(0, 17);
            this.Print_Status.TabIndex = 19;
            this.Print_Status.Click += new System.EventHandler(this.Print_Status_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Salmon;
            this.panel4.Controls.Add(this.cart_tot_text);
            this.panel4.Location = new System.Drawing.Point(415, 528);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(232, 28);
            this.panel4.TabIndex = 29;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // cart_tot_text
            // 
            this.cart_tot_text.AutoSize = true;
            this.cart_tot_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cart_tot_text.ForeColor = System.Drawing.Color.White;
            this.cart_tot_text.Location = new System.Drawing.Point(4, 5);
            this.cart_tot_text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cart_tot_text.Name = "cart_tot_text";
            this.cart_tot_text.Size = new System.Drawing.Size(115, 20);
            this.cart_tot_text.TabIndex = 0;
            this.cart_tot_text.Text = "Cart Total: 0";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(41, 377);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(341, 203);
            this.panel2.TabIndex = 30;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // Grocery_store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(819, 594);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.quantity_input_box);
            this.Controls.Add(this.Remove_Btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RemoveProd_TextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Print_Status);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Val2_Label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.New_ProdPrice_TextBox);
            this.Controls.Add(this.New_ProdName_TextBox);
            this.Controls.Add(this.Add_New_Prod_Btn);
            this.Controls.Add(this.Prod_Disp_Screen);
            this.Controls.Add(this.Available_Prod);
            this.Controls.Add(this.Product_Count);
            this.Controls.Add(this.Enter_Btn);
            this.Controls.Add(this.Print_Btn);
            this.Controls.Add(this.Display_screen);
            this.Controls.Add(this.Minus_Button);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.Product_textBox);
            this.Controls.Add(this.ProductText);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Grocery_store";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grocery Store";
            this.Load += new System.EventHandler(this.Grocery_store_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_input_box)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ProductText;
        private System.Windows.Forms.TextBox Product_textBox;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button Minus_Button;
        private System.Windows.Forms.RichTextBox Display_screen;
        private System.Windows.Forms.Button Print_Btn;
        private System.Windows.Forms.Button Enter_Btn;
        private System.Windows.Forms.Label Product_Count;
        private System.Windows.Forms.Label Available_Prod;
        private System.Windows.Forms.RichTextBox Prod_Disp_Screen;
        private System.Windows.Forms.Button Add_New_Prod_Btn;
        private System.Windows.Forms.TextBox New_ProdName_TextBox;
        private System.Windows.Forms.TextBox New_ProdPrice_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Val2_Label;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox RemoveProd_TextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Remove_Btn;
        private System.Windows.Forms.NumericUpDown quantity_input_box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Print_Status;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label cart_tot_text;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Cart_Clear_Btn;
    }
}

