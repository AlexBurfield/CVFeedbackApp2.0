using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReplyHelper
{
    public partial class SetOptionsForm : Form
    {
        public SetOptionsForm()
        {
            InitializeComponent();
        }
        int OptionSetNumber;
        protected int AddOptionSet(int OptionCounter)
        {
            OptionSetNumber = OptionCounter ;

            return 1;
        }
        private void AddOptiontoSet_MouseClick(object sender, MouseEventArgs e)
        {
              
        }
    }
}
