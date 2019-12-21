using InterviewCampProblems.Code;
using System;
using Xunit;

namespace InterviewCampProblems.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            TraversingArray x = new TraversingArray();
            var y = x.Print();

            Assert.Equal("Hello", y);


        }
    }
}
