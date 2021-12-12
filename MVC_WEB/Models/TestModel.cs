using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_WEB.Models
{
    public class TestModel
    {

        public class StudentModel
        {
            public string Name { get; set; }

            public string Idnumber { get; set; }

            public string Mobile { get; set; }

            public bool Equals(StudentModel obj)
            {
                return Name == obj.Name
                    && Idnumber == obj.Idnumber
                    && Mobile == obj.Mobile;
            }
        }
    }
}
