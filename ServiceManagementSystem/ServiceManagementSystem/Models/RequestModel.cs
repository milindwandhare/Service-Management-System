using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;


namespace ServiceManagementSystem.Models
{
    public class RequestModel
    {
        public int RequestId { get; set; }

        [DisplayName("Department")]
        public int DepartmentId { get; set; }

        [DisplayName("Description")]
        public string RequestDescription { get; set; }
    }
}