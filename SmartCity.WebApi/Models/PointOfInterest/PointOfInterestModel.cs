﻿using SmartCity.WebApi.Models.City;
using SmartCity.WebApi.Models.Coordinates;
using System;

namespace SmartCity.WebApi.Models.PointOfInterest
{
    public class PointOfInterestModel
    {
        public Guid Id { get; set; }

        public CoordinatesModel Coordinates { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsPrivate { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
