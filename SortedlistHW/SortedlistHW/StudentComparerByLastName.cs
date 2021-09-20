using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedlistHW
{
    public class StudentComparerByLastName: IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            if (y.LastName == x.LastName)
            {
                return -1;
            }
            return y.LastName.CompareTo(x.LastName);
        }
    }
}
