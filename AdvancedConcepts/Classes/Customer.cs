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
        public int PlayerID { get; set; }
        public string TeamName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }
        public SportType Sport { get;  set; } = SportType.Basketball;
        public DateTime? BirthDay { get; set; }

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
        public int PlayerID { get; set; }
        public string TeamName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }
        public SportType Sport { get; set; } = SportType.Basketball;
        public DateTime? BirthDay { get; set; }


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
        public int PlayerID { get; set; }
        public string TeamName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }
        public SportType Sport { get; set; } = SportType.Football;
        public DateTime? BirthDay { get; set; }
     

        public  FootballPlayer()
        {
          
        }
        public FootballPlayer(int playerID, string teamName, string firstName, string lastName, 
            int salary)
        {
            PlayerID = playerID;
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            TeamName = teamName;
        }
        public void ChangeTeam(string newTeam)
        {
            TeamName = newTeam;
        }


    }

    public interface IAthlete
    {
         int PlayerID { get; set; }
        string TeamName { get; set; }
        string FirstName { get; set; }
        string LastName { get; set;  }
        int Salary { get; set; }
        SportType Sport { get;  set; }

        //nullable type
        DateTime? BirthDay { get; set; }
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
