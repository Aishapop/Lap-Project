using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EOB
{
    public partial class AutomatischeOverschrijvingPage : Form
    {
        private string Email;
        private string Password;
        public AutomatischeOverschrijvingPage(string email, string password)
        {
            InitializeComponent();
            this.Email = email;
            this.Password = password;
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            FormUtils.OpenForm(new ClientMainPage(Email, Password));
        }

        private void BeginDateAutoOverschrij_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void EndDateAutoOverschrij_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TermijnDropDownMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BedragText_TextChanged(object sender, EventArgs e)
        {

        }

        private void OntvangersRekeningNR_TextChanged(object sender, EventArgs e)
        {

        }

        private void ToevoegenAutoOverschrButton_Click(object sender, EventArgs e)
        {
            if(ValidateInputs())
            {
                string rekeningNrText = OntvangersRekeningNR.Text.Replace("BE", "");
                int rekeningNr = Convert.ToInt32(rekeningNrText);
                string bedragtext = BedragText.Text.Replace("€", "");
                float bedrag = (float)Convert.ToDouble(bedragtext);
                string termijn = TermijnDropDownMenu.Text;
                DateTime beginDate = BeginDateAutoOverschrij.Value.Date;
                DateTime endDate = BeginDateAutoOverschrij.Value.Date;
                string formattedBeginDate = beginDate.ToString("yyyy-MM-dd");
                string formattedEndDate = endDate.ToString("yyyy-MM-dd");
                
                //              all de informatie gebruiken om een auto overschrijving te maken ***********
            }
        }
        private bool ValidateInputs()
        {
            DateTime beginDate = BeginDateAutoOverschrij.Value.Date;
            DateTime endDate = BeginDateAutoOverschrij.Value.Date;

            string mijnrekeningen = MijnRekeningenDropDown.Text;
            string termijn = TermijnDropDownMenu.Text;
            string rekeningNrText = OntvangersRekeningNR.Text.Replace("BE", "");
            string bedragtext = BedragText.Text.Replace("€", "");
            if (string.IsNullOrEmpty(rekeningNrText) || string.IsNullOrEmpty(bedragtext) || string.IsNullOrEmpty(mijnrekeningen) || string.IsNullOrEmpty(termijn))
            {
                MessageBox.Show("Please fill in all the fields!", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            foreach (var item in rekeningNrText)
            {
                if(!"1234567890".Contains(item))
                {
                    MessageBox.Show("Voer enkel nummers in dit veld in", "rekeningNr error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    OntvangersRekeningNR.Clear();
                    return false;                 
                }
            }     

            foreach (var item in bedragtext)
            {
                if (!"1234567890".Contains(item))
                {
                    MessageBox.Show("Voer enkel nummers in dit veld in", "bedrag error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    BedragText.Clear();
                    return false;
                }
            }

            if (beginDate > endDate)
            {
                MessageBox.Show("De datums kloppen niet", "Datum error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            if (termijn != "wekelijks" || termijn != "maandelijks" || termijn != "jaarlijks")
            {
                MessageBox.Show("Het ingevoerde termijn is geen optie", "Termijn error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void AutomatischeOverschrijving_Load(object sender, EventArgs e)
        {
            string connectionString =
            "datasource=127.0.0.1;" +
            "port=3306;" +
            "username=root;" +
            "password=root;" +
            "database=eob;";

            MySqlConnection connection = new MySqlConnection(connectionString);

            // Create a command to retrieve the data
            MySqlCommand command = new MySqlCommand("SELECT * FROM rekening", connection);

            // Create a data adapter to fill the dataset
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();

            try
            {
                connection.Open();
                // Fill the dataset
                adapter.Fill(dataTable);

                // Get the users id
                Data data = new Data();
                User user = data.SelectUSerIfExist(Email);

                // Iterate over the data and populate the ListView control
                foreach (DataRow row in dataTable.Rows)
                {
                    if (Convert.ToInt32(row["User_id"]) == user.ID)
                    {
                        if (Convert.ToInt32(row["SoortRekening_id"]) == 1)
                        {
                            ListViewItem item = new ListViewItem("BE" + row["Rekening_nr"].ToString());

                            MijnRekeningenDropDown.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Clean up resources
                adapter.Dispose();
                command.Dispose();
                connection.Close();
            }
        }

        private void MijnRekeningenDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
