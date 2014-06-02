using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Q_Medic_Hospital
{
    public partial class Hospital_Admin : Form
    {
        
        public Hospital_Admin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Hospital_Admin_Load(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void staffProfileToolStripMenuItem_Click(object sender, EventArgs e) {
            ((HospitalAdminMaster)this.MdiParent).changeForm((int)HospitalAdminMaster.forms.StaffProfile);
        }

        private void label4_Click(object sender, EventArgs e) {

        }

        private void PatientViewBTN_Click(object sender, EventArgs e) {
            try {
                ((HospitalAdminMaster)this.MdiParent).PaitentID = Convert.ToInt32(PatientBox.Text);
                ((HospitalAdminMaster)this.MdiParent).changeForm((int)HospitalAdminMaster.forms.PatientProfile);
            }
            catch {
                PatientBox.Text = "Number Reqired";
            }
        }

        private void PatientBox_TextChanged(object sender, EventArgs e) {

        }

        private void pictureBox1_Click(object sender, EventArgs e) {

        }

        private void ExportPaitentDetails_Click(object sender, EventArgs e) {
            int PID;
            try {
                PID = Convert.ToInt32(PatientBox.Text);
            }
            catch {
                PID = -1;
                PatientBox.Text = "Number Reqired";
            }


            if (PID > -1) {
                MiddleWare.middle.OpenConnection();

                SqlCommand GetData = new SqlCommand(string.Format("select FirstName, LastName, Gender, DateOfBirth, StreetNo, StreetAddress, Suburb, PostCode, PhoneNumber, MobileNumber, Email from Patients WHERE PatientID='{0}';", PID), MiddleWare.middle.dbConnection);
                SqlDataReader dataReader = GetData.ExecuteReader();
                if (dataReader.HasRows) {
                    dataReader.Read();
                    String name = dataReader.GetString(0) + " " + dataReader.GetString(1);
                    String gender;
                    if (dataReader.GetBoolean(2) == true) {
                        gender = "Female";
                    } else {
                        gender = "Male";
                    }
                    String DOB = dataReader.GetString(3);
                    String address = dataReader.GetString(4) + " " + dataReader.GetString(5) + " " + dataReader.GetString(6) + " - PostCode: " + dataReader.GetString(7);
                    String phoneNumber = dataReader.GetString(8);
                    String mobileNumber = dataReader.GetString(9);
                    String Email = dataReader.GetString(10);

                    MiddleWare.middle.CloseConnection();

                    string printString;
                    PdfSharp.Pdf.PdfDocument PDFDocument = new PdfSharp.Pdf.PdfDocument();
                    PDFDocument.Info.Title = "Patient Details";
                    PdfSharp.Pdf.PdfPage PDFPage = PDFDocument.AddPage();
                    PdfSharp.Drawing.XGraphics PDFGraphics = PdfSharp.Drawing.XGraphics.FromPdfPage(PDFPage);
                    PdfSharp.Drawing.XFont font = new PdfSharp.Drawing.XFont("Verdana", 12, PdfSharp.Drawing.XFontStyle.Bold);
                    PdfSharp.Drawing.XRect rec = new PdfSharp.Drawing.XRect((PDFPage.Width / 8), 110, PDFPage.Width, PDFPage.Height);
                    // 0 - 90 banner       
                    PDFGraphics.DrawString("Q Medic Hospital Banner Goes Here", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect((PDFPage.Width / 4), 50, PDFPage.Width, PDFPage.Height), PdfSharp.Drawing.XStringFormats.TopLeft);
                    
                    printString = "Patient ID: " + PID;
                    PDFGraphics.DrawString(printString, font, PdfSharp.Drawing.XBrushes.Black, rec, PdfSharp.Drawing.XStringFormats.TopLeft);
                    rec.X = (PDFPage.Width / 8) + 20;

                    printString = "Name: " + name;
                    rec.Y = 150;
                    PDFGraphics.DrawString(printString, font, PdfSharp.Drawing.XBrushes.Black, rec, PdfSharp.Drawing.XStringFormats.TopLeft);

                    printString = "Gender: " + gender;
                    rec.Y = 170;
                    PDFGraphics.DrawString(printString, font, PdfSharp.Drawing.XBrushes.Black, rec, PdfSharp.Drawing.XStringFormats.TopLeft);

                    printString = "Date Of Birth: " + DOB;
                    rec.Y = 190;
                    PDFGraphics.DrawString(printString, font, PdfSharp.Drawing.XBrushes.Black, rec, PdfSharp.Drawing.XStringFormats.TopLeft);

                    printString = "Address: " + address;
                    rec.Y = 210;
                    PDFGraphics.DrawString(printString, font, PdfSharp.Drawing.XBrushes.Black, rec, PdfSharp.Drawing.XStringFormats.TopLeft);

                    printString = "Phone Number: " + phoneNumber;
                    rec.Y = 230;
                    PDFGraphics.DrawString(printString, font, PdfSharp.Drawing.XBrushes.Black, rec, PdfSharp.Drawing.XStringFormats.TopLeft);

                    printString = "Mobile Number: " + mobileNumber;
                    rec.Y = 250;
                    PDFGraphics.DrawString(printString, font, PdfSharp.Drawing.XBrushes.Black, rec, PdfSharp.Drawing.XStringFormats.TopLeft);

                    printString = "E-mail: " + Email;
                    rec.Y = 270;
                    PDFGraphics.DrawString(printString, font, PdfSharp.Drawing.XBrushes.Black, rec, PdfSharp.Drawing.XStringFormats.TopLeft);

                    String filename = PID + "_PaitentDetails.pdf";
                    PDFDocument.Save(filename);
                }
            }
        }

        private void ToDaysFinances_Click(object sender, EventArgs e) {
    
            // todayes finances
        }

        private void PaitentFinances_Click(object sender, EventArgs e) {
            int PID;
            try {
                PID = Convert.ToInt32(PatientBox.Text);
            }
            catch {
                PID = -1;
                PatientBox.Text = "Number Reqired";
            }


            if (PID > -1) {
                MiddleWare.middle.OpenConnection();

                SqlCommand GetData = new SqlCommand(string.Format("select FirstName, LastName from Patients WHERE PatientID='{0}';", PID), MiddleWare.middle.dbConnection);
                SqlDataReader dataReader = GetData.ExecuteReader();
                if (dataReader.HasRows) {
                    dataReader.Read();
                    String name = dataReader.GetString(0) + " " + dataReader.GetString(1);
                    MiddleWare.middle.CloseConnection();

                    MiddleWare.middle.OpenConnection();
                    String feeID = "";
                    String grossCost = "";
                    String DiscountedCost = "";
                    int totalCost = 0;
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataSet ds = new DataSet();
                    GetData = new SqlCommand(string.Format("SELECT Treatment.PatientID, Fees.FeeID, Fees.GrossCost, Fees.TotalCost FROM Treatment INNER JOIN Fees ON Treatment.FeeID = Fees.FeeID WHERE Treatment.PatientID = '{0}'", PID), MiddleWare.middle.dbConnection);
                    adapter.SelectCommand = GetData;
                    adapter.Fill(ds);
                    
                    MiddleWare.middle.CloseConnection();

                    string printString;
                    PdfSharp.Pdf.PdfDocument PDFDocument = new PdfSharp.Pdf.PdfDocument();
                    PDFDocument.Info.Title = "Patient Details";
                    PdfSharp.Pdf.PdfPage PDFPage = PDFDocument.AddPage();
                    PdfSharp.Drawing.XGraphics PDFGraphics = PdfSharp.Drawing.XGraphics.FromPdfPage(PDFPage);
                    PdfSharp.Drawing.XFont font = new PdfSharp.Drawing.XFont("Verdana", 12, PdfSharp.Drawing.XFontStyle.Bold);
                    PdfSharp.Drawing.XRect rec = new PdfSharp.Drawing.XRect((PDFPage.Width / 8), 110, PDFPage.Width, PDFPage.Height);
                    // 0 - 90 banner       
                    PDFGraphics.DrawString("Q Medic Hospital Banner Goes Here", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect((PDFPage.Width / 4), 50, PDFPage.Width, PDFPage.Height), PdfSharp.Drawing.XStringFormats.TopLeft);

                    printString = "Patient ID: " + PID;
                    PDFGraphics.DrawString(printString, font, PdfSharp.Drawing.XBrushes.Black, rec, PdfSharp.Drawing.XStringFormats.TopLeft);
                    rec.X = (PDFPage.Width / 8) + 20;

                    printString = "Name: " + name;
                    rec.Y = 150;
                    PDFGraphics.DrawString(printString, font, PdfSharp.Drawing.XBrushes.Black, rec, PdfSharp.Drawing.XStringFormats.TopLeft);
                    int yPoint = 220;

                    PDFGraphics.DrawString("Invoice Number", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(40, yPoint, PDFPage.Width.Point, PDFPage.Height.Point), PdfSharp.Drawing.XStringFormats.TopLeft);

                    PDFGraphics.DrawString("Gross Cost", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(180, yPoint, PDFPage.Width.Point, PDFPage.Height.Point), PdfSharp.Drawing.XStringFormats.TopLeft);

                    PDFGraphics.DrawString("Discounted Cost", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(300, yPoint, PDFPage.Width.Point, PDFPage.Height.Point), PdfSharp.Drawing.XStringFormats.TopLeft);

                    PDFGraphics.DrawString("TotalCost", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(420, yPoint, PDFPage.Width.Point, PDFPage.Height.Point), PdfSharp.Drawing.XStringFormats.TopLeft);

                    yPoint = 250;
                    for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    feeID = ds.Tables[0].Rows[i].ItemArray[1].ToString ();
                    grossCost = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                    DiscountedCost = ds.Tables[0].Rows[i].ItemArray[3].ToString();

                    PDFGraphics.DrawString(feeID, font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(40, yPoint, PDFPage.Width.Point, PDFPage.Height.Point), PdfSharp.Drawing.XStringFormats.TopLeft);

                    PDFGraphics.DrawString("$"+grossCost+".00", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(180, yPoint, PDFPage.Width.Point, PDFPage.Height.Point), PdfSharp.Drawing.XStringFormats.TopLeft);

                    PDFGraphics.DrawString("$"+DiscountedCost+".00", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(300, yPoint, PDFPage.Width.Point, PDFPage.Height.Point), PdfSharp.Drawing.XStringFormats.TopLeft);
                    try {
                        totalCost += Convert.ToInt32(DiscountedCost);
                        PDFGraphics.DrawString("$" + totalCost + ".00", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(420, yPoint, PDFPage.Width.Point, PDFPage.Height.Point), PdfSharp.Drawing.XStringFormats.TopLeft);
                    }
                    catch {
                        PDFGraphics.DrawString("NaN", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(420, yPoint, PDFPage.Width.Point, PDFPage.Height.Point), PdfSharp.Drawing.XStringFormats.TopLeft);

                    }
                        yPoint = yPoint + 20;
                }
                    yPoint += 40;
                    PDFGraphics.DrawString("Grand Total: ", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(320, yPoint, PDFPage.Width.Point, PDFPage.Height.Point), PdfSharp.Drawing.XStringFormats.TopLeft);
                    PDFGraphics.DrawString("$" + totalCost+".00", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(420, yPoint, PDFPage.Width.Point, PDFPage.Height.Point), PdfSharp.Drawing.XStringFormats.TopLeft);

                    String filename = PID + "_PaitentStatement.pdf";
                    PDFDocument.Save(filename);
                }
            }
            // finances for patient
        }

        private void PaitentTreatments_Click(object sender, EventArgs e) {
            
            // treatment for patients
        }
    }
}
