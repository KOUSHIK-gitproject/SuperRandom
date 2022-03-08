using System;

namespace SuperRandom
{

        public class PersonalDetail
        {
            private string _firstname;
            private string _lastname;
            private string _Email;
            private long _PhoneNumber;
            public string FirstName
            {
                get { return _firstname; }
                set { _firstname = value; }
            }
            public string LastName
            {
                get { return _lastname; }
                set { _lastname = value; }
            }
            public string Email
            {
                get { return _Email; }
                set { _Email = value; }
            }
            public long PhoneNumber
            {
                get { return _PhoneNumber; }
                set { _PhoneNumber = value; }
            }
        }
}
