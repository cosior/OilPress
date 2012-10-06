using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OilPress.Forms.UIForms;

namespace OilPress
{
    public partial class Start : Form
    {
        #region Forms Declaration

        AddNewUser newUser;
        EditUser editUser;
        EditUserData userData;
        DeleteUser userDelete;
        MyVersion version;
        UserReport report;
        NewCustomer newCustomer;
        EditCustomer editCustomer;
        DeleteCustomer deleteCustomer;
        InvoicesS invSales;
        CancelSalesInvoice cancelSalesInv;
        MainMenuOil mainOil = new MainMenuOil();

        #endregion

        private void Start_Load(object sender, EventArgs e)
        {
            MainMenuOil menu = new MainMenuOil();
            menu.MdiParent = this;
            menu.Show();
        }

        #region Form common Utilities and modes

        public Start()
        {
            InitializeComponent();
        }

        public void SetUser(String user)
        {
            mainMessage.Text = "Ελαιοτριβεία Α/φοι Κουρούμουνου. Τρέχον Χρήστης =\"" + user + "\".";
            this.Text = "Ελαιοτριβεία Α/φοι Κουρούμουνου - " + user; // edit application title.
        }

        private void menuStripMain_MouseClick(object sender, MouseEventArgs e)
        {
            mainMessage.Text = "Έτοιμο.";
        }

        private void exitLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitLibraryToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            mainMessage.Text = "Έξοδος Προγράμματος";
        }

