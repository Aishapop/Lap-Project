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

        private static Form currentForm;
        private static bool isRunning = false;

        [STAThread]
        static void Main()
        {
            if (!isRunning)
            {
                isRunning = true; // Set the flag to indicate that the application is running
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                FormUtils.OpenForm(new Firstpage());
                Application.Run();
                isRunning = false; // Reset the flag when the application is closed
            }
            /*
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            OpenForm(new Firstpage());
            Application.Run(new Firstpage());
            */

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

            /*
            Data data = new Data();

            User aisha = data.SelectUSerIfExist("Aisha123@gmail.com", "123");
            Console.WriteLine(aisha.ID+ " "+ aisha.Firstname);
            */
        }
        public static void OpenForm(Form form)
        {
            if (currentForm != null)
            {
                currentForm.Close();  // Close the current form if one is open
            }

            currentForm = form;  // Set the new form as the current form
            form.FormClosed += (sender, e) => currentForm = null;  // Clear the current form reference when it's closed
            form.Show();  // Show the new form
        }
    }
    public static class FormUtils
    {
        public static void OpenForm(Form form)
        {
            Program.OpenForm(form);  // Call the OpenForm function from Program class
        }
    }
}
