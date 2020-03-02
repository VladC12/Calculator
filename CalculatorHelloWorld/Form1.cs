using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace CalculatorHelloWorld {

    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        public static string preveq = "", prevop = "", op = "";
        public static double answer = 0;

        private void AllBtn_Click(object sender, EventArgs e) {
            Button btn = sender as Button;
            // MessageBox.Show(btn.Name); Testing if the buttons have proper name and are used as senders properly
            switch (btn.Name) {
                case "BtnDel":
                    if (Display.Text.Length > 0) {
                    Display.Text = Display.Text.Substring(0, Display.Text.Length - 1); //Will delete one character from display
                    }
                break;
                case "BtnC": //Will clear op and display C = clear
                    op = "";
                    Display.ResetText();
                    Display2.ResetText();
                break;
                case "BtnCE": //Will clear display CE = Clear Entry
                    Display.ResetText();        
                break;
                case "BtnPoint": //Decimal
                    if (!Display.Text.Contains(".")) { //case there already is
                        Display.Text += ".";
                    }
                break;
                case "BtnNegate":
                if (Display.Text.Length > 0) {
                    if (!Display.Text.Contains("-")) { //if it's positive it will a minus at end
                        Display.Text = "-" + Display.Text;
                    }
                    else if (Display.Text.Contains("-")) { //if it's negative will remove the minus
                        Display.Text = Display.Text.Substring(1, Display.Text.Length - 1);
                    }
                }
                break;
                default:
                    if (op == "=") {
                        op = "";
                        Display.ResetText();
                    }
                    Display.Text += btn.Text; // adds stuff on display
                break;
            }
        }

        private void Operation_Click(object sender, EventArgs e) {
            Button opr = sender as Button;

            switch (opr.Text) {
                case "+":
                if (Display.Text.Length > 0) {
                    if (op == "" || op == "=") {
                        op = "+";
                        prevop = op;
                        preveq = Display.Text;
                        Display2.Text = preveq + op;
                        Display.ResetText();
                    }
                }
                else {
                    op = "+";
                    multi_eq(); //this will do the actual calculations
                }
                break;
                case "-":
                if (Display.Text.Length > 0) {
                    if (op == "" || op == "=") {
                        op = "-";
                        prevop = op;
                        preveq = Display.Text;
                        Display2.Text = preveq + op;
                        Display.ResetText();
                    }
                }
                else {
                    op = "-";
                    multi_eq();
                }
                break;
                case "÷":
                if (Display.Text.Length > 0) {
                    if (op == "" || op == "=") {
                        op = "÷";
                        prevop = op;
                        preveq = Display.Text;
                        Display2.Text = preveq + op;
                        Display.ResetText();
                    }
                }
                else {
                    op = "";
                    multi_eq();
                }
                break;
                case "x":
                if (Display.Text.Length > 0) {
                    if (op == "" || op == "=") {
                        op = "x";
                        prevop = op;
                        preveq = Display.Text;
                        Display2.Text = preveq + op;
                        Display.ResetText();
                    }
                }
                else {
                    op = "x";
                    multi_eq();
                }
                break;
                case "=":
                if (Display.Text.Length > 0) {
                    op = "";
                    multi_eq();
                    Display2.ResetText();
                    Display.Text = answer.ToString();
                }
                break;
            }
        }
        private void multi_eq() {
            if (prevop == "+") {
                prevop = op;

                answer = Convert.ToDouble(preveq, CultureInfo.InvariantCulture) + Convert.ToDouble(Display.Text);
                                                  //not sure why but it fixes decimal division
                preveq = answer.ToString();
                Display2.Text = preveq + op;
                Display.ResetText();
            }
            else if (prevop == "-") {
                prevop = op;

                answer = Convert.ToDouble(preveq, CultureInfo.InvariantCulture) - Convert.ToDouble(Display.Text);

                preveq = answer.ToString();
                Display2.Text = preveq + op;
                Display.ResetText();
            }
            else if (prevop == "÷") {
                prevop = op;

                answer = Convert.ToDouble(preveq, CultureInfo.InvariantCulture) / Convert.ToDouble(Display.Text);

                preveq = answer.ToString();
                Display2.Text = preveq + op;
                Display.ResetText();
            }
            else if (prevop == "x") {
                prevop = op;

                answer = Convert.ToDouble(preveq, CultureInfo.InvariantCulture) * Convert.ToDouble(Display.Text);

                preveq = answer.ToString();
                Display2.Text = preveq + op;
                Display.ResetText();
            }
        }
    }
}
