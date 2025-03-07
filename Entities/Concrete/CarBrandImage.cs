﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class CarBrandImage : IEntity
    {
        [Key]
        public int Id { get; set; }
        public int BrandId { get; set; }
        public string ImagePath { get; set; }
        public DateTime Date { get; set; }
    }
}
