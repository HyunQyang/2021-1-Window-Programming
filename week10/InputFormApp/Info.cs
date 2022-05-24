using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputFormApp
{
   public class Info
    {
        string name;
        int age;
        string gender;
        int year;
        int month;
        int day;
        string favorite = "";
        
        public Info(string name, int age, string gender, int year,int month, int day,string favorite)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.month = month;
            this.day = day;
            this.favorite = favorite;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }
        public int Age 
        {
            get
            {
                return age;
            }
            set
            {
                this.age = value;
            }
        }
        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                this.gender = value;
            }
        }
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                this.year = value;
            }
        }
        public int Month
        {
            get
            {
                return month;
            }
            set
            {
                this.month = value;
            }
        }
        public int Day
        {
            get
            {
                return day;
            }
            set
            {
                this.day = value;
            }
        }
        public string Favorite
        {
            get
            {
                return favorite;
            }
            set
            {
                this.favorite = value;
            }
        }
    }
}
