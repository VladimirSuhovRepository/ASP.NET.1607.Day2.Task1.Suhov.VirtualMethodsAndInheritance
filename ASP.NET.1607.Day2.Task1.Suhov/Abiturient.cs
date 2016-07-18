using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET._1607.Day2.Task1.Suhov
{
    /// <summary>
    /// Class for average abiturient
    /// </summary>
    public class Abiturient
    {
        private string _surname;
        private int[] _marks;
        private int _averageMark;
        /// <summary>
        /// Surname for average abiturient
        /// </summary>
        public string Surname { get { return _surname; } set { _surname = value; } }
        /// <summary>
        /// Average mark for average abiturient
        /// </summary>
        public int AverageMark { get { return _averageMark; } set { _averageMark = value; } }
        /// <summary>
        /// All marks for average abiturient
        /// </summary>
        public int[] Marks { get { return _marks; } set { _marks = value; } }
        /// <summary>
        /// String for console output for average abiturient
        /// </summary>
        public string Output { get { return $"Surname: {_surname}, Average mark: {_averageMark}"; } }
        public Abiturient() { }
        public Abiturient(string surname, int[] marks)
        {
            _surname = surname;
            _marks = marks;
            _averageMark = CalcAvgMark(marks);
        }
        /// <summary>
        /// Virtual method for adding new abiturient as average abiturient
        /// </summary>
        public virtual Abiturient AddAbiturient(string surname, int[] marks, AbiturientType type = AbiturientType.Default)
        {
            return new Abiturient(surname, marks);
        }
        /// <summary>
        /// Non virtual method for adding new abiturient as average abiturient
        /// </summary>
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
