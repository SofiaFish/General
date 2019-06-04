using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication7
{
    class Game
    {
        public int humans;
        public int money;
        public int zerno;
        public int territory;
        public int wars;
        public int min_money_war;
        public int max_money_war;
        public int min_money_zerno;
        public int max_money_zerno;
        public int money_war;
        public int money_zerno;
        public int wars_counter;
        public int hod_counter;
        public int warriors;
        public int year;
        public bool win;
        public bool napadenie;
        // public int count_warriors;

        public  int Humans
        {
            get { return humans; }
            set { humans = value; }
        }
        public int Money
        {
            get { return money; }
            set { money = value; }
        }
        public int Zerno
        {
            get { return zerno; }
            set { zerno = value; }
        }
        public int Territory
        {
            get { return territory; }
            set { territory = value; }
        }
        public int Wars
        {
            get { return wars; }
            set { wars = value; }
        }
        public int Warriors
        {
            get { return warriors; }
            set { warriors = value; }
        }
        public Game()
        {
            humans = 100000;
            money = 1000000;
            zerno = 1000000;
            territory = 1500;
            wars = 0;
            min_money_war = 0;
            max_money_war = 1000000;
            min_money_zerno = 0;
            max_money_zerno = 1000;
            money_war = 0;
            money_zerno = 0;
            wars_counter = 0;
            hod_counter = 0;
            warriors = 0;
            year = 1000;
            win = false;
            napadenie = false;


        }
    }
}
