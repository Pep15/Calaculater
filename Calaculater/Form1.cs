using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calaculater
{

  
    public partial class Form1 : Form
    {
        stCalaculater Calaculater;
        EnOperations CurrentOperation;
        EnNumbers CurrentNumbers = EnNumbers.Number1;
        bool OprationClicked = false;
       enum EnNumbers
        {
            Number1,
            Number2,
       
        }
       enum EnOperations
        {
            Plus,
            multiplication,
            subtract,
            Divide,
            None
        }
        private bool isZero(float number1 , float number2)
        {
            if(number1 == 0  || number2 == 0)
            {
                return true;
            }

            return false;
        }
         struct stCalaculater
        {
            public float Number1;
            public float Number2;
           
        }
        public Form1()
        {
            InitializeComponent();
            RestCalaculater();
        }
        private void RestCalaculater()
        {
            lbScreen.Text = "0";
            CurrentOperation = EnOperations.None;
            Calaculater.Number1 = 0;
            Calaculater.Number2 = 0;
            CurrentNumbers= EnNumbers.Number1;
            
        }
        private void CalaculaterResult()
        {
            
           
            float Result = 0;
            switch (CurrentOperation)
            {
                case EnOperations.Plus:
                    Result = Calaculater.Number1 + Calaculater.Number2;
                    break;
                case EnOperations.multiplication:
                        Result = Calaculater.Number1 * Calaculater.Number2;
                    break;
                case EnOperations.subtract:
                    Result = Calaculater.Number1 - Calaculater.Number2;
                    break;
                case EnOperations.Divide:
                    if(Calaculater.Number1 != 0 && Calaculater.Number2 != 0)
                    {
                        
                        Result = Calaculater.Number1 / Calaculater.Number2;
                        
                    }
                    else 
                    {
                        if (isZero(Calaculater.Number1, Calaculater.Number2))
                            Result = 1;
                    }
                    break;

            }
            lbScreen.Text = Result.ToString();
        }
       
      
        private void changeValueLable(object sender )
        {
            Button btn = (Button)sender;
            switch (CurrentNumbers)
            {
                case EnNumbers.Number1:
                    if(btn.Name == btn.Name)
                    {
                        lbScreen.Text = btn.Text;
                        Calaculater.Number1 = float.Parse(lbScreen.Text);
                        CurrentNumbers = EnNumbers.Number2;
                    }
                    break;
                case EnNumbers.Number2:
                    if (btn.Name == btn.Name)
                    {
                        lbScreen.Text = btn.Text;
                        Calaculater.Number2 = float.Parse(lbScreen.Text);
                        
                    }
                    break;
            }
        }
        private void GetCalaculaterResult(object sender)
        {
            Button btn = ( Button )sender;
            switch(btn.Text)
            {
                case "+":
                    CurrentOperation = EnOperations.Plus;
                    break;
                case "-":
                    CurrentOperation = EnOperations.subtract;
                    break;
                case "X":
                    CurrentOperation = EnOperations.multiplication;
                    break;
                case "÷":
                    CurrentOperation = EnOperations.Divide;
                    break;

            }
            OprationClicked = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            changeValueLable(sender);
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            changeValueLable(sender);

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            changeValueLable(sender);

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            changeValueLable(sender);

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            changeValueLable(sender);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            changeValueLable(sender);

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            changeValueLable(sender);

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            changeValueLable(sender);

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            changeValueLable(sender);

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
           
            GetCalaculaterResult((Button)sender);
        }

        private void btnmultiplication_Click(object sender, EventArgs e)
        {
           
            GetCalaculaterResult((Button)sender);
        }

        private void btnsubtract_Click(object sender, EventArgs e)
        {
           
            GetCalaculaterResult((Button)sender);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
           
            GetCalaculaterResult((Button)sender);
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            RestCalaculater();
        }

        private void btnEqule_Click(object sender, EventArgs e)
        {
            CalaculaterResult();
        }
    }
}
