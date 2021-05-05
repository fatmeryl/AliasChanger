using System.Windows.Forms;

namespace AliasChanger
{
    public class MessageGenerator
    {
        public MessageGenerator(State state)
        {
            switch (state)
            {
                case State.Changed:
                    MessageBox.Show(
                        "Aliases Changed",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                    break;
                case State.ChangedAndDatabaseCleared:
                    MessageBox.Show(
                        "Aliases Changed \nDatabase Removed",
                    "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                    break;
                case State.ChangedDatabaseNotFound:
                    MessageBox.Show(
                        "Aliases Changed \nDatabase Not Found",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                    break;
            }
        }
    }
}