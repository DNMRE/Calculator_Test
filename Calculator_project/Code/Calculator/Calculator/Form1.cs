using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        //Double resultValue = 0;
        //String operationPerformed = "";

        double resultValue = 0;
        string operationPerformed = "";
        bool isOperationPerformed = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void Button_click(object sender, EventArgs e)
        {
            if ((Resultbox.Text == "0") || (isOperationPerformed))
                Resultbox.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            if(button.Text == ",")
            {
                if (!Resultbox.Text.Contains(","))
                    Resultbox.Text = Resultbox.Text + button.Text;
                    
            }else

            Resultbox.Text = Resultbox.Text + button.Text;
        }

        private void OperatorClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if(resultValue!=0)
            {
                buttonEqual.PerformClick();
                operationPerformed = button.Text;
                isOperationPerformed = true;
            }
            
            else
            {
                operationPerformed = button.Text;              
                resultValue = Double.Parse(Resultbox.Text);
                isOperationPerformed = true;

            }

            if (isOperationPerformed == true)
            {
                Resultbox.Clear();
                
            }
                
                

            /*
            
            if(isOperationPerformed == true)
            {
                Resultbox.Text = "";          
            }
            
            */
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            Resultbox.Text = "0";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            Resultbox.Text = "0";
            resultValue = 0;
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {

            if (operationPerformed == "+")
            {
                Resultbox.Text = (resultValue + double.Parse(Resultbox.Text)).ToString();
            }

            else if (operationPerformed == "-")
            {
                Resultbox.Text = (resultValue - double.Parse(Resultbox.Text)).ToString();
            }

            else if (operationPerformed == "x")
            {
                Resultbox.Text = (resultValue * double.Parse(Resultbox.Text)).ToString();
            }

            else if(operationPerformed == "/")
            {
                Resultbox.Text = (resultValue / double.Parse(Resultbox.Text)).ToString();
            }

            resultValue = Double.Parse(Resultbox.Text);
            resultValue = 0;
            isOperationPerformed = true;

            /*
            
            switch (operationPerformed)
            {

                case "+":
                    Resultbox.Text = (resultValue + Double.Parse(Resultbox.Text)).ToString();
                    break;

                case "-":
                    Resultbox.Text = (resultValue - Double.Parse(Resultbox.Text)).ToString();
                    break;

                case "x":
                    Resultbox.Text = (resultValue * Double.Parse(Resultbox.Text)).ToString();
                    break;

                case "/":
                    Resultbox.Text = (resultValue / Double.Parse(Resultbox.Text)).ToString();
                    break;

                default:
                    break;

            }
            
            */
           
                                   
            
        }

        
    }
}



                
/*

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false; 
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void Button_click(object sender, EventArgs e)
        {
            if ((Resultbox.Text == "0") || (isOperationPerformed))
                Resultbox.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;

            Resultbox.Text = Resultbox.Text + button.Text;
        }

        private void OperatorClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationPerformed = button.Text;
            Prevresult.Text = resultValue + " " + operationPerformed;
            resultValue = Double.Parse(Resultbox.Text);
            isOperationPerformed = true;
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            Resultbox.Text = "0";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            Resultbox.Text = "0";
            resultValue = 0;
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            switch(operationPerformed)
            {

                case "+":
                    Resultbox.Text = (resultValue + Double.Parse(Resultbox.Text)).ToString();
                    break;

                case "-":
                    Resultbox.Text = (resultValue - Double.Parse(Resultbox.Text)).ToString();
                    break;

                case "x":
                    Resultbox.Text = (resultValue * Double.Parse(Resultbox.Text)).ToString();
                    break;

                case "/":
                    Resultbox.Text = (resultValue / Double.Parse(Resultbox.Text)).ToString();
                    break;

                case "%":
                    Resultbox.Text = (resultValue % Double.Parse(Resultbox.Text)).ToString();
                    break;

                default:
                    break;

            }
        }
    }
}

*/

