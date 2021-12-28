using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GoContactDotNet.Models;

[Keyless]
[Table("person_city")]
public class PersonCity
{
    [Column("person_id")]
    public int PersonID { get; set; }

    [Column("city_id")]
    public int CityID { get; set; }
}