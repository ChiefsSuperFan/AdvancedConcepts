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
    public partial class frmLINQ : Form
    {
        private List<FootballPlayer> _footballPlayers = new List<FootballPlayer>();
        public frmLINQ()
        {
            InitializeComponent();
        }

        private void frmLINQ_Load(object sender, EventArgs e)
        {
            _footballPlayers = new List<FootballPlayer>
            {
                new FootballPlayer(1, "Chiefs", "Patrick", "Mahomes", 2000000),
                new FootballPlayer(2, "Chiefs", "Travis", "Kelce", 9000000),
                new FootballPlayer(3, "Chiefs", "Tyreek", "Hill", 600000),
                new FootballPlayer(4, "Panthers", "Cam", "Newton", 17000000),
                new FootballPlayer(5, "Panthers", "Luke", "Kuechly", 9000000),
                new FootballPlayer(6, "Broncos", "Von", "Miller", 20000000),

            };
            BindingSource source = new BindingSource();

            var playerIDS = _footballPlayers.Select(p => p.PlayerID);
            source.DataSource = playerIDS;
           
            cboPlayerIDS.DataSource = source;

            int playerCount = _footballPlayers.Count();

            int teamCount = _footballPlayers.GroupBy(p => p.TeamName).Count();

            var totalSalary = _footballPlayers.Sum(p => p.Salary);
            var hightestSalary = _footballPlayers.Max(p => p.Salary);


            txtPlayerCount.Text = playerCount.ToString();
            txtTeamCount.Text = teamCount.ToString();

            txtTotalSalaries.Text = totalSalary.ToString();
            txtMaxSalary.Text = hightestSalary.ToString();

           
           
           

        }

        private void cboPlayerIDS_SelectedIndexChanged(object sender, EventArgs e)
        {
            //use linq to find the player record
            
            try
            {
                //var playerID = cboPlayerIDS.SelectedItem;
                int playerID = Convert.ToInt32(cboPlayerIDS.SelectedItem);
                var lookupPlayer = _footballPlayers.SingleOrDefault(p => p.PlayerID == playerID);
                
                //always use the OrDefault option because it wont throw and error if there is no 
                //match, just a null value
                if(lookupPlayer!=null)
                {
                    txtFirstName.Text = lookupPlayer.FirstName;
                    txtLastName.Text = lookupPlayer.LastName;

                }

            }
            catch
            {

            }

 

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
