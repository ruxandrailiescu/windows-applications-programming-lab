using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamSubject4
{
    public partial class MainForm : Form
    {
        private List<Category> categories;
        private List<Product> products;
        private const string connectionString = "Data Source=C:\\Users\\Admin\\repos\\windows-applications-programming-lab\\ExamSubject4\\ExamSubject4\\database.db";
        public MainForm()
        {
            InitializeComponent();
            categories = LoadCategories("C:\\Users\\Admin\\repos\\windows-applications-programming-lab\\ExamSubject4\\ExamSubject4\\Categories.txt");
            products = new List<Product>();

            LoadProductsDB();
            PopulateDataGridView();
        }

        private List<Category> LoadCategories(string filePath)
        {
            List<Category> categories = new List<Category>();

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (var line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 2)
                    {
                        int id = int.Parse(parts[0]);
                        string name = parts[1];

                        categories.Add(new Category(id, name));
                    }
                }
            }
            else
            {
                MessageBox.Show("The file does not exist.");
            }

            return categories;
        }

        private void PopulateDataGridView()
        {
            products.Sort();
            dgvProducts.Rows.Clear();

            foreach (var product in products)
            {
                string category = categories.First(c => c.Id == product.CategoryId).Name;
                int indexRow = dgvProducts.Rows.Add(
                    product.Id.ToString(),
                    product.Name,
                    product.Units.ToString(),
                    product.Price.ToString(),
                    category
                    );
                dgvProducts.Rows[indexRow].Tag = product;
            }
        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            var form = new AddEditProduct(categories);

            if (form.ShowDialog() == DialogResult.OK)
            {
                var product = form.Product;
                products.Add(product);
                PopulateDataGridView();
                AddProductDB(product);
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dgvProducts.SelectedRows.Count > 0)
            {
                var item = dgvProducts.SelectedRows[0];
                var product = (Product)item.Tag;
                var form = new AddEditProduct(categories);

                if(form.ShowDialog() == DialogResult.OK)
                {
                    products.Remove(product);
                    product = form.Product;
                    products.Add(product);
                    PopulateDataGridView();
                    UpdateProductDB(product);
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dgvProducts.SelectedRows.Count > 0)
            {
                var item = dgvProducts.SelectedRows[0];
                var product = (Product)item.Tag;
                products.Remove(product);
                PopulateDataGridView();
                DeleteProductDB(product);
            }
        }

        private void totalPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double totalPrice = 0;

            foreach (var product in products)
            {
                totalPrice += (double)product;
            }
            MessageBox.Show($"Total price for all products: {totalPrice}");
        }

        private void LoadProductsDB()
        {
            string query = "SELECT * FROM Products";

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                SQLiteCommand command = new SQLiteCommand(query, conn);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        long id = (long)reader["Id"];
                        string name = (string)reader["Name"];
                        long units = (long)reader["Units"];
                        double price = (double)reader["Price"];
                        long categoryId = (long)reader["CategoryId"];

                        Product product = new Product((int)id, name, (int)units, price, (int)categoryId);
                        products.Add(product);
                    }
                }
            }
        }

        private void AddProductDB(Product product)
        {
            string query = "INSERT INTO Products (Id, Name, Units, Price, CategoryId) "
                + "VALUES (@id, @name, @units, @price, @categoryId)";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@id", product.Id);
                command.Parameters.AddWithValue("@name", product.Name);
                command.Parameters.AddWithValue("@units", product.Units);
                command.Parameters.AddWithValue("@price", product.Price);
                command.Parameters.AddWithValue("@categoryId", product.CategoryId);

                command.ExecuteNonQuery();
            }
        }

        private void UpdateProductDB(Product product)
        {
            string query = @"
                UPDATE Products
                SET
                    Id = @id,
                    Name = @name,
                    Units = @units,
                    Price = @price,
                    CategoryId = @categoryId
                WHERE
                    Id = @id";

            using (SQLiteConnection con = new SQLiteConnection(connectionString))
            {
                con.Open();

                using (SQLiteCommand command = new SQLiteCommand(query, con))
                {
                    command.Parameters.AddWithValue("@id", product.Id);
                    command.Parameters.AddWithValue("@name", product.Name);
                    command.Parameters.AddWithValue("@units", product.Units);
                    command.Parameters.AddWithValue("@price", product.Price);
                    command.Parameters.AddWithValue("@categoryId", product.CategoryId);

                    command.ExecuteNonQuery();
                }
            }
        }

        private void DeleteProductDB(Product product)
        {
            string query = "DELETE FROM Products WHERE Id = @id";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@id", product.Id);

                command.ExecuteNonQuery();
            }
        }
    }
}
