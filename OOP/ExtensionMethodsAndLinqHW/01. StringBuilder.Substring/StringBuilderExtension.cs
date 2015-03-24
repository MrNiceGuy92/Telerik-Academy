namespace StringBuilderSubstring
{
    using System.Text;

    public static class StringBuilderExtension
    {
        public static StringBuilder Substring(this StringBuilder str, int index, int length)
        {
            var newStringBuilder = new StringBuilder();

            for (int i = index; i < index + length; i++)
            {
                newStringBuilder.Append(str[i]);
            }

            return newStringBuilder;
        }
    }
}
