using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public partial class History : Form
    {
        public History(List<Calculation> calculations)
        {
            InitializeComponent();

            if (calculations != null)
                foreach (var item in calculations)
                    label1.Text += item.ToString() + "\n";
            else
                label1.Text = "История пуста";
        }
    }
}