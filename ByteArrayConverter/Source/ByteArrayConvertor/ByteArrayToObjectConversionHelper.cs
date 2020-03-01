// ReSharper disable UnusedMember.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedType.Global

namespace ByteArrayConverter
{
    using System;
    using System.Globalization;
    using System.Text;

    /// <summary>
    /// Functions converting other types into a byte array.
    /// </summary>
    public static class ByteArrayToObjectConversionHelper
    {
        /// <summary>
        /// Converts the byte array into a Boolean value
        /// True[1] or False[0].
        /// </summary>
        /// <param name="array">The byte array.</param>
        /// <param name="position">The position within the array. Byref : is auto-incremented by the size of the output type.</param>
        /// <param name="defaultValue">Default value for that type, can be overriden.</param>
        /// <returns>Converted value.</returns>
        public static bool ToBoolean(byte[] array, ref int position, bool defaultValue = default) => ToType(array, ref position, sizeof(bool), BitConverter.ToBoolean, defaultValue);

        /// <summary>
        /// Converts the byte array into a Boolean value
        /// True[1] or False[0].
        /// </summary>
        /// <param name="array">The byte array.</param>
        /// <param name="position">The position within the array.</param>
        /// <param name="defaultValue">Default value for that type, can be overriden.</param>
        /// <returns>Converted value.</returns>
        public static bool ToBoolean(byte[] array, int position = 0, bool defaultValue = default) => ToType(array, ref position, sizeof(bool), BitConverter.ToBoolean, defaultValue);

        /// <summary>
        /// Converts the byte array into an Unsigned 8-bit integer
        /// From 0 to 255.
        /// </summary>
        /// <param name="array">The byte array.</param>
        /// <param name="position">The position within the array. Byref : is auto-incremented by the size of the output type.</param>
        /// <param name="defaultValue">Default value for that type, can be overriden.</param>
        /// <returns>Converted value.</returns>
        public static byte ToByte(byte[] array, ref int position, byte defaultValue = default) => ToType(array, ref position, sizeof(byte), (bytes, i) => bytes[i], defaultValue);

        /// <summary>
        /// Converts the byte array into an Unsigned 8-bit integer
        /// From 0 to 255.
        /// </summary>
        /// <param name="array">The byte array.</param>
        /// <param name="position">The position within the array.</param>
        /// <param name="defaultValue">Default value for that type, can be overriden.</param>
        /// <returns>Converted value.</returns>
        public static byte ToByte(byte[] array, int position = 0, byte defaultValue = default) => ToType(array, ref position, sizeof(byte), (bytes, i) => bytes[i], defaultValue);

        /// <summary>
        /// Converts the byte array into a Signed 8-bit integer
        /// From -128 to 127.
        /// </summary>
        /// <param name="array">The byte array.</param>
        /// <param name="position">The position within the array. Byref : is auto-incremented by the size of the output type.</param>
        /// <param name="defaultValue">Default value for that type, can be overriden.</param>
        /// <returns>Converted value.</returns>
        public static sbyte ToSByte(byte[] array, ref int position, sbyte defaultValue = default) => ToType(array, ref position, sizeof(sbyte), (bytes, i) => (sbyte)bytes[i], defaultValue);

        /// <summary>
        /// Converts the byte array into a Signed 8-bit integer
        /// From -128 to 127.
        /// </summary>
        /// <param name="array">The byte array.</param>
        /// <param name="position">The position within the array.</param>
        /// <param name="defaultValue">Default value for that type, can be overriden.</param>
        /// <returns>Converted value.</returns>
        public static sbyte ToSByte(byte[] array, int position = 0, sbyte defaultValue = default) => ToType(array, ref position, sizeof(sbyte), (bytes, i) => (sbyte)bytes[i], defaultValue);

        /// <summary>
        /// Converts the byte array into a Signed 16-bit integer
        /// From -32,768 to 32,767.
        /// </summary>
        /// <param name="array">The byte array.</param>
        /// <param name="position">The position within the array. Byref : is auto-incremented by the size of the output type.</param>
        /// <param name="defaultValue">Default value for that type, can be overriden.</param>
        /// <returns>Converted value.</returns>
        public static short ToInt16(byte[] array, ref int position, short defaultValue = default) => ToType(array, ref position, sizeof(short), BitConverter.ToInt16, defaultValue);

        /// <summary>
        /// Converts the byte array into a Signed 16-bit integer
        /// From -32,768 to 32,767.
        /// </summary>
        /// <param name="array">The byte array.</param>
        /// <param name="position">The position within the array.</param>
        /// <param name="defaultValue">Default value for that type, can be overriden.</param>
        /// <returns>Converted value.</returns>
        public static short ToInt16(byte[] array, int position = 0, short defaultValue = default) => ToType(array, ref position, sizeof(short), BitConverter.ToInt16, defaultValue);

