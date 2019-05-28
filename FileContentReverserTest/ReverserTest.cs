using NUnit.Framework;
using System;
using FileContentReverser;

namespace FileContentReverserTest
{
    public class Tests
    {
        IReverser reverser = new Reverser();
        [Test]
        public void Is_Empty_Text_Reversed()
        {
            string reversedText = reverser.Reverse("");
            Assert.AreEqual("", reversedText);
        }

        [Test]
        public void Is_Single_Line_With_Two_Letters_Reversed()
        {
            string reversedText = reverser.Reverse("ab");
            Assert.AreEqual("ba", reversedText);
        }
        [Test]
        public void Is_Single_Line_Reversed()
        {
            string reversedText = reverser.Reverse("some of the more densely populated places on Earth, has caused significant conflicts with humans.national animal of India, Bangladesh, Malaysia and South Korea.");
            Assert.AreEqual(".aeroK htuoS dna aisyalaM ,hsedalgnaB ,aidnI fo lamina lanoitan.snamuh htiw stcilfnoc tnacifingis desuac sah ,htraE no secalp detalupop ylesned erom eht fo emos", reversedText);
        }


    }
}
