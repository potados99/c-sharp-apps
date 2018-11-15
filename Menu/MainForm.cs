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

namespace Menu
{
    public partial class MainForm : Form
    {
        #region Variables

        private BindingSource ListBoxSource { get; set; }

        private int MBButtonType = 0;
        private int MBImageType = 0;
        private int MBDefaultbutton = 0;

        #endregion

        #region Constructor

        public MainForm()
        {
            InitializeComponent();

            // Create new binding source containing a list of string
            ListBoxSource = new BindingSource
            {
                DataSource = new List<String>()
            };

            // Set the bindingsource as a datasource of listbox
            FileNameListBox.DataSource = ListBoxSource;
        }

        #endregion

        #region Button click listener

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ListBoxSource.Clear();
        }

        private void MBButtonTypeTest_Click(object sender, EventArgs e)
        {
            var type = (MessageBoxButtons)MBButtonType;

            ShowMessageBox("Button Type Test: \n" + type.ToString(), "Test1");
            MBButtonType = (int)((MBButtonType + 1) % System.Enum.GetValues(typeof(MessageBoxButtons)).Length);
        }

        private void MBImageTestButton_Click(object sender, EventArgs e)
        {
            var type = (MessageBoxIcon)(MBImageType << 4);

            ShowMessageBox("Icon Test: \n" + type.ToString(), "Test2");
            MBImageType = (int)((MBImageType + 1) % 4);
        }
 
        private void MBFocusTestButton_Click(object sender, EventArgs e)
        {
            var type = (MessageBoxDefaultButton)(MBDefaultbutton << 8);

            ShowMessageBox("Default Button Test: \n" + type.ToString(), "Test3");
            MBDefaultbutton = (int)((MBDefaultbutton + 1) % System.Enum.GetValues(typeof(MessageBoxDefaultButton)).Length);
        }

        #region Context menu
        private void AddFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog()
            {
                Filter = "텍스트 파일 (*.txt)|*.txt",
                InitialDirectory = "C:\\menu",
                RestoreDirectory = true,
                Multiselect = true
            };
            fileDialog.ShowDialog();

             foreach (var originFileName in fileDialog.FileNames)
            {
                ListBoxSource.Add(Path.GetFileName(originFileName));
            }
        }

        private void ChangeFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog()
            {
                ShowApply = true,
                ShowColor = true
            };
            fontDialog.Apply += (_sender, _e) => ApplyFontChanges(fontDialog);

            switch (fontDialog.ShowDialog())
            {
                case DialogResult.OK:
                    ApplyFontChanges(fontDialog);
                    break;
                case DialogResult.Yes:
                    ApplyFontChanges(fontDialog);
                    break;
                default:
                    break;
            }
        }
        #endregion

        #endregion

        #region Helper

        private void ApplyFontChanges(FontDialog dialog)
        {
            FileNameListBox.Font = dialog.Font;
            FileNameListBox.ForeColor = dialog.Color;
        }

        private void ShowMessageBox(string text, string title)
        {
            var buttonType = (MessageBoxButtons)MBButtonType;
            var iconType = (MessageBoxIcon)(MBImageType << 4);
            var defaultType = (MessageBoxDefaultButton)(MBDefaultbutton << 8);

            MessageBox.Show(text, title, buttonType, iconType, defaultType);
        }

        #endregion
    }
}
