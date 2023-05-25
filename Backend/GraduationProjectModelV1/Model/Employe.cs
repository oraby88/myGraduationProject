﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GraduationProjectModelV1.enums;


namespace GraduationProjectModelV1.Model
{
   public class Employe
    {
        public int Id { get; set; }
        [StringLength(70)]
        [Required(ErrorMessage ="please enter your name ")]
        public string Name { get; set; }

        [StringLength(15)]
        [Required(ErrorMessage = "please enter your phone ")]
        public string  Phone { get; set; }

        [Column(TypeName ="money")]
        [Required(ErrorMessage = "please enter your salary ")]

        public decimal Salary { get; set; }


        [StringLength(50)]
        [Required(ErrorMessage = "please enter your Job ")]
        public string Job { get; set; }

        [StringLength(70)]
        [Required(ErrorMessage = "please enter your Adress ")]
        public string Adress { get; set; }
        [Required(ErrorMessage = "please eenter your code ")]
        [Index(IsUnique = true)]
        [StringLength(100)]

        public string Code { get; set; }

        public EmployType EmployeType { get; set; }
        [Required(ErrorMessage = "please eenter yor user name ")]
        [Index(IsUnique = true)]
        [StringLength(100)]

        public string CasherUserName { get; set; }

        [Required(ErrorMessage = "please eenter yor user password ")]
        [Index(IsUnique = true)]
        [StringLength(100)]

        public string CasherPassword { get; set; }

        [ForeignKey("Admin")]
        public int Admin_Id { get; set; }
        public Admin Admin { get; set; }

    }
}
