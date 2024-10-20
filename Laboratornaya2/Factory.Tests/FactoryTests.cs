
namespace Factory.Tests
{
    public class FactoryTests
    {
        [Fact]
        public void CheckType_true_or_false()
        {
            Assert.True(MyFactory.CheckType("„астный∆илƒом"));
            Assert.True(MyFactory.CheckType("ƒачныйƒом"));
            Assert.True(MyFactory.CheckType("Ќовостройка"));

            Assert.False(MyFactory.CheckType("„астный∆илƒом1"));
            Assert.False(MyFactory.CheckType(""));
            Assert.False(MyFactory.CheckType("random string"));
        }

        [Fact]
        public void ParseDateTime()
        {
            Assert.Equal(new DateTime(2020, 05, 06), MyFactory.parseDate("2020.05.06"));
            Assert.Equal(new DateTime(2013, 12, 15), MyFactory.parseDate("2013.12.15"));

            Assert.Throws<Exception>(() => MyFactory.parseDate("12.12.2015"));
            Assert.Throws<Exception>(() => MyFactory.parseDate("12 12 2015"));
            Assert.Throws<Exception>(() => MyFactory.parseDate("2020/05/06"));
            Assert.Throws<Exception>(() => MyFactory.parseDate("random string"));
            Assert.Throws<Exception>(() => MyFactory.parseDate(""));
        }

        [Fact]
        public void ParseInt()
        {
            Assert.Equal(123, MyFactory.parseInt("123"));
            Assert.Equal(0, MyFactory.parseInt("0"));
            Assert.Equal(-123, MyFactory.parseInt("-123"));

            Assert.Throws<Exception>(() => MyFactory.parseInt("123.2"));
            Assert.Throws<Exception>(() => MyFactory.parseInt("123/2"));
            Assert.Throws<Exception>(() => MyFactory.parseInt(""));
        }

        [Fact]
        public void ParseDouble()
        {
            Assert.Equal(123, MyFactory.parseDouble("123"));
            Assert.Equal(123.5, MyFactory.parseDouble("123,5"));
            Assert.Equal(-123.5, MyFactory.parseDouble("-123,5"));

            Assert.Throws<Exception>(() => MyFactory.parseDouble("123.2"));
            Assert.Throws<Exception>(() => MyFactory.parseInt("123/2"));
            Assert.Throws<Exception>(() => MyFactory.parseInt("random string"));
        }

        [Fact]
        public void ChechQuoteIndex_true_or_false()
        {
            Assert.True(MyFactory.ChechQuoteIndex("\"„астный∆илƒом\""));
            Assert.True(MyFactory.ChechQuoteIndex("\"ћихаил ћихайлович\""));
            Assert.True(MyFactory.ChechQuoteIndex("\"ѕетров\""));

            Assert.False(MyFactory.ChechQuoteIndex(""));
            Assert.False(MyFactory.ChechQuoteIndex("\""));
        }

        [Fact]
        public void createRealtyFromArguments()
        {
            var expected = new PrivateResidentBuilding("‘едор ‘едоров ‘едорович", new DateTime(2020, 05, 06), 25000);
            var actual = MyFactory.CreatePrivateResidentBuilding("„астный∆илƒом \"‘едор ‘едоров ‘едорович\" 2020.05.06  25000");

            Assert.True(expected.NameOwner == actual.NameOwner);
            Assert.True(expected.DateCreated == actual.DateCreated);
            Assert.True(expected.Cost == actual.Cost);

            Assert.Throws<Exception>(() => MyFactory.CreatePrivateResidentBuilding("„астный∆илƒом \"‘едор ‘едоров 2020.05.06  25000"));
            Assert.Throws<Exception>(() => MyFactory.CreatePrivateResidentBuilding("„астный∆илƒом  2020.05.06  25000"));
            Assert.Throws<Exception>(() => MyFactory.CreatePrivateResidentBuilding("„астный∆илƒом \"‘едор ‘едоров ‘едорович\"  25000"));
        }

        [Fact]
        public void CreateObject()
        {
            Assert.Throws<Exception>(() => MyFactory.createRealty("„астный∆илƒом1 \"‘едор ‘едоров ‘едорович\" 2025.09.04  25000"));
            Assert.Throws<Exception>(() => MyFactory.createRealty("„астный∆илƒом \"‘едор ‘едоров ‘едорович\" 09.04.2020  250Gff00"));
            Assert.Throws<Exception>(() => MyFactory.createRealty("„астный∆илƒом 09.04.2020  25000"));
            Assert.Throws<Exception>(() => MyFactory.createRealty("„астный∆илƒом"));
            Assert.Throws<Exception>(() => MyFactory.createRealty(""));
        }
    }
}