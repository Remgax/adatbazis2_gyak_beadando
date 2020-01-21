using DB2_ZH.Models.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB2_ZH.Views.WinForms
{
    public partial class ZHForm : Form
    {
        private OracleManager oracleManager;
        private OracleManager tableManager;
        private List<Models.Records.Record> szamlak;
        public ZHForm()
        {
            InitializeComponent();
            tableManager = new OracleManager();
            szamlak = tableManager.Select();
        }

        private void ZHForm_Load(object sender, EventArgs e)
        {
            oracleManager = new OracleManager();
        }

        private void ZHForm_Shown(object sender, EventArgs e)
        {

        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            try
            {
                Models.Records.Record ujRecord = new Models.Records.Record();
                ujRecord.Nev = textBox_nev.Text;
                ujRecord.Bankartyaszam = textBox_kartyaszam.Text;
                ujRecord.Egyenleg = int.Parse(textBox_egyenleg.Text);
                int ujSorok = tableManager.Insert(ujRecord);
                MessageBox.Show(ujSorok + " sor rögzitésre került!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView_recrods.CurrentCell.RowIndex < 0)
            {
                MessageBox.Show("Kérem válaszzon egy sor törlés előtt");
                return;
            }
            else 
            {
                Models.Records.Record torles = (Models.Records.Record)dataGridView_recrods.SelectedRows;
                int toroltRecord = tableManager.Delete(torles);
                MessageBox.Show(toroltRecord + " Sikeresen Törölve lett!");
                szamlak = tableManager.Select();

            }
                    
        }

        private void textBox_kartyaszam_TextChanged(object sender, EventArgs e)
        {
            string value = textBox_kartyaszam.Text;
            OracleManager oracleManager = new OracleManager();
            if (!oracleManager.CheckData(value))
            {
                textBox_kartyaszam.BackColor = Color.Red;
            }
            else 
            {
                textBox_kartyaszam.BackColor = Color.White;
            }
        }
    }
}
