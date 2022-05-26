﻿using System.ComponentModel.DataAnnotations;

namespace Catalog.Dtos
{
    public class UpdateItemDto
    {
        [Required] 
        public string Name { get; init; }
        
        [Required] 
        [Range(1,100000)]
        public decimal Price { get; init; }

    }
}