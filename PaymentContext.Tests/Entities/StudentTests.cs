using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests;

[TestClass]
public class StudentTests
{
    [TestMethod]
    public void TestMethod1()
    {
        var student = new Student(
            "Bruce",
            "Wayne",
            "12345678910",
            "email@email.com"
        );
    }
}