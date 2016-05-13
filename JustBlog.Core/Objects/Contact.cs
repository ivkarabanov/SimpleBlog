using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustBlog.Core.Objects
{
    public class Contact
    {   [Display(Name="Имя")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "e-mail")]
        [Required,EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Вебсайт")]
        [Url]
        public string Website { get; set; }

        [Display(Name = "Тема")]
        [Required]
        public string Subject { get; set; }

        [Display(Name = "Сообщение")]
        [Required]
        public string Body { get; set; }
    }
}
