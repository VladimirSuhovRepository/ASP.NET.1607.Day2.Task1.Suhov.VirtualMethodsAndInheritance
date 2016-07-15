using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET._1607.Day2.Task1.Suhov
{
    public class Abiturient
    {
        private string _surname;
        private int[] _marks;
        private int _averageMark;
        
        public string Surname { get { return _surname; } set { _surname = value; } }
        public int AverageMark { get { return _averageMark; } set { _averageMark = value; } }
        public int[] Marks { get { return _marks; } set { _marks = value; } }
        public string Output { get { return $"Surname: {_surname}, Average mark: {_averageMark}"; } }
        public Abiturient() { }
        public Abiturient(string surname, int[] marks)
        {
            _surname = surname;
            _marks = marks;
            _averageMark = CalcAvgMark(marks);
        }
        public virtual Abiturient AddAbiturient(string surname, int[] marks, AbiturientType type = AbiturientType.Default)
        {
            return new Abiturient(surname, marks);
        }

        public Abiturient AddAbiturientNoVirtual(string surname, int[] marks, AbiturientType type = AbiturientType.Default)
        {
            return new Abiturient(surname, marks);
        }
        protected int CalcAvgMark(int[] marks) {
            int result=0;
            for (int i = 0; i < marks.Length; i++) {
                result = result + marks[i];
            }
            return result / marks.Count();
        }
    }
}
