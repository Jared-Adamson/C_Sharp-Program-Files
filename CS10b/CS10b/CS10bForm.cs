using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

//CS10b by Jared Adamson

namespace CS10b
{
    public partial class frmCS10b : Form
    {
        
        public frmCS10b()
        {
            InitializeComponent();
        }

        private void btnForLoop_Click(object sender, EventArgs e)
        {
            int r; //row
            int c; //column
            int intResult;
            string strSpace;

            txtTable.Clear(); //clear the text box
            
            //Outer loop goes down the rows
            for (r = 1; r < 10; r++)
            {
                //Inner loop goes across the columns
                for (c = 1; c < 10; c++)
                {
                    intResult = r * c;

                    if (intResult < 10)
                        strSpace = "  ";  //two spaces 
                    else
                        strSpace = " ";   //one space
                    txtTable.AppendText(strSpace); // insert space

                    txtTable.AppendText(intResult.ToString());  //insert result
                }

                txtTable.AppendText("\r\n");  //Move down one line
           }
        }

 
        //Modify the nested for loops used above to nested while loops
        private void btnWhileLoop_Click(object sender, EventArgs e)
        {
            int r; //row
            int c; //column
            int intResult;
            string strSpace;

            txtTable.Clear(); //clear the text box

            r = 0;
            while (r < 9)
            {
                r++;
                c = 0;
                while (c < 9)
                {
                    c++;
                    intResult = r * c;

                    if (intResult < 10)
                        strSpace = "  ";  //two spaces
                    else
                        strSpace = " ";   //one space
                    txtTable.AppendText(strSpace); // insert space

                    txtTable.AppendText(intResult.ToString());  //insert result

                }

                txtTable.AppendText("\r\n");  //Move down one line
            }
          }
    

        //Modify the nested for loops used above to nested do-while loops
        private void btnDoWhileLoop_Click(object sender, EventArgs e)
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

                   
                    if (intResult < 11)
                        strSpace = "  ";  //two spaces
                    else
                        strSpace = " ";   //one space
                    
                    txtTable.AppendText(strSpace); // insert space

                    txtTable.AppendText(intResult.ToString());  //insert result

                } while (c < 10);
                r++;
            } while (r < 10);

                txtTable.AppendText("\r\n");  //Move down one line
            }

        private void exitBtn_Click(object sender, EventArgs e)
        {
           

        }
            }

       
        }


      


    //end of form
//end of namespace