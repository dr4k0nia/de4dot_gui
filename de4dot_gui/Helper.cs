using System.Windows.Forms;

namespace de4dot_gui
{
    public static class Helper
    {
        public static void ShowError(string message)
        {
            MessageBox.Show(message, @"Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}