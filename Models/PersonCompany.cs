using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GoContactDotNet.Models;

[Keyless]
[Table("person_company")]
public class PersonCompany
{
    [Column("person_id")]
    public int PersonID { get; set; }

    [Column("company_id")]
    public int CompanyID { get; set; }
}