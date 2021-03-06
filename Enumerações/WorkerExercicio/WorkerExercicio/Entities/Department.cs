using System;
using System.Collections.Generic;
using System.Text;

namespace WorkerExercicio.Entities
{
    class Department
    {
        public string DepartmentName { get; set; }

        public Department()
        {

        }
        public Department(string name)
        {
            DepartmentName = name;
        }
    }
}
