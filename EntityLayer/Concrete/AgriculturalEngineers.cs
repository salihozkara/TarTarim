﻿using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Concrete
{
    public class AgriculturalEngineers : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
    }
}
