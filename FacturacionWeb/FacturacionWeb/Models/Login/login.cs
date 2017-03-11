using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FacturacionWeb.Models.Login
{
    public class login
    {
        public class Login
        {
            [Required]
            public string usuario { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string contrasena
            {
                get; set;
            }
        }
        public class Register
        {
            [Required]
            [Display(Name = "Nombre")]
            public string nombre { get; set; }
            [Required]
            [Display(Name = "Apellido")]
            public string apellido { get; set; }
            [Required]
            [Display(Name = "Usuario")]
            public string usuario { get; set; }
            [Required]
            [Display(Name = "Contraseña")]
            [DataType(DataType.Password)]
            [StringLength(250, ErrorMessage = "La contraseña no puede estar vacia", MinimumLength = 6)]
            public string contrasena { get; set; }
            [Required]
            [Display(Name = "Confirmar")]
            [CompareAttribute("contrasena", ErrorMessage = "La contraseña y la confirmación no coinciden")]
            public string confirmarcontrasena { get; set; }
            [Required]
            [Display(Name = "Nombre Empresa")]
            [StringLength(250, ErrorMessage = "La empresa no puede estar vacia", MinimumLength = 6)]
            public string empresa { get; set; }
            [Required]
            [Display(Name = "Nombre Corto")]
            [StringLength(15, ErrorMessage = "El nombre corto no puede estar vacio", MinimumLength = 5)]
            public string nombrecorto { get; set; }
            [Required]
            [Display(Name = "RFC")]
            [StringLength(250, ErrorMessage = "El RFC no puede estar vacio", MinimumLength = 6)]
            public string rfc { get; set; }
            [Required]
            [Display(Name = "Domicilio")]
            [StringLength(250, ErrorMessage = "El domicilio no puede estar vacio", MinimumLength = 6)]
            public string domicilio { get; set; }
            [Required]
            [Display(Name = "No Int")]
            [StringLength(250, ErrorMessage = "El numeor interior no puede estar vacio", MinimumLength = 6)]
            public string noint { get; set; }

            [Display(Name = "No Ext")]
            public string noext { get; set; }
            [Required]
            [Display(Name = "CP")]
            [StringLength(250, ErrorMessage = "El cp no puede estar vacio", MinimumLength = 6)]
            public string cp { get; set; }
            [Required]
            [Display(Name = "Colonia")]
            [StringLength(250, ErrorMessage = "La colonia no puede estar vacia", MinimumLength = 6)]
            public string col { get; set; }
            [Required]
            [Display(Name = "Telefono")]
            [DataType(DataType.PhoneNumber)]
            [StringLength(250, ErrorMessage = "El telefono no puede estar vacio", MinimumLength = 6)]
            public string tel { get; set; }
            [Required]
            [EmailAddress]
            [Display(Name = "Correo Electronico")]
            public string email { get; set; }
        }

        public class BigViewModel
        {
            public Login Login { get; set; }
            public Register Register { get; set; }
            public Recuperar Recuperar { get; set; }
        }

        public class Recuperar
        {
            public string email { get; set; }
            public string usuario { get; set; }
        }

    }
    //[Table("user_account", Schema = "public")]
    public class UserAccount
    {
        public virtual int user_account_id { get; set; }
        public virtual int tenant_id { get; set; }
        public virtual string user_name { get; set; }
        public virtual string password { get; set; }
        public virtual bool is_active { get; set; }
        public virtual bool is_locked_out { get; set; }
        public virtual bool is_disabled { get; set; }
        public virtual bool is_system { get; set; }
        public virtual DateTime last_activity_date { get; set; }
        public virtual int user_account_settings_id { get; set; }
        public virtual int user_role_id { get; set; }
        public virtual string first_name { get; set; }
        public virtual string last_name { get; set; }
        public virtual string name { get; set; }
        public virtual string email { get; set; }
        public virtual bool restrict_access_from_ip { get; set; }
        public virtual string authorized_ips { get; set; }

    }

    public class RegisterAccount
    {
        public virtual int id { get; set; }
        //public virtual string Nombre { get; set; }
        //public virtual string Apellido { get; set; }
        public virtual int IdUserAccount { get; set; }
        public virtual string NombreEmpresa { get; set; }
        public virtual string NombreCorto { get; set; }
        public virtual string Domicilio { get; set; }
        public virtual string RFC { get; set; }
        public virtual string NoInt { get; set; }
        public virtual string NoExt { get; set; }
        public virtual int CP { get; set; }
        public virtual string Col { get; set; }
        public virtual string Tel { get; set; }
        public virtual string Email { get; set; }
        public virtual bool Activo { get; set; }

    }

    public class Tenants
    {
        public virtual int tenant_id { get; set; }
        public virtual string code { get; set; }
        public virtual string name { get; set; }
        public virtual string access_key { get; set; }
        public virtual string access_secret { get; set; }
        public virtual string status { get; set; }
    }
}
