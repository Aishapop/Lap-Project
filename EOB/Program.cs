using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EOB
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            /*byte[] imageData = System.IO.File.ReadAllBytes("C:\\Users\\aisha\\Logo.png");


            User Omar = new User("school", "thuis", "777", "school@gmail.com", imageData);*/

            /*User lili = new User("lilim1", "O'Branm1", "ooo21", "ai1@gmail.com", imageData);
*/

            /*Account zichtrekening = new Account(Types.CurrentAccount, Omar);*/
            /*Account zichtrekening1 = new Account(Types.CurrentAccount, Omar);
            Account zichtrekening2 = new Account(Types.CurrentAccount, Omar);*/
            /*Account zichtrekening2 = new Account(Types.CurrentAccount, lili);*/

            /*Data data = new Data();
            data.UpdateUserToDeleted(Omar);*/
            /*data.EditUser(Omar, "Email", "Kristen@852.com");*/
            /*data.InsertAutomaticTransaction(zichtrekening, "2023-10-02", "2023-11-01", 100);*/

            /*Transaction tran = new Transaction(zichtrekening, zichtrekening2, 200);*/

            Data data = new Data();

            User aisha = data.SelectUSerIfExist("Aisha123@gmail.com", "123");
            Console.WriteLine(aisha.ID+ " "+ aisha.Firstname); ;











        }
    }
}
