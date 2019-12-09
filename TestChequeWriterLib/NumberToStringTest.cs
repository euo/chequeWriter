using ChequeWriterLib;
using System;
using Xunit;

namespace TestChequeWriterLib
{
    public class NumberToString
    {
        [Fact]
        public void Zero_ReturnsZero()
        {
            var expected = "zero";
            var res = ChequeWriterUtil.GetString(0);
            Assert.Equal(expected, res);
        }

        [Fact]
        public void MoreThan_2Decimals_Are_Rounded()
        {
            var expected = "one CENT";
            var res = ChequeWriterUtil.GetString(0.0120m);
            Assert.Equal(expected, res);
        }

        [Fact]
        public void MoreThan_2Decimals_Are_RoundedUp()
        {
            var expected = "two CENTS";
            var res = ChequeWriterUtil.GetString(0.0150m);
            Assert.Equal(expected, res);
        }

        [Fact]
        public void OneCent_ReturnsCorrectly()
        {
            var expected = "one CENT";
            var res = ChequeWriterUtil.GetString(0.01m);
            Assert.Equal(expected, res);
        }

        [Fact]
        public void Decimals_ReturnsCorrectly()
        {
            var expected = "thirteen CENTS";
            var res = ChequeWriterUtil.GetString(0.13m);
            Assert.Equal(expected, res);
        }

        [Fact]
        public void One_ReturnsCorrectly()
        {
            var expected = "one DOLLAR";
            var res = ChequeWriterUtil.GetString(1);
            Assert.Equal(expected, res);
        }

        [Fact]
        public void One_WithDecimal_ReturnsCorrectly()
        {
            var expected = "one DOLLAR AND fifty CENTS";
            var res = ChequeWriterUtil.GetString(1.5m);
            Assert.Equal(expected, res);
        }

        [Fact]
        public void Ones_ReturnsCorrectly()
        {
            var expected = "four DOLLARS";
            var res = ChequeWriterUtil.GetString(4);
            Assert.Equal(expected, res);
        }

        [Fact]
        public void Ones_WithDecimal_ReturnsCorrectly()
        {
            var expected = "four DOLLARS AND fifty three CENTS";
            var res = ChequeWriterUtil.GetString(4.53m);
            Assert.Equal(expected, res);
        }

        [Fact]
        public void Whole_Tens_ReturnsCorrectly()
        {
            var expected = "fifty DOLLARS";
            var res = ChequeWriterUtil.GetString(50m);
            Assert.Equal(expected, res);
        }

        [Fact]
        public void Whole_Tens_WithDecimal_ReturnsCorrectly()
        {
            var expected = "fifty DOLLARS AND fifty three CENTS";
            var res = ChequeWriterUtil.GetString(50.53m);
            Assert.Equal(expected, res);
        }

        [Fact]
        public void Tens_ReturnsCorrectly()
        {
            var expected = "fifty four DOLLARS";
            var res = ChequeWriterUtil.GetString(54m);
            Assert.Equal(expected, res);
        }

        [Fact]
        public void Tens_WithDecimal_ReturnsCorrectly()
        {
            var expected = "fifty four DOLLARS AND fifty three CENTS";
            var res = ChequeWriterUtil.GetString(54.53m);
            Assert.Equal(expected, res);
        }
        [Fact]
        public void Whole_Hundreds_ReturnsCorrectly()
        {
            var expected = "two hundred DOLLARS";
            var res = ChequeWriterUtil.GetString(200.00m);
            Assert.Equal(expected, res);
        }

        [Fact]
        public void Whole_Hundreds_WithDecimal_ReturnsCorrectly()
        {
            var expected = "two hundred DOLLARS AND fifty three CENTS";
            var res = ChequeWriterUtil.GetString(200.53m);
            Assert.Equal(expected, res);
        }

        [Fact]
        public void Hundreds_ReturnsCorrectly()
        {
            var expected = "two hundred and fifty four DOLLARS";
            var res = ChequeWriterUtil.GetString(254.00m);
            Assert.Equal(expected, res);
        }

        [Fact]
        public void Hundreds_WithDecimal_ReturnsCorrectly()
        {
            var expected = "two hundred and fifty four DOLLARS AND fifty three CENTS";
            var res = ChequeWriterUtil.GetString(254.53m);
            Assert.Equal(expected, res);
        }

        [Fact]
        public void Whole_Thousands_ReturnsCorrectly()
        {
            var expected = "one thousand DOLLARS";
            var res = ChequeWriterUtil.GetString(1000.00m);
            Assert.Equal(expected, res);
        }

        [Fact]
        public void Whole_Thousands_WithDecimal_ReturnsCorrectly()
        {
            var expected = "one thousand DOLLARS AND fifty three CENTS";
            var res = ChequeWriterUtil.GetString(1000.53m);
            Assert.Equal(expected, res);
        }


        [Fact]
        public void Thousands_ReturnsCorrectly()
        {
            var expected = "eleven thousand DOLLARS";
            var res = ChequeWriterUtil.GetString(11000.00m);
            Assert.Equal(expected, res);
        }


