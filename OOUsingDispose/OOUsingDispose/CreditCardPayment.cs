using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOUsingDispose
{
    public partial class PaymentPartialClass
    {
        private DateTime _vencimentoCard;
        private DateTime _emissaoCard;
        private string _numberCard;

        public DateTime VencimentoCard
        {
            get { return _vencimentoCard; }
            set { _vencimentoCard = value; }
        }

        public DateTime EmissaoCard
        {
            get { return _emissaoCard; }
            set { _emissaoCard = value; }
        }

        public string NumberCard
        {
            get { return _numberCard; }
            set { _numberCard = value; }
        }
    }
}
