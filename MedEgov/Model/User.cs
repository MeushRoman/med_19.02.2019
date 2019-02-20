using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedEgov.Model
{
    public enum access { admin = 1, user = 0 }
    public sealed class User : Patient
    {
       
        public string login { get; set; }
        public string password { get; set; }
        public MedOrg medOrg { get; set; }
        public int access { get; set; }

        public override void printInfo()
        {
            base.printInfo();
            Console.WriteLine("login {0}", login);
        }

        public override double GetDiscount()
        {
            return 1.2;
        }

    }
}
