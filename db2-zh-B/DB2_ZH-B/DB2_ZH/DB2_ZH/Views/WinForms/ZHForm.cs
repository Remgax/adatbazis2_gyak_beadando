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

        public ZHForm()
        {
            InitializeComponent();
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

        }

        private void button_delete_Click(object sender, EventArgs e)
        {

        }
    }
}
