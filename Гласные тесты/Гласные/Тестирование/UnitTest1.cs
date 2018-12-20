using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Гласные;
namespace Тестирование
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void enter_3_letters_А()
        {
            // arrange
            string S = "ааа";
            char[] C = { 'А', 'а', 'Е', 'е', 'Ё', 'ё', 'У', 'у', 'Ы', 'ы', 'Я', 'я', 'И', 'и', 'О', 'о', 'Ю', 'ю', 'Э', 'э' };
            int i = 0;
            Program o = new Program();
            // act
            int result = o.Glasnai( S,  C,  i);
            int expected = 3;
            // assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void enter_word_no_glas()
        {
            // arrange
            string S = "бзкн";
            char[] C = { 'А', 'а', 'Е', 'е', 'Ё', 'ё', 'У', 'у', 'Ы', 'ы', 'Я', 'я', 'И', 'и', 'О', 'о', 'Ю', 'ю', 'Э', 'э' };
            int i = 0;
            Program o = new Program();
            // act
            int result = o.Glasnai(S, C, i); 
            int expected = 0;
            // assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void enter_glas_soglas()
        {
            // arrange
            string S = "привет";
            char[] C = { 'А', 'а', 'Е', 'е', 'Ё', 'ё', 'У', 'у', 'Ы', 'ы', 'Я', 'я', 'И', 'и', 'О', 'о', 'Ю', 'ю', 'Э', 'э' };
            int i = 0;
            Program o = new Program();
            // act
            int result = o.Glasnai(S, C, i);
            int expected = 2;
            // assert
            Assert.AreEqual(expected, result);
        }

        
    }
}
