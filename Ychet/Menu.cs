using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ychet
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonOpenSupplies_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonOpenClients_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonAgents_Click(object sender, EventArgs e)
        {
            Form agentSet = new Agents();
            agentSet.Show();
        }

        private void buttonProvider_Click(object sender, EventArgs e)
        {
            Form agentSet = new AgentsSet();
            agentSet.Show();
        }

        private void buttonExtra_Click(object sender, EventArgs e)
        {
            Form agentSet = new AgentsSet();
            agentSet.Show();
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            Form agentSet = new AgentsSet();
            agentSet.Show();
        }

        private void buttonNal_Click(object sender, EventArgs e)
        {
            Form agentSet = new AgentsSet();
            agentSet.Show();
        }

        private void buttonPriem_Click(object sender, EventArgs e)
        {
            Form agentSet = new AgentsSet();
            agentSet.Show();
        }
    }
}
