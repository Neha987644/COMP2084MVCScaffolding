using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeInfo.Web.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int DesignationId { get; set; }
        [Display(Name ="Date Of Birth")]
        public DateTime EmployeeDoB { get; set; }
        [Display(Name = "Employee Email")]
        public string EmployeeEmail { get; set; }
    }
}
