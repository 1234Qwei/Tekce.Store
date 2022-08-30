using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class LocationDto : BaseDto
    {
        public string Name { get; set; }
        public string Pid_Title { get; set; }
        public string Type_Title { get; set; }
        public LocationTypes Type { get; set; }

    }
}
