using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace StudentMvcApp.Data.Models;

public partial class Student
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Age { get; set; }

    public string Course { get; set; } = null!;
}
