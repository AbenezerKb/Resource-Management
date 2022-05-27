﻿using System.ComponentModel.DataAnnotations;


namespace ERP.DTOs
{
    public class TimeCardCreateDto
    {
        [Required]
        public int id { get; set; }
        [Required]
        public DateTime dateOfWork { get; set; }
        [Required]
        public string employeeName { get; set; }
        [Required]
        public string jobType { get; set; }
        [Required]
        public int weekNo { get; set; }
        [Required]
        public int NoOfPresents { get; set; }
        [Required]
        public int NoOfAbscents { get; set; }
        [Required]
        public int NoOfHrsPerSession { get; set; }
        [Required]
        public int totalWorkedHrs { get; set; }
        [Required]
        public double wages { get; set; }
        [Required]
        public double totalPayment { get; set; }

        //FK
        [Required]
        public int preparedByFK { get; set; }

        //FK
        [Required]
        public int approvedBy { get; set; }

        //FK
        [Required]
        public int LaborerID { get; set; }
        [Required]
        public string remark { get; set; }
    }
}
