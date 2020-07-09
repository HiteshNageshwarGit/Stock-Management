using System;
using System.Drawing;
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

        public void NumericFieldKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) // Only numeric values are allowed
            {
                e.Handled = true;
            }
        }

        //public void CloseMDIChildForms(Form parentForm)
        //{
        //    FormCollection formCollection = Application.OpenForms;
        //    if (formCollection != null && formCollection.Count > 0)
        //    {
        //        foreach (Form formItem in formCollection)
        //        {
        //            if (formItem.Name != parentForm.Name
        //                //&& formItem.Name != childForm.Name
        //                )
        //            {
        //                formItem.Close();
        //                formItem.Dispose();
        //                //formItem.Hide();
        //                break;
        //            }
        //        }
        //    }
        //}
        //public void ShowFormAsMDIChild(Form parentForm, Form childForm)
        //{
        //    parentForm.IsMdiContainer = true;
        //    childForm.MdiParent = parentForm;
        //    childForm.MaximizeBox = false;
        //    childForm.MinimizeBox = false;
        //    childForm.ShowInTaskbar = false;
        //    childForm.FormBorderStyle = FormBorderStyle.None;
        //    childForm.WindowState = FormWindowState.Normal;
        //    childForm.Dock = DockStyle.Fill;
        //    childForm.Show();
        //    childForm.Focus();
        //}

        public void ShowFormAsFixedDialog(BaseForm parentForm, BaseForm childForm)
        {
            childForm.CallerForm = parentForm;
            childForm.MaximizeBox = false;
            childForm.MinimizeBox = false;
            childForm.ShowInTaskbar = false;
            childForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            childForm.StartPosition = FormStartPosition.CenterParent;
            childForm.ShowDialog();
        }

        public void ShowFormResizableAsDialog(BaseForm parentForm, BaseForm childForm)
        {
            childForm.CallerForm = parentForm;
            childForm.MinimizeBox = false;
            childForm.ShowInTaskbar = false;
            childForm.StartPosition = FormStartPosition.CenterParent;
            childForm.Width = parentForm.Width - 20;
            childForm.Height = parentForm.IsMdiChild ? parentForm.MdiParent.Height - 40 : parentForm.Height - 40;
            //childForm.Text = "Form Name: " + childForm.Name + " (" + childForm.Width + "X" + childForm.Height + ")";
            childForm.ShowDialog();
        }

        public void ShowFormInPanel(Panel panel, BaseForm childForm)
        {
            panel.Controls.Clear();//contentpnl is the panelname
            childForm.TopLevel = false;
            childForm.AutoScroll = true;
            panel.Controls.Add(childForm);
            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Show();
        }

        public string GetSelectedCellText(DataGridView dataGridView, DataGridViewCellEventArgs e)
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
    }
}
