﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IntexAzure.Models
{
    [Table("TestEmployees")]
    public class TestEmployees
    {
        public int EmployeeID { get; set; }

        public int CompoundTestID { get; set; }



    }
}