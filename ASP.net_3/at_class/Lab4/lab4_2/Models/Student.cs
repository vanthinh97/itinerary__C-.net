using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lab4_2.Models
{
    //public enum Gender { Male, Female, Other }
    public class Student
    {
        [DisplayName("Ma Sinh Vien")]
        public int Id { get; set; }

        [DisplayName("Mat khau"), DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("Ho va ten")]
        public string FullName { get; set; }

        [DisplayName("Gioi tinh")]
        public bool Gender { get; set; }

        [DisplayName("Ngay sinh")]
        public DateTime BirthDay { get; set; }

        [DisplayName("Ghi chu"), DataType(DataType.MultilineText)]
        public string Notes { get; set; }
    }
}