using System;
using System.Linq;
using System.Collections.Generic;
	
namespace MVC5Course.Models
{   
	public  class vwClientOrderRepository : EFRepository<vwClientOrder>, IvwClientOrderRepository
	{

	}

	public  interface IvwClientOrderRepository : IRepository<vwClientOrder>
	{

	}
}