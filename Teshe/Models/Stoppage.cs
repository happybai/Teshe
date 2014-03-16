﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Teshe.Models
{
    public class Stoppage
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("设备")]
        [Required(ErrorMessage = "设备不能为空")]
        public virtual Device Device { get; set; }

        [DisplayName("故障描述")]
        [Required(ErrorMessage = "故障描述不能为空")]
        public String Description { get; set; }

        [DisplayName("故障时间")]
        [Required(ErrorMessage = "故障时间不能为空")]
        public DateTime StoppageTime { get; set; }

        [DisplayName("维修人员")]
        [Required(ErrorMessage = "维修人员不能为空")]
        public String RepairPeople { get; set; }

        [DisplayName("维修时间")]
        [Required(ErrorMessage = "维修时间不能为空")]
        public DateTime RepairTime { get; set; }

        [DisplayName("备注")]
        public String Remarks { get; set; }

        [DisplayName("录入时间")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime InputTime { get; set; }

        [DisplayName("录入人员")]
        public virtual UserInfo UserInfo { get; set; }

    }
}