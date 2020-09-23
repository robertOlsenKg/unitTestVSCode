using Xunit;

public class testclass
{
    [Theory]
    [InlineData(3)]
    [InlineData(5)]
    [InlineData(7)]
    public void Teori(int tal)
    {
        //skapa
        bool arvarde;

        //anropa
        arvarde = Program.Udda(tal);

        //jämföra
        Assert.True(arvarde);
    }

    [Fact]
    public void Ratt()
    {
        //skapa
        int arvarde, borvarde = 4;

        //anropa
        arvarde = Program.Add(2, 2);

        //jämföra
        Assert.Equal(arvarde, borvarde);
    }

    [Fact]
    public void Fel()
    {
        //skapa
        int arvarde, borvarde = 5;

        //anropa
        arvarde = Program.Add(2, 2);

        //jämföra
        Assert.NotEqual(arvarde, borvarde);
    }
}