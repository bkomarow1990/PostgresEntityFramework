using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postgres.Entities
{
    public class People
    {
        public Guid Id { get; set; }
        [Required, MaxLength(500)]
        public string Name { get; set; }
        public DateTime AddingDate { get; set; } = DateTime.Now;
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Telegram { get; set; }
        public string Viber { get; set; }
        public string WhatsApp { get; set; }
        public string Site { get; set; }
        public Guid? CategoryId { get; set; }
        public Guid? CompanyTypeId { get; set; }
        public string Skype { get; set; }
        //Navigation properties
        public virtual Category Category { get; set; }
        public virtual CompanyType CompanyType { get; set; }

    }
}
