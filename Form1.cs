using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace FormsGyumolcs {
    public partial class Form1 : Form {

        private readonly MySqlConnection connection;
        private readonly MySqlCommand command;

        public Form1() {
            InitializeComponent();

            try {
                (connection = new MySqlConnection("server=localhost;user=root;database=gyumolcsok;")).Open();
                command = connection.CreateCommand();
            } catch (Exception e) {
                MessageBox.Show(e.Message, "Adatbázis kapcsolódás sikertelen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
                return;
            }

            amountBox.Maximum = egysegAr.Maximum = int.MaxValue;
            RefreshListItems();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            connection.Close();
        }

        private void RefreshListItems() {
            gyumolcsList.Items.Clear();

            command.CommandText = "select * from gyumolcs;";

            using (MySqlDataReader reader = command.ExecuteReader()) {
                while (reader.Read()) {
                    gyumolcsList.Items.Add(new Vegetable(reader.GetInt32("id"), reader.GetString("nev"), reader.GetInt32("egysegar"), reader.GetInt32("mennyiseg")));
                }
            }
        }

        private async void newVegButton_Click(object sender, EventArgs e) {
            string nev = nevBox.Text;

            if (nev.Length == 0) {
                MessageBox.Show("Adjon meg egy gyümölcs nevet", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nevBox.Focus();
                return;
            }

            command.CommandText = "INSERT INTO `gyumolcs` (`nev`, `egysegar`, `mennyiseg`) VALUES (@nev, @egysegar, @mennyiseg);";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@nev", nev);
            command.Parameters.AddWithValue("@egysegar", egysegAr.Value);
            command.Parameters.AddWithValue("@mennyiseg", amountBox.Value);

            await command.ExecuteNonQueryAsync();

            nevBox.Text = "";
            egysegAr.Value = egysegAr.Minimum;
            amountBox.Value = amountBox.Minimum;
            RefreshListItems();

            MessageBox.Show("Adatok rögzítve", "Adatok", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void removeVeg_Click(object sender, EventArgs e) {
            object selectedVeg = gyumolcsList.SelectedItem;

            if (selectedVeg is null) {
                MessageBox.Show("Válasszon ki egy meglévő gyümölcsöt az eltávolításhoz", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            command.CommandText = $"delete from `gyumolcs` where `nev` = '{selectedVeg}';";
            await command.ExecuteNonQueryAsync();

            RefreshListItems();
            MessageBox.Show("Kiválasztott adatok eltávolítva", "Adatok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            removeVeg.Enabled = false;
        }

        private void gyumolcsList_SelectedIndexChanged(object sender, EventArgs e) {
            removeVeg.Enabled = gyumolcsList.SelectedItems.Count != 0;
        }
    }
}
