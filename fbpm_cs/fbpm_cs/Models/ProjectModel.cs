using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;


namespace fbpm_cs.Models
{
    public class ProjectDetailModel
    {
        [Required]
        [Display(Name = "Project ID")]
        public string ProjectID { get; set; }

        [Required]
        [Display(Name = "Project name")]
        public string ProjectName { get; set; }

        [Required]
        [Display(Name = "Blocks")]
        public int NoOfBlocks { get; set; }

        [Required]
        [Display(Name = "Floors")]
        public int NoOfFloors { get; set; }

        [Required]
        [Display(Name = "Flats")]
        public int NoOfFlats { get; set; }

        [Display(Name = "Amenities")]
        public string Amenities { get; set; }
    }

    public class ProjectScheduleModel
    {
        [Required]
        [Display(Name = "Schedule ID")]
        public string ScheduleID { get; set; }

        [Required]
        [Display(Name = "Project ID")]
        public string ProjectID { get; set; }

        [Required]
        [Display(Name = "Schedule Desc")]
        public string ScheduleDesc { get; set; }

        [Required]
        [Display(Name = "Schedule Date")]
        public DateTime ScheduleDate { get; set; }

        [Required]
        [Display(Name = "Schedule Percentage")]
        public int SchedulePercent { get; set; }
    }
}