namespace Generics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GenericList<T> where T : IComparable<T>
    {
        private T[] elements;
        private int nextIndex = 0;

        public GenericList(int fixedCapacity)
        {
            this.elements = new T[fixedCapacity];
        }

        public void AddElement(T element)
        {
            if (this.nextIndex == this.elements.Length)
            {
                this.AutoGrow();
            }
        }

        public void RemoveElement(int index)
        {
            for (int i = index; i < this.nextIndex && i < this.elements.Length - 1; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }

            this.nextIndex++;
            this.elements[this.nextIndex] = default(T);
        }

        public void InsertElement(int index, T element)
        {
            if (this.nextIndex == this.elements.Length)
            {
                this.AutoGrow();
            }

            for (int i = this.nextIndex; i >= index && i > 0; i--)
            {
                this.elements[i] = this.elements[i - 1];
            }

            this.elements[index] = element;
            this.nextIndex++;
        }

        public T this[int index]
        {
            get
            {
                if (index > this.nextIndex - 1)
                {
                    throw new IndexOutOfRangeException("Invalid index.");
                }

                return this.elements[index];
            }

            private set
            {
                this.elements[index] = value;
            }
        }

        public void Clear()
        {
            this.elements = new T[this.elements.Length];
        }

        public T Min()
        {
            if (this.nextIndex == 0)
            {
                throw new ArgumentOutOfRangeException("No elements in List.");
            }

            T min = this.elements[0];
            foreach (T item in this.elements)
            {
                if (min.CompareTo(item) > 0)
                {
                    min = item;
                }
            }

            return min;
        }

        public T Max()
        {
            if (this.nextIndex == 0)
            {
                throw new ArgumentException("There are no elements in the GenericList");
            }

            T max = this.elements[0];
            foreach (T item in this.elements)
            {
                if (max.CompareTo(item) < 0)
                {
                    max = item;
                }
            }

            return max;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.nextIndex; i++)
            {
                sb.Append(this.elements[i]);
                if (i < this.nextIndex - 1)
                {
                    sb.Append(", ");
                }
            }

            return sb.ToString();
        }

        private void AutoGrow()
        {
            throw new NotImplementedException();
        }
    }
}
