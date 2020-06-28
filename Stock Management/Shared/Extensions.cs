using System.Windows.Forms;

namespace Stock_Management.Forms
{
    public static class Extensions
    {
        public static void EnumerateChildren(this Control root)
        {
            foreach (Control control in root.Controls)
            {
                //if (control is Label)
                //{
                //    Label lable = (Label)control;
                //    lable.BackColor = System.Drawing.SystemColors.Control;
                //    lable.ForeColor = System.Drawing.Color.Black;
                //}
                //if (control.Controls != null)
                //{
                //    EnumerateChildren(control);
                //}
            }
        }
    }
}
