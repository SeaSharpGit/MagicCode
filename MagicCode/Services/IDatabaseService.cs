﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicCode
{
    public interface IDatabaseService
    {
        string ConnectionString { get; set; }

        List<Table> GetTableModels(List<string> filterTables, List<string> baseFields);


    }
}
