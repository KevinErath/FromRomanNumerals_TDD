using NUnit.Framework;

[TestFixture]
internal class FromRomanNumeralsTest
{
  [Test]
  public void Should_Return_1_When_I_Is_Passed()
  {
    Assert.AreEqual(1, FromRomanNumerals.Convert("I"));
  }

  [Test]
  public void Should_Return_2_When_II_Is_Passed()
  {
    Assert.AreEqual(2, FromRomanNumerals.Convert("II"));
  }

  [Test]
  public void Should_Return_3_When_III_Is_Passed()
  {
    Assert.AreEqual(3, FromRomanNumerals.Convert("III"));
  }

  [Test]
  public void Should_Return_5_When_V_Is_Passed()
  {
    Assert.AreEqual(5, FromRomanNumerals.Convert("V"));
  }

  [Test]
  public void Should_Return_6_When_VI_Is_Passed()
  {
    Assert.AreEqual(6, FromRomanNumerals.Convert("VI"));
  }

  [Test]
  public void Should_Return_4_When_IV_Is_Passed()
  {
    Assert.AreEqual(4, FromRomanNumerals.Convert("IV"));
  }

  [Test]
  public void Should_Return_1984_When_MCMLXXXIV_Is_Passed()
  {
    Assert.AreEqual(1984, FromRomanNumerals.Convert("MCMLXXXIV"));
  }
}