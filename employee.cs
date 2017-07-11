using System;
using System.Collections.Generic;

namespace classes
{

    public class Employee{

        public string Name;
        public string Title;
        public DateTime JoinDate;

        
        public Employee(string name, string title, DateTime doj){
              Name=name;
              Title=title;
              JoinDate=doj;
          }
    }
}