using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sol3
{
    class Contact
    {
        string name,company,cell,tel,mail;
        int age;



        public Contact(string name,int age,string company, string cell,string tel,string mail)
        {
            this.age = age; this.name = name; this.company = company; 
            this.cell = cell; this.tel = tel; this.mail = mail;

        }

        public override string ToString()
        {
            return "name: "+ name +",age:"+age+",company:"+company+",cell:"+cell+",tel:"+tel+",mail:"+mail;
        }
    }
}
