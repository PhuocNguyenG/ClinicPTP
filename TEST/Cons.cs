using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    /// <summary>
    /// Lưu lại tham số cần dùng.
    /// </summary>
    public class Cons
    {
        // System
        public static int  screenWidth = 1200;
        public static int screenHeight = 666;

        public static bool isCloseProgram = false;


        //User
        public static int permission = 0;


        public static string temp = "";
        public static int AccountID = 0;
        public static string WorkingStatusId = "";

        public static string PatientId = "";
        public static DentalClinicDataContext dataContext = new DentalClinicDataContext();


        public static DateTime date = new DateTime();
        //Methods cons

        /// <summary>
        /// Random mã
        /// </summary>
        /// <returns></returns>
        public static string ranDomId()
        {
            string id = "";
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                if (random.Next(0, 2) == 1)
                {
                    int num = random.Next(65, 91);
                    id += (char)num;
                }
                else
                {
                    int num = random.Next(48, 58);
                    id += (char)num;
                }
            }
            return id;

        }

        
    }
}
