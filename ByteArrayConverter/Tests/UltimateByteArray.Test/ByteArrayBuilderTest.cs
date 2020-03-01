// ReSharper disable SA1600

namespace ByteArrayConverter.Test
{
    using System;
    using ByteArrayConverter;
    using Xunit;

    public class ByteArrayBuilderTest
    {
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void BooleanTest(bool input) =>
            this.RunConversionTest(
                input,
                i => i.ToByteArray(),
                i => i.ToBoolean());

        [Theory]
        [InlineData(byte.MinValue)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(byte.MaxValue)]
        public void ByteTest(byte input) =>
            this.RunConversionTest(
                input,
                i => i.ToByteArray(),
                i => i.ToByte());

        [Theory]
        [InlineData(sbyte.MinValue)]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(sbyte.MaxValue)]
        public void SByteTest(sbyte input) =>
            this.RunConversionTest(
                input,
                i => i.ToByteArray(),
                i => i.ToSByte());

        [Theory]
        [InlineData(short.MinValue)]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(short.MaxValue)]
        public void Int16Test(short input) =>
            this.RunConversionTest(
                input,
                i => i.ToByteArray(),
                i => i.ToInt16());

        [Theory]
        [InlineData(ushort.MinValue)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(ushort.MaxValue)]
        public void UInt16Test(ushort input) =>
            this.RunConversionTest(
                input,
                i => i.ToByteArray(),
                i => i.ToUInt16());

        [Theory]
        [InlineData(int.MinValue)]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(int.MaxValue)]
        public void Int32Test(int input) =>
            this.RunConversionTest(
                input,
                i => i.ToByteArray(),
                i => i.ToInt32());

        [Theory]
        [InlineData(uint.MinValue)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(uint.MaxValue)]
        public void UInt32Test(uint input) =>
            this.RunConversionTest(
                input,
                i => i.ToByteArray(),
                i => i.ToUInt32());

        [Theory]
        [InlineData(long.MinValue)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(long.MaxValue)]
        public void Int64Test(long input) =>
            this.RunConversionTest(
                input,
                i => i.ToByteArray(),
                i => i.ToInt64());

        [Theory]
        [InlineData(ulong.MinValue)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(ulong.MaxValue)]
        public void UInt64Test(ulong input) =>
            this.RunConversionTest(
                input,
                i => i.ToByteArray(),
                i => i.ToUInt64());

        [Theory]
        [InlineData(double.MinValue)]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(double.MaxValue)]
        public void DoubleTest(double input) =>
            this.RunConversionTest(
                input,
                i => i.ToByteArray(),
                i => i.ToDouble());

        [Theory]
        [InlineData(float.MinValue)]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(float.MaxValue)]
        public void SingleTest(float input) =>
            this.RunConversionTest(
                input,
                i => i.ToByteArray(),
                i => i.ToSingle());

        [Theory]
        [InlineData(char.MinValue)]
        [InlineData('T')]
        [InlineData(char.MaxValue)]
        public void CharTest(char input) =>
            this.RunConversionTest(
                input,
                i => i.ToByteArray(),
                i => i.ToChar());

        [Theory]
        [InlineData("")]
        [InlineData("François Raminosona")]
        public void StringTest(string input) =>
            this.RunConversionTest(
                input,
                i => i.ToByteArray(),
                i => i.ToUtf8String());

        [Theory]
        [InlineData(FiveWs.Who)]
        [InlineData(FiveWs.What)]
        [InlineData(FiveWs.When)]
        [InlineData(FiveWs.Where)]
        [InlineData(FiveWs.Why)]
        [InlineData(FiveWs.WingardiumLeviosa)]
        public void EnumTest<T>(T input)
            where T : Enum =>
            this.RunConversionTest(
                input,
                i => i.ToByteArray(),
                i => i.ToEnum<T>());

        [Fact]
        public void ObjectConstructionAndDeconstructionTest()
        {
            using var byteArrayBuilder = new ByteArrayBuilder();
            var byteArray = byteArrayBuilder
                .Append(true)
                .Append(false)
                .Append((byte)2)
                .Append((sbyte)2)
                .Append((short)2)
                .Append((ushort)2)
                .Append(2)
                .Append(2U)
                .Append(2L)
                .Append(2UL)
                .Append(2D)
                .Append(2F)
                .Append(FiveWs.Why)
                .ToByteArray();

            var position = 0;
            this.DeconstructionAssertion(byteArray.ToBoolean(ref position), true);
            this.DeconstructionAssertion(byteArray.ToBoolean(ref position), false);
            this.DeconstructionAssertion(byteArray.ToByte(ref position), (byte)2);
            this.DeconstructionAssertion(byteArray.ToSByte(ref position), (sbyte)2);
            this.DeconstructionAssertion(byteArray.ToInt16(ref position), (short)2);
            this.DeconstructionAssertion(byteArray.ToUInt16(ref position), (ushort)2);
            this.DeconstructionAssertion(byteArray.ToInt32(ref position), 2);
            this.DeconstructionAssertion(byteArray.ToUInt32(ref position), 2U);
            this.DeconstructionAssertion(byteArray.ToInt64(ref position), 2L);
            this.DeconstructionAssertion(byteArray.ToUInt64(ref position), 2UL);
            this.DeconstructionAssertion(byteArray.ToDouble(ref position), 2D);
            this.DeconstructionAssertion(byteArray.ToSingle(ref position), 2F);
            this.DeconstructionAssertion(byteArray.ToEnum<FiveWs>(ref position), FiveWs.Why);
        }

        private void DeconstructionAssertion<TParsed, TExpected>(TParsed parsedValue, TExpected expectedValue)
            where TParsed : TExpected
        {
            Assert.Equal(typeof(TExpected), typeof(TParsed));
            Assert.Equal(expectedValue, parsedValue);
        }

        private void RunConversionTest<T>(T input, Func<T, byte[]> fromTypeToByteArray, Func<byte[], T> fromByteArrayToType)
        {
            var array = fromTypeToByteArray.Invoke(input);
            Console.WriteLine($"{typeof(T)}:{input} => {array.ToDebugString()}");

            var output = fromByteArrayToType.Invoke(array);
            Console.WriteLine($"{array.ToDebugString()} => {typeof(T)}:{output}");

            Assert.Equal(input, output);
        }
    }
}
