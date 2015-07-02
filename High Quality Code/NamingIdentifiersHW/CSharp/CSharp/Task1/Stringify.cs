namespace CSharp.Task1
{
    using System;
    using System.Text;

    public class Stringify
    {
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
