namespace _64BitArray
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class BitArray64 : IEnumerable<int>
    {
        private ulong someNum;

        public BitArray64(ulong someNum)
        {
            this.SomeNum = someNum;
        }

        public ulong SomeNum
        {
            get
            {
                return this.someNum;
            }

            set
            {
                if (value < 0 || value > ulong.MaxValue)
                {
                    throw new ArgumentOutOfRangeException("Invalid number.");
                }
            }
        }

        public int[] BitArray
        {
            get { return this.Convert(this.SomeNum); }
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= BitArray.Count())
                {
                    throw new IndexOutOfRangeException("No such index!");
                }

                return BitArray[index];
            }
        }

        // Implementing IEnumerable<int> interface
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this.BitArray.Length; i++)
            {
                yield return this.BitArray[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override bool Equals(object obj)
        {
            if (obj is BitArray64)
            {
                for (int i = 0; i < this.BitArray.Length; i++)
                {
                    if (this.BitArray[i] != (obj as BitArray64).BitArray[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            if (obj is string)
            {
                var padded = (obj as string).PadLeft(64, '0');

                for (int i = 0; i < padded.Length; i++)
                {
                    if (int.Parse(padded[i].ToString()) != this.BitArray[i])
                    {
                        return false;
                    }
                }

                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return this.SomeNum.GetHashCode() ^ 123 ^
               this.BitArray[5].GetHashCode() ^
               this.BitArray[25].GetHashCode();
        }

        private int[] Convert(ulong p)
        {
            int[] result = new int[64];
            int counter = 63;

            do
            {
                result[counter] = (int)p % 2;
                p /= 2;
                counter--;
            } while (p > 0);

            if (counter > 0)
            {
                for (int i = counter; i >= 0; i--)
                {
                    result[i] = 0;
                }
            }

            return result;
        }

        public static bool operator ==(BitArray64 first, BitArray64 second)
        {
            return first.Equals(second);
        }

        public static bool operator !=(BitArray64 first, BitArray64 second)
        {
            return !first.Equals(second);
        }

    }
}
