﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CompanyEmployee.Models
{
    public enum Gender
    {
        Male, Female
    }
    public class Employee
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Designation { get; set; }
        public Gender? Gender { get; set; }
        public long? PhoneNumber { get; set; }
        public float? HighSchoolPercentage { get; set; }
        public float? IntermediatePercentage { get; set; }
        public int? DepartmentId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }    
        public string State { get; set; }
        public string Country { get; set; }
        public bool Experienced { get; set; }
        public float? CTC { get; set; }
        public string LastCompany { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime JoiningDate { get; set; }
        public virtual Department Department { get; set; }
    }
}