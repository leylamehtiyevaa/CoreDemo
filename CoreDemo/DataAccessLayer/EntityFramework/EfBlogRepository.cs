﻿using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
	public class EfBlogRepository: GenericRepository<Blog>, IBlogDal
	{
		
	}
}

