﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace XCL_
{
    public static class values
    {
        // sets up read only values
        public const string numver = "0003";
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string arg = string.Join(" ", args);
            if (arg.Length > 0)
            {
                xclrun(arg);
            }
            else { MessageBox.Show("No XCL+ Files to Run!", "XCL+");  }
        }

        public static void xclrun(string filename)
        {
            string line = "";
            TextReader text = new StreamReader(filename);
            while (line != null)
            {
                // reads the file
                line = text.ReadLine();
                // ends if line is null
                if (line == null) { text.Close(); return; }
                // makes new lowercase string
                string inputlr = line.ToLower();
                // converts string "inputlr" to an array of strings called "inputlrar" 
                string[] inputlrar = inputlr.Split(new char[] { ' ' });
                // converts string "line" to an array of strings called "inputar" 
                string[] inputar = line.Split(new char[] { ' ' });
                // exits in string is "exit"
                if (inputlrar[0] == "exit") { return; }
                // starts the command find system & see if the command was (in)valid and prints error message if appropriate
                if (cmdrun(inputlrar, inputar, line) == true) { MessageBox.Show("Bad Command: " + inputar[0], "XCL+"); }
            }
        }

        public static Boolean cmdrun(string[] inputlr, string[] input, string inputstr)
        {
            // the messagebox command
            if (inputlr[0] == "messagebox") { Commands.messagebox(Functions.argumentgetarar(input)); return false; }
            if (inputlr[0] == "about") { AboutBox about = new AboutBox(); about.ShowDialog(); about = null; return false; }
            if (inputlr[0] == "exe") { if (File.Exists(Functions.argumentgetarstr(input))) { Process.Start(Functions.argumentgetarstr(input)); } }
            if (inputlr[0] == "xcl+file") { if (File.Exists(Functions.argumentgetarstr(input))) { xclrun(Functions.argumentgetarstr(input)); } }
            return true;
        }
    }
}
