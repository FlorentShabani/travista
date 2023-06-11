﻿namespace Travista.Models.Domain;

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

public class Destination
{
    [Key]
    public int ID_Destination { get; set; }

    [Required]
    [StringLength(50)]
    public string Emri { get; set; }

    [StringLength(1000)]
    public string Description { get; set; }

    [Required]
    [StringLength(100)]
    public string Address { get; set; }

    [StringLength(50)]
    public string AdditionalAddress { get; set; }

    [Required]
    public string Longitude { get; set; }

    [Required]
    public string Latitude { get; set; }
    public string Foto { get; set; }

    [Required]
    public int ID_City { get; set; }

    [Required]
    public int ID_Users { get; set; }

        [ForeignKey("ID_Users")]
    public virtual User FK_Users { get; set; }

    [ForeignKey("ID_City")]
    public virtual City FK_City { get; set; }

}
