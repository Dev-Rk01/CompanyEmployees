﻿using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
	public interface ICompanyRepository 
	{
		IEnumerable<Company> GetAllCompanies(bool trackChanges);
	}
}
