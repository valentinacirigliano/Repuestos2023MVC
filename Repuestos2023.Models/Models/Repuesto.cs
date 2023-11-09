﻿using System.ComponentModel.DataAnnotations;

namespace Repuestos2023.Models.Models
{
    public class Repuesto
    {
        public int RepuestoId { get; set; }
        [Required]
        [StringLength(250, ErrorMessage = "Must be between {2} and {1}", MinimumLength = 10)]
        public string Descripcion { get; set; }

        [Required]
        [Range(1, 10000)]
        [Display(Name = "List Price")]
        public double PrecioLista { get; set; }

        [Required]
        [Range(1, 10000)]
        [Display(Name = "Price for 1-50")]
        public double PrecioUnitario { get; set; }


        [Required]
        [Range(1, 10000)]
        [Display(Name = "Price for 51-100")]
        public double Precio50 { get; set; }

        [Required]
        [Display(Name = "Price for 100+")]
        [Range(1, 10000)]
        public double Precio100 { get; set; }
        [Display(Name = "Image")]

        public int Stock { get; set; }


        //[ValidateNever]

        public string Imagen { get; set; }

        [Required]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        //[ValidateNever]

        public Categoria Categoria { get; set; }
    }
}
