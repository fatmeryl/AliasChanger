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
            }
        }
    }
}