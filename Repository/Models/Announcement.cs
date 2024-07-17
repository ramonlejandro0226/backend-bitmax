using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BimexBackendWebApi.Repository.Models;

[Table("announcement")]
public partial class Announcement
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("title")]
    [StringLength(150)]
    public string? Title { get; set; }
}
