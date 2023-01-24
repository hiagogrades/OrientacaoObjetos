using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOUsingDispose
{
    public partial class PaymentPartialClass
    {
        private string _nameClient;
        private string _cic;
        public string NameClient
        {
            get { return _nameClient; }
            set { _nameClient = value; }
        }

        public string CIC
        {
            get { return _cic; }
            set { _cic = value; }
        }
    }
}
