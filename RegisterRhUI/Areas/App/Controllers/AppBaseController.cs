using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace RegisterRhUI.Areas.App.Controllers
{
	[Area("App")]
	public class AppBaseController : Controller
    {

		private readonly UserManager<IdentityUser> _userManager;

		public AppBaseController(UserManager<IdentityUser> userManager)
		{
			_userManager = userManager;
		}

		[HttpGet]
		public async Task<string> GetCurrentUserId()
		{
			IdentityUser usr = await GetCurrentUserAsync();
			return usr?.Id;
		}
		[HttpGet]
		public async Task<string> GetCurrentUserName()
		{
			IdentityUser usr = await GetCurrentUserAsync();
			return usr?.UserName;
		}
		private Task<IdentityUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

    }
}
