﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ETradeApiV1.Client.Dtos
{
    public class QuoteDto
    {public QuoteResponse QuoteResponse { get; set; }
    }

    public class All
    {
        public bool adjustedFlag { get; set; }
        public double annualDividend { get; set; }
        public double ask { get; set; }
        public string askExchange { get; set; }
        public int askSize { get; set; }
        public string askTime { get; set; }
        public double bid { get; set; }
        public string bidExchange { get; set; }
        public int bidSize { get; set; }
        public string bidTime { get; set; }
        public double changeClose { get; set; }
        public double changeClosePercentage { get; set; }
        public string companyName { get; set; }
        public int daysToExpiration { get; set; }
        public string dirLast { get; set; }
        public double dividend { get; set; }
        public double eps { get; set; }
        public double estEarnings { get; set; }
        public int exDividendDate { get; set; }
        public string exchgLastTrade { get; set; }
        public string fsi { get; set; }
        public double high { get; set; }
        public double high52 { get; set; }
        public double highAsk { get; set; }
        public double highBid { get; set; }
        public double lastTrade { get; set; }
        public double low { get; set; }
        public double low52 { get; set; }
        public double lowAsk { get; set; }
        public double lowBid { get; set; }
        public int numberOfTrades { get; set; }
        public double open { get; set; }
        public int openInterest { get; set; }
        public string optionStyle { get; set; }
        public double previousClose { get; set; }
        public int previousDayVolume { get; set; }
        public string primaryExchange { get; set; }
        public string symbolDescription { get; set; }
        public double todayClose { get; set; }
        public int totalVolume { get; set; }
        public int upc { get; set; }
        public int volume10Day { get; set; }
        public int cashDeliverable { get; set; }
        public double marketCap { get; set; }
        public int sharesOutstanding { get; set; }
        public string nextEarningDate { get; set; }
        public double beta { get; set; }
        public double yield { get; set; }
        public double declaredDividend { get; set; }
        public int dividendPayableDate { get; set; }
        public double pe { get; set; }
        public int marketCloseBidSize { get; set; }
        public int marketCloseAskSize { get; set; }
        public int marketCloseVolume { get; set; }
        public int week52LowDate { get; set; }
        public int week52HiDate { get; set; }
        public double intrinsicValue { get; set; }
        public double timePremium { get; set; }
        public double optionMultiplier { get; set; }
        public double contractSize { get; set; }
        public int expirationDate { get; set; }
        public int timeOfLastTrade { get; set; }
        public int averageVolume { get; set; }
    }

    public class Product
    {
        public string symbol { get; set; }
        public string securityType { get; set; }
    }

    public class QuoteData
    {
        public string dateTime { get; set; }
        public int dateTimeUTC { get; set; }
        public string quoteStatus { get; set; }
        public string ahFlag { get; set; }
        public All All { get; set; }
        public Product Product { get; set; }
    }

    public class QuoteResponse
    {
        public List<QuoteData> QuoteData { get; set; }
    }


}
