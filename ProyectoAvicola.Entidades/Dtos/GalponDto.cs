﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAvicola.Entidades.Dtos
{
    public class GalponDto : ICloneable
    {
        [DisplayName("N° Galpon")]
        public int GalponId { get; set; }
        [DisplayName("Granja")]
        public string NombreGranja { get; set; }
        [DisplayName("Capacidad")]
        public int Capacidad { get; set; }
        public string  NombreGalpon { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone(); 
        }
    }
}
