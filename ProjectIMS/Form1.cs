using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectIMS
{
    public partial class InventoryManagementSystem : Form
    {
        DataTable inventory = new DataTable();
        
        public InventoryManagementSystem()
        {
            InitializeComponent();
            
        }

       

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Create a Bitmap to represent the visible portion of the DataGridView
            Bitmap bitmap = new Bitmap(inventoryGridView.Width, inventoryGridView.Height);
            inventoryGridView.DrawToBitmap(bitmap, new Rectangle(0, 0, inventoryGridView.Width, inventoryGridView.Height));

            // Draw the bitmap on the print page
            e.Graphics.DrawImage(bitmap, new Point(0, 0));
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            skuTextBox.Text = "";
            nameTextBox.Text = "";
            priceTextBox.Text = "";
            descriptionTextBox.Text = "";
            quantityTextBox.Text = "";
            categoryBox.SelectedIndex = -1;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Save all the values from our fields into variables
            String sku = skuTextBox.Text;
            String name = nameTextBox.Text;
            String price = priceTextBox.Text;
            String quantity = quantityTextBox.Text;
            String description = descriptionTextBox.Text;
            String category = (string)categoryBox.SelectedItem;

            // Add these values to the datatable
            inventory.Rows.Add(sku, name, category, price, description, quantity);

            // Clear fields after save
            newButton_Click(sender, e);

          
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                inventory.Rows[inventoryGridView.CurrentCell.RowIndex].Delete();
            }
            catch (Exception err)
            {
                Console.WriteLine("Error: " + err);
            }
        }

        private void inventoryGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                skuTextBox.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[0].ToString();
                nameTextBox.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[1].ToString();
                priceTextBox.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[3].ToString();
                descriptionTextBox.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[4].ToString();
                quantityTextBox.Text = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[5].ToString();

                String itemToLookFor = inventory.Rows[inventoryGridView.CurrentCell.RowIndex].ItemArray[2].ToString();
                categoryBox.SelectedIndex = categoryBox.Items.IndexOf(itemToLookFor);
            }
            catch (Exception err)
            {
                Console.WriteLine("There has been an error: " + err);
            }
        }

        private void InventoryManagementSystem_Load(object sender, EventArgs e)
        {
            inventory.Columns.Add("SKU");
            inventory.Columns.Add("Name");
            inventory.Columns.Add("Category");
            inventory.Columns.Add("Price");
            inventory.Columns.Add("Description");
            inventory.Columns.Add("Quantity");

            inventoryGridView.DataSource = inventory;

            // Adjust column widths
            foreach (DataGridViewColumn column in inventoryGridView.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            // Ensure row height based on content
            inventoryGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Set font size and style
            inventoryGridView.DefaultCellStyle.Font = new Font("Arial", 12); // Change "Arial" and 12 as needed

            // Set cell padding
            inventoryGridView.DefaultCellStyle.Padding = new Padding(5); // Adjust padding as needed
        }

        private void inventoryGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void printButton_Click(object sender, EventArgs e)
        {
            // Create a PrintDocument object
            PrintDocument printDocument = new PrintDocument();

            // Set the PrintPage event handler
            printDocument.PrintPage += PrintDocument_PrintPage;

            // Show print dialog to allow user to select printer and print settings
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;
            DialogResult result = printDialog.ShowDialog();

            // If user clicks OK in the print dialog
            if (result == DialogResult.OK)
            {
                // Start printing
                printDocument.Print();
            }
        }
    }
}