        /// <summary>
        /// Converts the byte array into a Unsigned 16-bit integer
        /// From 0 to 65,535.
        /// </summary>
        /// <param name="array">The byte array.</param>
        /// <param name="position">The position within the array. Byref : is auto-incremented by the size of the output type.</param>
        /// <param name="defaultValue">Default value for that type, can be overriden.</param>
        /// <returns>Converted value.</returns>
        public static ushort ToUInt16(byte[] array, ref int position, ushort defaultValue = default) => ToType(array, ref position, sizeof(ushort), BitConverter.ToUInt16, defaultValue);

        /// <summary>
        /// Converts the byte array into a Unsigned 16-bit integer
        /// From 0 to 65,535.
        /// </summary>
        /// <param name="array">The byte array.</param>
        /// <param name="position">The position within the array.</param>
        /// <param name="defaultValue">Default value for that type, can be overriden.</param>
        /// <returns>Converted value.</returns>
        public static ushort ToUInt16(byte[] array, int position = 0, ushort defaultValue = default) => ToType(array, ref position, sizeof(ushort), BitConverter.ToUInt16, defaultValue);

        /// <summary>
        /// Converts the byte array into a Signed 32-bit integer
        /// From -2,147,483,648 to 2,147,483,647.
        /// </summary>
        /// <param name="array">The byte array.</param>
        /// <param name="position">The position within the array. Byref : is auto-incremented by the size of the output type.</param>
        /// <param name="defaultValue">Default value for that type, can be overriden.</param>
        /// <returns>Converted value.</returns>
        public static int ToInt32(byte[] array, ref int position, int defaultValue = default) => ToType(array, ref position, sizeof(int), BitConverter.ToInt32, defaultValue);

        /// <summary>
        /// Converts the byte array into a Signed 32-bit integer
        /// From -2,147,483,648 to 2,147,483,647.
        /// </summary>
        /// <param name="array">The byte array.</param>
        /// <param name="position">The position within the array.</param>
        /// <param name="defaultValue">Default value for that type, can be overriden.</param>
        /// <returns>Converted value.</returns>
        public static int ToInt32(byte[] array, int position = 0, int defaultValue = default) => ToType(array, ref position, sizeof(int), BitConverter.ToInt32, defaultValue);

        /// <summary>
        /// Converts the byte array into a Unsigned 32-bit integer
        /// From 0 to 4,294,967,295.
        /// </summary>
        /// <param name="array">The byte array.</param>
        /// <param name="position">The position within the array. Byref : is auto-incremented by the size of the output type.</param>
        /// <param name="defaultValue">Default value for that type, can be overriden.</param>
        /// <returns>Converted value.</returns>
        public static uint ToUInt32(byte[] array, ref int position, uint defaultValue = default) => ToType(array, ref position, sizeof(uint), BitConverter.ToUInt32, defaultValue);

        /// <summary>
        /// Converts the byte array into a Unsigned 32-bit integer
        /// From 0 to 4,294,967,295.
        /// </summary>
        /// <param name="array">The byte array.</param>
        /// <param name="position">The position within the array.</param>
        /// <param name="defaultValue">Default value for that type, can be overriden.</param>
        /// <returns>Converted value.</returns>
        public static uint ToUInt32(byte[] array, int position = 0, uint defaultValue = default) => ToType(array, ref position, sizeof(uint), BitConverter.ToUInt32, defaultValue);

        /// <summary>
        /// Converts the byte array into a Signed 64-bit integer
        /// From -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807.
        /// </summary>
        /// <param name="array">The byte array.</param>
        /// <param name="position">The position within the array. Byref : is auto-incremented by the size of the output type.</param>
        /// <param name="defaultValue">Default value for that type, can be overriden.</param>
        /// <returns>Converted value.</returns>
        public static long ToInt64(byte[] array, ref int position, long defaultValue = default) => ToType(array, ref position, sizeof(long), BitConverter.ToInt64, defaultValue);

        /// <summary>
        /// Converts the byte array into a Signed 64-bit integer
        /// From -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807.
        /// </summary>
        /// <param name="array">The byte array.</param>
        /// <param name="position">The position within the array.</param>
        /// <param name="defaultValue">Default value for that type, can be overriden.</param>
        /// <returns>Converted value.</returns>
        public static long ToInt64(byte[] array, int position = 0, long defaultValue = default) => ToType(array, ref position, sizeof(long), BitConverter.ToInt64, defaultValue);

