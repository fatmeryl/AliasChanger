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
using Microsoft.Win32;

namespace AliasChanger
{
    public partial class AliasChanger : Form
    {
        private readonly string aliasesList;
        private readonly IConfigurationProvider aliasesProvider;
        private Dictionary<string, string> listOfAliases;
        private MessageGenerator messageGenerator;
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

        private void button1_Click(object sender, EventArgs e)
        {
            var pccWowKey = @"HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\MEDICALgorithmics\PocketECG\PCClient";
            Registry.SetValue(pccWowKey, "DefaultServerAlias", comboBoxPccAlias.Text);
            messageGenerator = new MessageGenerator(0);

        }
    }
}
