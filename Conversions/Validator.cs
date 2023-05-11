using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Conversions
{
    /// <summary>
    /// a repository of validation methods
    /// </summary>
    /// <param name="textBox">text box to check</param>
    public static class Validator
    {
        public static bool IsValid(TextBox textbox) 
        {
            bool isValid = true;
            if(textbox.Text=="")//bad
            {
                MessageBox.Show( textBox.Tag + "is required")
                textBox.focus();
                 isValid=false;
            }
           return isValid 
        }

    }
}