        /// <summary>
        /// Converts the byte array into a Unsigned 64-bit integer
        /// From 0 to 18,446,744,073,709,551,615.
        /// </summary>
        /// <param name="array">The byte array.</param>
        /// <param name="position">The position within the array. Byref : is auto-incremented by the size of the output type.</param>
        /// <param name="defaultValue">Default value for that type, can be overriden.</param>
        /// <returns>Converted value.</returns>
        public static ulong ToUInt64(byte[] array, ref int position, ulong defaultValue = default) => ToType(array, ref position, sizeof(ulong), BitConverter.ToUInt64, defaultValue);

        /// <summary>
        /// Converts the byte array into a Unsigned 64-bit integer
        /// From 0 to 18,446,744,073,709,551,615.
        /// </summary>
        /// <param name="array">The byte array.</param>
        /// <param name="position">The position within the array.</param>
        /// <param name="defaultValue">Default value for that type, can be overriden.</param>
        /// <returns>Converted value.</returns>
        public static ulong ToUInt64(byte[] array, int position = 0, ulong defaultValue = default) => ToType(array, ref position, sizeof(ulong), BitConverter.ToUInt64, defaultValue);

        /// <summary>
        /// Converts the byte array into a Signed 64-bit double-precision floating-point number
        /// From -1.79769313486232E+308 to 1.79769313486232E+308.
        /// </summary>
        /// <param name="array">The byte array.</param>
        /// <param name="position">The position within the array. Byref : is auto-incremented by the size of the output type.</param>
        /// <param name="defaultValue">Default value for that type, can be overriden.</param>
        /// <returns>Converted value.</returns>
        public static double ToDouble(byte[] array, ref int position, double defaultValue = default) => ToType(array, ref position, sizeof(double), BitConverter.ToDouble, defaultValue);

        /// <summary>
        /// Converts the byte array into a Signed 64-bit double-precision floating-point number
        /// From -1.79769313486232E+308 to 1.79769313486232E+308.
        /// </summary>
        /// <param name="array">The byte array.</param>
        /// <param name="position">The position within the array.</param>
        /// <param name="defaultValue">Default value for that type, can be overriden.</param>
        /// <returns>Converted value.</returns>
        public static double ToDouble(byte[] array, int position = 0, double defaultValue = default) => ToType(array, ref position, sizeof(double), BitConverter.ToDouble, defaultValue);

        /// <summary>
        /// Converts the byte array into a Signed 32-bit single-precision floating-point number
        /// From -32768 to 32767.
        /// </summary>
        /// <param name="array">The byte array.</param>
        /// <param name="position">The position within the array. Byref : is auto-incremented by the size of the output type.</param>
        /// <param name="defaultValue">Default value for that type, can be overriden.</param>
        /// <returns>Converted value.</returns>
        public static float ToSingle(byte[] array, ref int position, float defaultValue = default) => ToType(array, ref position, sizeof(float), BitConverter.ToSingle, defaultValue);

        /// <summary>
        /// Converts the byte array into a Signed 32-bit single-precision floating-point number
        /// From -32768 to 32767.
        /// </summary>
        /// <param name="array">The byte array.</param>
        /// <param name="position">The position within the array.</param>
        /// <param name="defaultValue">Default value for that type, can be overriden.</param>
        /// <returns>Converted value.</returns>
        public static float ToSingle(byte[] array, int position = 0, float defaultValue = default) => ToType(array, ref position, sizeof(float), BitConverter.ToSingle, defaultValue);

        /// <summary>
        /// Converts the byte array into a Character in UTF-16 code unit
        /// Any UTF-16 character.
        /// </summary>
        /// <param name="array">The byte array.</param>
        /// <param name="position">The position within the array. Byref : is auto-incremented by the size of the output type.</param>
        /// <param name="defaultValue">Default value for that type, can be overriden.</param>
        /// <returns>Converted value.</returns>
        public static char ToChar(byte[] array, ref int position, char defaultValue = default) => ToType(array, ref position, sizeof(char), BitConverter.ToChar, defaultValue);

        /// <summary>
        /// Converts the byte array into a Character in UTF-16 code unit
        /// Any UTF-16 character.
        /// </summary>
        /// <param name="array">The byte array.</param>
        /// <param name="position">The position within the array.</param>
        /// <param name="defaultValue">Default value for that type, can be overriden.</param>
        /// <returns>Converted value.</returns>
        public static char ToChar(byte[] array, int position = 0, char defaultValue = default) => ToType(array, ref position, sizeof(char), BitConverter.ToChar, defaultValue);

        /// <summary>
        /// Converts the full byte array into a UTF8 String.
        /// </summary>
        /// <param name="array">The byte array.</param>
        /// <param name="defaultValue">Default value for that type, can be overriden.</param>
        /// <returns>Converted value.</returns>
        public static string ToUtf8String(byte[] array, string defaultValue = default) => ArrayToType(array, bytes => Encoding.UTF8.GetString(bytes, 0, bytes.Length), defaultValue) ?? string.Empty;

