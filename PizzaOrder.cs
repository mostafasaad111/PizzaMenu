﻿using System;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class PizzaOrder : Form
    {
        public PizzaOrder()
        {
            InitializeComponent();
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            lbSize.Text = rbSmall.Checked ? rbSmall.Text : string.Empty;
            UpdatePrice();
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            lbSize.Text = rbMedium.Checked ? rbMedium.Text : string.Empty;
            UpdatePrice();

        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            lbSize.Text = rbLarge.Checked ? rbLarge.Text : string.Empty;
            UpdatePrice();

        }

        //start chekced Box //

        void UpdateTappings()
        {

            string sTapping = "";

            if (chExtraChees.Checked)
            {
                sTapping = " ExtraChees";
            }
            if (chOlives.Checked)
            {
                sTapping += ", Olives";
            }
            if (chOnion.Checked)
            {
                sTapping += ",Onion";
            }
            if (chTomatoes.Checked)
            {
                sTapping += ", Tomatoes";
            }
            if (chMushrooms.Checked)
            {
                sTapping += ", Mushrooms";
            }
            if (chGreenPeppers.Checked)
            {
                sTapping += ", GreenPeppers";
            }
            if (sTapping.StartsWith(","))
            {
                sTapping = sTapping.Substring(1, sTapping.Length - 1).Trim();
            }
            if (sTapping == "")
                sTapping = "No Tappings";

            lbToppings.Text = sTapping;

        }

        float CountTopping()
        {
            float TotalTappingPrice = 0;
            if (chMushrooms.Checked)
            {
                TotalTappingPrice += Convert.ToSingle(chMushrooms.Tag);
            }
            if (chExtraChees.Checked)
            {
                TotalTappingPrice += Convert.ToSingle(chExtraChees.Tag);
            }
            if (chGreenPeppers.Checked)
            {
                TotalTappingPrice += Convert.ToSingle(chGreenPeppers.Tag);
            }
            if (chTomatoes.Checked)
            {
                TotalTappingPrice += Convert.ToSingle(chTomatoes.Tag);
            }
            if (chOnion.Checked)
            {
                TotalTappingPrice += Convert.ToSingle(chOnion.Tag);
            }
            if (chOlives.Checked)
            {
                TotalTappingPrice += Convert.ToSingle(chOlives.Tag);
            }
            return TotalTappingPrice;
        }
        float CountSize()
        {
            if (rbSmall.Checked)
            {
                return Convert.ToSingle(rbSmall.Tag);
            }
            else if (rbMedium.Checked)
            {
                return Convert.ToSingle(rbMedium.Tag);
            }
            else
            {
                return Convert.ToSingle(rbLarge.Tag);
            }

        }
        float CountCrsutType()
        {
            return rbThick.Checked ? Convert.ToSingle(rbThick.Tag) : Convert.ToSingle(rbThin.Tag);
        }
        void UpdatePrice()
        {
            float Totla = CountTopping() + CountCrsutType() + CountSize();
            lbPrice.Text = $"${Totla}";
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTappings();
            UpdatePrice();
        }
        private void chMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTappings();
            UpdatePrice();
        }

        private void chTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTappings();
            UpdatePrice();
        }

        private void chOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTappings();
            UpdatePrice();
        }

        private void chOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTappings();
            UpdatePrice();
        }

        private void chGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTappings();
            UpdatePrice();
        }

        // End Checked Box // 

        // Start Crust
        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {
            lbCrustType.Text = rbThin.Checked ? rbThin.Text : string.Empty;
            UpdatePrice();
        }

        private void rbThick_CheckedChanged(object sender, EventArgs e)
        {
            lbCrustType.Text = rbThick.Checked ? rbThick.Text : string.Empty;
            UpdatePrice();
        }

        //start Eat 
        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            lbEat.Text = rbEatIn.Checked ? rbEatIn.Text : string.Empty;
        }

        private void rbEatOut_CheckedChanged(object sender, EventArgs e)
        {
            lbEat.Text = rbEatOut.Checked ? rbEatOut.Text : string.Empty;

        }

        private void lbPrice_Click(object sender, EventArgs e)
        {
            lbPrice.Text = Convert.ToString(CountCrsutType() + CountSize() + CountTopping());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (MessageBox.Show("Order Placed Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    gbSize.Enabled = false;
                    gbEat.Enabled = false;
                    gbCrust.Enabled = false;
                    gbTopping.Enabled = false;
                    btOrderPiza.Enabled = false;
                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            gbSize.Enabled = true;
            gbEat.Enabled = true;
            gbCrust.Enabled = true;
            gbTopping.Enabled = true;
        }

        private void PizzaOrder_Load(object sender, EventArgs e)
        {

        }
    }
}
