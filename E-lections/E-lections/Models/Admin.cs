﻿using System;
using System.Collections.Generic;

namespace E_lections.Models
{

    public class Admin : IIzbor, IStranka
    {
        public int ID { get; set; }
        public string JMBG   { get; set; }
        public string Lozinka { get; set; }

        public IIzbor KreirajIzbor()
        {
            throw new NotImplementedException();
        }

        public void ObrisiIzbor(int id)
        {
            throw new NotImplementedException();
        }

        public Stranka KreirajStranku()
        {
            throw new NotImplementedException();
        }

        public void IzbrisiStranku()
        {
            throw new NotImplementedException();
        }
    }
}