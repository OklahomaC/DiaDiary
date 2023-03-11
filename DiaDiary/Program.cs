﻿using System.Security.Cryptography;
using DataAccess;
using Models;

namespace DiaDiary;

class Program
{
    static void Main(string[] args)
    {
        DefaultMessages.Welcome();
        UserActions.ChooseAction();
    }
}