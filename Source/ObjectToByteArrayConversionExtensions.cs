// ReSharper disable UnusedMember.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedType.Global

namespace ByteArrayConverter
{
    using System;

    /// <summary>
    /// Classes extensions to convert into byte array.
    /// </summary>
    public static class ObjectToByteArrayConversionExtensions
    {
        /// <inheritdoc cref="ObjectToByteArrayConversionHelper.ToByteArray(byte)" />
        public static byte[] ToByteArray(this byte value) => ObjectToByteArrayConversionHelper.ToByteArray(value);

        /// <inheritdoc cref="ObjectToByteArrayConversionHelper.ToByteArray(sbyte)" />
        public static byte[] ToByteArray(this sbyte value) => ObjectToByteArrayConversionHelper.ToByteArray(value);

        /// <inheritdoc cref="ObjectToByteArrayConversionHelper.ToByteArray(bool)" />
        public static byte[] ToByteArray(this bool value) => ObjectToByteArrayConversionHelper.ToByteArray(value);

        /// <inheritdoc cref="ObjectToByteArrayConversionHelper.ToByteArray(short)" />
        public static byte[] ToByteArray(this short value) => ObjectToByteArrayConversionHelper.ToByteArray(value);

        /// <inheritdoc cref="ObjectToByteArrayConversionHelper.ToByteArray(ushort)" />
        public static byte[] ToByteArray(this ushort value) => ObjectToByteArrayConversionHelper.ToByteArray(value);

        /// <inheritdoc cref="ObjectToByteArrayConversionHelper.ToByteArray(int)" />
        public static byte[] ToByteArray(this int value) => ObjectToByteArrayConversionHelper.ToByteArray(value);

        /// <inheritdoc cref="ObjectToByteArrayConversionHelper.ToByteArray(uint)" />
        public static byte[] ToByteArray(this uint value) => ObjectToByteArrayConversionHelper.ToByteArray(value);

        /// <inheritdoc cref="ObjectToByteArrayConversionHelper.ToByteArray(long)" />
        public static byte[] ToByteArray(this long value) => ObjectToByteArrayConversionHelper.ToByteArray(value);

        /// <inheritdoc cref="ObjectToByteArrayConversionHelper.ToByteArray(ulong)" />
        public static byte[] ToByteArray(this ulong value) => ObjectToByteArrayConversionHelper.ToByteArray(value);

        /// <inheritdoc cref="ObjectToByteArrayConversionHelper.ToByteArray(char)" />
        public static byte[] ToByteArray(this char value) => ObjectToByteArrayConversionHelper.ToByteArray(value);

        /// <inheritdoc cref="ObjectToByteArrayConversionHelper.ToByteArray(double)" />
        public static byte[] ToByteArray(this double value) => ObjectToByteArrayConversionHelper.ToByteArray(value);

        /// <inheritdoc cref="ObjectToByteArrayConversionHelper.ToByteArray(float)" />
        public static byte[] ToByteArray(this float value) => ObjectToByteArrayConversionHelper.ToByteArray(value);

        /// <inheritdoc cref="ObjectToByteArrayConversionHelper.ToByteArray(string)" />
        public static byte[] ToByteArray(this string value) => ObjectToByteArrayConversionHelper.ToByteArray(value);

        /// <inheritdoc cref="ObjectToByteArrayConversionHelper.ToByteArray(Version)" />
        public static byte[] ToByteArray(this Version value) => ObjectToByteArrayConversionHelper.ToByteArray(value);

        /// <inheritdoc cref="ObjectToByteArrayConversionHelper.ToByteArray{T}" />
        public static byte[] ToByteArray<T>(this T value) => ObjectToByteArrayConversionHelper.ToByteArray(value);
    }
}
