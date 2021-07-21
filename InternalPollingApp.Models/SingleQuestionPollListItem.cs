using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternalPollingApp.Models
{
    public class SingleQuestionPollListItem
    {
        public int SingleQuestionId { get; set; }
        public string Question { get; set; }
        public string Response { get; set; }
    }
}
