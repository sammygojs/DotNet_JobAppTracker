using System;
using System.ComponentModel.DataAnnotations;

public class JobApplication
{
    public int Id { get; set; }
    
    [Required]
    public string ResumeName { get; set; }
    
    [Required]
    public string Role { get; set; }
    
    [Required]
    public string Company { get; set; }
    
    [Required]
    public string JobLink { get; set; }
    
    public DateTime ApplicationDate { get; set; }
    
    public string Status { get; set; } // Applied, In Progress, GG
}
