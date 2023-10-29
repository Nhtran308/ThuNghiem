using ThuNghiem.View;
using ThuNghiem.Utils;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ThuNghiem
{
    internal static class Program
    {

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DataHelper.server = "NHAT\\SQLEXPRESS";
            DataHelper.data = "QuanLyKho";
            DataHelper.uid = "NhatTran";
            DataHelper.password = "12345";

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmMenu());
        }
    }
}