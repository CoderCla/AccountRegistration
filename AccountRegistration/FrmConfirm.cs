using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountRegistration
{
    public partial class FrmConfirm : Form
    {
        private DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;
        private DelegateNumber DelNumAge, DelNumContact, DelStuNo;

        private void FrmConfirm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK; 
        }

        private void FrmConfirm_Load(object sender, EventArgs e)
        {
            
            textBoxProgramConfirm.Text = DelProgram(StudentInfoClass.Program);
            textBoxLastNameConfirm.Text = DelLastName(StudentInfoClass.LastName);
            textBoxFirstNameConfirm.Text = DelFirstName(StudentInfoClass.FirstName);
            textBoxMNameConfirm.Text = DelMiddleName(StudentInfoClass.MiddleName);
            textBoxAddressConfirm.Text = DelAddress(StudentInfoClass.Address);
            textBoxAgeConfirm.Text = DelNumAge(StudentInfoClass.Age).ToString();
            textBoxContactConfirm.Text = DelNumContact(StudentInfoClass.ContactNo).ToString();
            textBoxStuNumConfirm.Text = DelStuNo(StudentInfoClass.StudentNo).ToString();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        
        public FrmConfirm()
        {
            InitializeComponent();
            DelProgram = new DelegateText(StudentInfoClass.GetProgram);
            DelLastName = new DelegateText(StudentInfoClass.GetLastName);
            DelFirstName = new DelegateText(StudentInfoClass.GetFirstName);
            DelMiddleName = new DelegateText(StudentInfoClass.GetMiddleName);
            DelAddress = new DelegateText (StudentInfoClass.GetAddress);

            DelNumAge = new DelegateNumber(StudentInfoClass.GetAge);
            DelNumContact = new DelegateNumber(StudentInfoClass.GetContactNo);
            DelStuNo = new DelegateNumber(StudentInfoClass.GetStudentNo);
        }

        private void textBoxProgram_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}

