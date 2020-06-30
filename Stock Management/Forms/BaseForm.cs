using System.Windows.Forms;

namespace Stock_Management.Forms
{
    public class BaseForm : Form
    {
        public BaseForm CallerForm { get; set; }

        public void ShowFormAsMDIChild(Form parentForm, Form childForm)
        {
            FormCollection formCollection = Application.OpenForms;
            if (formCollection != null && formCollection.Count > 0)
            {
                foreach (Form formItem in formCollection)
                {
                    if (formItem.Name != parentForm.Name && formItem.Name != childForm.Name)
                    {
                        //frm.Close();
                        //frm.Dispose();
                        formItem.Hide();
                        break;
                    }
                }
            }
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
                return dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            }
            else
            {
                return "";
            }
        }
    }
}
