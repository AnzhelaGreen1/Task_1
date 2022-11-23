using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WpfApp1;

namespace Test_For_WpfApp1
{
    [TestClass]
    public class UnitTest1
    {
     
      
       
        [TestMethod]
        public void The_password_does_not_contain_numbers()
        {
            Auth auth = new Auth();
            string expected = "Пароль должен содержать цифры!";
            string actual = auth.TestPassword("Абвгде%");
            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        public void The_password_does_not_contain_lowercase_characters()
        {
            Auth auth = new Auth();
            string expected = "Пароль должен содержать символы в нижнем регистре!";
            string actual = auth.TestPassword("ПРИВЕТ5%");
            Assert.AreEqual(expected, actual);
        }

       
        [TestMethod]
        public void The_password_does_not_contain_uppercase_characters()
        {
            Auth auth = new Auth();
            string expected = "Пароль должен содержать символы в верхнем регистре!";
            string actual = auth.TestPassword("привет5%");
            Assert.AreEqual(expected, actual);
        }

       
        [TestMethod]
        public void The_password_does_not_contain_any_special_characters()
        {
            Auth auth = new Auth();
            string expected = "Пароль должен содержать спецсимволы!";
            string actual = auth.TestPassword("Привет5");
            Assert.AreEqual(expected, actual);
        }

        
        [TestMethod]
        public void Repeated_characters_in_the_password()
        {
            Auth auth = new Auth();
            string expected = "В пароле не должно быть подряд идущих повторяющихся символов!";
            string actual = auth.TestPassword("ППрив%4");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void The_password_is_short ()
        {
            Auth auth = new Auth();
            string expected = "Пароль короткий!";
            string actual = auth.TestPassword("123");
            Assert.AreEqual(expected, actual);
        }

        
        [TestMethod]
        public void The_password_is_long()
        {
            Auth auth = new Auth();
            string expected = "Пароль длинный!";
            string actual = auth.TestPassword("123456789101");
            Assert.AreEqual(expected, actual);
        }
    }
}
