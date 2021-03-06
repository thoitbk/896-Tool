﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _896_Tool
{
    class Person
    {
        public string Name { get; set; }
        public string DateOfBirth { get; set; }
        public bool Gender { get; set; }
        public string IdNumber { get; set; }
        public bool IsRegistered { get; set; }
    }

    class Household
    {
        public int HouseholdId { get; set; }
        public Person MainMember { get; set; }
        public List<Person> OtherMembers { get; set; }
        public int NumMembers { get; set; }
        public int NumRegistered { get; set; }
    }

    class DC02
    {
        public Person Member { get; set; }
        public List<String> Corrections { get; set; }
        public string Attachment { get; set; }
    }
}
