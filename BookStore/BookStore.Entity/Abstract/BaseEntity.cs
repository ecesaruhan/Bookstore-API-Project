﻿using System;
namespace BookStore.Entity.Abstract
{
	public abstract class BaseEntity
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public DateTime CreatedDate { get; set; } = DateTime.Now;

        public DateTime ModifiedDate { get; set; } = DateTime.Now;

		public bool IsActive { get; set; } = true;

		public bool IsDeleted { get; set; }

		public string Url { get; set; }

	}
}

