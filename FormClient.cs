using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class FormClient : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\RAZAFIMANAMPY\AppData\Local\Temporary Projects\WindowsFormsApplication1\dbclients.mdf;Integrated Security=True";
        private SqlConnection connection;
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;

        public FormClient()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            dataTable = new DataTable();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM clients";
                dataAdapter = new SqlDataAdapter(query, connection);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                dataTable.Clear();
                dataAdapter.Fill(dataTable);
                dtlisteclient.DataSource = dataTable;
                // Configuration explicite des colonnes avec vérification
                if (dtlisteclient.Columns.Count > 0)
                {
                    dtlisteclient.Columns["Numero"].DataPropertyName = "Numero";
                    dtlisteclient.Columns["Nom"].DataPropertyName = "Nom";
                    dtlisteclient.Columns["Prenom"].DataPropertyName = "Prenom";
                    dtlisteclient.Columns["Adresse"].DataPropertyName = "Adresse";
                    dtlisteclient.Columns["Telephone"].DataPropertyName = "Telephone";
                    dtlisteclient.Columns["Email"].DataPropertyName = "Email";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur dans LoadData : " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dtlisteclient.SelectionChanged += dtlisteclient_SelectionChanged;
        }

        private void txtnumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtprenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtadresse_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttelephone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btajouter_Click(object sender, EventArgs e)
        {
            // Ajout d'un nouveau client dans la base de données
            try
            {
                connection.Open();
                string query = "INSERT INTO clients (Numero, Nom, Prenom, Adresse, Telephone, Email) VALUES (@Numero, @Nom, @Prenom, @Adresse, @Telephone, @Email)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Numero", int.Parse(txtnumero.Text));
                command.Parameters.AddWithValue("@Nom", txtnom.Text);
                command.Parameters.AddWithValue("@Prenom", txtprenom.Text);
                command.Parameters.AddWithValue("@Adresse", txtadresse.Text);
                command.Parameters.AddWithValue("@Telephone", txttelephone.Text);
                command.Parameters.AddWithValue("@Email", txtemail.Text);
                command.ExecuteNonQuery();
                dataTable.Clear();
                dataAdapter.Fill(dataTable);
                MessageBox.Show("Client ajouté avec succès!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btmodifier_Click(object sender, EventArgs e)
        {
            // Modification des informations d'un client existant
            try
            {
                connection.Open();
                string query = "UPDATE clients SET Nom = @Nom, Prenom = @Prenom, Adresse = @Adresse, Telephone = @Telephone, Email = @Email WHERE Numero = @Numero";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Numero", int.Parse(txtnumero.Text));
                command.Parameters.AddWithValue("@Nom", txtnom.Text);
                command.Parameters.AddWithValue("@Prenom", txtprenom.Text);
                command.Parameters.AddWithValue("@Adresse", txtadresse.Text);
                command.Parameters.AddWithValue("@Telephone", txttelephone.Text);
                command.Parameters.AddWithValue("@Email", txtemail.Text);
                command.ExecuteNonQuery();
                dataTable.Clear();
                dataAdapter.Fill(dataTable);
                MessageBox.Show("Client modifié avec succès!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btsupprimer_Click(object sender, EventArgs e)
        {
            // Suppression d'un client après confirmation
            if (MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce client?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM clients WHERE Numero = @Numero";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Numero", int.Parse(txtnumero.Text));
                    command.ExecuteNonQuery();
                    dataTable.Clear();
                    dataAdapter.Fill(dataTable);
                    MessageBox.Show("Client supprimé avec succès!");
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

 

private void dtlisteclient_SelectionChanged(object sender, EventArgs e)
{
    // Remplissage des champs avec les données de la ligne sélectionnée
    if (dtlisteclient.SelectedRows.Count > 0)
    {
        DataGridViewRow row = dtlisteclient.SelectedRows[0];
        if (row.Cells.Count > 0)
        {
            // Utilisation de l'index des colonnes au lieu des noms directs pour éviter les erreurs
            txtnumero.Text = row.Cells.Cast<DataGridViewCell>().Any(cell => cell.OwningColumn != null && cell.OwningColumn.Name == "Numero") ? (row.Cells[dtlisteclient.Columns["Numero"].Index].Value != null ? row.Cells[dtlisteclient.Columns["Numero"].Index].Value.ToString() : "") : "";
            txtnom.Text = row.Cells.Cast<DataGridViewCell>().Any(cell => cell.OwningColumn != null && cell.OwningColumn.Name == "Nom") ? (row.Cells[dtlisteclient.Columns["Nom"].Index].Value != null ? row.Cells[dtlisteclient.Columns["Nom"].Index].Value.ToString() : "") : "";
            txtprenom.Text = row.Cells.Cast<DataGridViewCell>().Any(cell => cell.OwningColumn != null && cell.OwningColumn.Name == "Prenom") ? (row.Cells[dtlisteclient.Columns["Prenom"].Index].Value != null ? row.Cells[dtlisteclient.Columns["Prenom"].Index].Value.ToString() : "") : "";
            txtadresse.Text = row.Cells.Cast<DataGridViewCell>().Any(cell => cell.OwningColumn != null && cell.OwningColumn.Name == "Adresse") ? (row.Cells[dtlisteclient.Columns["Adresse"].Index].Value != null ? row.Cells[dtlisteclient.Columns["Adresse"].Index].Value.ToString() : "") : "";
            txttelephone.Text = row.Cells.Cast<DataGridViewCell>().Any(cell => cell.OwningColumn != null && cell.OwningColumn.Name == "Telephone") ? (row.Cells[dtlisteclient.Columns["Telephone"].Index].Value != null ? row.Cells[dtlisteclient.Columns["Telephone"].Index].Value.ToString() : "") : "";
            txtemail.Text = row.Cells.Cast<DataGridViewCell>().Any(cell => cell.OwningColumn != null && cell.OwningColumn.Name == "Email") ? (row.Cells[dtlisteclient.Columns["Email"].Index].Value != null ? row.Cells[dtlisteclient.Columns["Email"].Index].Value.ToString() : "") : "";
        }
    }
}
        private void ClearFields()
        {
            // Réinitialisation de tous les champs
            txtnumero.Text = "";
            txtnom.Text = "";
            txtprenom.Text = "";
            txtadresse.Text = "";
            txttelephone.Text = "";
            txtemail.Text = "";
        }
    }
}