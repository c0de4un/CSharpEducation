using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Task5
{
    public class Student
    {
        private int mAge;
        private string mFirstName;
        private string mLastName;
        private string mEMail;
        private int mUniversityCode;

        public Student(
            int age,
            string firstName,
            string lastName,
            string email,
            int universityCode
        ) {
            // No validation
            mAge = age;
            mFirstName = firstName;
            mLastName = lastName;
            mEMail = email;
            mUniversityCode = universityCode;
        }

        public Student setAge(int age)
        {
            if (age > 0) {
                mAge = age;
            }

            return this;
        }

        public int getAge() {
            return mAge;
        }

        public Student setName(string firstName, string lastName)
        {
            if (firstName.Length > 0) {
                mFirstName = firstName;
            }
            mLastName = lastName; // Can be empty

            return this;
        }

        public string getName()
        {
            return mLastName.Length > 0 ? $"{mFirstName} {mLastName}" : mFirstName;
        }

        public Student setEmail(string email)
        {
            if (email.Length > 0 && email.Contains('@')) {
                mEMail = email;
            }

            return this;
        }

        public string getEmail()
        {
            return mEMail;
        }

        public Student setUniversityCode(int universityCode)
        {
            mUniversityCode = universityCode;

            return this;
        }

        public int getUniversityCode()
        {
            return mUniversityCode;
        }

        public void IntroduceYourself()
        {
            System.Console.WriteLine($"Привет, меня зовут {getName()} 👋");
        }
    }
}