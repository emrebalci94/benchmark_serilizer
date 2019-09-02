using System;
using System.Globalization;
using MessagePack;
using MessagePack.Formatters;
using MessagePack.Resolvers;

namespace benchmark_serilizer.Extension
{
    public class DurableDateTimeFormatter : IMessagePackFormatter<DateTime>
    {
        public DateTime Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
        {
            if (MessagePackBinary.GetMessagePackType(bytes, offset) == MessagePackType.String)
            {
                var str = MessagePackBinary.ReadString(bytes, offset, out readSize);
                return DateTime.Parse(str, CultureInfo.CurrentCulture);
            }
            else
            {
                return new DateTime(MessagePackBinary.ReadDateTime(bytes, offset, out readSize).ToLocalTime().Ticks);
            }
        }

        public int Serialize(ref byte[] bytes, int offset, DateTime value, IFormatterResolver formatterResolver)
        {

            return MessagePackBinary.WriteDateTime(ref bytes, offset, value);
        }
    }

    public static class MsgPackExtension
    {
        static MsgPackExtension()
        {
            CompositeResolver.RegisterAndSetAsDefault(
 new[] { new DurableDateTimeFormatter() },
 new[] { StandardResolver.Instance });
        }
        public static byte[] ToMsgPackSerialize(this object value)
        {
            // CompositeResolver.RegisterAndSetAsDefault(StandardResolver.Instance);

            return MessagePackSerializer.Serialize(value);
        }

        public static TObject ToMsgPackDeserialize<TObject>(this byte[] value)
        {

            return MessagePackSerializer.Deserialize<TObject>(value);
        }
    }
}