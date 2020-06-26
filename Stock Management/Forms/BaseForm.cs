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
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.WindowState = FormWindowState.Normal;
            childForm.Dock = DockStyle.Fill;
            childForm.Show();
            childForm.Focus();
        }

        public void ShowFormAsDialog(BaseForm parentForm, BaseForm childForm)
        {
            childForm.CallerForm = parentForm;
            childForm.MaximizeBox = false;
            childForm.MinimizeBox = false;
            childForm.ShowInTaskbar = false;
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

        //internal void NumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    // Verify that the pressed key isn't CTRL or any non-numeric digit
        //    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
        //    {
        //        e.Handled = true;
        //    }

        //    // If you want, you can allow decimal (float) numbers
        //    if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
        //    {
        //        e.Handled = true;
        //    }
        //}
    }
}
