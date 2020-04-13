using Microsoft.VisualStudio.TestTools.UnitTesting;
using Final_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Tests
{
    [TestClass()]
    public class ForgotPasswordTests
    {
        private ForgotPassword lg;
        [TestInitialize()]
        public void setup()
        {
            lg = new ForgotPassword();
        }
        // Trường hợp đúng
        [TestMethod()]
        public void checkUsernameTest()
        {
            String txt = "Giangdeptrai";
            bool result = lg.checkUsername(txt);
            Assert.AreEqual(true, result);
        }
        // Trường hợp null
        [TestMethod()]
        [ExpectedException(typeof(NullReferenceException))]
        public void checkUsernameTest1()
        {
            String txt = null;
            bool result = lg.checkUsername(txt);

        }
        // Trường hợp ít hơn 3 chữ số
        [TestMethod()]
        public void checkUsernameTest2()
        {
            String txt = "By";
            bool result = lg.checkUsername(txt);
            Assert.AreEqual(false, result);
        }
        // Trường hợp đúng 
        [TestMethod()]
        public void checkEmailTest()
        {
            String txt = "Giangdeptrai@gmail.com";
            bool result = lg.checkEmail(txt);
            Assert.AreEqual(true, result);
        }
        // Trường hợp sai
        [TestMethod()]
        public void checkEmailTest1()
        {
            String txt = "Giangdeptra";
            bool result = lg.checkEmail(txt);
            Assert.AreEqual(false, result);
        }
    }
}