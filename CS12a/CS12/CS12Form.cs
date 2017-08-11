using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

//Project:     CS12 Array Processing
//Programmer:  Jared Adamson


using System.IO;  

namespace CS12
{
    public partial class frmCS12 : Form
    {
        public frmCS12()
        {
            InitializeComponent();
        }

        //Declare class-level arrays
        const int cintARRAY_SIZE = 10;  //used to declare arrays
        int[] cstrId = new int[cintARRAY_SIZE];
        string[] cstrName = new string[cintARRAY_SIZE];
        string[] discountCode = new string[cintARRAY_SIZE];
        decimal[] cstrDiscountPer = new decimal[cintARRAY_SIZE];
        string[] cstrDiscount = new string[cintARRAY_SIZE];
        string[] cstrDISCOUNT_CODE = new string[] { "A", "F", "S", "X" };
       
        decimal[] cdecDISCOUNT_RATE = new decimal[] { 0.03M, 0.05M, 0.1M, 0M };
        int cintNumberOfCustomers;

       
        decimal[] cdecPERCENT_RANGE = new decimal[] { 97M, 95M, 90M, 00M,};

        private void btnLoadArrays_Click(object sender, EventArgs e)
        {
            int i = 0; // subscript initialized to zero

          
          

            try
            {
                //Load the arrays with the data in the file
                FileStream studentFile = new FileStream("cs12.txt", FileMode.Open);
                StreamReader studentStreamReader = new StreamReader(studentFile);
                while (studentStreamReader.Peek() != -1)
                {
                    if (i < cstrName.Length)
                    {
                        cstrId[i] = int.Parse(studentStreamReader.ReadLine());
                        cstrName[i] = studentStreamReader.ReadLine();
                        discountCode[i] = (studentStreamReader.ReadLine());
                        
                        i++;  //Increment subscript by one
                    }
                    else
                    {
                        MessageBox.Show
                            ("Error: Notify Programmer Array Size Exceeded. ",
                            "Array Size Exceeded", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                        break; //Get of out of loop; Arrays are full.
                    }//End If
                }//End Loop

                studentFile.Close();      //Close file
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Opening File. Data not loaded " + ex.Message,
                     "File Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            cintNumberOfCustomers = i;    
            assignDiscountRate();         
            displayArrays();             
            btnLoadArrays.Enabled = false;  

        }


        void assignDiscountRate()
        {
            int c;
            int r;

            //Use cintNumberOfCustomers to process a partially filled array
            //cintNumberOfCustomers is like Length, so we need to subtract one
            //to get the subscript value of the last entry.

            //outer loop walks through customers
            //inner loop looks up code 

            for (c = 0; c < cintNumberOfCustomers; c++)
            {
                for (r = 0; r <= cdecDISCOUNT_RATE.GetUpperBound(0); r++)
                {
                    if (discountCode[c] == cstrDISCOUNT_CODE[r])
                    {
                        cstrDiscountPer[c] = cdecDISCOUNT_RATE[r];
                        break; //exit inner for loop
                    }
                }//next g - rate
            }//next s - customer
        }


        void displayArrays()
        {

            int i;

            

            lstName.Items.Clear();
            lstId.Items.Clear();
            lstCode.Items.Clear();
            lstRate.Items.Clear();
           

            for (i = 0; i < cintNumberOfCustomers; i++)
            {
                lstId.Items.Add(cstrId[i]);
                lstName.Items.Add(cstrName[i]);  
                lstCode.Items.Add(discountCode[i]);
                lstRate.Items.Add(cstrDiscountPer[i].ToString());
            }


        }


        private void btnSortById_Click(object sender, EventArgs e)
        {
            int i;
            int i2;
            int strMinId;
            int intMinSubscript;


            for (i = 0; i < cintNumberOfCustomers - 1; i++)
            {
                intMinSubscript = i;
                strMinId = cstrId[i];


                for (i2 = i + 1; i2 < cintNumberOfCustomers; i2++)
                {

                    if (cstrId[i2].CompareTo(strMinId) < 0)
                    {

                        strMinId = cstrId[i2];
                        intMinSubscript = i2;
                    }
                }

                swapArrayValues(i, intMinSubscript);
            }


            displayArrays();
        }


        void swapArrayValues(int i, int intMinSubscript)
        {
            string strHoldValue;
            decimal decHoldValue;
            int intHoldValue;

            strHoldValue = cstrName[i];
            cstrName[i] = cstrName[intMinSubscript];
            cstrName[intMinSubscript] = strHoldValue;

            decHoldValue = cstrDiscountPer[i];
            cstrDiscountPer[i] = cstrDiscountPer[intMinSubscript];
            cstrDiscountPer[intMinSubscript] = decHoldValue;

            strHoldValue = discountCode[i];
            discountCode[i] = discountCode[intMinSubscript];
            discountCode[intMinSubscript] = strHoldValue;


            intHoldValue = cstrId[i];
            cstrId[i] = cstrId[intMinSubscript];
            cstrId[intMinSubscript] = intHoldValue;
        }
		

        private void btnSortByName_Click(object sender, EventArgs e)
        {
           
            int i;
            int i2;
            string strMinName;
            int intMinSubscript;

           
            for (i = 0; i < cintNumberOfCustomers - 1; i++)
            {
                intMinSubscript = i;
                strMinName = cstrName[i];

                
                for (i2 = i + 1; i2 < cintNumberOfCustomers; i2++)
                {
                   
                    if (cstrName[i2].CompareTo(strMinName) < 0)
                    {
                        
                        strMinName = cstrName[i2];
                        intMinSubscript = i2;
                    }
                }

                swapArrayValues(i, intMinSubscript);
            }

            
            displayArrays();
        }


        private void btnSearchByName_Click(object sender, EventArgs e)
        {
            int i;
            bool blnNameFound = false;

           btnSortByName_Click(sender, e);
               
            txtSearchResults.Clear();

            for (i = 0; i < cintNumberOfCustomers; i++)
            {
                if (txtSearchName.Text.ToUpper() == cstrName[i].ToUpper())
                {
                    blnNameFound = true;
                    txtSearchResults.Text = "Matching name is selected in list box.";
                    lstName.SelectedIndex = i;
                    lstRate.SelectedIndex = i;
                    lstCode.SelectedIndex = i;
                    break; 
                }
                else if (txtSearchName.Text.ToUpper().CompareTo(cstrName[i].ToUpper()) < 0)
                {
                    txtSearchResults.Text = "Match not found - Early Exit taken";
                    break; 
                }
            }

            if (blnNameFound == false
            && txtSearchResults.Text == "")
                txtSearchResults.Text = "Match not found - Reached end of array";

        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }//end of class
}//end of namespace
