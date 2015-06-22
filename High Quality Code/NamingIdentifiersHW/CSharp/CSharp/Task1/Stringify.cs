namespace CSharp.Task1
{
    using System;
    using System.Text;

    public class Stringify
    {
        // The const is not used anywhere, so it could be removed.
        private const int MaxCount = 6;

        public static void Main()
        {
            Stringify.ToStringTransform instance =
              new Stringify.ToStringTransform();
            instance.CovertToString(true);
        }

        public class ToStringTransform
        {
            public void CovertToString(bool input)
            {
                string inputAsString = input.ToString();
                Console.WriteLine(inputAsString);
            }
        }
    }
}
