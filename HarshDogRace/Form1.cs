using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarshDogRace
{
    public partial class Form1 : Form
    {
        int harsh = 90, kim = 70, sam = 100;
        int strt = 0;
        int hrshAmount = 0, kimAmount = 0, samAmount = 0;
        int hrshDog = 0, kimDog = 0, samDog = 0;

        Game game_Object = new Game();
        frstDog obj = new frstDog();
        scndDog obj2 = new scndDog();
        thrdDog dog3 = new thrdDog();

        // resetgame is a method that is used to restart the game and reset all the variable and the position of  the contestant 
        public void resetGame() {
            
            // calling the function of the restart of the game class 

            hrshDog = game_Object.restart();
            kimDog = game_Object.restart();
            samDog = game_Object.restart();

            frstContestant.Left = game_Object.restart();
            secndContestant.Left = game_Object.restart();
            thrdContestant.Left = game_Object.restart();


            frstPlayer.Text = "Player1";
            secndPlayer.Text = "Player2";
            thrdPlayer.Text = "Player3";

            cbDog.Text = "";

            Amount.Value = 0;

            strt = 0;

            Harsh.Checked = false;
            Kim.Checked = false;
            Sam.Checked = false;


        }
        private void cbDog_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Sam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Kim_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (strt >= 1)
            {
                // after setting the bet of the game start the timer and run the dog for game 
                timer1.Start();
                timer2.Start();
                timer3.Start();
            }
            else {
                MessageBox.Show("fill the details or check the details of the Player  ");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // after starting th timer the firstdof willl move from one position to another 
            frstContestant.Left = frstContestant.Left + game_Object.run();
            if (frstContestant.Left>690) {
                // when the dog reach at the finishing line then the timer will stop and display the message 
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();

                MessageBox.Show("Contestant 1 won the Race");
                
                //finding the winner of the game and increment his amount or otherwise decrement 

                if (hrshAmount>0 &&  hrshDog==1) {
                    harsh= game_Object.Increment(harsh,hrshAmount);
                    Harsh.Text = "Harsh has " + harsh + " Dollar ";
                }
                if (hrshAmount>0 && hrshDog!=1) {
                    harsh = game_Object.Decrement(harsh, hrshAmount);
                    Harsh.Text = "Harsh has " + harsh + " Dollar ";
                }


                if (kimAmount > 0 && kimDog == 1)
                {
                    kim = game_Object.Increment(kim, kimAmount);
                    Kim.Text = "Kim has " + kim + " Dollar ";
                }
                if (kimAmount > 0 && kimDog != 1)
                {
                    kim = game_Object.Decrement(kim, kimAmount);
                    Kim.Text = "Kim has " + kim + " Dollar ";
                }


                if (samAmount > 0 && samDog == 1)
                {
                    sam = game_Object.Increment(sam, samAmount);
                    Sam.Text = "Sam has " + sam + " Dollar ";
                }
                if (samAmount > 0 && samDog != 1)
                {
                    sam = game_Object.Decrement(sam, samAmount);
                    Sam.Text = "Sam has " + sam + " Dollar ";
                }





                resetGame();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            secndContestant.Left =secndContestant.Left + game_Object.run();

            if (secndContestant.Left > 690)
            {
                // when the dog reach at the finishing line then the timer will stop and display the message 
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                MessageBox.Show("Contestant 2 won the Race");
                //finding the winner of the game and increment his amount or otherwise decrement 
                if (hrshAmount > 0 && hrshDog == 2)
                {
                    harsh = game_Object.Increment(harsh, hrshAmount);
                    Harsh.Text = "Harsh has " + harsh + " Dollar ";
                }
                if (hrshAmount > 0 && hrshDog != 2)
                {
                    harsh = game_Object.Decrement(harsh, hrshAmount);
                    Harsh.Text = "Harsh has " + harsh + " Dollar ";
                }


                if (kimAmount > 0 && kimDog == 2)
                {
                    kim = game_Object.Increment(kim, kimAmount);
                    Kim.Text = "Kim has " + kim + " Dollar ";
                }
                if (kimAmount > 0 && kimDog != 2)
                {
                    kim = game_Object.Decrement(kim, kimAmount);
                    Kim.Text = "Kim has " + kim + " Dollar ";
                }


                if (samAmount > 0 && samDog == 2)
                {
                    sam = game_Object.Increment(sam, samAmount);
                    Sam.Text = "Sam has " + sam + " Dollar ";
                }
                if (samAmount > 0 && samDog != 2)
                {
                    sam = game_Object.Decrement(sam, samAmount);
                    Sam.Text = "Sam has " + sam + " Dollar ";
                }

                resetGame();
            }
            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            thrdContestant.Left = thrdContestant.Left + game_Object.run();
            if (thrdContestant.Left > 690)
            {
                // when the dog reach at the finishing line then the timer will stop and display the message 
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                MessageBox.Show("Contestant 3 won the Race");
                //finding the winner of the game and increment his amount or otherwise decrement 
                if (hrshAmount > 0 && hrshDog == 3)
                {
                    harsh = game_Object.Increment(harsh, hrshAmount);
                    Harsh.Text = "Harsh has " + harsh + " Dollar ";
                }
                if (hrshAmount > 0 && hrshDog != 3)
                {
                    harsh = game_Object.Decrement(harsh, hrshAmount);
                    Harsh.Text = "Harsh has " + harsh + " Dollar ";
                }


                if (kimAmount > 0 && kimDog == 3)
                {
                    kim = game_Object.Increment(kim, kimAmount);
                    Kim.Text = "Kim has " + kim + " Dollar ";
                }
                if (kimAmount > 0 && kimDog != 3)
                {
                    kim = game_Object.Decrement(kim, kimAmount);
                    Kim.Text = "Kim has " + kim + " Dollar ";
                }


                if (samAmount > 0 && samDog == 3)
                {
                    sam = game_Object.Increment(sam, samAmount);
                    Sam.Text = "Sam has " + sam + " Dollar ";
                }
                if (samAmount > 0 && samDog != 3)
                {
                    sam = game_Object.Decrement(sam, samAmount);
                    Sam.Text = "Sam has " + sam + " Dollar ";
                }

                resetGame();
            }
            
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this block is used  to check weather the player want to participate in the game or not if he want to participate then select  the dog and set the bet amount 
            if (Harsh.Checked == true && cbDog.Text != "" && Convert.ToInt32(Amount.Value) > 0 && Convert.ToInt32(Amount.Value) <= harsh)
            {
                frstPlayer.Text = "Harsh set " + Convert.ToInt32(Amount.Value) + " Dollar on Dog " + cbDog.SelectedItem.ToString();
                hrshAmount = Convert.ToInt32(Amount.Value); 
                hrshDog = Convert.ToInt32(cbDog.SelectedItem.ToString());
                strt++;
              //  MessageBox.Show("frst");

            }
            else if (Kim.Checked == true && cbDog.Text!="" && Convert.ToInt32(Amount.Value) > 0 && Convert.ToInt32(Amount.Value) <= kim)
            {
                secndPlayer.Text = "Kim set " + Convert.ToInt32(Amount.Value) + " Dollar on Dog " + cbDog.SelectedItem.ToString();
                kimAmount = Convert.ToInt32(Amount.Value);
                kimDog =Convert.ToInt32( cbDog.SelectedItem.ToString());
                strt++;
                //MessageBox.Show("2nd");
            }
            else if (Sam.Checked == true && cbDog.Text != "" && Convert.ToInt32(Amount.Value) > 0 && Convert.ToInt32(Amount.Value) <= sam)
            {
                thrdPlayer.Text = "Sam set " + Convert.ToInt32(Amount.Value) + " Dollar on Dog " + cbDog.SelectedItem.ToString();
                samAmount = Convert.ToInt32(Amount.Value);
                samDog= Convert.ToInt32(cbDog.SelectedItem.ToString());
                strt++;
                //MessageBox.Show("thrd");
            }
            else {
                MessageBox.Show("first of all select the Player , then the Dog , set the bet  Amount and the  Amount must be greater then 9 dollaar and less than the budget ");
            }

        }
    }
}
