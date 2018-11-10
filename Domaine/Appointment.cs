using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine
{
    class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }
        [Display(Name = "Date")]
        public DateTime Date { get; set; }

        [Display(Name = "Date de naissance")]
        public DateTime startHour { get; set; }

        public state state { get; set; }
        public Patient patient { get; set; }
        public Doctor doctor { get; set; }
    }
}
