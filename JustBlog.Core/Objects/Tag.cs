using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustBlog.Core.Objects
{
    public class Tag
    {
        public virtual int Id
        { get; set; }

        [Required(ErrorMessage ="Название: поле является обязательным") ]
        [StringLength(500,ErrorMessage ="Название: максимальная длина 500 символов")]
        public virtual string Name
        { get; set; }

        [Required(ErrorMessage = "UrlSlug: поле является обязательным")]
        [StringLength(500, ErrorMessage = "UrlSlug: максимальная длина 500 символов")]
        public virtual string UrlSlug
        { get; set; }

        public virtual string Description
        { get; set; }

        [JsonIgnore]
        public virtual IList<Post> Posts
        { get; set; }
    }
}
