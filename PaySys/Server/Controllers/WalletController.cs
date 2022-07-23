﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PaySys.Server.Models;
using PaySys.Server.Data;
using System;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using PaySys.Client.Shared;

namespace PaySys.Server.Controllers
{
    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class WalletController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<ApplicationUser> userManager;
        public WalletController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            this.context = context;
            this.userManager = userManager;
        }

        [HttpGet]
        public List<Wallet> GetWallets()
        {
            var userId = userManager.GetUserId(User);
            var wallets = context.Users.Include(x => x.Wallets).FirstOrDefault(x => x.Id == userId).Wallets;
            return wallets;
        }

        [HttpGet]
        [Route("{id}")]
        public Wallet GetWallet(Guid id)
        {
            var userId = userManager.GetUserId(User);
            var wallet = context.Users.Include(x => x.Wallets).FirstOrDefault(x => x.Id == userId).Wallets.FirstOrDefault(x => x.Id == id);
            return wallet;
        }

        [HttpPost]
        [Route("transfer")]
        public ActionResult MakeTransfer([FromBody] TransferDto data)
        {
            var userId = userManager.GetUserId(User);
            var user = context.Users.Include(x => x.Wallets).FirstOrDefault(x => x.Id == userId);

            if (!user.Wallets.Any(x => x.Id == Guid.Parse(data.SourceWalletId)))
            {
                return BadRequest();
            }
            var source = user.Wallets.FirstOrDefault(x => x.Id == Guid.Parse(data.SourceWalletId));
            var destinationUser = context.Users.Include(x => x.Wallets).FirstOrDefault(x => x.UserName == data.Username);
            var destination = destinationUser.Wallets.FirstOrDefault(x => x.Currency == data.Currency);

            if(destination == null || source.Amount < data.Amount)
            {
                return BadRequest();
            }

            source.Amount -= data.Amount;
            destination.Amount += data.Amount;

            var transaction = new Transaction
            {
                Amount = data.Amount,
                Date = DateTime.Now,
                DestinationWalletId = destination.Id,
                SourceWalletId = source.Id
            };

            context.Add(transaction);
            context.SaveChanges();

            return Ok();
        }


        [HttpPost]
        public IActionResult CreateWallet([FromQuery]string currency)
        {
            var userId = userManager.GetUserId(User);

            var wallet = new Wallet 
            { 
                Currency = currency,
                Amount = 0
            };

            var user = context.Users.FirstOrDefault(x => x.Id == userId);

            if (user.Wallets == null)
            {
                user.Wallets = new List<Wallet> ();
            }
            
            user.Wallets.Add(wallet);   

            context.SaveChanges();

            return Ok();
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteWallet([FromRoute] Guid id)
        {
            var userId = userManager.GetUserId(User);
            var user = context.Users.Include(x => x.Wallets).FirstOrDefault(x => x.Id == userId);

            if (!user.Wallets.Any(x => x.Id == id))
            {
                return BadRequest();
            }

            var wallet = context.Wallets.Find(id);
            context.Wallets.Remove(wallet);
            context.SaveChanges();

            return Ok();
        }
    }
}