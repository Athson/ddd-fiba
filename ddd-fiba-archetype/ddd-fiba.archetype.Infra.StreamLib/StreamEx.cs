using System.Text;

namespace ddd_fiba.archetype.Infra.StreamLib
{
    public static class StreamEx
    {
        public static string OutStringContent(this Stream? stream)
        {
            if (stream == null) return string.Empty;
            using (var content = stream)
            {
                byte[] b = new byte[content.Length];
                content.Read(b, 0, b.Length);
                return Encoding.UTF8.GetString(b);
            }
        }
    }
}
