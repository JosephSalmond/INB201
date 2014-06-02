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
           
                    MiddleWare.middle.OpenConnection();
                    SqlCommand GetData = new SqlCommand(string.Format("select FeeID, GrossCost, TotalCost, comments from Fees;"), MiddleWare.middle.dbConnection);
                    String feeID = "";
                    String grossCost = "";
                    String DiscountedCost = "";
                    String comments = "";
                    int totalCost = 0;
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataSet ds = new DataSet();
                    adapter.SelectCommand = GetData;
                    adapter.Fill(ds);

                    MiddleWare.middle.CloseConnection();

                    string printString;
                    PdfSharp.Pdf.PdfDocument PDFDocument = new PdfSharp.Pdf.PdfDocument();
                    PDFDocument.Info.Title = "Financial History";
                    PdfSharp.Pdf.PdfPage PDFPage = PDFDocument.AddPage();
                    PdfSharp.Drawing.XGraphics PDFGraphics = PdfSharp.Drawing.XGraphics.FromPdfPage(PDFPage);
                    PdfSharp.Drawing.XFont font = new PdfSharp.Drawing.XFont("Verdana", 12, PdfSharp.Drawing.XFontStyle.Bold);
                    PdfSharp.Drawing.XRect rec = new PdfSharp.Drawing.XRect((PDFPage.Width / 8), 110, PDFPage.Width, PDFPage.Height);
                    // 0 - 90 banner       
                    PDFGraphics.DrawString("Q Medic Hospital Banner Goes Here", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect((PDFPage.Width / 4), 50, PDFPage.Width, PDFPage.Height), PdfSharp.Drawing.XStringFormats.TopLeft);


                    printString = "Q Medic Financials";
                    rec.Y = 150;
                    PDFGraphics.DrawString(printString, font, PdfSharp.Drawing.XBrushes.Black, rec, PdfSharp.Drawing.XStringFormats.TopLeft);
                    int yPoint = 220;

                    PDFGraphics.DrawString("Invoice No", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(40, yPoint, PDFPage.Width.Point, PDFPage.Height.Point), PdfSharp.Drawing.XStringFormats.TopLeft);

                    PDFGraphics.DrawString("Gross Cost", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(120, yPoint, PDFPage.Width.Point, PDFPage.Height.Point), PdfSharp.Drawing.XStringFormats.TopLeft);

                    PDFGraphics.DrawString("Discounted Cost", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(220, yPoint, PDFPage.Width.Point, PDFPage.Height.Point), PdfSharp.Drawing.XStringFormats.TopLeft);

                    PDFGraphics.DrawString("TotalCost", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(360, yPoint, PDFPage.Width.Point, PDFPage.Height.Point), PdfSharp.Drawing.XStringFormats.TopLeft);

                    PDFGraphics.DrawString("Comments", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(500, yPoint, PDFPage.Width.Point, PDFPage.Height.Point), PdfSharp.Drawing.XStringFormats.TopLeft);

                    yPoint = 250;
                    for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++) {
                        if (yPoint > 820){
                            yPoint = 50;
                            PDFPage = PDFDocument.AddPage();
                            PDFGraphics = PdfSharp.Drawing.XGraphics.FromPdfPage(PDFPage);
                            PDFGraphics.DrawString("Invoice No", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(40, yPoint, PDFPage.Width.Point, PDFPage.Height.Point), PdfSharp.Drawing.XStringFormats.TopLeft);

                            PDFGraphics.DrawString("Gross Cost", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(120, yPoint, PDFPage.Width.Point, PDFPage.Height.Point), PdfSharp.Drawing.XStringFormats.TopLeft);

                            PDFGraphics.DrawString("Discounted Cost", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(220, yPoint, PDFPage.Width.Point, PDFPage.Height.Point), PdfSharp.Drawing.XStringFormats.TopLeft);

                            PDFGraphics.DrawString("TotalCost", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(360, yPoint, PDFPage.Width.Point, PDFPage.Height.Point), PdfSharp.Drawing.XStringFormats.TopLeft);

                            PDFGraphics.DrawString("Comments", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(500, yPoint, PDFPage.Width.Point, PDFPage.Height.Point), PdfSharp.Drawing.XStringFormats.TopLeft);
                            yPoint = 70;
                        }
                        feeID = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                        grossCost = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                        DiscountedCost = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                        comments = ds.Tables[0].Rows[i].ItemArray[3].ToString();

                        PDFGraphics.DrawString(feeID, font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(40, yPoint, PDFPage.Width.Point, PDFPage.Height.Point), PdfSharp.Drawing.XStringFormats.TopLeft);

                        PDFGraphics.DrawString("$" + grossCost + ".00", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(120, yPoint, PDFPage.Width.Point, PDFPage.Height.Point), PdfSharp.Drawing.XStringFormats.TopLeft);

                        PDFGraphics.DrawString("$" + DiscountedCost + ".00", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(220, yPoint, PDFPage.Width.Point, PDFPage.Height.Point), PdfSharp.Drawing.XStringFormats.TopLeft);
                        try {
                            totalCost += Convert.ToInt32(DiscountedCost);
                            PDFGraphics.DrawString("$" + totalCost + ".00", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(360, yPoint, PDFPage.Width.Point, PDFPage.Height.Point), PdfSharp.Drawing.XStringFormats.TopLeft);
                        }
                        catch {
                            PDFGraphics.DrawString("NaN", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(500, yPoint, PDFPage.Width.Point, PDFPage.Height.Point), PdfSharp.Drawing.XStringFormats.TopLeft);
                        }
                        PDFGraphics.DrawString(comments, font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(500, yPoint, PDFPage.Width.Point, PDFPage.Height.Point), PdfSharp.Drawing.XStringFormats.TopLeft);
                        yPoint = yPoint + 20;
                    }
                    yPoint += 40;
                    PDFGraphics.DrawString("Grand Total: ", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(320, yPoint, PDFPage.Width.Point, PDFPage.Height.Point), PdfSharp.Drawing.XStringFormats.TopLeft);
                    PDFGraphics.DrawString("$" + totalCost + ".00", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(420, yPoint, PDFPage.Width.Point, PDFPage.Height.Point), PdfSharp.Drawing.XStringFormats.TopLeft);

                    String filename = "Hospital_Takings.pdf";
                    PDFDocument.Save(filename);
                
            
            // tabel of all the treatments
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
                    PDFDocument.Info.Title = "Patient Invoice";
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
                    if (yPoint > 820) {
                        yPoint = 50;
                        PDFPage = PDFDocument.AddPage();
                        PDFGraphics = PdfSharp.Drawing.XGraphics.FromPdfPage(PDFPage);

                        PDFGraphics.DrawString("Invoice Number", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(40, yPoint, PDFPage.Width.Point, PDFPage.Height.Point), PdfSharp.Drawing.XStringFormats.TopLeft);

                        PDFGraphics.DrawString("Gross Cost", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(180, yPoint, PDFPage.Width.Point, PDFPage.Height.Point), PdfSharp.Drawing.XStringFormats.TopLeft);

                        PDFGraphics.DrawString("Discounted Cost", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(300, yPoint, PDFPage.Width.Point, PDFPage.Height.Point), PdfSharp.Drawing.XStringFormats.TopLeft);

                        PDFGraphics.DrawString("TotalCost", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(420, yPoint, PDFPage.Width.Point, PDFPage.Height.Point), PdfSharp.Drawing.XStringFormats.TopLeft);
                        yPoint = 70;
                    }
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
                    String TreatmentID = "";
                    String staffName = "";
                    String TreatmentDate = "";
                    String TreatmentTime = "";
                    int totalCost = 0;
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataSet ds = new DataSet();
                    GetData = new SqlCommand(string.Format("SELECT Treatment.TreatmentID, Staff.StaffID, StaffType.StaffTypeName, Staff.FirstName, Staff.LastName, Treatment.PatientID, Treatment.TreatmentDate, Treatment.TreatmentTime FROM Treatment INNER JOIN Staff ON Treatment.StaffID = Staff.StaffID INNER JOIN StaffType ON Staff.StaffTypeID = StaffType.StaffTypeID WHERE (Treatment.PatientID = '{0}')", PID), MiddleWare.middle.dbConnection);
                    adapter.SelectCommand = GetData;
                    adapter.Fill(ds);

                    MiddleWare.middle.CloseConnection();

                    string printString;
                    PdfSharp.Pdf.PdfDocument PDFDocument = new PdfSharp.Pdf.PdfDocument();
                    PDFDocument.Info.Title = "Patient Treatments";
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

                    PDFGraphics.DrawString("Treatment ID", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(40, yPoint, PDFPage.Width.Point, PDFPage.Height.Point), PdfSharp.Drawing.XStringFormats.TopLeft);
                    PDFGraphics.DrawString("Staff", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(180, yPoint, PDFPage.Width.Point, PDFPage.Height.Point), PdfSharp.Drawing.XStringFormats.TopLeft);
                    PDFGraphics.DrawString("Treatment Date", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(300, yPoint, PDFPage.Width.Point, PDFPage.Height.Point), PdfSharp.Drawing.XStringFormats.TopLeft);
                    PDFGraphics.DrawString("Treatment Time", font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(420, yPoint, PDFPage.Width.Point, PDFPage.Height.Point), PdfSharp.Drawing.XStringFormats.TopLeft);

                    yPoint = 250;
                    for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++) {
                        TreatmentID = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                        staffName = ds.Tables[0].Rows[i].ItemArray[3].ToString() + " " + ds.Tables[0].Rows[i].ItemArray[4].ToString();
                        TreatmentDate = ds.Tables[0].Rows[i].ItemArray[6].ToString();
                        TreatmentTime = ds.Tables[0].Rows[i].ItemArray[7].ToString();

                        PDFGraphics.DrawString(TreatmentID, font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(40, yPoint, PDFPage.Width.Point, PDFPage.Height.Point), PdfSharp.Drawing.XStringFormats.TopLeft);
                        PDFGraphics.DrawString(staffName, font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(180, yPoint, PDFPage.Width.Point, PDFPage.Height.Point), PdfSharp.Drawing.XStringFormats.TopLeft);
                        PDFGraphics.DrawString(TreatmentDate, font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(300, yPoint, PDFPage.Width.Point, PDFPage.Height.Point), PdfSharp.Drawing.XStringFormats.TopLeft);
                       PDFGraphics.DrawString(TreatmentTime, font, PdfSharp.Drawing.XBrushes.Black, new PdfSharp.Drawing.XRect(420, yPoint, PDFPage.Width.Point, PDFPage.Height.Point), PdfSharp.Drawing.XStringFormats.TopLeft);

                        yPoint = yPoint + 20;
                    }

                    String filename = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\HospitalExport\\" + PID + "_PaitentTreatment.pdf";
                    PDFDocument.Save(filename);
                }
            }
            // treatment for patients
        }
    }
}
