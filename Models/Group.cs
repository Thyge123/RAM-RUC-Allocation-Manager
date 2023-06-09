﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using RAM___RUC_Allocation_Manager.Models.DbConnections;

namespace RAM___RUC_Allocation_Manager.Models
{
    public class Group
    {

        #region Properties
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int RucId { get; set; }
        public bool IsMasterThesis { get; set; }
        public int MemberAmount { get; set; }
        public ICollection<EmployeeGroup> EmployeeGroups { get; set; } = new List<EmployeeGroup>();
        #endregion

        #region Methods

        #endregion

    }
}
