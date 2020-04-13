using Microsoft.VisualStudio.TestTools.UnitTesting;

using Final_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MaterialSkin;
using MaterialSkin.Controls;

namespace Final_Project.Tests
{
    [TestClass()]
    public class LoginTests
    {

        private Login lg;
        [TestInitialize()]
        public void setup()
        {
            lg = new Login();
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
        public void checkPasswordTest()
        {
            String txt = "Giangdeptrai";
            bool result = lg.checkPassword(txt);
            Assert.AreEqual(true, result);
        }
        // Trường hợp null
        [TestMethod()]
        [ExpectedException(typeof(NullReferenceException))]
        public void checkPasswordTest1()
        {
            String txt = null;
            bool result = lg.checkPassword(txt);
         
        }
        // Trường hợp ít hơn 3 kí tự
        [TestMethod()]
        public void checkPasswordTest2()
        {
            String txt = "g";
            bool result = lg.checkPassword(txt);
            Assert.AreEqual(false, result);
        }





    }
}