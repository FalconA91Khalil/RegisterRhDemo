using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business;
using Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace RegisterRhUI.Areas.App.Controllers
{
    public class AppBaseController : Controller
    {
		private readonly UserManager<ApplicationUser> _userManager;

		public AppBaseController(UserManager<ApplicationUser> userManager)
		{
			_userManager = userManager;
		}

		[HttpGet]
		public async Task<string> GetCurrentUserId()
		{
			ApplicationUser usr = await GetCurrentUserAsync();
			return usr?.Id;
		}
		[HttpGet]
		public async Task<string> GetCurrentUserName()
		{
			ApplicationUser usr = await GetCurrentUserAsync();
			return usr?.UserName;
		}
		private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

    }
}
