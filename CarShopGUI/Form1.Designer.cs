namespace CarShopGUI
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Year = new System.Windows.Forms.TextBox();
            this.txt_Color = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Create_a_car = new System.Windows.Forms.Button();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_Model = new System.Windows.Forms.TextBox();
            this.txt_make = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Car_inventory = new System.Windows.Forms.GroupBox();
            this.lst_inventory = new System.Windows.Forms.ListBox();
            this.btn_Add_to_cart = new System.Windows.Forms.Button();
            this.Shoping_Cart = new System.Windows.Forms.GroupBox();
            this.lst_cart = new System.Windows.Forms.ListBox();
            this.btn_Checkout = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.Car_inventory.SuspendLayout();
            this.Shoping_Cart.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Year);
            this.groupBox1.Controls.Add(this.txt_Color);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btn_Create_a_car);
            this.groupBox1.Controls.Add(this.txt_price);
            this.groupBox1.Controls.Add(this.txt_Model);
            this.groupBox1.Controls.Add(this.txt_make);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(43, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 344);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create a car";
            // 
            // txt_Year
            // 
            this.txt_Year.Location = new System.Drawing.Point(159, 235);
            this.txt_Year.Name = "txt_Year";
            this.txt_Year.Size = new System.Drawing.Size(100, 22);
            this.txt_Year.TabIndex = 10;
            this.txt_Year.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt_Year.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Year_KeyPress);
            // 
            // txt_Color
            // 
            this.txt_Color.Location = new System.Drawing.Point(159, 178);
            this.txt_Color.Name = "txt_Color";
            this.txt_Color.Size = new System.Drawing.Size(100, 22);
            this.txt_Color.TabIndex = 9;
            this.txt_Color.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Year";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Color";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btn_Create_a_car
            // 
            this.btn_Create_a_car.Location = new System.Drawing.Point(82, 292);
            this.btn_Create_a_car.Name = "btn_Create_a_car";
            this.btn_Create_a_car.Size = new System.Drawing.Size(110, 23);
            this.btn_Create_a_car.TabIndex = 6;
            this.btn_Create_a_car.Text = "Create a car";
            this.btn_Create_a_car.UseVisualStyleBackColor = true;
            this.btn_Create_a_car.Click += new System.EventHandler(this.btn_Create_a_car_Click);
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(159, 126);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(100, 22);
            this.txt_price.TabIndex = 5;
            this.txt_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_price_KeyPress);
            // 
            // txt_Model
            // 
            this.txt_Model.Location = new System.Drawing.Point(159, 79);
            this.txt_Model.Name = "txt_Model";
            this.txt_Model.Size = new System.Drawing.Size(100, 22);
            this.txt_Model.TabIndex = 4;
            this.txt_Model.TextChanged += new System.EventHandler(this.txt_Model_TextChanged);
            // 
            // txt_make
            // 
            this.txt_make.Location = new System.Drawing.Point(159, 31);
            this.txt_make.Name = "txt_make";
            this.txt_make.Size = new System.Drawing.Size(100, 22);
            this.txt_make.TabIndex = 3;
            this.txt_make.TextChanged += new System.EventHandler(this.txt_make_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Maker";
            // 
            // Car_inventory
            // 
            this.Car_inventory.Controls.Add(this.lst_inventory);
            this.Car_inventory.Location = new System.Drawing.Point(367, 46);
            this.Car_inventory.Name = "Car_inventory";
            this.Car_inventory.Size = new System.Drawing.Size(395, 454);
            this.Car_inventory.TabIndex = 1;
            this.Car_inventory.TabStop = false;
            this.Car_inventory.Text = "Car inventory";
            // 
            // lst_inventory
            // 
            this.lst_inventory.FormattingEnabled = true;
            this.lst_inventory.ItemHeight = 16;
            this.lst_inventory.Location = new System.Drawing.Point(6, 31);
            this.lst_inventory.Name = "lst_inventory";
            this.lst_inventory.Size = new System.Drawing.Size(383, 404);
            this.lst_inventory.TabIndex = 0;
            // 
            // btn_Add_to_cart
            // 
            this.btn_Add_to_cart.Location = new System.Drawing.Point(768, 202);
            this.btn_Add_to_cart.Name = "btn_Add_to_cart";
            this.btn_Add_to_cart.Size = new System.Drawing.Size(94, 23);
            this.btn_Add_to_cart.TabIndex = 6;
            this.btn_Add_to_cart.Text = "Add to cart";
            this.btn_Add_to_cart.UseVisualStyleBackColor = true;
            this.btn_Add_to_cart.Click += new System.EventHandler(this.btn_Add_to_cart_Click);
            // 
            // Shoping_Cart
            // 
            this.Shoping_Cart.Controls.Add(this.lst_cart);
            this.Shoping_Cart.Location = new System.Drawing.Point(868, 46);
            this.Shoping_Cart.Name = "Shoping_Cart";
            this.Shoping_Cart.Size = new System.Drawing.Size(365, 350);
            this.Shoping_Cart.TabIndex = 7;
            this.Shoping_Cart.TabStop = false;
            this.Shoping_Cart.Text = "Shoping cart";
            // 
            // lst_cart
            // 
            this.lst_cart.FormattingEnabled = true;
            this.lst_cart.ItemHeight = 16;
            this.lst_cart.Location = new System.Drawing.Point(13, 31);
            this.lst_cart.Name = "lst_cart";
            this.lst_cart.Size = new System.Drawing.Size(346, 260);
            this.lst_cart.TabIndex = 0;
            // 
            // btn_Checkout
            // 
            this.btn_Checkout.Location = new System.Drawing.Point(985, 402);
            this.btn_Checkout.Name = "btn_Checkout";
            this.btn_Checkout.Size = new System.Drawing.Size(127, 32);
            this.btn_Checkout.TabIndex = 8;
            this.btn_Checkout.Text = "Checkout";
            this.btn_Checkout.UseVisualStyleBackColor = true;
            this.btn_Checkout.Click += new System.EventHandler(this.btn_Checkout_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(957, 464);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Total:";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(1098, 464);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(44, 17);
            this.lbl_total.TabIndex = 2;
            this.lbl_total.Text = "00.00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 512);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Checkout);
            this.Controls.Add(this.Shoping_Cart);
            this.Controls.Add(this.btn_Add_to_cart);
            this.Controls.Add(this.Car_inventory);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Car_inventory.ResumeLayout(false);
            this.Shoping_Cart.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Create_a_car;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_Model;
        private System.Windows.Forms.TextBox txt_make;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox Car_inventory;
        private System.Windows.Forms.ListBox lst_inventory;
        private System.Windows.Forms.Button btn_Add_to_cart;
        private System.Windows.Forms.GroupBox Shoping_Cart;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lst_cart;
        private System.Windows.Forms.Button btn_Checkout;
        private System.Windows.Forms.TextBox txt_Year;
        private System.Windows.Forms.TextBox txt_Color;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

