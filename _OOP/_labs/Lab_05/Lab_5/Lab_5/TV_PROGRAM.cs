using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace LAB_4
{
    public abstract partial class TV_program
    {
        public string _YearOfIssue;
        public string _duraTION;
        public string _country;

        public abstract void yearOfIssue(string time);
        public abstract void duration(string dur);
        public abstract void country(string country);

     }

    public abstract partial class TV_program
    {
        public enum AllTypesOfProgram
        {
            Advertising,
            Art_films,
            Cartoons,
            Film,
            News
        }

        public struct DopInformation
        {
            public string StarttimeOfProgram;
            public string EndtimeOfProgram;
            public string CostOfProgram;
        }
    }
}