        /// <summary>
        /// Converts the full byte array into a Version.
        /// </summary>
        /// <param name="array">The byte array.</param>
        /// <param name="defaultValue">Default value for that type, can be overriden.</param>
        /// <returns>Converted value.</returns>
        public static Version ToVersion(byte[] array, Version defaultValue = default) => ArrayToType(array, bytes => Version.Parse(ToUtf8String(bytes)), defaultValue);

        /// <summary>
        /// Converts the byte array into a given Enum.
        /// </summary>
        /// <param name="array">The byte array.</param>
        /// <param name="position">The position within the array. Byref : is auto-incremented by the size of the output type.</param>
        /// <param name="defaultValue">Default value for that type, can be overriden.</param>
        /// <typeparam name="T">Type of Enum.</typeparam>
        /// <returns>Converted value.</returns>
        public static T ToEnum<T>(byte[] array, ref int position, T defaultValue = default)
            where T : Enum
            => GetEnum<T>(ToByte(array, ref position, Convert.ToByte(defaultValue, CultureInfo.InvariantCulture)));

        /// <summary>
        /// Converts the byte array into a given Enum.
        /// </summary>
        /// <param name="array">The byte array.</param>
        /// <param name="position">The position within the array.</param>
        /// <param name="defaultValue">Default value for that type, can be overriden.</param>
        /// <typeparam name="T">Type of Enum.</typeparam>
        /// <returns>Converted value.</returns>
        public static T ToEnum<T>(byte[] array, int position = 0, T defaultValue = default)
            where T : Enum
            => GetEnum<T>(ToByte(array, ref position, Convert.ToByte(defaultValue, CultureInfo.InvariantCulture)));

        /// <summary>
        /// Converts the byte array into a given Object.
        /// </summary>
        /// <param name="array">The byte array.</param>
        /// <param name="position">The position within the array. Byref : is auto-incremented by the size of the output type.</param>
        /// <param name="defaultValue">Default value for that type, can be overriden.</param>
        /// <typeparam name="T">Type of Object.</typeparam>
        /// <returns>Converted value.</returns>
        public static T ToObject<T>(byte[] array, ref int position, T defaultValue = default)
            where T : class
            => GetObject<T>(ToByte(array, ref position, Convert.ToByte(defaultValue, CultureInfo.InvariantCulture)));

        /// <summary>
        /// Converts the byte array into a given Object.
        /// </summary>
        /// <param name="array">The byte array.</param>
        /// <param name="position">The position within the array.</param>
        /// <param name="defaultValue">Default value for that type, can be overriden.</param>
        /// <typeparam name="T">Type of Object.</typeparam>
        /// <returns>Converted value.</returns>
        public static T ToObject<T>(byte[] array, int position = 0, T defaultValue = default)
            where T : class
            => GetObject<T>(ToByte(array, ref position, Convert.ToByte(defaultValue, CultureInfo.InvariantCulture)));

        /// <summary>
        /// Converts the byte array into a readable byte array string.
        /// Perfect for Debug purposes.
        /// </summary>
        /// <param name="array">The byte array.</param>
        /// <returns>Readable string representing the byte array.</returns>
        public static string ToDebugString(byte[] array) => $"[{string.Join(",", array)}]";

        private static T ToType<T>(byte[] array, ref int position, int size, Func<byte[], int, T> bitConverterFunction, T defaultValue = default)
        {
            var output = array == null || array.Length < 1 ? defaultValue : bitConverterFunction.Invoke(array, position);
            position += size;
            return output;
        }

        private static T ArrayToType<T>(byte[] array, Func<byte[], T> bitConverterFunction, T defaultValue = default) => array == null || array.Length < 1 ? defaultValue : bitConverterFunction.Invoke(array);

        private static T GetObject<T>(byte byteValue)
            where T : class =>
            Convert.ChangeType(byteValue, typeof(T), CultureInfo.InvariantCulture) as T;

        private static T GetEnum<T>(byte byteValue)
            where T : Enum
        {
            var underlyingType = Enum.GetUnderlyingType(typeof(T));
            var valueTransposedInUnderlyingType = Convert.ChangeType(byteValue, underlyingType, CultureInfo.InvariantCulture);

            if (!Enum.IsDefined(typeof(T), valueTransposedInUnderlyingType))
            {
                throw new InvalidCastException($"Value {byteValue} does not exist in {typeof(T)}");
            }

            foreach (var enumValue in Enum.GetValues(typeof(T)))
            {
                if ((byte)enumValue == byteValue)
                {
                    // ReSharper disable once PossibleInvalidCastException
                    return (T)enumValue;
                }
            }

            return default;
        }
    }
}
