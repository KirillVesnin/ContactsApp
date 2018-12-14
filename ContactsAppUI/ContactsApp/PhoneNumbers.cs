using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ContactsApp
{
    public class PhoneNumbers
    {
        /// <summary>
        /// Поле содержащее номер телефона.
        /// </summary>
        private long _number;

        public PhoneNumbers(long number)
        {
            Number = number;
        }

        public long Number
        {
            get
            {
                return _number;
            }
            set
            {
                string numberPattern = @"^ ((7)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{7,10}$";
                Regex numberRegex = new Regex(numberPattern);
                if (numberRegex.IsMatch(value.ToString()))
                {
                    _number = value;
                }
                else
                {
                        throw new ArgumentException("Алярма, номера не номера");
                }
            }
        

        }
    }
}
