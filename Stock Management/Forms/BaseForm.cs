using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace Stock_Management.Forms
{
    public class BaseForm : Form
    {
        #region
        public const string CRUD_OP_ADD = "Add";
        public const string CRUD_OP_VIEW = "View";
        public const string CRUD_OP_EDIT = "Edit";
        public const string CRUD_OP_UPDATE = "Update";
        #endregion
        public BaseForm CallerForm { get; set; }
        internal ToolTip toolTip;

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (Name != "MainForm") // do not close main form on Esc button press
            {
                if (keyData == Keys.Escape)
                {
                    Close();
                    return true;
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        internal void NumericContyrolKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) // Only numeric values and decimal are allowed
            {
                e.Handled = true;
            }
        }

        internal void NumericControlWithoutDecimalKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) // Only numeric values are allowed, decimal also not allowed
            {
                e.Handled = true;
            }
        }

        internal void ShowFormAsFixedDialog(BaseForm parentForm, BaseForm childForm)
        {
            childForm.CallerForm = parentForm;
            childForm.MaximizeBox = false;
            childForm.MinimizeBox = false;
            childForm.ShowInTaskbar = false;
            childForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            childForm.StartPosition = FormStartPosition.CenterParent;
            childForm.ShowDialog();
        }

        internal void ShowFormResizableAsDialog(BaseForm parentForm, BaseForm childForm)
        {
            childForm.CallerForm = parentForm;
            childForm.MinimizeBox = false;
            childForm.ShowInTaskbar = false;
            childForm.StartPosition = FormStartPosition.CenterParent;
            childForm.Width = parentForm.Width - 20;
            childForm.Height = parentForm.IsMdiChild ? parentForm.MdiParent.Height - 40 : parentForm.Height - 40;
            childForm.ShowDialog();
        }

        internal void ShowFormInPanel(BaseForm parentForm, Panel panel, BaseForm childForm)
        {
            childForm.CallerForm = parentForm;
            panel.Controls.Clear();//contentpnl is the panelname
            childForm.TopLevel = false;
            childForm.AutoScroll = true;
            panel.Controls.Add(childForm);
            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Show();
        }

        internal void ShowFormInGroupBox(BaseForm parentForm, GroupBox groupBox, BaseForm childForm)
        {
            childForm.CallerForm = parentForm;
            groupBox.Controls.Clear();//contentpnl is the panelname
            childForm.TopLevel = false;
            childForm.AutoScroll = true;
            groupBox.Controls.Add(childForm);
            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Show();
        }

        internal string GetSelectedCellText(DataGridView dataGridView, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return "";
            }
            else if (e.ColumnIndex != -1)
            {
                return (dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null ? "" : dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            }
            else
            {
                return "";
            }
        }
        internal static void ToTitleCase(TextBox textBox)
        {
            // Save the selection's start and length.
            int sel_start = textBox.SelectionStart;
            int sel_length = textBox.SelectionLength;
            CultureInfo culture_info = Thread.CurrentThread.CurrentCulture;
            TextInfo text_info = culture_info.TextInfo;
            textBox.Text = text_info.ToTitleCase(textBox.Text);
            // Restore the selection's start and length.
            textBox.Select(sel_start, sel_length);
        }

        internal void PrepareTooltips(Control ctrlContainer)
        {
            toolTip = new ToolTip();
            foreach (Control ctrl in ctrlContainer.Controls)
            {
                if (ctrl is GroupBox)
                {
                    PrepareTooltips(ctrl);
                }

                if (ctrl is Button && ctrl.Tag is string)
                {
                    ctrl.MouseHover += new EventHandler(delegate (Object o, EventArgs a)
                    {
                        var btn = (Control)o;
                        toolTip.SetToolTip(btn, btn.Tag.ToString());
                    });
                }
            }
        }
    }
}
