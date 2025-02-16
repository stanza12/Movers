using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;



namespace SR_Movers_coursework.Forms
{
    public static class InputBox
    {
            public static DialogResult Show(string title, string promptText, out string length, out string width, out string height)
            {
                Form form = new Form();
                Label label = new Label();
                TextBox txtLength = new TextBox();
                TextBox txtWidth = new TextBox();
                TextBox txtHeight = new TextBox();
                Button buttonOk = new Button();
                Button buttonCancel = new Button();

                form.Text = title;
                label.Text = promptText;
                buttonOk.Text = "OK";
                buttonCancel.Text = "Cancel";
                buttonOk.DialogResult = DialogResult.OK;
                buttonCancel.DialogResult = DialogResult.Cancel;

                label.SetBounds(9, 20, 372, 13);
                txtLength.SetBounds(12, 36, 372, 20);
                txtWidth.SetBounds(12, 62, 372, 20);
                txtHeight.SetBounds(12, 88, 372, 20);
                buttonOk.SetBounds(228, 126, 75, 23);
                buttonCancel.SetBounds(309, 126, 75, 23);

                form.ClientSize = new Size(400, 160);
                form.Controls.AddRange(new Control[] { label, txtLength, txtWidth, txtHeight, buttonOk, buttonCancel });
                form.FormBorderStyle = FormBorderStyle.FixedDialog;
                form.StartPosition = FormStartPosition.CenterScreen;
                form.MinimizeBox = false;
                form.MaximizeBox = false;
                form.AcceptButton = buttonOk;
                form.CancelButton = buttonCancel;

                DialogResult dialogResult = form.ShowDialog();
                length = txtLength.Text;
                width = txtWidth.Text;
                height = txtHeight.Text;
                return dialogResult;
            }
        

    }
}
