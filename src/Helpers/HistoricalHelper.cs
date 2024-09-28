﻿
namespace OoplesFinance.YahooFinanceAPI.Helpers;

internal class HistoricalHelper : YahooJsonBase
{
    /// <summary>
    /// Parses the raw json data for the Financial Data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="jsonData"></param>
    /// <returns></returns>
    internal override IEnumerable<T> ParseYahooJsonData<T>(string jsonData)
    {
        var historicalData = JsonConvert.DeserializeObject<HistoricalDataRoot>(jsonData);

        return historicalData != null ? (IEnumerable<T>)historicalData.Chart.Result.Select(x => x.Indicators.Quote) : [];
    }
}