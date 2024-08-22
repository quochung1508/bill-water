using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bill_Water
{
    public partial class Form2 : Form
    {
        private int selectedIndex = -1;

        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            tbConsumed.Enabled = false;
            tbPrice.Enabled = false;
            tbBill.Enabled = false;
            tbTotal.Enabled = false;

            lvBills.View = View.Details;
            lvBills.Columns.Add("Customer name", 160);
            lvBills.Columns.Add("Customer type", 250);
            lvBills.Columns.Add("Last month", 95);
            lvBills.Columns.Add("This month", 95);
            lvBills.Columns.Add("Consumption (m³)", 145);
            lvBills.Columns.Add("Price (VND)", 130);
            lvBills.Columns.Add("Bill + env (10%)", 165);
            lvBills.Columns.Add("Total bill + vat (10%)", 170);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvBills.SelectedItems.Count > 0)
            {
                ListViewItem item = lvBills.SelectedItems[0];
                selectedIndex = item.Index;

                tbName.Text = item.SubItems[0].Text;
                cbbType.Text = item.SubItems[1].Text;
                tbLast.Text = item.SubItems[2].Text;
                tbThis.Text = item.SubItems[3].Text;
                tbConsumed.Text = item.SubItems[4].Text;
                tbPrice.Text = item.SubItems[5].Text;
                tbBill.Text = item.SubItems[6].Text;
                tbTotal.Text = item.SubItems[7].Text;
            }
        }

        private void bntCalculate_Click(object sender, EventArgs e)
        {
            int lastMonth;
            int thisMonth;

            if (string.IsNullOrWhiteSpace(tbLast.Text))
            {
                MessageBox.Show("Please enter the last month's water number.", "Notice",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbThis.Text))
            {
                MessageBox.Show("Please enter this month's water number.", "Notice",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check and get the value of the previous month's water number
            if (!int.TryParse(tbLast.Text, out lastMonth))
            {
                MessageBox.Show("Invalid input for last month's water number.", "Notice",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check and get the value of this month's water number
            if (!int.TryParse(tbThis.Text, out thisMonth))
            {
                MessageBox.Show("Invalid input for this month's water number.", "Notice",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // If the water level last month is equal to the water level this month, a message is displayed.
            if (thisMonth == lastMonth)
            {
                MessageBox.Show("This month's water number is the same as last month's. No water consumption recorded.", "Notice",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // If the amount of water this month is less than the amount of water last month, please re-enter.
            if (thisMonth < lastMonth)
            {
                MessageBox.Show("This month's water number must be greater than or equal to last month's.", "Notice",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Calculate water consumption
            int waterConsumption = thisMonth - lastMonth;

            // Show results in Consumed
            tbConsumed.Text = waterConsumption.ToString();

            double price = Calculate(waterConsumption, cbbType.SelectedIndex);
            tbPrice.Text = price.ToString();

            double bill = GetBill(price);
            tbBill.Text = bill.ToString();

            double totalBill = TotalBill(bill);
            tbTotal.Text = totalBill.ToString();
        }

        private double Calculate(int waterConsumption, int customerType)
        {
            double price = 0;
            switch (customerType)
            {
                case 0:
                    if (waterConsumption <= 10)
                    {
                        price = waterConsumption * 5.972;
                    }
                    else if (waterConsumption > 10 && waterConsumption <= 20)
                    {
                        price = ((waterConsumption - 10) * 7.052) + 10 * 5.972;
                    }
                    else if (waterConsumption > 20 && waterConsumption <= 30)
                    {
                        price = ((waterConsumption - 20) * 8.699) + 10 * 7.052 + 10 * 5.972;
                    }
                    else
                    {
                        price = ((waterConsumption - 30) * 15.929) + 10 * 8.699 + 10 * 7.052 + 10 * 5.972;
                    }
                    break;
                case 1:
                    price = waterConsumption * 9.955;
                    break;
                case 2:
                    price = waterConsumption * 11.615;
                    break;
                case 3:
                    price = waterConsumption * 22.068;
                    break;
            }
            return price;
        }

        private double GetBill(double price)
        {
            double env = 0.1; // 10% environmental fee
            return price * (1 + env);
        }

        private double TotalBill(double bill)
        {
            double VAT = 0.1; // 10% VAT
            return bill * (1 + VAT);
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            string CusName = tbName.Text;
            string CusType = cbbType.Text;
            string LastMonth = tbLast.Text;
            string ThisMonth = tbThis.Text;
            string Consumed = tbConsumed.Text;
            string Price = tbPrice.Text;
            string Bill = tbBill.Text;
            string TotalBill = tbTotal.Text;

            ListViewItem item = new ListViewItem();
            item.Text = CusName;
            item.SubItems.Add(CusType);
            item.SubItems.Add(LastMonth);
            item.SubItems.Add(ThisMonth);
            item.SubItems.Add(Consumed);
            item.SubItems.Add(Price);
            item.SubItems.Add(Bill);
            item.SubItems.Add(TotalBill);
            lvBills.Items.Add(item);

            tbName.Clear();
            cbbType.SelectedIndex = -1;
            tbLast.Clear();
            tbThis.Clear();
            tbConsumed.Clear();
            tbPrice.Clear();
            tbBill.Clear();
            tbTotal.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lvBills.SelectedItems != null)
            {
                // Show confirmation dialog
                DialogResult result = MessageBox.Show("Are you sure you want to edit this item?", "Confirm Update",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result != DialogResult.Yes)
                {
                    return; // User selects "No" will stop editing
                }

                int lastMonth;
                int thisMonth;

                // Check and get the value of the previous month's water
                if (!int.TryParse(tbLast.Text, out lastMonth))
                {
                    MessageBox.Show("Invalid input for last month's water number.", "Noitice",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check and get the value of this month's water number
                if (!int.TryParse(tbThis.Text, out thisMonth))
                {
                    MessageBox.Show("Invalid input for this month's water number.", "Noitice",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if this month's water count is less than last month's water count
                if (thisMonth < lastMonth)
                {
                    MessageBox.Show("This month's water number must be greater than or equal to last month's.", "Noitice",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Calculate m³ of water consumption and bills
                int waterConsumption = thisMonth - lastMonth;
                double price = Calculate(waterConsumption, cbbType.SelectedIndex);
                double bill = GetBill(price);
                double totalBill = TotalBill(bill);

                // Edit items in ListView
                ListViewItem item = lvBills.Items[selectedIndex];
                item.SubItems[0].Text = tbName.Text;
                item.SubItems[1].Text = cbbType.Text;
                item.SubItems[2].Text = tbLast.Text;
                item.SubItems[3].Text = tbThis.Text;
                item.SubItems[4].Text = waterConsumption.ToString();
                item.SubItems[5].Text = price.ToString();
                item.SubItems[6].Text = bill.ToString();
                item.SubItems[7].Text = totalBill.ToString();

                // Reset selectedIndex
                selectedIndex = -1;

                // Clear input controls after edit
                tbName.Clear();
                tbLast.Clear();
                tbThis.Clear();
                tbConsumed.Clear();
                tbPrice.Clear();
                tbBill.Clear();
                tbTotal.Clear();
                cbbType.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Please select an item to edit.", "Noitice",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit ?", "Confirm Exit", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
            {
                return;
            }
            Application.Exit();
        }
    }
}
