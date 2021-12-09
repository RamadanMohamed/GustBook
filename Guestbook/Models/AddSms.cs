using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Guestbook.Models
{
    public class AddSms
    {
        [Key]
        public int IdMs { get; set; }
        public string ContentMs { get; set; }
    }
}