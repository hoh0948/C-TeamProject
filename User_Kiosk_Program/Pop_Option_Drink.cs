using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Kiosk_Program
{
    public partial class Pop_Option_Drink : UserControl
    {
        public event EventHandler ConfirmClicked;
        public event EventHandler CancelClicked;
        public Pop_Option_Drink()
        {
            InitializeComponent();
            pn__Option.AutoScroll = true;
        }


        private void btn_Option_Hot_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton == null) return;

            if (clickedButton.BackColor == SystemColors.Control || clickedButton.BackColor == Color.White)
            {
                clickedButton.BackColor = Color.LightBlue;
            }
            else
            {
                clickedButton.BackColor = Color.White;
            }
        }

        private void btn_Option_Ice_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton == null) return;

            if (clickedButton.BackColor == SystemColors.Control || clickedButton.BackColor == Color.White)
            {
                clickedButton.BackColor = Color.LightBlue;
            }
            else
            {
                clickedButton.BackColor = Color.White;
            }
        }

        private void btn_Vanilla_syrup_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton == null) return;

            if (clickedButton.BackColor == SystemColors.Control || clickedButton.BackColor == Color.White)
            {
                clickedButton.BackColor = Color.LightBlue;
            }
            else
            {
                clickedButton.BackColor = Color.White;
            }
        }

        private void btn_Hazelnut_syrup_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton == null) return;

            if (clickedButton.BackColor == SystemColors.Control || clickedButton.BackColor == Color.White)
            {
                clickedButton.BackColor = Color.LightBlue;
            }
            else
            {
                clickedButton.BackColor = Color.White;
            }
        }

        private void btn_Unselected_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton == null) return;

            if (clickedButton.BackColor == SystemColors.Control || clickedButton.BackColor == Color.White)
            {
                clickedButton.BackColor = Color.LightBlue;
            }
            else
            {
                clickedButton.BackColor = Color.White;
            }
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("선택하시겠습니까?", "선택 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {

                ConfirmClicked?.Invoke(this, EventArgs.Empty);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {

        }
    }
}

