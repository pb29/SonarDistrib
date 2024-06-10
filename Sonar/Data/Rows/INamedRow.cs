﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonar.Data.Rows
{
    public interface INamedRow : IDataRow
    {
        public string Name { get; }
    }
}
