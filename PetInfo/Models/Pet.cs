using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace PetInfo.Models
{
    public class Pet
    {
        [Key]
        [Column(TypeName = "int")]
        public int PetId { get; set; }

        [Required]
        [Column(TypeName ="varchar(50)")]
        [DisplayName("Name")]
        public String Name { get; set; }

        //[Required]
        [Column(TypeName = "int")]
        [DisplayName("Age")]
        public int Age { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [DisplayName("Color")]
        public String Color { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [DisplayName("Gender")]
        public String Gender { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [DisplayName("Pet Owner Name")] 
        public String OwnerName { get; set; }


        [Required]
        [Column(TypeName = "varchar(50)")]
        [DisplayName("Address")]
        public String Address { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Image Name")]
        public string ImageName { get; set; }

        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ImageFile { get; set; }

        [Column(TypeName = "int")]
        public int Price { get; set; }

    }
}
