﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartCity.WebApi.Models.PointOfInterest
{
    public class UpdatePointOfInterestModel : CreatePointOfInterestModel
    {
        public Guid Id { get; set; }
    }
}
