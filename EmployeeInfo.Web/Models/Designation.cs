using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeInfo.Web.Models
{
    public class Designation
    {

        [Key]
        public string DesignationId { get; set; }

        public string DesignationName { get; set; }
        public string DesignationDescription { get; set; }

    }
}
