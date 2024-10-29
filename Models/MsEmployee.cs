using System;
using System.ComponentModel.DataAnnotations;

namespace ITDIV.Models;

public class MsEmployee
{
    [Key]
    [MaxLength(36)]
    public string Employee_id { get; set; } 

    [MaxLength(200)]
    public string name { get; set; } 

    [MaxLength(4000)]
    public string position { get; set; } 

    [MaxLength(100)]
    public string email { get; set; } 

    [MaxLength(36)]
    public string phone_number { get; set; }
}