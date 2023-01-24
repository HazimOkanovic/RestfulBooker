using System;
using System.Linq;

namespace RestfulBooker
{
    public class Constants
    {
        public const string OkStatus = "OK";
        public const string ValidUsername = "admin";
        public const string ValidPassword = "password123";
        public const string BadCredentials = "Bad credentials";
        public const string WrongUsername = "admin123";
        public const string WrongPassword = "password";
        private static Random Random = new Random();
        public const string Nothing = "nothing";
        public const string Breakfast = "breakfast";
        public const string MyName = "Hazim";
        public const string MySurname = "Okanovic";
        public const string SleepingBag = "Sleeping Bag";
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[Random.Next(s.Length)]).ToArray());
        }

        public static readonly string FirstName = RandomString(6);
        public static readonly string LastName = RandomString(8);
    }
}