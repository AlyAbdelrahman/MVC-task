namespace MyWebApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        //[Key]
        //[Column(Order = 0)]
        public int id { get; set; }

        //[Key]
        //[Column(Order = 1)]
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public Gender? Gender { get; set; }
        //[Key]
        //[Column(Order = 2)]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Salary { get; set; }
        [ForeignKey("Department")]
        public int fk_DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
