


using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using Microsoft.AspNetCore.Mvc;

namespace _02_Luniakina.Models
{
    public class Person
    {


        public string Name
        {
            get;
            set;
        }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd'/'MM'/'yyyy}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate
        {
            get;
            set;

        }


        public string LastName { get; set; }


        public string EMail { get; set; }

        public Person()
        {
        }

        public Person(string name, string lastName, DateTime dateOfBirth, string email)
        {
            this.Name = name;
            this.BirthDate = dateOfBirth;
            this.LastName = lastName;
            this.EMail = email;
        }

        public Person(string name, string lastName, string email)
        {
            this.Name = name;
            this.LastName = lastName;
            this.EMail = email;
        }

        public Person(string name, string lastName, DateTime dateOfBirth)
        {
            this.Name = name;
            this.BirthDate = dateOfBirth;
            this.LastName = lastName;

        }

        enum ChineseSign
        {
            Rat,
            Ox,
            Tiger,
            Rabbit,
            Dragon,
            Snake,
            Horse,
            Goat,
            Monkey,
            Rooster,
            Dog,
            Pig
        }

        enum ZodiacSign
        {
            Aries,
            Taurus,
            Gemini,
            Cancer,
            Leo,
            Virgo,
            Libra,
            Scorpio,
            Sagittarius,
            Capricorn,
            Aquarius,
            Pisces
        }
        public static int CalculateAge(DateTime BirthDate)
        {

            int YearsPassed = DateTime.Now.Year - BirthDate.Year;

            if (DateTime.Now.Month < BirthDate.Month ||
                (DateTime.Now.Month == BirthDate.Month &&
                DateTime.Now.Day < BirthDate.Day))
            {
                YearsPassed--;
            }

            return YearsPassed;
        }

        public static bool IsBirthday(DateTime BirthDate)
        {
            if (BirthDate.Month == DateTime.Now.Month)
            {
                if (BirthDate.Day == DateTime.Now.Day)
                {
                    return true;
                }
            }
            return false;
        }

        public static String SunSign(DateTime BirthDate)
        {
            int month = BirthDate.Month;
            int day = BirthDate.Day;

            if (month == 12 && day >= 22 ||
                month == 1 && day <= 22)
            {
                return ZodiacSign.Capricorn.ToString();
            }

            if (month == 1 && day >= 21 ||
                month == 2 && day <= 18)
            {
                return ZodiacSign.Aquarius.ToString();
            }

            if (month == 2 && day >= 19 ||
                month == 3 && day <= 20)
            {
                return ZodiacSign.Pisces.ToString();
            }

            if (month == 3 && day >= 21 ||
                month == 4 && day <= 20)
            {
                return ZodiacSign.Aries.ToString();
            }

            if (month == 4 && day >= 21 ||
                month == 5 && day <= 20)
            {
                return ZodiacSign.Taurus.ToString();
            }

            if (month == 5 && day >= 21 ||
                month == 6 && day <= 21)
            {
                return ZodiacSign.Gemini.ToString();
            }

            if (month == 6 && day >= 22 ||
                month == 7 && day <= 22)
            {
                return ZodiacSign.Cancer.ToString();
            }

            if (month == 7 && day >= 23 ||
                month == 8 && day <= 23)
            {
                return ZodiacSign.Leo.ToString();
            }

            if (month == 8 && day >= 24 ||
                month == 9 && day <= 23)
            {
                return ZodiacSign.Virgo.ToString();
            }

            if (month == 9 && day >= 24 ||
                month == 10 && day <= 23)
            {
                return ZodiacSign.Libra.ToString();
            }

            if (month == 10 && day >= 24 ||
                month == 11 && day <= 22)
            {
                return ZodiacSign.Scorpio.ToString();
            }

            if (month == 11 && day >= 23 ||
                month == 12 && day <= 21)
            {
                return ZodiacSign.Sagittarius.ToString();
            }

            return "";
        }

        public static String ChineseZodiacSign(DateTime BirthDate)
        {

            switch (BirthDate.Year % 12)
            {
                case 0:
                    return ChineseSign.Monkey.ToString();
                    break;

                case 1:
                    return ChineseSign.Rooster.ToString();
                    break;

                case 2:
                    return ChineseSign.Dog.ToString();
                    break;

                case 3:
                    return ChineseSign.Pig.ToString();
                    break;

                case 4:
                    return ChineseSign.Rat.ToString();
                    break;

                case 5:
                    return ChineseSign.Ox.ToString();
                    break;

                case 6:
                    return ChineseSign.Tiger.ToString();
                    break;

                case 7:
                    return ChineseSign.Rabbit.ToString();
                    break;

                case 8:
                    return ChineseSign.Dragon.ToString();
                    break;

                case 9:
                    return ChineseSign.Snake.ToString();
                    break;

                case 10:
                    return ChineseSign.Horse.ToString();
                    break;

                case 11:
                    return ChineseSign.Goat.ToString();
                    break;

            }
            return "";
        }

        public static bool IsAdult(DateTime dateOfBirth)
        {
            if (CalculateAge(dateOfBirth) >= 18)
            {
                return true;
            }
            return false;
        }
    }


}