﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RAM___RUC_Allocation_Manager.Models.DbConnections
{
    public class EmployeeProgramme
    {
        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }
        public int ProgrammeId { get; set; }

        public Programme Programme { get; set; }
    }
}
