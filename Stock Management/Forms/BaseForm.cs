using System.Windows.Forms;

namespace Stock_Management.Forms
{
    public class BaseForm : Form
    {
        public BaseForm CallerForm { get; set; }

        public void NumericFieldKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) // Only numeric values are allowed
            {
                e.Handled = true;
            }
        }
        public void CloseMDIChildForms(Form parentForm)
        {
            FormCollection formCollection = Application.OpenForms;
            if (formCollection != null && formCollection.Count > 0)
            {
                foreach (Form formItem in formCollection)
                {
                    if (formItem.Name != parentForm.Name
                        //&& formItem.Name != childForm.Name
                        )
                    {
                        formItem.Close();
                        formItem.Dispose();
                        //formItem.Hide();
                        break;
                    }
                }
            }
        }
        public void ShowFormAsMDIChild(Form parentForm, Form childForm)
        {
            parentForm.IsMdiContainer = true;
            childForm.MdiParent = parentForm;
            childForm.MaximizeBox = false;
            childForm.MinimizeBox = false;
            childForm.ShowInTaskbar = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.WindowState = FormWindowState.Normal;
            childForm.Dock = DockStyle.Fill;
            childForm.Show();
            childForm.Focus();
        }

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
            childForm.WindowState = parentForm.MdiParent.WindowState; // if main form is maximized then dialog also should open in maximise state
            childForm.ShowDialog();
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
