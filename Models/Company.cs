using System.ComponentModel.DataAnnotations.Schema;

namespace GoContactDotNet.Models;

[Table("company")]
public class Company
{
    [Column("company_id")]
    public int ID { get; set; }

    [Column("name")]
    public string? Name { get; set; }
}