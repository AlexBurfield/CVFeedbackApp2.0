using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplyHelper
{
    class Option 
    {
        private string title;
        private string message;

        public void GetMessage(string gotMessage)
        {
            if (gotMessage == null)
            {
                //need error form
                //move all error catching to SetOptionsForm.cs
                //Console.WriteLine("Message does not exist");
            }
            else
            {
                gotMessage = message;
            }
        }
        public void GetTitle(string gottitle)
        {
            gottitle = title;
            if (title == null)
            {
                //Console.WriteLine("Title does not exist");
            }
        }
    }
}
