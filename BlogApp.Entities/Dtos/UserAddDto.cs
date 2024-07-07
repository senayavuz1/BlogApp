﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Entities.Dtos
{
    public class UserAddDto
    {
        [DisplayName("Kullanıcı Adı")]
        [Required(ErrorMessage = "{0} boş geçilemez.")]
        [MaxLength(50, ErrorMessage = "{0} {1} karakterden büyük olamaz.")]
        [MinLength(3, ErrorMessage = "{0} {1} karakterden küçük olamaz.")]
        public string UserName { get; set; }

        [DisplayName("E-Mail Adresi")]
        [Required(ErrorMessage = "{0} boş geçilemez.")]
        [MaxLength(100, ErrorMessage = "{0} {1} karakterden büyük olamaz.")]
        [MinLength(10, ErrorMessage = "{0} {1} karakterden küçük olamaz.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DisplayName("Şifre")]
        [Required(ErrorMessage = "{0} boş geçilemez.")]
        [MaxLength(30, ErrorMessage = "{0} {1} karakterden büyük olamaz.")]
        [MinLength(5, ErrorMessage = "{0} {1} karakterden küçük olamaz.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("Telefon Numarası")]
        [Required(ErrorMessage = "{0} boş geçilemez.")]
        [MaxLength(13, ErrorMessage = "{0} {1} karakterden büyük olamaz.")] // +905551231223 -- 13 characters
        [MinLength(13, ErrorMessage = "{0} {1} karakterden küçük olamaz.")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [DisplayName("Fotoğraf")]
        [Required(ErrorMessage = "Lütfen, bir {0} seçiniz.")]
        [DataType(DataType.Upload)]
        public IFormFile PictureFile { get; set; }

        public string Picture { get; set; }


    }
}
