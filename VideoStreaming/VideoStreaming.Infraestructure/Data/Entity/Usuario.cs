using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoStreaming.Infraestructure.Data.Entity.Contract;

namespace VideoStreaming.Infraestructure.Data.Entity
{
    [Table("Usuario")]
    public class Usuario : EntityBase
    {

        public Usuario() : base()
        {
        }

        [Required(ErrorMessageResourceName = "Usuario_UserName_Required")]
        [StringLength(40, ErrorMessageResourceName = "Usuario_UserName_StringLength", MinimumLength = 1)]
        public string UserName { get; set; }

        [Required(ErrorMessageResourceName = "Usuario_Password_Required")]
        [StringLength(255, ErrorMessageResourceName = "Usuario_Password_StringLength", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessageResourceName = "Usuario_ConfirmPassword_Required")]
        [StringLength(255, ErrorMessageResourceName = "Usario_ConfirmPassword_StringLength", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

    }
}
