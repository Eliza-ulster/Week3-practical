using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Member
    {
        private int memberId;
        private string name;
        private string address;
        private int phone;

        // Public properties
        public int MemberId
        {
            get { return memberId; }
            private set { memberId = value; } // private setter make it read-only


        }
        public string Name
        {
            get { return name; }
            set { name = value; }

        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public int Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        // Constructor for new menber
        public Member(int memberId ,string name, string address , int phone )
        {
            this.memberId = memberId;
            this.name = name;
            this.address = address;
            this.phone = phone;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Member id:{memberId}");
            Console.WriteLine($"Name : {name}");
            Console.WriteLine($"Address:{address}");
            Console.WriteLine($"Phone Number:{phone}");
            Console.WriteLine();

        }

    }
}

