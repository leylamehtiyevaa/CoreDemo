using System;
using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        
        EfCategoryRepository efCategoryRepository;

        public CategoryManager()
        {
            efCategoryRepository = new EfCategoryRepository();
        }

        public void CategoryAdd(Category category)
        {
            efCategoryRepository.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            efCategoryRepository.Delete(category); 
        }

        public List<Category> GetAllList()
        {
            return efCategoryRepository.GetListAll();
        }

        public Category GetById(int id)
        {
            return efCategoryRepository.GetByID(id);
        }

        public void CategoryUpdate(Category category)
        {
            efCategoryRepository.Update(category);
        }
    }
}

