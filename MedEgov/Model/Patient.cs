using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedEgov.Model
{
    public class Patient : People
    {
        public string IIN_;

        public string IIN
        {
            get
            {
                return IIN_;
            }
            set
            {
                if (value.Length != 12)
                    throw new ArgumentException("Введите корректный ИИН");

                IIN_ = value;
            }
        }
        public MedOrg medOrg { get; set; } = null;

        public override double GetDiscount()
        {
            throw new NotImplementedException();
        }

        public override void printInfo()
        {
            base.printInfo();
            Console.WriteLine(medOrg);
        }
    }
}
