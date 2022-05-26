﻿using System.ComponentModel.DataAnnotations;

namespace Catalog.Dtos
{
    public record CreateItemDto
    {
        [Required] 
        public string Name { get; init; }
        
        [Required] 
        [Range(1,100000)]
        public decimal Price { get; init; }

    }
}