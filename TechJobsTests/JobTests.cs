using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job hotline = new Job();
            Job coldline = new Job();

            Assert.IsTrue(hotline.Id == coldline.Id - 1);
            
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job acmeTester = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsTrue(acmeTester.Name == "Product tester" && acmeTester.EmployerName.Value == "ACME" && acmeTester.EmployerLocation.Value == "Desert" && acmeTester.JobType.Value == "Quality control" && acmeTester.JobCoreCompetency.Value == "Persistence");

        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job hotline = new Job("Employee", new Employer("Freddy's"), new Location("Shiloh, IL"), new PositionType("Entry Level"), new CoreCompetency("Service with a smile"));
            Job coldline = new Job("Employee", new Employer("Freddy's"), new Location("Shiloh, IL"), new PositionType("Entry Level"), new CoreCompetency("Service with a smile"));

            Assert.IsFalse(hotline.Equals(coldline));
        }

        [TestMethod]
        public void TestToStringForBlankLines()
        {
            Job acmeTester = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            //Assert.IsTrue(acmeTester.ToString() == "\n ID:" + acmeTester.Id + "\n Name:" + acmeTester.Name + "\n Employer:" + acmeTester.EmployerName.Value + "\n Location:" + acmeTester.EmployerLocation.Value + "\n Position Type:" + acmeTester.JobType.Value + "\n Core Competency:" + acmeTester.JobCoreCompetency.Value + "\n");
            Assert.IsTrue(acmeTester.ToString().StartsWith("\n") && acmeTester.ToString().EndsWith("\n"));
        }

        [TestMethod]
        public void TestToStringFieldsAndFormatting()
        {
            Job acmeTester = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.IsTrue(acmeTester.ToString() == "\n ID:" + acmeTester.Id + "\n Name:" + acmeTester.Name + "\n Employer:" + acmeTester.EmployerName.Value + "\n Location:" + acmeTester.EmployerLocation.Value + "\n Position Type:" + acmeTester.JobType.Value + "\n Core Competency:" + acmeTester.JobCoreCompetency.Value + "\n");

        }

        [TestMethod]
        public void TestToStringEmptyFieldReturnsDataNotAvailable()
        {
            Job acmeTester = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency(""));

            Assert.IsTrue(acmeTester.ToString() == "\n ID: " + acmeTester.Id + "\n Name: " + acmeTester.Name + "\n Employer: " + acmeTester.EmployerName.Value + "\n Location: " + acmeTester.EmployerLocation.Value + "\n Position Type: " + acmeTester.JobType.Value + "\n Core Competency: " + "Data not available" + "\n");
        }

        [TestMethod]
        public void TestToStringAllEmptyFieldsReturnsError()
        {
            Job acmeTester = new Job("", new Employer(""), new Location(""), new PositionType(""), new CoreCompetency(""));

            Assert.IsTrue(acmeTester.ToString() == "OOPS! This job does not seem to exist.");
        }
    }
}
