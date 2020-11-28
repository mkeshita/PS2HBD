using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Interfaces;
using MetroFramework.Controls;



namespace MetroFramework
{
    public static class MetroInputBox
    {
        public static DialogResult Show(String title, String promptText, String value)
        {
            return Show(title, promptText, "", 155);
        }

        public static DialogResult Show(String title, String promptText, String value, int height)
        {
            DialogResult _result = DialogResult.None;

            MetroForm form = new MetroForm();
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Style = MetroColorStyle.Default;
            form.Theme = MetroThemeStyle.Dark;
            form.Size = new Size(400, height);
            form.Font = new Font("Verdana", 12f);
            form.SizeGripStyle = SizeGripStyle.Hide;
            form.Movable = false;
            form.ControlBox = false;
            form.ShowInTaskbar = false;
            form.TopMost = true;
            form.AutoSize = true;

            MetroLabel uxLabel = new MetroLabel();
            uxLabel.Style = MetroColorStyle.Default;
            uxLabel.Theme = MetroThemeStyle.Dark;

            MetroTextBox uxTextBox = new MetroTextBox();
            uxTextBox.Style = MetroColorStyle.Default;
            uxTextBox.Theme = MetroThemeStyle.Dark;
            uxTextBox.Width = 1000;

            MetroButton uxOK = new MetroButton();
            uxOK.Style = MetroColorStyle.Default;
            uxOK.Theme = MetroThemeStyle.Dark;
            uxOK.Text = "OK";
            uxOK.DialogResult = DialogResult.OK;
            uxOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            MetroButton uxCancel = new MetroButton();
            uxCancel.Style = MetroColorStyle.Default;
            uxCancel.Theme = MetroThemeStyle.Dark;
            uxCancel.Text = "Cancel";
            uxCancel.DialogResult = DialogResult.Cancel;
            uxCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.Text = title;
            uxLabel.Text = promptText;
            uxTextBox.Text = value;

            uxLabel.SetBounds(20, 60, 372, 13);
            //uxTextBox.SetBounds(12, uxLabel.Bounds.Y + 25, 372, 20);
            uxTextBox.SetBounds(12, uxLabel.Bounds.Y + promptText.Length, 372, 20);
            uxCancel.SetBounds(309, uxTextBox.Bounds.Y + 33, 75, 23);
            uxOK.SetBounds(228, uxTextBox.Bounds.Y + 33, 75, 23);

            uxLabel.AutoSize = true;
            uxTextBox.Anchor = uxTextBox.Anchor | AnchorStyles.Right;

            form.Controls.AddRange(new Control[] { uxLabel, uxTextBox, uxOK, uxCancel });
            form.ClientSize = new Size(Math.Max(300, uxLabel.Right + 10), form.ClientSize.Height);
            form.AcceptButton = uxOK;
            form.CancelButton = uxCancel;

            _result = form.ShowDialog();
            value = uxTextBox.Text;
            return _result;
        }
    }
}