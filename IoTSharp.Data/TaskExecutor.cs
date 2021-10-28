﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTSharp.Data
{
   public class TaskExecutor
    {
        [Key]
        public Guid ExecutorId { get; set; }
        public string ExecutorName { get; set; }
        public string ExecutorDesc { get; set; }
        public string Path { get; set; }
        public string TypeName { get; set; }
        public string DefaultConfig { get; set; }


        public int ExecutorStatus { get; set; }
        public DateTime AddDateTime { get; set; }
        public Guid Creator { get; set; }
    }
}
