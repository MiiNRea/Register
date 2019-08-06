using System;
using System.ComponentModel.DataAnnotations;

namespace regist.Models{
    public class Member{
        [Key]
        public int id {get; set;}
        public string fname {get; set;}
        public string lname {get; set;}
        public int age {get; set;}
    }
}