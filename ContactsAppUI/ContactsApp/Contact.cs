using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    public class Contact: ICloneable
    {
        private string _surname;

        public string Surname
        {
            get
            {
                return _surname;
                
            }
            set
            {
                
                if (value.Length <= 50)
                {
                    var charUP = new StringBuilder(value);
                    charUP[0] = Char.ToUpper(charUP[0]);
                    _surname = (charUP.ToString());

                }
                else
                {
                        throw new ArgumentException("превышено максимально допустимое число символов");
                }

            }
        }

        private string _name;

        public string Name
        {
            get
            {
                return _name;

            }
            set
            {
                if(value.Length <= 50)
                {
                    var charUP = new StringBuilder(value);
                    charUP[0] = Char.ToUpper(charUP[0]);
                    _name = (charUP.ToString());

                }
                else
                {
                    throw new ArgumentException("превышено максимально допустимое число символов");
                }

            }
        }

        private string _idvk;

        public string Idvk
        {
            get { return _idvk; }
            set
            {
                if (value.Length <= 15)
                {
                    _idvk = value;
                }
                else
                {
                    throw new ArgumentException("Превышено максимально допустимое количество символов");
                }
            }
        }

        private PhoneNumbers _phoneNumber;
            public PhoneNumbers PhoneNumber
            {
                get
                {
                    return _phoneNumber;

                }
                set
                {
                    _phoneNumber = (value);

                }
            }

        private DateTime _dateofbirth;

        public DateTime DateofBirht
        {
            get { return _dateofbirth; }
            set
            {
                var maxdate = DateTime.Now;
                var mindate = new DateTime(1900,1,1);
                
                if (value <= maxdate && value >=mindate )
                {
                    _dateofbirth = (value);
                }
                else
                {
                    throw new ArgumentException("Дата указана неверено");
                }
            }
            
        }

        public object Clone()
        {
            return (Contact)this.MemberwiseClone();
        }
    }
  


}

