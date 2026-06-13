using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymSystem.DAL.Models
{
    public class HealthRecords : BaseEntity
    {
        public float Height { get; set; }
        public float Weight { get; set; }
        public string BloodType { get; set; }
        public string? Notes { get; set; }

        public Member Member { get; set; }
        public int MemberId { get; set; }

    }
}
