using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

//CS12c by Jared Adamson
 
namespace CS12c
{
    public partial class frmCS12c : Form
    {

        int [ , ] intTable = new int[9,9];  // 9 x 9 table 
        
        public frmCS12c()
        {
            InitializeComponent();
        }

        private void btnLoadArray_Click(object sender, EventArgs e)
        {
                 int r; 
                 int c; 
                 int intResult;

       for(r = 0; r < intTable.GetLength(0); r++)
       {
          for(c = 0; c < intTable.GetLength(1); c++)
          {       
             intResult = (r + 1) * (c + 1);
             intTable[r,c] = intResult; 
          }
       }
          
        }

 
    
        private void btnDisplayArray_Click(object sender, EventArgs e)
        {
            
            
            int r; //row
            int c; //column
            int intResult;
            string strSpace;

            txtTable.Clear(); //clear the text box

            r = 1;
            do
            {
               
                c = 1;
                do
                {
                    intResult = r * c;
                    c++;


                    if (intResult < 10)
                        strSpace = "  ";  //two spaces
                    else
                        strSpace = " ";   //one space

                    txtTable.AppendText(strSpace); // insert space

                    txtTable.AppendText(intResult.ToString());  //insert result

                } while (c < 10);
                r++;
                txtTable.AppendText("\r\n"); 
            } while (r < 10);
        
           
            
            
        }


        private void btnSearchArray_Click(object sender, EventArgs e)
        {
            int r; //row
            int c; //column
            int intSearchNumber;
                   

         
            try
            {
                intSearchNumber = int.Parse(txtSearchNumber.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Not a valid number, please re-enter");
                txtSearchNumber.Focus();
                return;
            }

            
            for (r = 0; r < intTable.GetLength(0); r++)
            {
                for (c = 0; c < intTable.GetLength(1); c++)
                {
                    if (intSearchNumber == intTable[r, c])
                    {
                        txtTable.Clear(); 
                        txtTable.AppendText(intTable[r, c].ToString() + " is located at " + r + ", " + c); 
                        txtTable.AppendText("\r\n");  //Move down one line
                    }
                }
            }
        }

    
        
          
       


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

 
    }//end of form
}//end of namespace