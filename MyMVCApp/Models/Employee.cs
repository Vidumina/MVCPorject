﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyMVCApp.Models
{
    [Table("tblEmployee")]
    public class Employee
    {

        public int EmployeeId { get; set; }

        public String Name { get; set; }
        public String Gender { get; set; }
        public String City { get; set; }
        public int DepartmentId { get; set; }




    }
}