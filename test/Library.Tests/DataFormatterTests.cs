using TestDateFormat;

namespace Library;

public class DataFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Fecha_EnFormaCorrecta()
    {
        const string ExpectedFecha = null;
        const string input="10/11/199";
        string actual = DateFormatter.ChangeFormat(input);
        Assert.That(actual, Is.EqualTo(ExpectedFecha));
    }

    [Test]
    public void Fecha_SinEspacios()
    {
        const string ExpectedFecha = null;
        const string input = "          ";
        string actual = DateFormatter.ChangeFormat(input);
        Assert.That(actual, Is.EqualTo(ExpectedFecha));
    }

    [Test]
    public void Fecha_sinBarritas()
    {
        const string ExpectedFecha = null;
        const string input = "1405/2022";
        string actual = DateFormatter.ChangeFormat(input);
        Assert.That(actual, Is.EqualTo(ExpectedFecha));
    }

    [Test]
    public void Fecha_ValoresAdecuados()
    {
        const string ExpectedFecha = null;
        const string input = " dos/3/2022";
        string actual = DateFormatter.ChangeFormat(input);
        Assert.That(actual, Is.EqualTo(ExpectedFecha));
    }
}