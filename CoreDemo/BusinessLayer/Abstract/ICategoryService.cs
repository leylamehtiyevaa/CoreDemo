﻿using System;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
	public interface ICategoryService
	{
		void CategoryAdd(Category category);
        void CategoryDelete(Category category);
        void CategoryUpdate(Category category);

        List<Category> GetAllList();
        Category GetById(int id);

    }
}

