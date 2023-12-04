﻿using ChimoneyDotNet;
using ChimoneyDotNet.Models;

var wrapperBase = new Chimoney("d3cd6f0247c5f4f7b398def389138b132a05e6443884f56b2fae3ed21e4ea47c");

var response = await wrapperBase.Simulate("random_id", Status.Failed);


Console.WriteLine(response.Status);
Console.WriteLine(response.Error);
Console.WriteLine(response.Message);