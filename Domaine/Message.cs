using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    class Message
    {
        [Key]
        public int MessageId { get; set; }
        public String Sender { get; set; }
        public DateTime TimeSend { get; set; }
        public String message { get; set; }
        public Disscussion discussion { get; set; }
    }
}
