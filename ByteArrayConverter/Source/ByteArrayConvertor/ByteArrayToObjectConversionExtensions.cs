// ReSharper disable UnusedMember.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedType.Global
namespace ByteArrayConverter
{
    using System;

    /// <summary>
    /// Classes extensions to convert from byte array.
    /// </summary>
    public static class ByteArrayToObjectConversionExtensions
    {
        /// <inheritdoc cref="ByteArrayToObjectConversionHelper.ToBoolean(byte[],ref int,bool)" />
        public static bool ToBoolean(this byte[] array, ref int position, bool defaultValue = default) => ByteArrayToObjectConversionHelper.ToBoolean(array, ref position, defaultValue);

        /// <inheritdoc cref="ByteArrayToObjectConversionHelper.ToBoolean(byte[],int,bool)" />
        public static bool ToBoolean(this byte[] array, int position = 0, bool defaultValue = default) => ByteArrayToObjectConversionHelper.ToBoolean(array, ref position, defaultValue);

        /// <inheritdoc cref="ByteArrayToObjectConversionHelper.ToSByte(byte[],ref int,sbyte)" />
        public static sbyte ToSByte(this byte[] array, ref int position, sbyte defaultValue = default) => ByteArrayToObjectConversionHelper.ToSByte(array, ref position, defaultValue);

        /// <inheritdoc cref="ByteArrayToObjectConversionHelper.ToSByte(byte[],int,sbyte)" />
        public static sbyte ToSByte(this byte[] array, int position = 0, sbyte defaultValue = default) => ByteArrayToObjectConversionHelper.ToSByte(array, ref position, defaultValue);

        /// <inheritdoc cref="ByteArrayToObjectConversionHelper.ToByte(byte[],ref int,byte)" />
        public static byte ToByte(this byte[] array, ref int position, byte defaultValue = default) => ByteArrayToObjectConversionHelper.ToByte(array, ref position, defaultValue);

        /// <inheritdoc cref="ByteArrayToObjectConversionHelper.ToByte(byte[],int,byte)" />
        public static byte ToByte(this byte[] array, int position = 0, byte defaultValue = default) => ByteArrayToObjectConversionHelper.ToByte(array, ref position, defaultValue);

        /// <inheritdoc cref="ByteArrayToObjectConversionHelper.ToInt16(byte[],ref int,short)" />
        public static short ToInt16(this byte[] array, ref int position, short defaultValue = default) => ByteArrayToObjectConversionHelper.ToInt16(array, ref position, defaultValue);

        /// <inheritdoc cref="ByteArrayToObjectConversionHelper.ToInt16(byte[],int,short)" />
        public static short ToInt16(this byte[] array, int position = 0, short defaultValue = default) => ByteArrayToObjectConversionHelper.ToInt16(array, ref position, defaultValue);

        /// <inheritdoc cref="ByteArrayToObjectConversionHelper.ToUInt16(byte[],ref int,ushort)" />
        public static ushort ToUInt16(this byte[] array, ref int position, ushort defaultValue = default) => ByteArrayToObjectConversionHelper.ToUInt16(array, ref position, defaultValue);

        /// <inheritdoc cref="ByteArrayToObjectConversionHelper.ToUInt16(byte[],int,ushort)" />
        public static ushort ToUInt16(this byte[] array, int position = 0, ushort defaultValue = default) => ByteArrayToObjectConversionHelper.ToUInt16(array, ref position, defaultValue);

        /// <inheritdoc cref="ByteArrayToObjectConversionHelper.ToInt32(byte[],ref int,int)" />
        public static int ToInt32(this byte[] array, ref int position, int defaultValue = default) => ByteArrayToObjectConversionHelper.ToInt32(array, ref position, defaultValue);

        /// <inheritdoc cref="ByteArrayToObjectConversionHelper.ToInt32(byte[],int,int)" />
        public static int ToInt32(this byte[] array, int position = 0, int defaultValue = default) => ByteArrayToObjectConversionHelper.ToInt32(array, ref position, defaultValue);

        /// <inheritdoc cref="ByteArrayToObjectConversionHelper.ToUInt32(byte[],ref int,uint)" />
        public static uint ToUInt32(this byte[] array, ref int position, uint defaultValue = default) => ByteArrayToObjectConversionHelper.ToUInt32(array, ref position, defaultValue);

        /// <inheritdoc cref="ByteArrayToObjectConversionHelper.ToUInt32(byte[],int,uint)" />
        public static uint ToUInt32(this byte[] array, int position = 0, uint defaultValue = default) => ByteArrayToObjectConversionHelper.ToUInt32(array, ref position, defaultValue);

        /// <inheritdoc cref="ByteArrayToObjectConversionHelper.ToInt64(byte[],ref int,long)" />
        public static long ToInt64(this byte[] array, ref int position, long defaultValue = default) => ByteArrayToObjectConversionHelper.ToInt64(array, ref position, defaultValue);

