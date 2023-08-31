using _8_EF_DataAnnotationAndFluentApi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_EF_DataAnnotationAndFluentApi.Contexts
{
    //Data Annotation, model sınıflarımızın üzerine yerleştirdiğimiz niteliklerdir. Bu nitelikler veri tabanı tablo ve sütun yapılarını 
    //belirlemek, uygulamak ve doğruluk kontrollerini yapmamızı sağlar
    public class Book
    {
        [Key]   //öz nitelikler
        public int BookId { get; set; }

        [Required]
        [MaxLength(50)]
        //[StringLength(50)] -- nesne tarafında kontrol gerçekleştirilir
        public string BookName { get; set; }

        //[Required(ErrorMessage ="*")]
        [Column("ClmBookSubject",Order =2,TypeName ="nvarchar(50)")]
        public string BookSubject { get; set; }

        [ForeignKey("Author")]
        public int AuthorFKId { get; set; }
        
        /*Bir kullanıcı veriyi alırken(okurken) başka bir kullanıcı tarafından bu veri değiştirildiyse veya kaydedildiyse, veriyi kaydetmeye
         * çalışan kullanıcıya bir hata bildirir
         */
        [ConcurrencyCheck] //eş zamanlı kontrol. sepete eklemiştir ama almamıştır o zaman stockta tutucam
        public int BookStock { get; set; }

        public Author Author { get; set; }
    }
}
