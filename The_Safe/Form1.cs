using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MyDialogs;
namespace The_Safe
{
    public partial class Form1 : Form
    {
        String Str_Combination;
        public Form1()
        {
            InitializeComponent();
        }
        private void Btn_Set_Combination_Click(object sender, EventArgs e)
        {
            if (Txt_Status.Text == "UnLocked" || Txt_Status.Text == "Combination Not Set")
            {
                 this.BackColor = System.Drawing.Color.Orange;
                    //this code brings up an input box for the user to put in new combination.
                Str_Combination = My_Dialogs.InputBox("Please Enter The Combination That Is Greater Than Five Characters");

                while (Str_Combination.Length < 6)
                {       //this pops up an error message if they do not put in more than five characters.  
                    MessageBox.Show("That Combination Is Wrong, Please Try Again.");
                    Str_Combination = My_Dialogs.InputBox("Please Enter The Combination That Is Greater Than Five Characters");
                }
                Txt_Status.Text = "Locked";
                Test_Key.Text = "Test Key";
                this.Txt_Status.BackColor = Color.Red;
                this.BackColor = System.Drawing.Color.Red;
                this.Enter_Key.BackColor = Color.PeachPuff;
                this.Txt_Status.BackColor = Color.PeachPuff;
                Enter_Key.Clear();
            }
            else
            {       //This message tells you to unlock the safe before trying to change the combination.
                MessageBox.Show("You Must UnLock The Safe Before Trying To Change The Combination.");
            }
        }

        private void Test_Key_Click(object sender, EventArgs e)
        {
            if (Test_Key.Text == "Test Key")
            {
                if (Enter_Key.Text == Str_Combination)
                {   //this piece of code tells the user that if the text in the enter key box does equal the set combination then the status turns to UnLocked and turns the colour to green and green yellow.
                    Txt_Status.Text = "UnLocked";
                    this.Txt_Status.BackColor = Color.GreenYellow;
                    this.Enter_Key.BackColor = Color.GreenYellow;
                    this.BackColor = System.Drawing.Color.Green;
                    Test_Key.Text = "Lock Safe";
                    Enter_Key.Clear();
                }
                else
                {   //this piece of code tells the user that if the text in the enter key box does not equal the set combination then a message box will pop up saying that the key is invalid and change colour to red and peach puff.
                    MessageBox.Show("This Key Is Invalid");
                    this.BackColor = System.Drawing.Color.Red;
                    this.Txt_Status.BackColor = Color.PeachPuff;
                    this.Enter_Key.BackColor = Color.PeachPuff;
                }
            }
            else
            {
                Txt_Status.Text = "Locked";
                Test_Key.Text = "Test Key";
                this.Txt_Status.BackColor = Color.Red;
                this.BackColor = System.Drawing.Color.Red;
                this.Enter_Key.BackColor = Color.PeachPuff;
                this.Txt_Status.BackColor = Color.PeachPuff;
                Enter_Key.Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Status_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
