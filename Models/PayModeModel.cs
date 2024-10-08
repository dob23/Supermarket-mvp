using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Supermarket_mvp.Models
{
    internal class PayModeModel
    {
        [DisplayName("Pay Mode Id")]
        public int Id { get; set; }
        [DisplayName("Pay Mode Name")]
        [Required(ErrorMessage = "Pay Mode Name is Required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Pay Mode name must be between 3 and 50 characteres")]
        public string Name { get; set; }
        [DisplayName("Observation")]
        [Required(ErrorMessage = "Pay Mode Observation is Required")]
        [StringLength(200, MinimumLength =3 , ErrorMessage ="Pay Mode Observation must be between 3 and 200 characteres")]
        public string Observation { get; set; }

        public PayModeModel(int id, string name, string observation)
        {
            Id = id;
            Name = name;
            Observation = observation;
        }
    }
}