        [Fact]
        public void Thousands_WithDecimal_ReturnsCorrectly()
        {
            var expected = "one thousand, two hundred and fifty four DOLLARS AND fifty three CENTS";
            var res = ChequeWriterUtil.GetString(1254.53m);
            Assert.Equal(expected, res);
        }
        [Fact]
        public void Whole_TenThousands_ReturnsCorrectly()
        {
            var expected = "twenty thousand DOLLARS";
            var res = ChequeWriterUtil.GetString(20000.00m);
            Assert.Equal(expected, res);
        }

        [Fact]
        public void Whole_TenThousands_WithDecimal_ReturnsCorrectly()
        {
            var expected = "twenty thousand DOLLARS AND fifty three CENTS";
            var res = ChequeWriterUtil.GetString(20000.53m);
            Assert.Equal(expected, res);
        }

        [Fact]
        public void TenThousands_ReturnsCorrectly()
        {
            var expected = "twenty one thousand, two hundred and fifty four DOLLARS";
            var res = ChequeWriterUtil.GetString(21254.00m);
            Assert.Equal(expected, res);
        }

        [Fact]
        public void TenThousands_WithDecimal_ReturnsCorrectly()
        {
            var expected = "twenty one thousand, two hundred and fifty four DOLLARS AND fifty three CENTS";
            var res = ChequeWriterUtil.GetString(21254.53m);
            Assert.Equal(expected, res);
        }
        [Fact]
        public void Whole_HundredThousands_ReturnsCorrectly()
        {
            var expected = "six hundred thousand DOLLARS";
            var res = ChequeWriterUtil.GetString(600000);
            Assert.Equal(expected, res);
        }

        [Fact]
        public void Whole_HundredThousands_WithDecimal_ReturnsCorrectly()
        {
            var expected = "six hundred thousand DOLLARS AND fifty three CENTS";
            var res = ChequeWriterUtil.GetString(600000.53m);
            Assert.Equal(expected, res);
        }

        [Fact]
        public void HundredThousands_ReturnsCorrectly()
        {
            var expected = "six hundred and twenty one thousand, two hundred and fifty four DOLLARS";
            var res = ChequeWriterUtil.GetString(621254.00m);
            Assert.Equal(expected, res);
        }

        [Fact]
        public void HundredThousands_WithDecimal_ReturnsCorrectly()
        {
            var expected = "six hundred and twenty one thousand, two hundred and fifty four DOLLARS AND fifty three CENTS";
            var res = ChequeWriterUtil.GetString(621254.53m);
            Assert.Equal(expected, res);
        }
        [Fact]
        public void Whole_Millions_ReturnsCorrectly()
        {
            var expected = "three million DOLLARS";
            var res = ChequeWriterUtil.GetString(3000000);
            Assert.Equal(expected, res);
        }

        [Fact]
        public void Whole_Millions_WithDecimal_ReturnsCorrectly()
        {
            var expected = "three million DOLLARS AND fifty three CENTS";
            var res = ChequeWriterUtil.GetString(3000000.53m);
            Assert.Equal(expected, res);
        }

        [Fact]
        public void Millions_ReturnsCorrectly()
        {
            var expected = "three million, six hundred and twenty one thousand, two hundred and fifty four DOLLARS";
            var res = ChequeWriterUtil.GetString(3621254);
            Assert.Equal(expected, res);
        }

        [Fact]
        public void Millions_WithDecimal_ReturnsCorrectly()
        {
            var expected = "three million, six hundred and twenty one thousand, two hundred and fifty four DOLLARS AND fifty three CENTS";
            var res = ChequeWriterUtil.GetString(3621254.53m);
            Assert.Equal(expected, res);
        }


        [Fact]
        public void Whole_TenMillions_ReturnsCorrectly()
        {
            var expected = "seventeen million DOLLARS";
            var res = ChequeWriterUtil.GetString(17000000);
            Assert.Equal(expected, res);
        }

        [Fact]
        public void Whole_TenMillions_WithDecimal_ReturnsCorrectly()
        {
            var expected = "seventeen million DOLLARS AND fifty three CENTS";
            var res = ChequeWriterUtil.GetString(17000000.53m);
            Assert.Equal(expected, res);
        }

        [Fact]
        public void TenMillions_ReturnsCorrectly()
        {
            var expected = "seventeen million, six hundred and twenty one thousand, two hundred and fifty four DOLLARS";
            var res = ChequeWriterUtil.GetString(17621254.00m);
            Assert.Equal(expected, res);
        }

        [Fact]
        public void TenMillions_WithDecimal_ReturnsCorrectly()
        {
            var expected = "seventeen million, six hundred and twenty one thousand, two hundred and fifty four DOLLARS AND fifty three CENTS";
            var res = ChequeWriterUtil.GetString(17621254.53m);
            Assert.Equal(expected, res);
        }


        [Fact]
        public void Whole_HundredMillions_ReturnsCorrectly()
        {
            var expected = "eight hundred million DOLLARS";
            var res = ChequeWriterUtil.GetString(800000000);
            Assert.Equal(expected, res);
        }

