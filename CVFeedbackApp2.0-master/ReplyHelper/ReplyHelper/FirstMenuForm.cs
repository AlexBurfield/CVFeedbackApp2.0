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
    public partial class FirstMenuForm : Form
    {
        public FirstMenuForm()
        {
            InitializeComponent(); 
        }
        //Initializes and displays the form to create a new Template
        private void NewTemplateButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            CreateNewTemplateForm NewCreateNewTemplateForm = new CreateNewTemplateForm();
            NewCreateNewTemplateForm.ShowDialog();
            
        }
        //Initializes and displays the form to Edit a new Template
        private void EditButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            LoadForm NewEditTemplateform = new LoadForm();
            NewEditTemplateform.ShowDialog();
        }
        //Initializes and displays the form for making replies
        private void MakeReplyButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            ReplyForm NewReplyForm = new ReplyForm();
            NewReplyForm.ShowDialog();
        }

        private void FirstMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void MakeReplyButton_Click(object sender, EventArgs e)
        {

        }
    }
}
