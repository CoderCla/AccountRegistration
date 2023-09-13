using AccountRegistration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountRegistration
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            
           FrmConfirm frmConfirm = new FrmConfirm();
            
            StudentInfoClass.Age = long.Parse(textBoxAge.Text.ToString());
            StudentInfoClass.ContactNo = long.Parse(textBoxContact.Text.ToString());
            StudentInfoClass.StudentNo = long.Parse(textBoxStudentNum.Text.ToString());

            
            StudentInfoClass.Program = comboBoxProgram.Text.ToString(); ;
            StudentInfoClass.LastName = textBoxLname.Text.ToString(); ;
            StudentInfoClass.FirstName = textBoxFname.Text.ToString();
            StudentInfoClass.MiddleName = textBoxMname.Text.ToString(); ;
            
            
            StudentInfoClass.Address = textBoxAddress.Text.ToString(); ;

            if (frmConfirm.ShowDialog().Equals(DialogResult.OK))
            
            {
                textBoxStudentNum.Text = "";
                textBoxLname.Text = "";
                textBoxFname.Text = "";
                textBoxMname.Text = "";
                textBoxAddress.Text = "";
                comboBoxProgram.Text = "";
                textBoxStudentNum.Text = "";
                textBoxAge.Text = "";
                textBoxContact.Text = "";
                
            }
        }
    }
}
public delegate long DelegateNumber(long number);
public delegate string DelegateText(string txt);
class StudentInfoClass
{
    public static string FirstName = " ", LastName = " ", MiddleName = " ", Address = " ", Program = " ";
    public static long Age = 0, ContactNo = 0, StudentNo = 0;

    public static string GetFirstName (string firstname)
    {
        return firstname;
    }
    public static string GetLastName(string lastname)
    {
        return lastname;
    }
    public static string GetMiddleName(string middlename)
    {
        return middlename;
    }
    public static string GetAddress(string address)
    {
        return address;
    }
    public static string GetProgram(string program)
    {
        return program;
    }
    public static long GetAge(long age)
    {
        return age;
    }
    public static long GetContactNo(long contact)
    {
        return contact;
    }
    public static long GetStudentNo(long student)
    {
        return student;
    }
}
