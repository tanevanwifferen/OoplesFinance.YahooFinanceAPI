﻿namespace OoplesFinance.YahooFinanceAPI.Models;

internal class TrendingFinance
{
    [JsonProperty("result")]
    public List<TrendingResult> Results { get; set; } = new();

    [JsonProperty("error")]
    public object Error { get; set; } = new();
}

internal class Quote
{
    [JsonProperty("symbol")]
    public string Symbol { get; set; } = string.Empty;
}

internal class TrendingResult
{
    [JsonProperty("count")]
    public int? Count { get; set; }

    [JsonProperty("quotes")]
    public List<Quote> Quotes { get; set; } = new();

    [JsonProperty("jobTimestamp")]
    public long? JobTimestamp { get; set; }

    [JsonProperty("startInterval")]
    public long? StartInterval { get; set; }
}

internal class TrendingData
{
    [JsonProperty("finance")]
    public TrendingFinance Finance { get; set; } = new();
}