        /// <inheritdoc cref="ByteArrayToObjectConversionHelper.ToInt64(byte[],int,long)" />
        public static long ToInt64(this byte[] array, int position = 0, long defaultValue = default) => ByteArrayToObjectConversionHelper.ToInt64(array, ref position, defaultValue);

        /// <inheritdoc cref="ByteArrayToObjectConversionHelper.ToUInt64(byte[],ref int,ulong)" />
        public static ulong ToUInt64(this byte[] array, ref int position, ulong defaultValue = default) => ByteArrayToObjectConversionHelper.ToUInt64(array, ref position, defaultValue);

        /// <inheritdoc cref="ByteArrayToObjectConversionHelper.ToUInt64(byte[],int,ulong)" />
        public static ulong ToUInt64(this byte[] array, int position = 0, ulong defaultValue = default) => ByteArrayToObjectConversionHelper.ToUInt64(array, ref position, defaultValue);

        /// <inheritdoc cref="ByteArrayToObjectConversionHelper.ToDouble(byte[],ref int,double)" />
        public static double ToDouble(this byte[] array, ref int position, double defaultValue = default) => ByteArrayToObjectConversionHelper.ToDouble(array, ref position, defaultValue);

        /// <inheritdoc cref="ByteArrayToObjectConversionHelper.ToDouble(byte[],int,double)" />
        public static double ToDouble(this byte[] array, int position = 0, double defaultValue = default) => ByteArrayToObjectConversionHelper.ToDouble(array, ref position, defaultValue);

        /// <inheritdoc cref="ByteArrayToObjectConversionHelper.ToSingle(byte[],ref int,float)" />
        public static float ToSingle(this byte[] array, ref int position, float defaultValue = default) => ByteArrayToObjectConversionHelper.ToSingle(array, ref position, defaultValue);

        /// <inheritdoc cref="ByteArrayToObjectConversionHelper.ToSingle(byte[],int,float)" />
        public static float ToSingle(this byte[] array, int position = 0, float defaultValue = default) => ByteArrayToObjectConversionHelper.ToSingle(array, ref position, defaultValue);

        /// <inheritdoc cref="ByteArrayToObjectConversionHelper.ToChar(byte[],ref int,char)" />
        public static char ToChar(this byte[] array, ref int position, char defaultValue = default) => ByteArrayToObjectConversionHelper.ToChar(array, ref position, defaultValue);

        /// <inheritdoc cref="ByteArrayToObjectConversionHelper.ToChar(byte[],int,char)" />
        public static char ToChar(this byte[] array, int position = 0, char defaultValue = default) => ByteArrayToObjectConversionHelper.ToChar(array, ref position, defaultValue);

        /// <inheritdoc cref="ByteArrayToObjectConversionHelper.ToUtf8String(byte[],string)" />
        public static string ToUtf8String(this byte[] array, string defaultValue = default) => ByteArrayToObjectConversionHelper.ToUtf8String(array, defaultValue);

        /// <inheritdoc cref="ByteArrayToObjectConversionHelper.ToVersion(byte[],Version)" />
        public static Version ToVersion(this byte[] array, Version defaultValue = default) => ByteArrayToObjectConversionHelper.ToVersion(array, defaultValue);

        /// <inheritdoc cref="ByteArrayToObjectConversionHelper.ToEnum{T}(byte[],ref int,T)" />
        public static T ToEnum<T>(this byte[] array, ref int position, T defaultValue = default)
            where T : Enum
            => ByteArrayToObjectConversionHelper.ToEnum(array, ref position, defaultValue);

        /// <inheritdoc cref="ByteArrayToObjectConversionHelper.ToEnum{T}(byte[],int,T)" />
        public static T ToEnum<T>(this byte[] array, int position = 0, T defaultValue = default)
            where T : Enum
            => ByteArrayToObjectConversionHelper.ToEnum(array, ref position, defaultValue);

        /// <inheritdoc cref="ByteArrayToObjectConversionHelper.ToObject{T}(byte[],ref int,T)" />
        public static T ToObject<T>(this byte[] array, ref int position, T defaultValue = default)
            where T : class
            => ByteArrayToObjectConversionHelper.ToObject(array, ref position, defaultValue);

        /// <inheritdoc cref="ByteArrayToObjectConversionHelper.ToObject{T}(byte[],int,T)" />
        public static T ToObject<T>(this byte[] array, int position = 0, T defaultValue = default)
            where T : class
            => ByteArrayToObjectConversionHelper.ToObject(array, ref position, defaultValue);

        /// <summary>
        /// Converts the byte array into a readable byte array string.
        /// Perfect for Debug purposes.
        /// </summary>
        /// <param name="array">The byte array.</param>
        /// <returns>Readable string representing the byte array.</returns>
        public static string ToDebugString(this byte[] array) => $"[{string.Join(",", array)}]";
    }
}
