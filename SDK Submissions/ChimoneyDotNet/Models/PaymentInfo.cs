﻿
namespace ChimoneyDotNet.Models;

public class PaymentInfo
{
    public decimal ValueInUSD { get; set; }
    public decimal Chimoney { get; set; }
    public string IssueID { get; set; }
    public decimal Fee { get; set; }
    public string Type { get; set; }
    public string Issuer { get; set; }
    public string ChiRef { get; set; }
    public Dictionary<string, string> Integration { get; set; }
    public string IssueDate { get; set; }
    public string PayerEmail { get; set; }
    public string Redirect_Url { get; set; }
    public Dictionary<string, string> RedeemData { get; set; }
    public string InitiatedBy { get; set; }
    public string Status { get; set; }
    public string PaymentRef { get; set; }
    public string PaymentLink { get; set; }
    public string Error { get; set; }
    //TODO figure out that data field
    public IEnumerable<Dictionary<string,string>> Data { get; set; }

    //TODO: Add CryptoPayment
    //public class CryptoPayment
    //{
    //    public Dictionary<string,string> Xrpl { get; set; }
    //    public Ditcionary<string,string> Eth { get; set; }
    //    public Dictionary<string,string> Bsc { get; set; }

    //}

}
