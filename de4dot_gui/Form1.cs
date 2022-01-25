using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace de4dot_gui
{
    public sealed partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AllowDrop = true;
            DragEnter += FormDragEnter;
            DragDrop += FormDragDrop;

            if (Properties.Settings.Default.deobfPath.Length <= 0)
                Properties.Settings.Default.deobfPath = Application.StartupPath + @"\de4dot.exe";

            if (Properties.Settings.Default.deobfPath64.Length <= 0)
                Properties.Settings.Default.deobfPath64 = Application.StartupPath + @"\de4dot64.exe";

            tbDeobfPath.Text = Properties.Settings.Default.deobfPath;
            tbDeobfPath64.Text = Properties.Settings.Default.deobfPath64;
        }

        #region "Drag&Drop Events"

        private static void FormDragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Copy : DragDropEffects.None;
        }

        private void FormDragDrop(object sender, DragEventArgs e)
        {
            string[] fileList = (string[]) e.Data.GetData(DataFormats.FileDrop, false);

            // Add files to our listbox and check for .exe and .dll files
            foreach (string file in fileList)
            {
                if (!File.Exists(file))
                    throw new FileNotFoundException(file);

                string extension = Path.GetExtension(file);

                if (extension == ".exe" || extension == ".dll")
                {
                    lbFilesToDeobfuscate.Items.Add(file);
                    continue;
                }

                MessageBox.Show(@"Invalid file format, use .dll or .exe files", @"Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        #endregion "Drag&Drop Events"

        #region "Listbox controls"

        private int _index0;

        private int _index1;

        private void lbFilesToDeobfuscate_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
                return;
            _index0 = lbFilesToDeobfuscate.IndexFromPoint(e.Location);
            if (_index0 != -1)
                contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
        }

        private void lbDecryptionMethods_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
                return;
            _index1 = lbDecryptionMethods.IndexFromPoint(e.Location);
            if (_index1 != -1)
                contextMenuStrip2.Show(Cursor.Position.X, Cursor.Position.Y);
        }

        private void toolStripMenuDeleteBtn_Click(object sender, EventArgs e)
        {
            lbFilesToDeobfuscate.Items.RemoveAt(_index0);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lbDecryptionMethods.Items.RemoveAt(_index1);
        }

        private void btnAddDecryptionMethod_Click(object sender, EventArgs e)
        {
            if (!tbDecryptionMethod.Text.StartsWith("0x"))
            {
                Helper.ShowError("Please input a valid metadata token, expected format 0x00000000");
                return;
            }

            lbDecryptionMethods.Items.Add(tbDecryptionMethod.Text);
        }

        #endregion "Listbox controls"

        #region "Settings Tab"

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using var browsePath = new OpenFileDialog();
            browsePath.Filter = @"Executable files (*.exe)|*.exe";

            if (browsePath.ShowDialog() != DialogResult.OK)
                return;

            tbDeobfPath.Text = browsePath.FileName;
            Properties.Settings.Default.deobfPath = browsePath.FileName;
        }

        private void btnBrowse64_Click(object sender, EventArgs e)
        {
            using var browsePath = new OpenFileDialog();
            browsePath.Filter = @"Executable files (*.exe)|*.exe";

            if (browsePath.ShowDialog() != DialogResult.OK)
                return;

            tbDeobfPath64.Text = browsePath.FileName;
            Properties.Settings.Default.deobfPath64 = browsePath.FileName;
        }

        #endregion "Settings Tab"

        private void btnDeobfuscate_Click_1(object sender, EventArgs e)
        {
            string[] files = lbFilesToDeobfuscate.Items.OfType<string>().ToArray();

            if (files.Length == 0)
            {
                Helper.ShowError("No files for deobfuscation found");
                return;
            }

            if (cbEnableAdvStrings.Checked)
            {
                if (comboDeobfMethod.SelectedIndex == -1)
                {
                    Helper.ShowError("Choose a method for string decryption!");
                    return;
                }

                if (lbDecryptionMethods.Items.Count == 0)
                {
                    Helper.ShowError("Please enter valid string decryption functions!");
                    return;
                }
            }

            foreach (string file in files)
            {
                var stringSettings = cbEnableAdvStrings.Checked
                    ? new StringDecryptionSettings(comboDeobfMethod.SelectedIndex,
                        lbDecryptionMethods.Items.OfType<string>().ToArray())
                    : new StringDecryptionSettings(0, Array.Empty<string>());

                var settings = new ProcessSettings(cbForceObf.Checked,
                    comboObfuscators.SelectedIndex, cbNoRenaming.Checked,
                    stringSettings);

                var processor = new Processor(file, cbUse64Bit.Checked);

                processor.Execute(settings);
            }
        }

        private void cbEnableAdvStrings_CheckedChanged(object sender, EventArgs e)
        {
            bool enabled = cbEnableAdvStrings.Checked;
            comboDeobfMethod.Enabled = enabled;
            lbDecryptionMethods.Enabled = enabled;
            tbDecryptionMethod.Enabled = enabled;
            btnAddDecryptionMethod.Enabled = enabled;
        }

        private void cbForceObf_CheckedChanged(object sender, EventArgs e)
        {
            comboObfuscators.Enabled = cbForceObf.Checked;
        }
    }
}