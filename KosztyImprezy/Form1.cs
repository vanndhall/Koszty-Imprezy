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
        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty((int)numericUpDown1.Value, healthyBox.Checked, fancy.Checked); // wywołanie konstruktora klasy DinnerParty oraz przeslanie argumentow z checkboxów do tegoż konstruktora
            DisplayDinnerPartyCost(); // wyświetlenie /aktualizacja
        }
        //zdarzenie checkboxa fantazyjnej dekoracji
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



        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.Cost;
            costLabel.Text = Cost.ToString("c");
        }
    }
}
