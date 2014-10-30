//Jared Adamson

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System. Windows . Forms;

namespace CS3
{
public partial class frmCS3 : Form
{
public frmCS3()
{
InitializeComponent ();

namespace CS3
{
public partial class frmCS3 : Form
{
public frmCS3()
{
InitializeComponent ();
}
//Declare class—level variables and constants
//Class variables are initialized to zero when declared
int cint0rderCount;
decimal cdecGrandTotal;
const decimal cdecTAX_RATE = 0.08M;
const decimal cdecSHIPPING_AHT = 10.00M;




private void btnCalculate_Click(object sender, EventArgs e)
{
// declare method variables
int intQuantitv;
decimal decPrice;
decimal decExtendedPrice;
decimal decSalesTax;
decimal decTotalDue;
decimal decAverageOrder;
//Input:
//Use nested try-catch blocks to get the input values
try
{
intQuantity = int.Parse(txtQuantity.Text);
try
{
decPrice = decimal.Parse (txtPrice.Text);
//Process:
//We now have a numeric quantity and price.
//Continue processing by performing calculations.
decExtendedPrice = intQuantity * decPrice;
decSalesTax = decExtendedPrice * cdecTAX_RATE;
decTotalDue = decExtendedPrice + decSalesTax + cdecSHIPPING_AHT;
//Accumulate summary totals
cdecGrandTotal += decTotalDue;
cintOrderCount += 1;
decAverageOrder = cdecGrandTotal / cintOrderCount;


//Output:
//We now have all of the values to display
1b1ExtendedPrice.Text = decExtendedPrice.ToString("C"); //Currency
1b1SalesTax.Text = decSa1esTax.ToString ("C");
1b1Shipping.Text = cdecSHIPPING_AHT.ToString ("C");
1b1Tota1Due.Text = decTota1Due.ToString ("C");
1b1GrandTota1.Text = cdecGrandTota1.ToString("C");
1b1NumberOfOrders.Text = cint0rderCount.ToString("NU");//N and a Zero
1b1AverageOrder.Text = decAverageOrder.ToString("C");
}
//Handle exceptions for price
catch (FormatException err)
{
MessageBox.Show("Price must be numeric. " + err.Hessage,
"Data Entry Error", MessageBoxButtons.OK,
MessageBoxIcon.Exclamation);
txtPrice.Se1ectA11();
txtPrice.Focus();
}
}
//Handle exceptions for quantity
catch (FormatException err)
{
MessageBox.Show("Quantity must be numeric. " + err.Message,
"Data Entry Error", MessageBoxButtons.OK,
MessageBoxIcon.Exclamation);
txtQuantity.Se1ectA11();
txtQuantity.Focus();
}
//Handle any other exceptions. Exceptions not caught by the inner




//Try will also end up here because that Try is inside the outer Try.
catch(Exception err)
{
MessageBox.Show("Unexpected Error: " + err.Message);
}
}//end of btnCalculate
private void btnC1earFormLC1ick(object sender, EventArgs e)
{
//Use Clear or null string "” for TextBoxes, but
//only use null string "” for Labels
txtQuantitv.C1ear(); //Clear
txtPrice.C1ear();
1b1ExtendedPrice.Text = ""; //null string
1b1Sa1esTax.Text = "";
1b1Shipping.Text = "";
1b1Tota1Due.Text = "";
1b1GrandTota1.Text = "";
1b1Number0fOrders.Text = "";
1b1AverageOrder.Text = "";
cdecGrandTota1 = 0; //Reset Accumulators
cintOrderCount = 0;
txtQuantitv.Focus();
}//end of btnClearForm

private void btnExit_C1ick(object sender, EventArgs e)
{
this.C1ose();
}//end of btnExit
}//end of class
}//end of namespace

