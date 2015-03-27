namespace SchoolClasses
{
    using System;

    public class Disciplines : IComment
    {
        // Fields
        private string disciplineName;

        private int numOfLectures;

        private int numOfExercises;

        private string comment;
       
        // Properties
        public string DisciplineName
        {
            get 
            { 
                return this.disciplineName; 
            }

            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null!");
                }

                this.disciplineName = value; 
            }
        }

        public int NumOfLectures
        {
            get 
            { 
                return this.numOfLectures; 
            }

            set 
            {
                if (value < 2)
                {
                    throw new ArgumentException("Must have at least two lectures per week.");
                }

                this.numOfLectures = value; 
            }
        }

        public int NumOfExercises
        {
            get 
            { 
                return this.numOfExercises; 
            }

            set 
            {
                if (value > 10)
                {
                    throw new ArgumentOutOfRangeException("Too many exercices :)");
                } 

                this.numOfExercises = value; 
            }
        }

        // Property from IComment interface
        public string Comment
        {
            get
            {
                return this.comment;
            }

            private set
            {
                this.comment = value;
            }
        }
    }
}
