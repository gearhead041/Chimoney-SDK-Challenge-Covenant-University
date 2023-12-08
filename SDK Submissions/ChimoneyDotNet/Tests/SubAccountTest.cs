﻿using ChimoneyDotNet.Models.SubAccount;
using System.Globalization;

namespace ChimonyDotNet.Test;

[Collection("Sequential")]
public class SubAccountTest
{
    private readonly IChimoneyBase chimoney = new
Chimoney("88cd4465f56b3132c385303ca1fd4950c6896eee96304f4dd46513aebff5bcde");
    //TODO : Replace with your API key from ENV or config file
    private readonly string success = "success";

    [Fact]
    public async Task Create_SubAccount_Returns_Success()
    {
        var result = await chimoney.CreateSubAccount(new CreateSubAccountRequest()
        {
            Name = "Miracle Jones",
            Email = Random.Shared.Next(2237, 343432423).ToString() + "user@email.com",
            FirstName = "Miracle",
            LastName = "Jones",
            PhoneNumber = "+2348123456789"
        });
        var tempAccountId = result.Data.Id!;
        Assert.Equal(success, result.Status);
        await chimoney.DeleteSubAccount(tempAccountId);
    }

    [Fact]
    public async Task UpdateSubAccount_Returns_Sucess()
    {
        var acoount = await chimoney.CreateSubAccount(new CreateSubAccountRequest()
        {
            Name = "Miracle Jones",
            Email = Random.Shared.Next(2237, 343432423).ToString() + "user@email.com",
            FirstName = "Miracle",
            LastName = "Jones",
            PhoneNumber = "+2348123456789"
        });
        var tempAccountId = acoount.Data.Id!;

        var result = await chimoney.UpdateSubAccount(new UpdateSubAccount()
        {
            Id = tempAccountId,
            FirstName = Random.Shared.Next(22343243, 343432423).ToString(),
            LastName = Random.Shared.Next(22343243, 343432423).ToString(),
            PhoneNumber = "+2348123456789",
            Meta = new Dictionary<string, object>()
            {
                { "test", "test" }
            }
        });

        Assert.Equal(success, result.Status);
        await chimoney.DeleteSubAccount(tempAccountId);
    }

    [Fact]
    public async Task DeleteSubAccount_Returns_Success()
    {
        var result = await chimoney.CreateSubAccount(new CreateSubAccountRequest()
        {
            Name = "Miracle Jones",
            Email = Random.Shared.Next(2237, 343432423).ToString() + "user@email.com",
            FirstName = "Miracle",
            LastName = "Jones",
            PhoneNumber = "+2348123456789"
        });
        var tempAccountId = result.Data.Id!;
        //wait for 1/2 second
        await Task.Delay(500);

        var resultTest = await chimoney.DeleteSubAccount(tempAccountId);
        Assert.Equal(success, resultTest.Status);
    }

    [Fact]
    public async Task GetSubAccount_Returns_Success()
    {
        var account = await chimoney.CreateSubAccount(new CreateSubAccountRequest()
        {
            Name = "Miracle Jones",
            Email = Random.Shared.Next(2237, 343432423).ToString() + "user@email.com",
            FirstName = "Miracle",
            LastName = "Jones",
            PhoneNumber = "+2348123456789"
        });
        var tempAccountId = account.Data.Id!;
        var result = await chimoney.GetSubAccount(tempAccountId);
        Assert.Equal(success, result.Status);
        await chimoney.DeleteSubAccount(tempAccountId);
    }

    [Fact]
    public async Task GetAllAccount_Returns_Sucess()
    {
        var result = await chimoney.GetAllSubAccounts();
        Assert.Equal(success, result.Status);
    }
}