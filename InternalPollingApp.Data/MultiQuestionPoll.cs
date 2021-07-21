﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternalPollingApp.Data
{
    public class MultiQuestionPoll
    {
        [Key]
        public int MultiQuestionId { get; set; }
        public string Question { get; set; }
        [Required]
        public string Response { get; set; }
    }
}
