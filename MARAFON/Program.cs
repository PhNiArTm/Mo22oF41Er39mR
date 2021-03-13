using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MARAFON
{
    static class Program
    {
        public static MySqlConnection connection = new MySqlConnection("server=" +
            "141.8.192.26;" +
            "user=a0521760_users;" +
            "database=a0521760_practicke;" +
            "password=PR02022002");
        public static User userInfo = new User();
        public static MySqlDataReader sqlDataReader = null;

        //Общая главная форма для избежания создания дубликатов
        public static Form formMain;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formMain = new FormMain();
            Application.Run(formMain);
        }
        public static void UserInfoClear()
        {
            userInfo.checkIsRegisterOnMarafon = false;
            userInfo.CountryCode = null;
            userInfo.CountryName = null;
            userInfo.Gender = null;
            userInfo.Email = null;
            userInfo.FirstName = null;
            userInfo.LastName = null;
            userInfo.Password = null;
            userInfo.RoleId = null;
            userInfo.RunnerId = 0;
        }
    }
}
