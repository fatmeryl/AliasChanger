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
            pccAliasTextBox.Select();
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
            UpdateRegistryAlias("HKLM-Alias");
            UpdatePCCAlias(pccAliasTextBox.Text);
            if (changeRDAliascheckBox.Checked)
            {
                UpdateRDAlias();
            }

            if (clearDbCheckBox.Checked)
            {
                RemoveDatabase(pccAliasTextBox.Text);
            }
            else
            {
                messageGenerator = new MessageGenerator(State.Changed);
            }
        }

        private void UpdateRDAlias()
        {
            if (sameRdAliasCheckBox.Checked)
            {
                RdAliasTextBox.Text = pccAliasTextBox.Text;
            }

            UpdateRDAlias(RdAliasTextBox.Text);
        }

        private void RemoveDatabase(string pccAlias)
        {
            string dbFileName = $"{pccAlias.ToUpper()}_CLIENTDB.FDB";
            string dbFileLocation;
            listOfpaths.TryGetValue("PCCClientDatabase", out dbFileLocation);
            string dbFilePath = $"{dbFileLocation}\\{dbFileName}";

            if (File.Exists(dbFilePath))
            {
                File.Delete(dbFilePath);
                messageGenerator = new MessageGenerator(State.ChangedAndDatabaseCleared);
            }
            else
            {
                messageGenerator = new MessageGenerator(State.ChangedDatabaseNotFound);
            }
        }

        private void UpdateRDAlias(string rdAlias)
        {
            string rdConfigPath;
            listOfpaths.TryGetValue("RDConfigPath", out rdConfigPath);
            LineChanger(rdAlias, rdConfigPath, 2);
            UpdateRDExeConfig(rdAlias);
        }

        private void UpdateRDExeConfig(string providedAlias)
        {
            string rdExeConfigFile;
            string textToSearch;
            string textToReplace;
            listOfpaths.TryGetValue("RDExeConfigPath", out rdExeConfigFile);
            textToSearch = @"(?<=<value>)(.*)(?=</value>)";
            textToReplace =
                $"<value>https://{GetAliasWithoutDash(providedAlias)}.test.medical.local/Services/LocatorService.svc</value>";
            ReplaceInFile(rdExeConfigFile, textToSearch, textToReplace);
        }

        static void LineChanger(string newText, string fileName, int line_to_edit)
        {
            string[] arrLine = File.ReadAllLines(fileName);
            arrLine[line_to_edit - 1] = newText;
            File.WriteAllLines(fileName, arrLine);
        }

        private void UpdateRegistryAlias(string registryPath)
        {
            string regaliaskey;
            listOfpaths.TryGetValue(registryPath, out regaliaskey);
            Registry.SetValue(regaliaskey, "DefaultServerAlias", pccAliasTextBox.Text);
        }

        private void UpdatePCCAlias(string providedAlias)
        {
            string pccConfigFile;
            string textToSearch;
            string textToReplace;

            if (providedAlias == "local")
            {
                listOfpaths.TryGetValue("PocketECGClientLocal", out pccConfigFile);
                textToSearch = @"<EnvironmentSettings .*\/>";
                textToReplace = $"<EnvironmentSettings environmentName=\"development\" locatorServiceUri=\"https://localhost:44302/LocatorService.svc\"/>";
                ReplaceInFile(pccConfigFile, textToSearch, textToReplace);
            }
            else
            {
                listOfpaths.TryGetValue("PocketECGClientConfigPath", out pccConfigFile);
                textToSearch = @"<EnvironmentSettings .*\/>";
                textToReplace = $"<EnvironmentSettings environmentName=\"{GetAliasWithoutDash(providedAlias)}\"/>";
                ReplaceInFile(pccConfigFile, textToSearch, textToReplace);
            }
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
                alias = alias.Substring(0, alias.IndexOf('-'));
                return alias;
            }
            return alias;
        }

        private void changeRDAliascheckBox_CheckedChanged(object sender, EventArgs e)
        {
            sameRdAliasCheckBox.Enabled = true;
        }

        private void pccAliasTextBox_TextChanged(object sender, EventArgs e)
        {
            if (pccAliasTextBox.Text.Length != 0)
            {
                changeAliasBtn.Enabled = true;
            }
            else
            {
                changeAliasBtn.Enabled = false;
            }
        }
    }
}