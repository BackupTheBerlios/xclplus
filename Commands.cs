using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace XCL_
{
    public static class Commands
    {
        public static void messagebox(string[] message){
            if (message[0] == "|") { if (Functions.argumentgetarar(message)[0] == "input") { message = Commands.input(Functions.argumentgetarstr(Functions.argumentgetarar(message))).Split(' '); } }
            MessageBox.Show(string.Join(" ",message));

        }

        public static string input(string inputstr)
        {
            input inputd = new input(); inputd.Text = inputstr; inputd.ShowDialog();
            string inputo = inputd.inputs;
            inputd = null;
            return inputo;
        }
    }
}
