using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AliasChanger
{
    public partial class AliasChanger : Form
    {
        private readonly string aliasesList;
        private readonly IConfigurationProvider aliasesProvider;
        private Dictionary<string, string> listOfAliases;
        public AliasChanger()
        {
            InitializeComponent();
            aliasesList = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Config\Aliases.json");
            aliasesProvider = new ConfigurationFromConfigProvider(aliasesList);
            listOfAliases = aliasesProvider.GetConfiguration();

            foreach (var value in listOfAliases.Values)
            {
                comboBoxPccAlias.Items.Add(value);
                comboBoxRdAlias.Items.Add(value);
            }
        }

        private void sameRdAliasCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            RdServerAliasLbl.Visible = !sameRdAliasCheckBox.Checked;
            comboBoxRdAlias.Visible = !sameRdAliasCheckBox.Checked;
        }
    }
}
