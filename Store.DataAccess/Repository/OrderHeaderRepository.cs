﻿using Store.DataAccess.Data;
using Store.DataAccess.Repository.IRepository;
using Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.DataAccess.Repository
{
	public class OrderHeaderRepository : Repository<OrderHeader>, IOrderHeaderRepository
	{
		private readonly ApplicationDbContext db;

		public OrderHeaderRepository(ApplicationDbContext db) : base(db)
		{
			this.db = db;
		}

		public void Update(OrderHeader orderHeader)
		{
			db.OrderHeaders.Update(orderHeader);
		}
	}
}
