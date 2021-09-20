using System.Collections.Generic;

namespace SortedlistHW
{
    public class StudentComparerByAge:IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            if(y.Age == x.Age)
            {
                return -1;
            }
            return y.Age.CompareTo(x.Age);
        }
    }
}
