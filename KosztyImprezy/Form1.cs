using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KosztyImprezy
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        BirthdayParty birthdayParty;
        public Form1()
        {
            InitializeComponent();

            dinnerParty = new DinnerParty((int)numericUpDown1.Value, healthyBox.Checked, fancy.Checked); // wywołanie konstruktora klasy DinnerParty oraz przeslanie argumentow z checkboxów do tegoż konstruktora
            DisplayDinnerPartyCost(); // wyświetlenie /aktualizacja

            birthdayParty = new BirthdayParty((int)numberBirthday.Value, fancyBirthday.Checked, cakeWriting.Text);
            DisplayDinnerPartyCost();

        }

        /* Procedury obsługi zdarzeń dla kontrolek fancyBox, healtyhyBox
         * oraz numericUpDwn1, jak również metoda DisplayDinnerPartyCost() są takie same 
         * jak analogiczne funkcje i metody zastosowane w projekcie 5
         */

        //zdarzenie checkboxa fantazyjnej dekoracji
        #region DinnerPartyInterface
        private void fancy_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.FancyDecorations = fancy.Checked;
            DisplayDinnerPartyCost();
        }
        //zdarzenie  checkboxa zdrowej opcji
        private void healthyBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.HealthyOption = healthyBox.Checked;
            DisplayDinnerPartyCost();

        }
        //zdarzenie zmiany liczby osób
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numericUpDown1.Value;
            DisplayDinnerPartyCost();
        }
        #endregion
        #region BirthdayPartyInterface 
        private void numberBirthday_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)numberBirthday.Value;
            DisplayBirthdayPartyCost();
        }

        private void fancyBirthday_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.FancyDecorations = fancyBirthday.Checked;
            DisplayBirthdayPartyCost();
        }

        private void cakeWriting_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWriting = cakeWriting.Text;
            DisplayBirthdayPartyCost();
        }

        #endregion


        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.Cost;
            costLabel.Text = Cost.ToString("c");
        }

        private void DisplayBirthdayPartyCost()
        {
            tooLongLabel.Visible = birthdayParty.CakeWritingTooLong;
            decimal cost = birthdayParty.Cost;
            birthdayCost.Text = cost.ToString("c");
        }

        
    }
}
