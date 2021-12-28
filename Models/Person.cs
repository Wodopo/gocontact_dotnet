using System.ComponentModel.DataAnnotations.Schema;

namespace GoContactDotNet.Models;

[Table("person")]
public class Person
{
    [Column("person_id")]
    public int ID { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("email")]
    public string? Email { get; set; }
}