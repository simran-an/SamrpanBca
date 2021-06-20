using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamrpanBca
{
    class Persons
    {

        //declaration of variables used in class.
        int id;
        string name;
        string address;
        string profession;
        bool isActive;
        DateTime dob;     //builtin data type to hold date and time attributes

        //creating constructor
        public Persons(int ID, string name, string address, string profession, bool IsActive, DateTime DOB)
        {
            this.id = ID;              //this points to the current location/class ;  = _____ value from the constructor parameter
            this.name = name;
            this.address = address;
            this.profession = profession;
            this.isActive = IsActive;
            this.dob = DOB;
        }
        //default constructor
        public Persons()
        {

        }

        //c# Get and Set
        //setting attributes for class or class members
        public int Pid
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Pname
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Paddress
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        public string Pprofession
        {
            get { return profession; }
            set
            {
                profession = value;
            }
        }
        public bool PisActive
        {
            get
            {
                return isActive;
            }
            set
            {
                isActive = value;
            }
        }
        public DateTime DOB
        {
            get
            {
                return dob;
            }
            set
            {
                dob = value;
            }
        }

        //List of Type Person: personList
        public IList<Persons> GetAllPersons()
        {

            List<Persons> personList = new List<Persons> {
                new Persons
                {

                id=1,
                name = "simran shrestha",
                profession= "software engineer",
                address = "kapan",
                isActive =true,
                dob = new DateTime(2057,08,06),
                },
                new Persons
                {

                id=1,
                name = "sandesh thapa",
                profession= "designer",
                address = "mulpani",
                isActive =true,
                dob = new DateTime(2057,10,06),
                },
                new Persons
                {

                id=1,
                name = "simran shrestha",
                profession= "software engineer",
                address = "kapan",
                isActive =true,
                dob = new DateTime(2057,08,06),
                },
                };
            return personList.ToList();


        }
    }
}

