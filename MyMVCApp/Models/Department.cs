using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;


namespace MyMVCApp.Models
{
    [Table("tblDepartment")]
    public class Department
    {
        public int ID { get; set; }
        public String Name { get; set; }

        public String Type { get; set; }
        public List<Employee> Employees { get; set; }


    }
}
