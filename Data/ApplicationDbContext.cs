﻿using Microsoft.EntityFrameworkCore;
using Task1.Models;

namespace Task1.Data
{
	public class ApplicationDbContext:DbContext
	{
		public DbSet<Employee> Employees { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=.;database=MVC1;trusted_connection=True;TrustServerCertificate=True");
		}
	}
}
