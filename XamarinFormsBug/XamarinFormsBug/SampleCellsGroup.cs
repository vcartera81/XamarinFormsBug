using System;
using System.Collections.Generic;

namespace XamarinFormsBug
{
    public class SampleCellsGroup : List<SampleCellModel>
    {
        public SampleCellsGroup(IEnumerable<SampleCellModel> collection) : base(collection)
        {
        }

        public DateTime Date { get; set; }

        public double DayBalance { get; set; }

        public string DayBalanceCurrency { get; } = "CHF";

        public string DayBalanceFormatted => $"{DayBalance:F2} {DayBalanceCurrency}";
    }
}
