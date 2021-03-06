﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Teshe.Models
{
    public class StoppageModifyRecord
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("修改内容")]
        public String Content { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime ModifyTime { get; set; }

        [JsonIgnore]
        [DisplayName("报废")]
        public virtual Stoppage Stoppage { get; set; }
    }
}