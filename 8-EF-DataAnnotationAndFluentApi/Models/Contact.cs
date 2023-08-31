using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_EF_DataAnnotationAndFluentApi.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //[DatabaseGenerated(DatabaseGeneratedOption.None)] //Hiçbir oto oluşturma veya değer belirleme yapılmasını ,istemiyoruz
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //bir kolonun identity olarak yönetilmesini sağlar
        public string Email { get; set; }
        public string Subject { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)] //Bir kolonun değerlerinin bir hesaplama veya ifade sonucunda oto olarak 
        //belirlenmesini sağlar
        public DateTime LastAccess { get; set; }

    }
}
