
namespace Factory.Tests
{
    public class FactoryTests
    {
        [Fact]
        public void CheckType_true_or_false()
        {
            Assert.True(MyFactory.CheckType("�������������"));
            Assert.True(MyFactory.CheckType("���������"));
            Assert.True(MyFactory.CheckType("�����������"));

            Assert.False(MyFactory.CheckType("�������������1"));
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
            Assert.True(MyFactory.ChechQuoteIndex("\"�������������\""));
            Assert.True(MyFactory.ChechQuoteIndex("\"������ ����������\""));
            Assert.True(MyFactory.ChechQuoteIndex("\"������\""));

            Assert.False(MyFactory.ChechQuoteIndex(""));
            Assert.False(MyFactory.ChechQuoteIndex("\""));
        }

        [Fact]
        public void createRealtyFromArguments()
        {
            var expected = new PrivateResidentBuilding("����� ������� ���������", new DateTime(2020, 05, 06), 25000);
            var actual = MyFactory.CreatePrivateResidentBuilding("������������� \"����� ������� ���������\" 2020.05.06  25000");

            Assert.True(expected.NameOwner == actual.NameOwner);
            Assert.True(expected.DateCreated == actual.DateCreated);
            Assert.True(expected.Cost == actual.Cost);

            Assert.Throws<Exception>(() => MyFactory.CreatePrivateResidentBuilding("������������� \"����� ������� 2020.05.06  25000"));
            Assert.Throws<Exception>(() => MyFactory.CreatePrivateResidentBuilding("�������������  2020.05.06  25000"));
            Assert.Throws<Exception>(() => MyFactory.CreatePrivateResidentBuilding("������������� \"����� ������� ���������\"  25000"));
        }

        [Fact]
        public void CreateObject()
        {
            Assert.Throws<Exception>(() => MyFactory.createRealty("�������������1 \"����� ������� ���������\" 2025.09.04  25000"));
            Assert.Throws<Exception>(() => MyFactory.createRealty("������������� \"����� ������� ���������\" 09.04.2020  250Gff00"));
            Assert.Throws<Exception>(() => MyFactory.createRealty("������������� 09.04.2020  25000"));
            Assert.Throws<Exception>(() => MyFactory.createRealty("�������������"));
            Assert.Throws<Exception>(() => MyFactory.createRealty(""));
        }
    }
}