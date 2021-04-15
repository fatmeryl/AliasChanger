using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace AliasChanger
{
    public partial class AliasChanger : Form
    {
        private string aliasesList;
        private readonly string configPaths;
        private IConfigurationProvider aliasesProvider;
        private IConfigurationProvider configProvider;
        private Dictionary<string, string> listOfAliases;
        private Dictionary<string, string> listOfpaths;
        private MessageGenerator messageGenerator;
        public AliasChanger()
        {
            InitializeComponent();
            FillCombobox(CreateConfigDictionary(aliasesList, @"Config\Aliases.json", aliasesProvider));
            //listOfpaths = CreateConfigDictionary();
        }

        private Dictionary<string, string> CreateConfigDictionary(string json, string jsonFileName,
            IConfigurationProvider configProvider)
        {
            json = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, jsonFileName);
            configProvider = new ConfigurationFromConfigProvider(json);
            return configProvider.GetConfiguration();
        }

        private void FillCombobox(Dictionary<string, string> list)
        {
            foreach (var value in list.Values)
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
