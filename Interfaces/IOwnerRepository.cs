using PokemonReview.Models;

namespace PokemonReview.Interfaces
{
    public interface IOwnerRepository
    {
        ICollection<Owner> GetAllOwner();

        Owner GetOwnerById(int ownerId);

        ICollection<Owner> GetOwnerOfAPokemon (int pokemonId);

        ICollection<Pokemon> GetPokemonByOwner(int ownerId);

        bool OwnerExists(int ownerId);

        bool CreateOwner(Owner owner);

        bool UpdatedOwner (Owner owner);

        bool DeleteOwner(Owner owner);

        bool Save();
    }
}
