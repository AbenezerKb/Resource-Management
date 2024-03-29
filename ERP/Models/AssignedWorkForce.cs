﻿
using ERP.DTOs;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.Models
{
    public class AssignedWorkForce
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int assigneWorkForceNo  { get; set; }
        public DateTime date { get; set; }
        public string projId { get; set; }
       // public string professionalName { get; set; }
        public IList<WorkForce> ProfessionWithWork { get; set; }
        public string remark { get; set; }

    }

    public class WorkForce
    {      
        public int WokrkForceID { get; set; }
        [Key]
        public int assigneWorkForceNo { get; set; }
        public int EmployeeId { get; set; }
    }
}
