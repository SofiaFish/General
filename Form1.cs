using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        Game game = new Game();
        public Form1()
        {
            InitializeComponent();
            tbHuman.DataBindings.Add("Text",game, "Humans");
            tbZerno.DataBindings.Add("Text", game, "Zerno");
            tbMoney.DataBindings.Add("Text", game, "Money");
            tbTerritory.DataBindings.Add("Text", game, "Territory");
            tbWar.DataBindings.Add("Text", game, "Wars");
         //   tbWar.DataBindings.Add("Text", game, "Warriors");
            trbWoiny.Minimum = 0;
            trbWoiny.Maximum =100000;
            trbZerno.Minimum = game.min_money_zerno;
            trbZerno.Maximum = game.max_money_zerno;
        }

        private void trbZerno_Scroll(object sender, EventArgs e)
        {
            lMoneyZerno.Text = (trbZerno.Value).ToString();
        }

        private void bOkWar_Click(object sender, EventArgs e)
        {
            game.money -= trbWoiny.Value;
            tbMoney.Text = (game.money).ToString();
            game.warriors += trbWoiny.Value;
            tbVoiny.Text = game.warriors.ToString();

        }

        private void bOkZerno_Click(object sender, EventArgs e)
        {
            
            game.money += trbZerno.Value;
            tbMoney.Text = (game.money).ToString();
            game.zerno -= trbZerno.Value;
            tbZerno.Text = (game.zerno).ToString();
            if(game.zerno==0)
                MessageBox.Show("У вас нет зерна для продажи.");
        }

        private void lMoneyWar_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void trbWoiny_Scroll(object sender, EventArgs e)
        {
            lMoneyWar.Text = ( trbWoiny.Value).ToString();
           
        }

        private void bNapast_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
           
            if (game.warriors >= 10000)
            {
                game.warriors -= 10000;
                tbVoiny.Text = (game.warriors).ToString();
                game.wars_counter++;
                game.territory += rand.Next(1000, 10000);
                tbWar.Text = (game.wars_counter).ToString();
                tbTerritory.Text = (game.territory).ToString();
            }
            else
                MessageBox.Show("Не хватает воинов. \n Наймите не менее 10000 воинов, \n прежде чем отправится на войну");
                
            
        }

        private void tbVoiny_TextChanged(object sender, EventArgs e)
        {

        }

        private void bHod_Click(object sender, EventArgs e)
        {
            Random humans = new Random();
            Random year = new Random();
            Random territory = new Random();
            Random zerno = new Random();
          
            game.year++;
            lYear.Text = (game.year).ToString();
            game.humans += humans.Next(10000,200000);
            tbHuman.Text = (game.humans).ToString();
            Win();
            if(game.humans>=70000)
            {
                game.zerno += 7000;
                tbZerno.Text = (game.zerno).ToString();
            }
            if(game.humans<70000)
            {
                game.zerno += 40000;
                tbZerno.Text = (game.zerno).ToString();
            }

            if (game.napadenie = (year.Next() % 5 == 0))
            {
                MessageBox.Show("На вас напали");
                game.humans -= humans.Next(10000, 20000);
                game.warriors -= 5000;
                tbVoiny.Text = (game.warriors).ToString();
                game.zerno -= zerno.Next(1000,200000);
                tbZerno.Text = (game.zerno).ToString();
                if (game.territory >= 5000)
                {
                    game.territory -= territory.Next(500, 1000);
                    tbTerritory.Text = (game.territory).ToString();
                }
                if (game.territory < 5000)
                {
                    game.territory -= territory.Next(100, 500);
                    tbTerritory.Text = (game.territory).ToString();
                }
               
            }
        }
        private void Win()
        {
            if (game.humans == 5000000)
            {
                game.win = true;
                MessageBox.Show("Вы победили!");
            }
            if(game.zerno==0)
            {
                game.win = false;
                MessageBox.Show("Народ умер от голода. \nВы проиграли");
                Close();
            }
            if(game.napadenie==true && game.warriors<5000 || game.warriors==0)
            {
                game.win = false;
                MessageBox.Show("Ваши земли захвачены. \nВы проиграли");
                Close();
            }
        }
        private void progressBar1_Click(object sender, EventArgs e)
        {
            int min = 100000;
            int max = 5000000;
            pbWin.Minimum = min;
            pbWin.Maximum = max;
            int Value = game.humans;
            pbWin.DataBindings.Add("Value", game, "Humans");
            
        }
    }
}
