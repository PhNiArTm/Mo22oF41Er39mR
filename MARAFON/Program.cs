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
        public static MARAFONEntities1 dateBases = new MARAFONEntities1();
        public static MySqlConnection connection = new MySqlConnection("server=" +
            "141.8.192.26;" +
            "user=a0521760_users;" +
            "database=a0521760_practicke;" +
            "password=PR02022002");
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormRegistrationConfirmation());
        }
    }
}
