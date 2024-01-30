﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteContracts
{
    public class Note
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }

        public int Priority { get; set; }
    }
}