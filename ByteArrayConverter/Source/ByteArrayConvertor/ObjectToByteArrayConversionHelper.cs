// ReSharper disable UnusedMember.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedType.Global
namespace ByteArrayConverter
{
    using System;

    /// <summary>
    /// Functions converting a byte array into another type.
    /// </summary>
    public static class ObjectToByteArrayConversionHelper
    {
        /// <summary>
        /// Creates a byte array from a byte.
        /// </summary>
        /// <param name="value">The input.</param>
        /// <returns>The new byte array.</returns>
        public static byte[] ToByteArray(byte value)
        {
            using var byteArrayBuilder = new ByteArrayBuilder();
            return byteArrayBuilder.Append(value).ToByteArray();
        }

        /// <summary>
        /// Creates a byte array from a bool.
        /// </summary>
        /// <param name="value">The input.</param>
        /// <returns>The new byte array.</returns>
        public static byte[] ToByteArray(bool value)
        {
            using var byteArrayBuilder = new ByteArrayBuilder();
            return byteArrayBuilder.Append(value).ToByteArray();
        }

        /// <summary>
        /// Creates a byte array from a sbyte.
        /// </summary>
        /// <param name="value">The input.</param>
        /// <returns>The new byte array.</returns>
        public static byte[] ToByteArray(sbyte value)
        {
            using var byteArrayBuilder = new ByteArrayBuilder();
            return byteArrayBuilder.Append(value).ToByteArray();
        }

        /// <summary>
        /// Creates a byte array from a short.
        /// </summary>
        /// <param name="value">The input.</param>
        /// <returns>The new byte array.</returns>
        public static byte[] ToByteArray(short value)
        {
            using var byteArrayBuilder = new ByteArrayBuilder();
            return byteArrayBuilder.Append(value).ToByteArray();
        }

        /// <summary>
        /// Creates a byte array from a ushort.
        /// </summary>
        /// <param name="value">The input.</param>
        /// <returns>The new byte array.</returns>
        public static byte[] ToByteArray(ushort value)
        {
            using var byteArrayBuilder = new ByteArrayBuilder();
            return byteArrayBuilder.Append(value).ToByteArray();
        }

        /// <summary>
        /// Creates a byte array from a int.
        /// </summary>
        /// <param name="value">The input.</param>
        /// <returns>The new byte array.</returns>
        public static byte[] ToByteArray(int value)
        {
            using var byteArrayBuilder = new ByteArrayBuilder();
            return byteArrayBuilder.Append(value).ToByteArray();
        }

        /// <summary>
        /// Creates a byte array from a uint.
        /// </summary>
        /// <param name="value">The input.</param>
        /// <returns>The new byte array.</returns>
        public static byte[] ToByteArray(uint value)
        {
            using var byteArrayBuilder = new ByteArrayBuilder();
            return byteArrayBuilder.Append(value).ToByteArray();
        }

        /// <summary>
        /// Creates a byte array from a long.
        /// </summary>
        /// <param name="value">The input.</param>
        /// <returns>The new byte array.</returns>
        public static byte[] ToByteArray(long value)
        {
            using var byteArrayBuilder = new ByteArrayBuilder();
            return byteArrayBuilder.Append(value).ToByteArray();
        }

        /// <summary>
        /// Creates a byte array from a ulong.
        /// </summary>
        /// <param name="value">The input.</param>
        /// <returns>The new byte array.</returns>
        public static byte[] ToByteArray(ulong value)
        {
            using var byteArrayBuilder = new ByteArrayBuilder();
            return byteArrayBuilder.Append(value).ToByteArray();
        }

        /// <summary>
        /// Creates a byte array from a char.
        /// </summary>
        /// <param name="value">The input.</param>
        /// <returns>The new byte array.</returns>
        public static byte[] ToByteArray(char value)
        {
            using var byteArrayBuilder = new ByteArrayBuilder();
            return byteArrayBuilder.Append(value).ToByteArray();
        }

        /// <summary>
        /// Creates a byte array from a double.
        /// </summary>
        /// <param name="value">The input.</param>
        /// <returns>The new byte array.</returns>
        public static byte[] ToByteArray(double value)
        {
            using var byteArrayBuilder = new ByteArrayBuilder();
            return byteArrayBuilder.Append(value).ToByteArray();
        }

        /// <summary>
        /// Creates a byte array from a float.
        /// </summary>
        /// <param name="value">The input.</param>
        /// <returns>The new byte array.</returns>
        public static byte[] ToByteArray(float value)
        {
            using var byteArrayBuilder = new ByteArrayBuilder();
            return byteArrayBuilder.Append(value).ToByteArray();
        }

        /// <summary>
        /// Creates a byte array from a string.
        /// </summary>
        /// <param name="value">The input.</param>
        /// <returns>The new byte array.</returns>
        public static byte[] ToByteArray(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return Array.Empty<byte>();
            }

            using var byteArrayBuilder = new ByteArrayBuilder();
            return byteArrayBuilder.Append(value).ToByteArray();
        }

        /// <summary>
        /// Creates a byte array from an object or an enum.
        /// </summary>
        /// <param name="value">The input.</param>
        /// <typeparam name="T">Type of input.</typeparam>
        /// <returns>The new byte array.</returns>
        public static byte[] ToByteArray<T>(T value)
        {
            if (value == null)
            {
                return Array.Empty<byte>();
            }

            using var byteArrayBuilder = new ByteArrayBuilder();
            return byteArrayBuilder.Append(value).ToByteArray();
        }

        /// <summary>
        /// Creates a byte array from a Version.
        /// </summary>
        /// <param name="value">The input.</param>
        /// <returns>The new byte array.</returns>
        public static byte[] ToByteArray(Version value)
        {
            if (value == null)
            {
                return Array.Empty<byte>();
            }

            using var byteArrayBuilder = new ByteArrayBuilder();
            return byteArrayBuilder.Append(value.ToString()).ToByteArray();
        }
    }
}
