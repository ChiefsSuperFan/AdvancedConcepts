using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdvancedConcepts.Generics;
using AdvancedConcepts.UI;
using AdvancedConcepts.Classes;

namespace AdvancedConcepts
{
    public partial class frmGenerics : Form
    {

        //our example event
        public EventHandler<ExampleEventArgs> SendMessage;

        public frmGenerics()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //this is the method that is called in this form to raise the event!
        protected virtual void OnSendMessage(ExampleEventArgs e)
        {
            try
            {
                EventHandler<ExampleEventArgs> handler = SendMessage;
                if(handler!=null)
                {
                    handler(this, e);
                }

            }catch
            {

            }

        }
        private void btnCompare_Click(object sender, EventArgs e)
        {
            var a = 123;

            var b = 45.6666;

            CompareValue compareValue = new CompareValue();

            var maxValue = compareValue.Max(a, b);

            MessageBox.Show(maxValue.ToString());


        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            if(txtMessage.Text.Length>0)
            {
      
                ExampleEventArgs eArg = new ExampleEventArgs();
                eArg.SendDate= DateTime.Now;
                eArg.SendMessage= txtMessage.Text;

                //now raise the event
                OnSendMessage(eArg);
            }
        }

        private void CreateInstanceExample<T>()
        {
            Type generic = typeof(T);
            var o = Activator.CreateInstance(generic);
            



        }

        private void button2_Click(object sender, EventArgs e)
        {
            //demos how to create an object instance of a 
            //generic type at runtime!
            CreateInstanceExample<Customer>();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this shows how to combine interfaces and generics
            //to create a flexible class

            GetName getName = new GetName();


            FootballPlayer footballPlayer = new FootballPlayer();
            footballPlayer.FirstName = "Tom";
            footballPlayer.LastName = "Brady";

            BasketBallPlayer basketBallPlayer = new BasketBallPlayer();
            basketBallPlayer.FirstName = "Lebron";
            basketBallPlayer.LastName = "James";

            string footballName = getName.GetValue<FootballPlayer>(footballPlayer);

            string basketBallName = getName.GetValue<BasketBallPlayer>(basketBallPlayer);



        }
    }
}
