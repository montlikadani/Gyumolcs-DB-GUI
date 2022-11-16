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

            if (nev.Trim().Length == 0) {
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

            ResetProperties();
            RefreshListItems();

            MessageBox.Show("Adatok rögzítve", "Adatok", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void removeVeg_Click(object sender, EventArgs e) {
            if (!(gyumolcsList.SelectedItem is Vegetable fruit)) {
                MessageBox.Show("Válasszon ki egy meglévő gyümölcsöt az eltávolításhoz", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            command.CommandText = $"delete from `gyumolcs` where `id` = @id;";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@id", fruit.Id);

            await command.ExecuteNonQueryAsync();

            RefreshListItems();
            MessageBox.Show("Kiválasztott adat eltávolítva", "Adat módosítás", MessageBoxButtons.OK, MessageBoxIcon.Information);

            updateFruitButton.Enabled = removeVeg.Enabled = false;
            ResetProperties();
        }

        private void gyumolcsList_SelectedIndexChanged(object sender, EventArgs e) {
            updateFruitButton.Enabled = removeVeg.Enabled = gyumolcsList.SelectedItems.Count != 0;

            if (gyumolcsList.SelectedItem is Vegetable fruit) {
                idBox.Text = fruit.Id.ToString();
                nevBox.Text = fruit.Name;
                egysegAr.Value = fruit.Egysegar;
                amountBox.Value = fruit.Mennyiseg;
            }
        }

        private async void updateFruitButton_Click(object sender, EventArgs e) {
            if (!(gyumolcsList.SelectedItem is Vegetable fruit)) {
                MessageBox.Show("Válasszon ki egy meglévő gyümölcsöt a módosításhoz", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nev = nevBox.Text;

            if (nev.Trim().Length == 0) {
                MessageBox.Show("Nincs megadva gyümölcs név", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nevBox.Focus();
                return;
            }

            command.CommandText = "update `gyumolcs` set `nev` = @name, `egysegar` = @ar, `mennyiseg` = @amount where `id` = @id;";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@id", fruit.Id);
            command.Parameters.AddWithValue("@name", nev);
            command.Parameters.AddWithValue("@ar", egysegAr.Value);
            command.Parameters.AddWithValue("@amount", amountBox.Value);

            await command.ExecuteNonQueryAsync();

            RefreshListItems();
            MessageBox.Show("Kiválasztott adat frissítve", "Adat módosítás", MessageBoxButtons.OK, MessageBoxIcon.Information);
            removeVeg.Enabled = updateFruitButton.Enabled = false;
        }

        private void ResetProperties() {
            idBox.Text = nevBox.Text = "";
            egysegAr.Value = egysegAr.Minimum;
            amountBox.Value = amountBox.Minimum;
        }
    }
}
