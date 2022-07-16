using System.ComponentModel.DataAnnotations;

namespace FeverBeaver.Models;

public class Person
{
    public string Id { get; }
    [Required]
    [StringLength(16, ErrorMessage = "Name length can't be more than 16.")]
    public string? Name { get; set; }
    [Required]
    public int Age { get; set; }

    public Person()
    {
        Id = Guid.NewGuid().ToString();
    }
}