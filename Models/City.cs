using System.ComponentModel.DataAnnotations.Schema;

namespace GoContactDotNet.Models;

[Table("city")]
public class City
{
    [Column("city_id")]
    public int ID { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("state")]
    public string? State { get; set; }
}