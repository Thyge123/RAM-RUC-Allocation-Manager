﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RAM___RUC_Allocation_Manager.Models
{
    public class GroupTeachingVT
    {

        #region Properties
        public int ID { get; set; }
        public string Name { get; set; }
        public int HoursLength { get; set; }
        #endregion

        #region Constructors
        public GroupTeachingVT() { }
        #endregion

        #region Methods

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override string ToString()
        {
            return base.ToString();
        }

        #endregion

    }
}
