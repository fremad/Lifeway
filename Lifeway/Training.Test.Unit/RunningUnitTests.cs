using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Training.Test.Unit
{
    [TestFixture]
    public class RunningUnitTests
    {
        [Test]
        public void Add_Add2And4_Expect6()
        {
            Assert.That(6, Is.EqualTo(Running.Add(2, 4)));
        }

    }
}
