﻿using System;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using CarAPI.Utils;

namespace CarAPI.Controllers
{
	[Route("api/[controller]")]
	public class AspNetDbController : Controller
	{
		// GET api/Car
		[HttpGet]
		[EnableCors("AllowAllOrigins")]
		public string GetAspNetDb()
		{
            //return Directory.GetCurrentDirectory() + "\\App_Data\\AspNet.db";
            return Helpers.GetAspNetDbConnection();
		}
	}
}