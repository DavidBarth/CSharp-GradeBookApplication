﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name): base(name)
        {
            GradeBookType = Enums.GradeBookType.Ranked;
        }
    }
}
