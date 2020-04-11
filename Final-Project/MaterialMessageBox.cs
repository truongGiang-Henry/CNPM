using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public static class MaterialMessageBox
    {
        public static DialogResult Show(string message, string caption)
        {
            FormOK ok = new FormOK();
            ok.Text = caption;
            ok.setMessage(message);

            return ok.ShowDialog();
        }
    }
}
