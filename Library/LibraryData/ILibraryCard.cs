﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryData
{
    public interface ILibraryCard
    {
        IEnumerable<ILibraryCard> GetAll();
    }
}
