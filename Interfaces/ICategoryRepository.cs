using PokemonReview.Models;

namespace PokemonReview.Interfaces
{
    public interface ICategoryRepository
    {
        ICollection<Category> GetAllCategories();

        Category GetCategoryById (int id);

        ICollection<Pokemon> GetPokemonByCategory (int categoryId);

        bool CategoriesExists (int id);

        bool CreateCategory(Category category);

        bool UpdateCategory(Category category);

        bool DeleteCategory(Category category);

        bool Save();
    }
}
