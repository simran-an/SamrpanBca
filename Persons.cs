﻿using System;
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
        DateTime dOB;     //builtin data type to hold date and time attributes

        //creating constructor
        public Persons(int ID, string name, string address, string profession, bool IsActive, DateTime DOB)
        {
            this.id = ID;              //this points to the current location/class ;  = _____ value from the constructor parameter
            this.name = name;
            this.address = address;
            this.profession = profession;
            this.isActive = IsActive;
            this.dOB = DOB;
        }

        //c# Get and Set
        //setting attributes for class or class members
        public string Pid { get; set; }
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
                return dOB;
            }
            set
            {
                dOB = value;
            }
        }
       
            //List of Type Person: personList
            List<Person> personList = new List<Person>();
        public IList<Person> GetAllPersons()
        {
                 personList.Add(new Person(
                "simran shrestha",
                20,
                "student",
                "kathmandu",
                new DateTime(2057-08- 06)
                )
                );
            return personList;



        }
    }
}

