using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class model
    {
        [DisplayName("id")]
        public string id { get; set; }

        [DisplayName("баланс игрока")]
        public string balance { get; set; }

        [DisplayName("Имя игрока")]
        public string igrokname { get; set; }

        [DisplayName("Название букмекерской конторы")]
        public string bk { get; set; }

        [DisplayName("Дата")]
        [DataType(DataType.Date)]
        public DateTime date { get; set; }

        [DisplayName("Номер телефона")]
        public string PhoneNumber { get; set; }
    }

}