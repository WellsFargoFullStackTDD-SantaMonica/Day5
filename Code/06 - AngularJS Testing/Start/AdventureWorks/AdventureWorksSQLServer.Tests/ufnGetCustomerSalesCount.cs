using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventureWorksSQLServer.Tests
{
    [TestClass()]
    public class ufnGetCustomerSalesCount : SqlDatabaseTestClass
    {

        public ufnGetCustomerSalesCount()
        {
            InitializeComponent();
        }

        [TestInitialize()]
        public void TestInitialize()
        {
            base.InitializeTest();
        }
        [TestCleanup()]
        public void TestCleanup()
        {
            base.CleanupTest();
        }

        #region Designer support code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_ufnGetCustomerSalesCountTest_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ufnGetCustomerSalesCount));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition ScalarValue12;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountIs1;
            this.dbo_ufnGetCustomerSalesCountTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            dbo_ufnGetCustomerSalesCountTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            ScalarValue12 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            rowCountIs1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            // 
            // dbo_ufnGetCustomerSalesCountTestData
            // 
            this.dbo_ufnGetCustomerSalesCountTestData.PosttestAction = null;
            this.dbo_ufnGetCustomerSalesCountTestData.PretestAction = null;
            this.dbo_ufnGetCustomerSalesCountTestData.TestAction = dbo_ufnGetCustomerSalesCountTest_TestAction;
            // 
            // dbo_ufnGetCustomerSalesCountTest_TestAction
            // 
            dbo_ufnGetCustomerSalesCountTest_TestAction.Conditions.Add(ScalarValue12);
            dbo_ufnGetCustomerSalesCountTest_TestAction.Conditions.Add(rowCountIs1);
            resources.ApplyResources(dbo_ufnGetCustomerSalesCountTest_TestAction, "dbo_ufnGetCustomerSalesCountTest_TestAction");
            // 
            // ScalarValue12
            // 
            ScalarValue12.ColumnNumber = 1;
            ScalarValue12.Enabled = true;
            ScalarValue12.ExpectedValue = "12";
            ScalarValue12.Name = "ScalarValue12";
            ScalarValue12.NullExpected = false;
            ScalarValue12.ResultSet = 1;
            ScalarValue12.RowNumber = 1;
            // 
            // rowCountIs1
            // 
            rowCountIs1.Enabled = true;
            rowCountIs1.Name = "rowCountIs1";
            rowCountIs1.ResultSet = 1;
            rowCountIs1.RowCount = 1;
        }

        #endregion


        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        #endregion


        [TestMethod()]
        public void dbo_ufnGetCustomerSalesCountTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_ufnGetCustomerSalesCountTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        private SqlDatabaseTestActions dbo_ufnGetCustomerSalesCountTestData;
    }
}
