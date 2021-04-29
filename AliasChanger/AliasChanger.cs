using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Win32;

namespace AliasChanger
{
    public partial class AliasChanger : Form
    {
        private readonly string configPaths;
        private IConfigurationProvider configProvider;
        private Dictionary<string, string> listOfpaths;
        private MessageGenerator messageGenerator;
        public AliasChanger()
        {
            InitializeComponent();
            listOfpaths = CreateConfigDictionary(configPaths, @"Config\Paths.json", configProvider);
        }

        private Dictionary<string, string> CreateConfigDictionary(string json, string jsonFileName,
            IConfigurationProvider configProvider)
        {
            json = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, jsonFileName);
            configProvider = new ConfigurationFromConfigProvider(json);
            return configProvider.GetConfiguration();
        }

        private void sameRdAliasCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            RdServerAliasLbl.Visible = !sameRdAliasCheckBox.Checked;
            RdAliasTextBox.Visible = !sameRdAliasCheckBox.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string regaliaskey;
            listOfpaths.TryGetValue("HKLM-Alias", out regaliaskey);
            Registry.SetValue(regaliaskey, "DefaultServerAlias", pccAliasTextBox.Text);
            updatePCCAlias("PocketECGClientConfigPath");
            messageGenerator = new MessageGenerator(0);
        }

        private void updatePCCAlias(string configName)
        {
            string pccConfigFile;
            listOfpaths.TryGetValue(configName, out pccConfigFile);
            string textToSearch = @"<EnvironmentSettings .*\/>";
            string textToReplace = $"<EnvironmentSettings environmentName=\"{GetAliasWithoutDash(pccAliasTextBox.Text)}\"/>";
            ReplaceInFile(pccConfigFile, textToSearch, textToReplace);
        }

        private void ReplaceInFile(string filePath, string searchText, string replaceText)
        {
            string content;

            using (var reader = new StreamReader(filePath))
            {
                content = reader.ReadToEnd();
            }

            content = Regex.Replace(content, searchText, replaceText, RegexOptions.Multiline);

            using (var writer = new StreamWriter(filePath))
            {
                writer.Write(content);
            }
        }

        private string GetAliasWithoutDash(string alias)
        {
            if (alias.Contains("-"))
            {
                alias = alias.Substring(0,alias.IndexOf('-'));
                return alias;
            }
            return alias;
        }
    }
}
