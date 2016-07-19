using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET._1607.Day2.Task1.Suhov
{
    /// <summary>
    /// Class for abiturient with medal or diploma
    /// </summary>
    public class AbiturientDrive:Abiturient
    {
        /// <summary> 
        /// Default constructor, initialize variables with default values 
        /// </summary> 
        public AbiturientDrive() { }
        /// <summary> 
        /// Constructor with parameters, initialize variables with the parameters value 
        /// </summary> 
        public AbiturientDrive(string surname, int[] marks, AbiturientType type = AbiturientType.Default)
        {
            base.Surname = surname;
            base.Marks = marks;
            base.AverageMark = base.CalcAvgMark(marks) + (int)type;
        }
        /// <summary>
        /// Overrided method for adding new abiturient as abiturient with medal or diploma
        /// </summary>
        public override Abiturient AddAbiturient(string surname, int[] marks, AbiturientType type = AbiturientType.Default)
        {
            return new AbiturientDrive(surname, marks, type);
        }
        /// <summary>
        /// New method for adding new abiturient as abiturient with medal or diploma
        /// </summary>
        public new Abiturient AddAbiturientNoVirtual(string surname, int[] marks, AbiturientType type = AbiturientType.Default)
        {
            return new AbiturientDrive(surname, marks, type);
        }
    }

    public enum AbiturientType {
        Default =0,
        GoldMedal =2,
        SilverMedal =1,
        FirstDiplom =3,
        SecondDiplom =2,
        ThirdDiplom =1
    }

    public static class OutputType
    {
        public static AbiturientType GetType(int id) {
            switch (id) { 
                case 1: return AbiturientType.GoldMedal;
                case 2: return AbiturientType.SilverMedal;
                case 3: return AbiturientType.FirstDiplom;
                case 4: return AbiturientType.SecondDiplom;
                case 5: return AbiturientType.ThirdDiplom;
                default: return AbiturientType.Default;
            }
        }
    }

}
