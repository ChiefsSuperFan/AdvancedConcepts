using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedConcepts.Classes
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public String City { get; set; }
        public USStateCodes State { get; set; }
        public string ZipCode { get; set; }




    }

    public enum USStateCodes
    {
        AL,
        AK,
        AZ,
        AR,
        CA,
        CO
    }

    public class BasketBallPlayer:IAthlete
    {
        public string TeamName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float Salary { get; set; }
        public SportType Sport { get; set; } = SportType.Basketball;

        public BasketBallPlayer()
        {

        }
        public void ChangeTeam(string newTeam)
        {
            TeamName = newTeam;
        }

    }

    public class BaseballPlayer:IAthlete
    {
        public string TeamName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float Salary { get; set; }
        public SportType Sport { get; set; } = SportType.Basketball;
   

        public BaseballPlayer()
        {

        }
        public void ChangeTeam(string newTeam)
        {
            TeamName = newTeam;
        }

    }
    public class FootballPlayer:IAthlete
    {
        public string TeamName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float Salary { get; set; }
        public SportType Sport { get; set; } = SportType.Football;
     

        public  FootballPlayer()
        {
          
        }
        public void ChangeTeam(string newTeam)
        {
            TeamName = newTeam;
        }


    }

    public interface IAthlete
    {
        string TeamName { get; set; }
        string FirstName { get; set; }
        string LastName { get; set;  }
        float Salary { get; set; }
        SportType Sport { get; set; }
        void ChangeTeam(string newTeam);




    }

    public enum FootballPositions
    {
        QB,
        RB,
        C,
        G,
        OT,  
        TE,
        WR,
        DE,
        DT,
        NT,
        LB,
        SS,
        FS,
        CB,
        P,
        K
    }
    public enum SportType
    {
        Baseball,
        Football,
        Basketball,
        Soccer
    }


    public class GetName
    {

        public GetName()
        {


        }


        //This takes a generic type.  the Where clause restricts
        //the input parameter to objects that implement the IAthlete 
        //interface
        public string GetValue<T>(T athleteObject) where T:IAthlete
        {

            string nameFirst = athleteObject.FirstName;
            string nameLast = athleteObject.LastName;

            return nameFirst + " " + nameLast;

        }

       

    }

    //this is an extension method for the int class
    //as a practice name these <ClassName>Extension
    //these must be static classes
    //you write these for sealed classes
    public static class IntExtension
    {
       public static TSQLIntegerTypes GetSQLType(this int intValue)
        {
            if(intValue >= 0 && intValue<= 255)
            {
                return TSQLIntegerTypes.TinyInt;
            }

            if(intValue>=-32676 && intValue<=32767)
            {
                return TSQLIntegerTypes.SmallInt;
            }

            return TSQLIntegerTypes.Int;

            
        }
    }

    public enum TSQLIntegerTypes
    {
        TinyInt,
        SmallInt,
        Int,
        BigInt
    }
}