        [Fact]
        public void Whole_HundredMillions_WithDecimal_ReturnsCorrectly()
        {
            var expected = "eight hundred million DOLLARS AND fifty three CENTS";
            var res = ChequeWriterUtil.GetString(800000000.53m);
            Assert.Equal(expected, res);
        }

        [Fact]
        public void HundredMillions_ReturnsCorrectly()
        {
            var expected = "eight hundred and seventeen million, six hundred and twenty one thousand, two hundred and fifty four DOLLARS";
            var res = ChequeWriterUtil.GetString(817621254);
            Assert.Equal(expected, res);
        }

        [Fact]
        public void HundredMillions_WithDecimal_ReturnsCorrectly()
        {
            var expected = "eight hundred and seventeen million, six hundred and twenty one thousand, two hundred and fifty four DOLLARS AND fifty three CENTS";
            var res = ChequeWriterUtil.GetString(817621254.53m);
            Assert.Equal(expected, res);
        }

        [Fact]
        public void WholeBillions_ReturnsCorrectly()
        {
            var expected = "one billion DOLLARS";
            var res = ChequeWriterUtil.GetString(1000000000);
            Assert.Equal(expected, res);
        }

        [Fact]
        public void WholeBillions_WithDecimal_ReturnsCorrectly()
        {
            var expected = "one billion DOLLARS AND fifty three CENTS";
            var res = ChequeWriterUtil.GetString(1000000000.53m);
            Assert.Equal(expected, res);
        }

        [Fact]
        public void Billions_ReturnsCorrectly()
        {
            var expected = "one billion, nine hundred and ninety nine million, nine hundred and ninety nine thousand, nine hundred and ninety nine DOLLARS";
            var res = ChequeWriterUtil.GetString(1999999999.00m);
            Assert.Equal(expected, res);
        }
                
        [Fact]
        public void Billions_WithDecimal_ReturnsCorrectly()
        {
            var expected = "one billion, nine hundred and ninety nine million, nine hundred and ninety nine thousand, nine hundred and ninety nine DOLLARS AND ninety nine CENTS";
            var res = ChequeWriterUtil.GetString(1999999999.99m);
            Assert.Equal(expected, res);
        }

        [Fact]
        public void Above_TwoBillions_AreNotSupported()
        {
            var expected = "more than 2 billion are not supported";
            var res = ChequeWriterUtil.GetString(2000000000.01m);
            Assert.Equal(expected, res);
        }

        [Fact(Skip = "a test when 10 billions are supported")]
        public void Whole_TenBillions_ReturnsCorrectly()
        {
            var expected = "ninety two billion DOLLARS";
            var res = ChequeWriterUtil.GetString(92000000000);
            Assert.Equal(expected, res);
        }

        [Fact(Skip = "a test when 10 billions are supported")]
        public void Whole_TenBillions_WithDecimalReturnsCorrectly()
        {
            var expected = "ninety two billion DOLLARS AND fifty three CENTS";
            var res = ChequeWriterUtil.GetString(92000000000.53m);
            Assert.Equal(expected, res);
        }

        [Fact (Skip ="a test when 10 billions are supported")]
        public void TenBillions_ReturnsCorrectly()
        {
            var expected = "ninety two billion, eight hundred and seventeen million, six hundred and twenty one thousand, two hundred and fifty four DOLLARS";
            var res = ChequeWriterUtil.GetString(92817621254);
            Assert.Equal(expected, res);
        }

        [Fact(Skip = "a test when 10 billions are supported")]
        public void TenBillions_WithDecimalReturnsCorrectly()
        {
            var expected = "ninety two billion, eight hundred and seventeen million, six hundred and twenty one thousand, two hundred and fifty four DOLLARS AND fifty three CENTS";
            var res = ChequeWriterUtil.GetString(92817621254.53m);
            Assert.Equal(expected, res);
        }

        

        [Fact]
        public void Tens_Return_1_Group()
        {
            var res = ChequeWriterUtil.GetGroups("23");
            Assert.Single(res);
        }

        [Fact]
        public void Hundreds_Return_1_Group()
        {
            var res = ChequeWriterUtil.GetGroups("123");
            Assert.Single(res);
        }

        [Fact]
        public void Thousands_Return_2_Groups()
        {
            var res = ChequeWriterUtil.GetGroups("43210");
            Assert.Equal(2, res.Count);
            Assert.Equal("210", res[0]);
            Assert.Equal("43", res[1]);
        }

        [Fact]
        public void Millions_Return_3_Groups()
        {
            var res = ChequeWriterUtil.GetGroups("76543210");
            Assert.Equal(3, res.Count);
            Assert.Equal("210", res[0]);
            Assert.Equal("543", res[1]);
            Assert.Equal("76", res[2]);
        }

        [Fact]
        public void Billions_Return_4_Groups()
        {
            var res = ChequeWriterUtil.GetGroups("9876543210");
            Assert.Equal(4, res.Count);
            Assert.Equal("210", res[0]);
            Assert.Equal("543", res[1]);
            Assert.Equal("876", res[2]);
            Assert.Equal("9", res[3]);
        }
    }
}
