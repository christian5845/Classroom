namespace ClassRoomTest
{
    [TestClass]
    public sealed class ClassRoomTestSeason
    {
        [TestMethod]
        [DataRow("G", 2, 3999, "Winter")]
        [DataRow("Rasmus", 4, 2004, "Spring")]

        
        public void TestStuderende_Årstid_Vinter(string name, int month, int year, string expectedSeason)
        {
            //arange
            Student student = new Student(name, month, year);

            //Act
            string årstid = student.Season();

            //Assert
            Assert.AreEqual(expectedSeason, årstid);
        }



    }
}
