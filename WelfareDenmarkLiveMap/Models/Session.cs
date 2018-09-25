using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WelfareDenmarkLiveMap.Models
{
    public class Session
    {
        public int ID { get; set; }
        public int completionRate { get; set; }
        public DateTime time { get; set; }
        public int patientID { get; set; }
    }
}
