using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdvancedConcepts.Classes;

namespace AdvancedConcepts
{
    public partial class frmOOP : Form
    {
        public frmOOP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            SportType selectSport = SportType.Football;

            IAthlete athlete = GetAthlete(selectSport);

            athlete.ChangeTeam("Chiefs");

            var team = athlete.TeamName;
      

        }

        private IAthlete GetAthlete(SportType sportType)
        {
            //Interfaces define contracts that a subscribing class must implement
            //However, the fact that you can store a classes object in an interface 
            //references adds tremendous flexibility to your code
            switch (sportType)
            {
                case SportType.Football:
                    IAthlete footballPlayer = new FootballPlayer();
                    return footballPlayer;
                case SportType.Basketball:
                    IAthlete basketBallPlayer = new BasketBallPlayer();
                    return basketBallPlayer;
                default:
                    IAthlete baseballPlayer = new BaseballPlayer();
                    return baseballPlayer;
            }
        }

        private void btnExtensionMethods_Click(object sender, EventArgs e)
        {
            int employeeCount = 47777;

            //we have added an extension method to return the t sql data type
            //of a value
           
            TSQLIntegerTypes sqlType = employeeCount.GetSQLType();
        }

        private void btnNullable_Click(object sender, EventArgs e)
        {
            //nullable types allow you to have properties that may sometimes be null
            //the birthday property of the football player class is an example

            FootballPlayer player1 = new FootballPlayer(1, "Chiefs", "Chris", "Jones", 3000000);
            FootballPlayer player2 = new FootballPlayer(1, "Chiefs", "Anthony", "Hitchens", 9000000);

            player1.BirthDay = new DateTime(1992, 5, 10);

            if(player1.BirthDay.HasValue)
            {
                MessageBox.Show(player1.BirthDay.ToString());
            }

            if(player2.BirthDay.HasValue)
            {
                MessageBox.Show(player2.BirthDay.ToString());
            }

        }
    }
}
