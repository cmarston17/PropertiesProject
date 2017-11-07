using System;
namespace PropertiesProject
{
    public class Student
    {
        public string Name { get; private set; }
        public bool Male { get; private set; }
        public bool FullAged { get; private set; }
        private int age;

        /// <summary>
        /// C# creates  get and set methods for us keeping the int age field priate and unmodifiable 
        ///  and safe above. the field is lowercase and private where the below method is capitalized
        /// </summary>
        /// <value>The age.</value>
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
                // updating whether student is of age
                FullAged = true;
                if (age < 18)
                    FullAged = false;
            }
        }
        public Student(string name, bool gender, int age)
        {
            EditStudent(name, gender, age); 
        }

            public void EditStudent(string name, bool gender, int age)
            {
            Name = name;
            Male = gender;
            Age = age;
            }

        public override string ToString()
        {
            string iAmFullAged = "I'm";
            if (!FullAged)
                iAmFullAged = "I'm not";
            string gender = "male";
            if (!Male)
                gender = "female";
            return String.Format("I'm {0}, {1}. I'm {2} years old and {3} of age.", Name, gender, Age, iAmFullAged);
        }


    
        
       
    }
}
