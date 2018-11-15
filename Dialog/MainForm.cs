using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dialog
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            FDialog.Apply += FDialog_Apply;
        }

        #region Event handler

        private void FDialog_Apply(object sender, EventArgs e)
        {
            ApplyFontChanges();
        }

        #endregion

        #region Button click listener

        #region Open Form
        private void ModalButton_Click(object sender, EventArgs e)
        {
            new DialgForm("Modal").ShowDialog();
        }
        private void ModelessButton_Click(object sender, EventArgs e)
        {
            new DialgForm("Modeless").Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Font Dialog
        private void ShowFontDialogButton_Click(object sender, EventArgs e)
        {
            if (OpenFontDialog())
            {
                ApplyFontChanges();
            }

        }
        #endregion

        #endregion

        #region Helper

        private bool OpenFontDialog()
        {
            FDialog.ShowApply = ShowApplyCheckBox.Checked;
            FDialog.ShowColor = ShowColorCheckBox.Checked;

            var result = FDialog.ShowDialog();
            switch (result)
            {
                case DialogResult.OK:
                    return true;
                case DialogResult.Yes:
                    return true;
                case DialogResult.Retry:
                    return true;
                default:
                    return false;
            }
        }

        private void ApplyFontChanges()
        {
            PreviewTextBox.Font = FDialog.Font;
            PreviewTextBox.ForeColor = FDialog.Color;
        }

        #endregion
    }
}
