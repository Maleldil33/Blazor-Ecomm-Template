﻿namespace ECommBlazor1.Server.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<ServiceResponse<List<Category>>> GetCategoriesAsync();
    }
}