        private void exitLibraryToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            mainMessage.Text = "Έτοιμο";
        }

        #endregion

        #region Users Menu Section Code

        #region Add new User

        private void toolStripMenuNewUser_Click(object sender, EventArgs e)
        {
            mainMessage.Text = "Προσθήκη Νέου Χρήστη Σε Εξέλιξη....";
            menuStripMain.Enabled = false;
            newUser = new AddNewUser();
            newUser.MdiParent = this;
            newUser.Show();
            newUser.FormClosing += new FormClosingEventHandler(newUser_FormClosing);
        }

        void newUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (newUser.GetClosingStatus)
            {
                mainMessage.Text = "Επιτυχές Εισδοχή Νέου Χρήστη!";
            }
            else
            {
                mainMessage.Text = "Καμία Προσθήκη Χρήστη";
            }
            menuStripMain.Enabled = true;
        }

        #endregion Add new User

        #region Edit User

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            mainMessage.Text = "Τροποποίηση Χρήστη Σε Εξέλιξη....";
            menuStripMain.Enabled = false;
            editUser = new EditUser();
            editUser.MdiParent = this;
            editUser.Show();
            editUser.FormClosing += new FormClosingEventHandler(editUser_FormClosing);
        }

        void editUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (editUser.userEditOk)
            {
                userData = new EditUserData(editUser.userName, editUser.position);
                userData.MdiParent = this;
                userData.Show();
                mainMessage.Text = "Τροποποίηση Χρήστη \"" + editUser.userName + "\" . UserName και Password...";

                userData.FormClosing += new FormClosingEventHandler(userData_FormClosing);
            }
            else
            {
                mainMessage.Text = "Δεν Έγιναν Αλλαγές Στο Χρήστη  \"" + editUser.userName + "\"";
            }

            if (editUser.userName == "null")
            {
                mainMessage.Text = "Ο Χρήστης Δεν Βρέθηκε! Καμία Αλλαγή!";
            }
            menuStripMain.Enabled = true;
        }

        void userData_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (userData.dataOk)
            {
                mainMessage.Text = "Επιτυχής Τροποποίηση Χρήστη";
            }
            else
            {
                mainMessage.Text = "Καμία Αλλαγή!";
            } 
        }

        #endregion Edit User

        #region Delete User

        private void toolStripMenuItemDeleteUser_Click(object sender, EventArgs e)
        {
            mainMessage.Text = "Διαγραφή Χρήστη Σε Εξέλιξη....";
            menuStripMain.Enabled = false;
            userDelete = new DeleteUser();
            userDelete.MdiParent = this;
            userDelete.Show();
            userDelete.FormClosing += new FormClosingEventHandler(userDelete_FormClosing);
        }

        void userDelete_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (userDelete.deleteOk)
            {
                menuStripMain.Enabled = true;
                mainMessage.Text = "Ο Χρήστης \"" + userDelete.userName + "\" Διαγράφηκε Επιτυχώς!";
            }
            else
            {
                menuStripMain.Enabled = true;
                mainMessage.Text = "Δεν Έγινε Καμία Διαγραφή Χρήστη!";

                if (userDelete.userName == "null")
                {
                    mainMessage.Text = " ** Ο Χρήστης Δεν Βρέθηκε **    Παρακαλώ Δοκιμάστε Ξανά!";
                }
            }
        }

        #endregion Delete User

        #region Print Users

        private void usersReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainMessage.Text = "Προβολή Αναφοράς Χρηστών";
            menuStripMain.Enabled = false;
            report = new UserReport();
            report.MdiParent = this;
            report.Show();
            report.FormClosing += new FormClosingEventHandler(report_FormClosing);
        }

        void report_FormClosing(object sender, FormClosingEventArgs e)
        {
            menuStripMain.Enabled = true;
            mainMessage.Text = "Έτοιμο";
        }

        #endregion Print Users

        #endregion Users Menu Section Code

        #region Customer Menu Section Code

        #region New Customer

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStripMain.Enabled = false;
            mainMessage.Text = "Προσθήκη Νέου Πελάτη Σε Εξέλιξη....";
            newCustomer = new NewCustomer();
            newCustomer.MdiParent = this;
            newCustomer.Show();
            newCustomer.FormClosing += new FormClosingEventHandler(newCustomer_FormClosing);
        }

        void newCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            menuStripMain.Enabled = true;
            if (newCustomer.GetCustomerStatus)
            {
                mainMessage.Text = "Νέος Πελάτης Καταχωρήθηκε";
            }
            else
            {
                mainMessage.Text = "Δεν Καταχωρήθηκε Νέος Πελάτης ";
            }
        }

        #endregion New Customer

        #region Edit Customer

        private void editCustomer_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStripMain.Enabled = false;
            editCustomer = new EditCustomer();
            mainMessage.Text = "Διόρθωση Πελάτη Σε εξέλιξη....";
            editCustomer.MdiParent = this;
            editCustomer.Show();
            editCustomer.FormClosing += new FormClosingEventHandler(editCustomer_FormClosing);
        }

        void editCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            menuStripMain.Enabled = true;
            if (editCustomer.GetEditCustomerStatus)
            {
                mainMessage.Text = "Η Διόρθωση Πελάτη Έχει αποθηκευτή";
            }
            else
            {
                mainMessage.Text = "Η Διόρθωση Πελάτη Απερρίφθη";
            }
        }

        #endregion

        #region Delete Customer

        private void διαγραφήToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStripMain.Enabled = false;
            deleteCustomer = new DeleteCustomer();
            mainMessage.Text = "Διαγραφή Πελάτη Σε εξέλιξη......";
            deleteCustomer.MdiParent = this;
            deleteCustomer.Show();
            deleteCustomer.FormClosing += new FormClosingEventHandler(deleteCustomer_FormClosing);
        }

        void deleteCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            menuStripMain.Enabled = true;
            if (deleteCustomer.GetDeleteCustomerStatus)
            {
                mainMessage.Text = "Ο Πελάτη Διεγράφη Επιτυχώς.";
            }
            else
            {
                mainMessage.Text = "Δεν Έγινε Διαγραφή Πελάτη.";
            }
        }

        #endregion

        #endregion Customer Menu Section Code

        #region Invoices Section Code

        //Sales Invoices
        #region Sales Invoice

        //New Sales Invoice
        private void νέοToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            invSales = new InvoicesS();
            mainMessage.Text = "Νέο Τιμολόγιο Πωλήσεων Σε εξέλιξη......";
            invSales.MdiParent = this;
            invSales.Show();
            invSales.FormClosing += new FormClosingEventHandler(invSales_FormClosing);
        }

        void invSales_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (invSales.GetInvoiceState)
            {
                mainMessage.Text = "Νέο τιμολόγιο Πωλήσεων Εισήχθηκε.";
            }
            else
            {
                mainMessage.Text = "Νέο τιμολόγιο Πωλήσεων ΔΕΝ Εισήχθηκε.";
            }
        }

        //Cancel Sales Invoice
        private void διόρθωσηToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            cancelSalesInv = new CancelSalesInvoice();
            mainMessage.Text = "Ακύρωση τιμολογίου Πώλησης Σε εξέλιξη......";
            cancelSalesInv.MdiParent = this;
            cancelSalesInv.Show();
            cancelSalesInv.FormClosing += new FormClosingEventHandler(cancelSalesInv_FormClosing);
        }

        void cancelSalesInv_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cancelSalesInv.GetCancelStatus)
            {
                mainMessage.Text = "Ακύρωση τιμολογίου Πώλησης Ολοκληρώθηκε με Επιτυχία";
            }
            else
            {
                mainMessage.Text = "Ακύρωση τιμολογίου Πώλησης ΔΕΝ Ολοκληρώθηκε με Επιτυχία";
            }
        }

        #endregion

        //Purchase Invoices
        #region Purchase Invoice

        //New Purchase Invoice
        private void new_ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            InvoicesP inv = new InvoicesP();
            inv.MdiParent = this;
            inv.Show();
        }

        //Cancel Purchase Invoice
        private void διόρθωσηToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            CancelPurchaseInvoice csInvoice = new CancelPurchaseInvoice();
            csInvoice.MdiParent = this;
            csInvoice.Show();
        }

        #endregion

        #endregion

        #region Products Section Code

        //New Product
        private void new_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewProduct np = new NewProduct();
            np.MdiParent = this;
            np.Show();
        }

        //Free Products
        private void αφαίρεσηςΑπόθεματοςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FreeProduct fproduct = new FreeProduct();
            fproduct.MdiParent = this;
            fproduct.Show();
        }

        //Edit Product
        private void διόρθωσηToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditProduct scmform = new EditProduct();
            scmform.MdiParent = this;
            scmform.Show();
        }

        #endregion

        #region General Staff

        //Show Receive Note Touch Box
        private void menu_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mainOil.Visible != true)
            {
                mainOil = new MainMenuOil();
                mainOil.MdiParent = this;
                mainOil.Show();
            }
        }

        //Receive Note
        private void δελτίοΠαραλαβήςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TempReceipt treceipt = new TempReceipt();
            treceipt.MdiParent = this;
            treceipt.Show();
        }

        

        #endregion      

        #region Statistics

        //Statistics Purchase Invoice
        private void αγορέςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatisticPurchaseSelectionForm stform = new StatisticPurchaseSelectionForm();
            stform.MdiParent = this;
            stform.Show();
        }

        //Statistics Sales
        private void πωλήσειςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatisticSellsSelectionForm slform = new StatisticSellsSelectionForm();
            slform.MdiParent = this;
            slform.Show();
        }

        //Statistics General Expenses
        private void γενικάΈξοδαToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StatisticsGeneralExpenses sgeform = new StatisticsGeneralExpenses();
            sgeform.MdiParent = this;
            sgeform.Show();
        }

        //Statistics Salaries
        private void μισθοίToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StatisticSalaryForm sslform = new StatisticSalaryForm();
            sslform.MdiParent = this;
            sslform.Show();
        }

        //Statistics Customers
        private void πελάτεςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatisticCustomerForm scmform = new StatisticCustomerForm();
            scmform.MdiParent = this;
            scmform.Show();
        }

        //Statistics Sales
        private void αναφοράToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            StatisticSellsSelectionForm slform = new StatisticSellsSelectionForm();
            slform.MdiParent = this;
            slform.Show();
        }

        //Statistics Purcases
        private void αναφοράToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StatisticPurchaseSelectionForm stform = new StatisticPurchaseSelectionForm();
            stform.MdiParent = this;
            stform.Show();
        }

        //Statistics Customers
        private void printInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatisticCustomerForm scmform = new StatisticCustomerForm();
            scmform.MdiParent = this;
            scmform.Show();
        }

        //Statistics Products
        private void αναφοράToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatisticsProduct stProd = new StatisticsProduct();
            stProd.MdiParent = this;
            stProd.Show();
        }

        //Statistics Employee
        private void αναφοράToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            StatisticEmployees se = new StatisticEmployees();
            se.MdiParent = this;
            se.Show();
        }

        //Statistics Salary
        private void μισθοίToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatisticSalaryForm sslform = new StatisticSalaryForm();
            sslform.MdiParent = this;
            sslform.Show();
        }

        #endregion

        #region More

        //Kilo to Oil Rate
        private void kiloToOil_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KilosToOil klconstunt = new KilosToOil();
            klconstunt.MdiParent = this;
            klconstunt.Show();
        }

        //Vat Rate
        private void vATRateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VatRateValueChange va = new VatRateValueChange();
            va.MdiParent = this;
            va.Show();
        }

        //Expenses Type
        private void τύποιΕξόδωνToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExpensesType et = new ExpensesType();
            et.MdiParent = this;
            et.Show();
        }

        //General expenses
        private void γενικάΈξοδαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GeneralExpenses ge = new GeneralExpenses();
            ge.MdiParent = this;
            ge.Show();
        }

        #endregion

        #region Employees

        private void newEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewEmployee ne = new NewEmployee();
            ne.MdiParent = this;
            ne.Show();
        }

        private void Edit_ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            EditEmployee ee = new EditEmployee();
            ee.MdiParent = this;
            ee.Show();
        }

        private void διαγραφήToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DeleteEmployee de = new DeleteEmployee();
            de.MdiParent = this;
            de.Show();
        }

        #endregion

        #region About Menu Section code

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            version = new MyVersion();
            menuStripMain.Enabled = false;
            version.MdiParent = this;
            version.Show();
            mainMessage.Text = "Πληροφορίες Συστήματος";
            version.FormClosing += new FormClosingEventHandler(version_FormClosing);
        }

        void version_FormClosing(object sender, FormClosingEventArgs e)
        {
            menuStripMain.Enabled = true;
            mainMessage.Text = "Έτοιμος";
        }

        #endregion About Menu Section code
    
    }
}
