using DomainDrivenDesign.Model.Broker;
using DomainDrivenDesign.Model.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDrivenDesign.Model.Exchange
{
    public sealed class Exchange
    {
        public TradeValueLimit MaximumLimit { get; private set; }
        public TradeValueLimit MinimumLimit { get; private set; }
        public bool EnableTrades { get; private set; } = false;
    }

    public record TradeValueLimit
    {
        private TradeValueLimit(long max, long min) => (Max, Min) = (max, min);

        public long Min { get; init; }
        public long Max { get; init; }

        public static TradeValueLimit? Create(long max, long min)
        {
            return new TradeValueLimit(max, min);
        }
    }
}
