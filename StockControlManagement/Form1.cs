using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockControlManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm you want to exit?","Stock Control",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if(iExit==DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            methodOfPay.Items.Add("Cash");
            methodOfPay.Items.Add("Master Card");
            methodOfPay.Items.Add("Visa Card");
            methodOfPay.Items.Add("Debit Card");


            accountType.Items.Add("Credit Account");
            accountType.Items.Add("Debit Account");
            accountType.Items.Add("Customer Account");
            accountType.Items.Add("Commercial Account");

            vat.Items.Add("Yes");
            vat.Items.Add("No");


            for (int i = 0; i<5; i++)
            {
                productId.Items.Add("PID0900" + i);
                customerId.Items.Add("CID00" + i);
                orderId.Items.Add("ORID00" + i);
            }


            discountComboBox.Items.Add("0");
            discountComboBox.Items.Add("5");
            discountComboBox.Items.Add("10");
            discountComboBox.Items.Add("15");
            discountComboBox.Items.Add("20");

            onSaleComboBox.Items.Add("On Sale");
            onSaleComboBox.Items.Add("Not On Sale");


        }

        private void productId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (productId.Text == "PID09000")
            {
                productName.Text = "Rice";
                description.Text = "White Seeds";
                stockLavel.Text = "200";
                reorderLevel.Text = "50";
                outOfStock.Text = "2";
                cost.Text = "20";

            }


            if (productId.Text == "PID09001")
            {
                productName.Text = "Beans";
                description.Text = "Black eye bean";
                stockLavel.Text = "130";
                reorderLevel.Text = "30";
                outOfStock.Text = "2";
                cost.Text = "10";

            }

            if (productId.Text == "PID09002")
            {
                productName.Text = "Carrot";
                description.Text = "Red";
                stockLavel.Text = "200";
                reorderLevel.Text = "50";
                outOfStock.Text = "2";
                cost.Text = "05";

            }


            if (productId.Text == "PID09003")
            {
                productName.Text = "Eggs";
                description.Text = "poltry";
                stockLavel.Text = "130";
                reorderLevel.Text = "30";
                outOfStock.Text = "2";
                cost.Text = "07";

            }
            if (productId.Text == "PID09004")
            {
                productName.Text = "Bread";
                description.Text = "Grain";
                stockLavel.Text = "200";
                reorderLevel.Text = "50";
                outOfStock.Text = "2";
                cost.Text = "12";

            }


            if (productId.Text == "PID09001")
            {
                productName.Text = "Potato";
                description.Text = "Red Poatato";
                stockLavel.Text = "130";
                reorderLevel.Text = "30";
                outOfStock.Text = "2";
                cost.Text = ".5";

            }
        }

        private void productName_Click(object sender, EventArgs e)
        {
            itemOrderedTextBox.Text = productName.Text;
        }

        private void noOfOrderTextBox_TextChanged(object sender, EventArgs e)
        {
            double p, q,t;
            noOfItemOrderTextBox.Text = noOfOrderTextBox.Text;
            p = double.Parse(stockLavel.Text);
            q = double.Parse(noOfOrderTextBox.Text);
            remainderTextBox.Text = Convert.ToString(p - q);

            t = double.Parse(remainderTextBox.Text);
            if (t<=10)
            {
                action.Text = "Order More";
            }
            else
            {
                action.Text = "No order Need";
            }
        }

        private void productName_TextChanged(object sender, EventArgs e)
        {
            itemOrderedTextBox.Text = productName.Text;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            tax.Text = "";
            subTotal.Text = "";
            total.Text = "";
            discountComboBox.Text = "0";
        }

        private void discardButton_Click(object sender, EventArgs e)
        {
            tax.Text = "";
            subTotal.Text = "";
            total.Text = "";
            discountComboBox.Text = "0";
        }

        private void totalButton_Click(object sender, EventArgs e)
        {
            double iTax,m,j,p,sub;

            if (discountComboBox.Text == "0")
            {
                m = double.Parse(cost.Text);
                j = double.Parse(noOfOrderTextBox.Text);

                iTax = ((m * j) * 7.5) / 100;
                tax.Text = Convert.ToString(iTax);
                //p = Convert.ToUInt32(((m * j) * 5) / 100);
                subTotal.Text = Convert.ToString(m * j);
                total.Text = Convert.ToString((m * j) + iTax);

            }
            if (discountComboBox.Text == "5")
            {
                m = double.Parse(cost.Text);
                j = double.Parse(noOfOrderTextBox.Text);

                iTax = ((m * j) * 7.5) / 100;
                tax.Text = Convert.ToString(iTax);
                p = Convert.ToUInt32(((m * j) * 5) / 100);
                subTotal.Text = Convert.ToString((m * j) - p);
                sub = double.Parse(subTotal.Text);
                total.Text = Convert.ToString((sub) + iTax);

            }
            if (discountComboBox.Text == "10")
            {
                m = double.Parse(cost.Text);
                j = double.Parse(noOfOrderTextBox.Text);

                iTax = ((m * j) * 7.5) / 100;
                tax.Text = Convert.ToString(iTax);
                p = Convert.ToUInt32(((m * j) * 10) / 100);
                subTotal.Text = Convert.ToString((m * j) - p);
                sub = double.Parse(subTotal.Text);
                total.Text = Convert.ToString((sub) + iTax);

            }
            if (discountComboBox.Text == "15")
            {
                m = double.Parse(cost.Text);
                j = double.Parse(noOfOrderTextBox.Text);

                iTax = ((m * j) * 7.5) / 100;
                tax.Text = Convert.ToString(iTax);
                p = Convert.ToUInt32(((m * j) * 15) / 100);
                subTotal.Text = Convert.ToString((m * j) - p);
                sub = double.Parse(subTotal.Text);
                total.Text = Convert.ToString((sub) + iTax);

            }
            if (discountComboBox.Text == "20")
            {
                m = double.Parse(cost.Text);
                j = double.Parse(noOfOrderTextBox.Text);

                iTax = ((m * j) * 7.5) / 100;
                tax.Text = Convert.ToString(iTax);
                p = Convert.ToUInt32(((m * j) * 20) / 100);
                subTotal.Text = Convert.ToString((m * j) - p);
                sub = double.Parse(subTotal.Text);
                total.Text = Convert.ToString((sub) + iTax);

            }
           
        }
    }
}
