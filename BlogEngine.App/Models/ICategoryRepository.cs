﻿namespace BlogEngine.App.Models
{
    public interface ICategoryRepository
    {
        List<Category> GetAllCategories();
        Category? GetCategoryById(int id);
    }
}