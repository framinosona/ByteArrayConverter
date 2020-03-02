// ReSharper disable UnusedMember.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedType.Global

namespace ByteArrayConverter
{
    using System;
    using System.Globalization;
    using System.IO;

    /// <summary>
    /// Builder for byte array.
    /// </summary>
    public sealed class ByteArrayBuilder : IDisposable
    {
        private readonly MemoryStream memoryStream = new MemoryStream();

        /// <summary>
        /// Returns the byte array.
        /// </summary>
        /// <param name="maxSize">Size of the byte array to return.</param>
        /// <returns>The byte array.</returns>
        /// <exception cref="IndexOutOfRangeException">If the byte array is longer than the maxSize.</exception>
        public byte[] ToByteArray(int? maxSize = null)
        {
            var output = this.memoryStream.ToArray();
            if (maxSize.HasValue && output.Length > maxSize.Value)
            {
                throw new IndexOutOfRangeException($"Array [{this}] is too big. {output.Length} bytes > {maxSize.Value} bytes");
            }

            return output;
        }

        /// <inheritdoc />
        public override string ToString() => string.Join(",", this.memoryStream.ToArray());

        /// <summary>
        /// Append a byte array to the ByteArrayBuilder.
        /// </summary>
        /// <param name="values">The input.</param>
        /// <returns>The ByteArrayBuilder.</returns>
        public ByteArrayBuilder Append(byte[] values)
        {
            if (values != null)
            {
                this.memoryStream.Write(values, 0, values.Length);
            }

            return this;
        }

        /// <summary>
        /// Append a byte to the ByteArrayBuilder.
        /// </summary>
        /// <param name="value">The input.</param>
        /// <returns>The ByteArrayBuilder.</returns>
        public ByteArrayBuilder Append(byte value) => this.Append(new[] { value });

        /// <summary>
        /// Append a sbyte to the ByteArrayBuilder.
        /// </summary>
        /// <param name="value">The input.</param>
        /// <returns>The ByteArrayBuilder.</returns>
        public ByteArrayBuilder Append(sbyte value) => this.Append(new[] { unchecked((byte)value) });

        /// <summary>
        /// Append a bool to the ByteArrayBuilder.
        /// </summary>
        /// <param name="value">The input.</param>
        /// <returns>The ByteArrayBuilder.</returns>
        public ByteArrayBuilder Append(bool value) => this.Append(BitConverter.GetBytes(value));

        /// <summary>
        /// Append a short to the ByteArrayBuilder.
        /// </summary>
        /// <param name="value">The input.</param>
        /// <returns>The ByteArrayBuilder.</returns>
        public ByteArrayBuilder Append(short value) => this.Append(BitConverter.GetBytes(value));

        /// <summary>
        /// Append a ushort to the ByteArrayBuilder.
        /// </summary>
        /// <param name="value">The input.</param>
        /// <returns>The ByteArrayBuilder.</returns>
        public ByteArrayBuilder Append(ushort value) => this.Append(BitConverter.GetBytes(value));

        /// <summary>
        /// Append a int to the ByteArrayBuilder.
        /// </summary>
        /// <param name="value">The input.</param>
        /// <returns>The ByteArrayBuilder.</returns>
        public ByteArrayBuilder Append(int value) => this.Append(BitConverter.GetBytes(value));

        /// <summary>
        /// Append a uint to the ByteArrayBuilder.
        /// </summary>
        /// <param name="value">The input.</param>
        /// <returns>The ByteArrayBuilder.</returns>
        public ByteArrayBuilder Append(uint value) => this.Append(BitConverter.GetBytes(value));

        /// <summary>
        /// Append a long to the ByteArrayBuilder.
        /// </summary>
        /// <param name="value">The input.</param>
        /// <returns>The ByteArrayBuilder.</returns>
        public ByteArrayBuilder Append(long value) => this.Append(BitConverter.GetBytes(value));

        /// <summary>
        /// Append a ulong to the ByteArrayBuilder.
        /// </summary>
        /// <param name="value">The input.</param>
        /// <returns>The ByteArrayBuilder.</returns>
        public ByteArrayBuilder Append(ulong value) => this.Append(BitConverter.GetBytes(value));

        /// <summary>
        /// Append a char to the ByteArrayBuilder.
        /// </summary>
        /// <param name="value">The input.</param>
        /// <returns>The ByteArrayBuilder.</returns>
        public ByteArrayBuilder Append(char value) => this.Append(BitConverter.GetBytes(value));

        /// <summary>
        /// Append a double to the ByteArrayBuilder.
        /// </summary>
        /// <param name="value">The input.</param>
        /// <returns>The ByteArrayBuilder.</returns>
        public ByteArrayBuilder Append(double value) => this.Append(BitConverter.GetBytes(value));

        /// <summary>
        /// Append a float to the ByteArrayBuilder.
        /// </summary>
        /// <param name="value">The input.</param>
        /// <returns>The ByteArrayBuilder.</returns>
        public ByteArrayBuilder Append(float value) => this.Append(BitConverter.GetBytes(value));

        /// <summary>
        /// Append an string to the ByteArrayBuilder.
        /// </summary>
        /// <param name="value">The input.</param>
        /// <returns>The ByteArrayBuilder.</returns>
        public ByteArrayBuilder Append(string value) => this.Append(System.Text.Encoding.UTF8.GetBytes(value));

        /// <summary>
        /// Append object or enum to the ByteArrayBuilder.
        /// </summary>
        /// <param name="value">The input.</param>
        /// <typeparam name="T">Type of input.</typeparam>
        /// <returns>The ByteArrayBuilder.</returns>
        public ByteArrayBuilder Append<T>(T value) => this.Append(Convert.ToByte(value, CultureInfo.InvariantCulture));

        /// <inheritdoc />
        public void Dispose() => this.memoryStream?.Dispose();
    }
}
