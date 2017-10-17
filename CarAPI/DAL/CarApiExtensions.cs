﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using CarAPI.Models;

namespace CarAPI.DAL
{
	public static class CarApiExtensions
	{
		public static void EnsureSeedData(this CarApiContext context)
		{
			if (!context.Cars.Any() || !context.Companies.Any())
			{
				var companyId = Guid.NewGuid();
				context.Companies.Add(new Company() { Id = companyId, Name = "Kalles Grustransporter AB", Address = "Cementvägen 8, 111 11 Södertälje" });
				context.Cars.Add(new Car
				{
					Id = Guid.NewGuid(),
					CompanyId = companyId,
					VIN = "YS2R4X20005399401",
					RegNr = "ABC123"
				});
				context.Cars.Add(new Car
				{
					Id = Guid.NewGuid(),
					CompanyId = companyId,
					VIN = "VLUR4X20009093588",
					RegNr = "DEF456"
				});
				context.Cars.Add(new Car
				{
					Id = Guid.NewGuid(),
					CompanyId = companyId,
					VIN = "VLUR4X20009048066",
					RegNr = "GHI789"
				});

				companyId = Guid.NewGuid();
				context.Companies.Add(new Company() { Id = companyId, Name = "Johans Bulk AB", Address = "Balkvägen 12, 222 22 Stockholm" });
				context.Cars.Add(new Car
				{
					Id = Guid.NewGuid(),
					CompanyId = companyId,
					VIN = "YS2R4X20005388011",
					RegNr = "JKL012"
				});
				context.Cars.Add(new Car
				{
					Id = Guid.NewGuid(),
					CompanyId = companyId,
					VIN = "YS2R4X20005387949",
					RegNr = "MNO345"
				});

				companyId = Guid.NewGuid();
				context.Companies.Add(new Company() { Id = companyId, Name = "Haralds Värdetransporter AB", Address = "Budgetvägen 1, 333 33 Uppsala" });
				context.Cars.Add(new Car
				{
					Id = Guid.NewGuid(),
					CompanyId = companyId,
					VIN = "YS2R4X20005387765",
					RegNr = "PQR678"
				});
				context.Cars.Add(new Car
				{
					Id = Guid.NewGuid(),
					CompanyId = companyId,
					VIN = "YS2R4X20005387055",
					RegNr = "STU901"
				});
				context.SaveChanges();
			}
		}
	}
}