using System;

using System.Collections;

using System.Configuration;

using System.Data;

using System.Linq;
using System.Threading;
using System.Web;

using System.Web.Security;

using System.Web.UI;

using System.Web.UI.HtmlControls;

using System.Web.UI.WebControls;

using System.Web.UI.WebControls.WebParts;

using System.Xml.Linq;


namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //TimerCallback tm = new TimerCallback(DoActioan);
            //System.Threading.Timer timer = new System.Threading.Timer(tm, null, 0, 1500);
            
        }

        private void Timer()
        {
            
        }

        private void DoActioan()
        {
            var random = new Random();

            int rangeEuro = random.Next(0, 1000000);
            double euro = random.NextDouble() * rangeEuro;

            int rangeDollar = random.Next(0, 1000000);
            double dollar = random.NextDouble() * rangeDollar;

            int rangeRuble = random.Next(0, 1000000);
            double ruble = random.NextDouble() * rangeRuble;

            ResultrLabel.Text = euro.ToString();
            Label3.Text = dollar.ToString();
            Label5.Text = ruble.ToString();

        }

        protected void GoButton_Click(object sender, EventArgs e)

        {

          


        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            DoActioan();
        }


        //protected void UploadButton_Click(object sender, EventArgs e)
        //{
        //// Specify the path on the server to
        //// save the uploaded file to.
        //String savePath = @"C:\Users\admin\source\ссп\ajax\SSP\WebApplication2\WebApplication2\images\";

        //// Before attempting to perform operations
        //// on the file, verify that the FileUpload 
        //// control contains a file.
        //if (FileUpload1.HasFile)
        //{
        //    // Get the name of the file to upload.
        //    String fileName = FileUpload1.FileName;

        //    // Append the name of the file to upload to the path.
        //    savePath += fileName;


        //    // Call the SaveAs method to save the 
        //    // uploaded file to the specified path.
        //    // This example does not perform all
        //    // the necessary error checking.               
        //    // If a file with the same name
        //    // already exists in the specified path,  
        //    // the uploaded file overwrites it.
        //    FileUpload1.SaveAs(savePath);

        //    // Notify the user of the name of the file
        //    // was saved under.
        //    UploadStatusLabel.Text = "Your file was saved as " + fileName;
        //    Image1.ImageUrl = "images/"+fileName;
        //}
        //else
        //{
        //    // Notify the user that a file was not uploaded.
        //    UploadStatusLabel.Text = "You did not specify a file to upload.";
        //}

        //}
    }
}