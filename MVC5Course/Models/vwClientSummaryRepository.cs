using System;
using System.Linq;
using System.Collections.Generic;
	
namespace MVC5Course.Models
{   
	public  class vwClientSummaryRepository : EFRepository<vwClientSummary>, IvwClientSummaryRepository
	{

	}

	public  interface IvwClientSummaryRepository : IRepository<vwClientSummary>
	{

	}
}