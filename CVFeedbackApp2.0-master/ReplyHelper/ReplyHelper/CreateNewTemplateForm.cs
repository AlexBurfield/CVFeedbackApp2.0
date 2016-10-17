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
    public partial class CreateNewTemplateForm : Form
    {
        public CreateNewTemplateForm()
        {
            InitializeComponent();
        }

        private void SaveHeaderAndFooter_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            AddOptionSet Optionset1 = new AddOptionSet();
            Optionset1.ShowDialog();

        }

        private void LoadTemplate_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            LoadForm newLoadForm = new LoadForm();
            newLoadForm.ShowDialog();
        }

        private void PreviewCurrentTemplate_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            PreviewForm newPreviewForm = new PreviewForm();
            newPreviewForm.ShowDialog();
        }

        //Tom - Need back buttons, not yet working
        //private void BackButton_MouseClick(object sender, MouseEventArgs e)
        //{
        //    this.Hide();
        //    FirstMenuForm newFirstMenuForm = new FirstMenuForm();
        //    ShowDialog();
        //}

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void PreviewCurrentTemplate_Click(object sender, EventArgs e)
        {

        }
    }
}
