using System.Collections.Generic;

namespace SortedlistHW
{
    class StudentComparerByFirstName:IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            if (y.FirstName == x.FirstName)
            {
                return -1;
            }
            return y.FirstName.CompareTo(x.FirstName);
        }
    }
}
