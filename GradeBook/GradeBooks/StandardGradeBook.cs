using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    internal class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name): base(name)
        {
            GradeBookType = Enums.GradeBookType.Standard;
        }
    }
}
