using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaProject
{
    public partial class PizzaOrder : Form
    {
        public PizzaOrder()
        {
            InitializeComponent();
        }

        void ResetToppings()
        {
            chkExtraCheese.Checked = false;
            chkOnion.Checked = false;
            chkMushrooms.Checked = false;
            chkOlives.Checked = false;
            chkTomatoes.Checked = false;
            chkGreenPeppers.Checked = false;
        }

        void UpdateToppings()
        {
            string sToppings = "";

            if (chkExtraCheese.Checked)
                sToppings += "Extra Cheese";
            if (chkOnion.Checked)
                sToppings += ", " + "Onion";
            if (chkMushrooms.Checked)
                sToppings += ", " + "Mushrooms";
            if (chkOlives.Checked)
                sToppings += ", " + "Olives";
            if (chkTomatoes.Checked)
                sToppings += ", " + "Tomatoes";
            if (chkGreenPeppers.Checked)
                sToppings += ", " + "Green Peppers";
            if (sToppings.StartsWith(", "))
                sToppings = sToppings.Substring(1,sToppings.Length - 1).Trim();
            if (sToppings == "")
                sToppings = "No Toppings";

            lToppings.Text = sToppings;
        }

        void UpdateTotalPrice()
        {
            int price = 0;
            if (rdbtnSmall.Checked)
                price += 20;
            if (rdbtnMedium.Checked)
                price += 30;
            if (rdbtnLarge.Checked)
                price += 40;
            if (chkExtraCheese.Checked)
                price += 5;
            if (chkOnion.Checked)
                price += 5;
            if (chkOlives.Checked)
                price += 5;
            if (chkMushrooms.Checked)
                price += 5;
            if (chkGreenPeppers.Checked)
                price += 5;
            if (chkTomatoes.Checked)
                price += 5;
            if (rdbtnThickCrust.Checked)
                price += 10;

            lTotalPrice.Text = "$" + price.ToString();
        }

        private void rdbtnSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            lSize.Text = rdbtnSmall.Text;
        }

        private void rdbtnMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            lSize.Text = rdbtnMedium.Text;
        }

        private void rdbtnLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            lSize.Text = rdbtnLarge.Text;
        }

        private void rdbtnThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            lCrustType.Text = rdbtnThinCrust.Text;
        }

        private void rdbtnThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            lCrustType.Text = rdbtnThickCrust.Text;
        }

        private void rdbtnEatIn_CheckedChanged(object sender, EventArgs e)
        {
            lWhereToEat.Text = rdbtnEatIn.Text;
        }

        private void rdbtnTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            lWhereToEat.Text = rdbtnTakeOut.Text;
        }

        private void chkExtraCheese_CheckedChanged(object sender, EventArgs e) {
            UpdateTotalPrice();
            UpdateToppings();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e) {
            UpdateTotalPrice();
            UpdateToppings();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e) {
            UpdateTotalPrice();
            UpdateToppings();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e) {
            UpdateTotalPrice();
            UpdateToppings();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e) {
            UpdateTotalPrice();
            UpdateToppings();
        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e) {
            UpdateTotalPrice();
            UpdateToppings();
        }

        private void PizzaOrder_Load(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            gbSize.Enabled = true;
            gbCrustType.Enabled = true;
            gbToppings.Enabled = true;
            gbWherToEat.Enabled = true;

            rdbtnEatIn.Checked = true;
            rdbtnMedium.Checked = true;
            rdbtnThinCrust.Checked = true;

            btnOrderPizza.Enabled = true;

            ResetToppings();
        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) {
                MessageBox.Show("Order Placed Succefully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gbSize.Enabled = false;
                gbCrustType.Enabled = false;
                gbToppings.Enabled = false;
                gbWherToEat.Enabled = false;
                btnOrderPizza.Enabled = false;
                
            }

        }
    }
}