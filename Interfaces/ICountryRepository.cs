using PokemonReview.Models;

namespace PokemonReview.Interfaces
{
    public interface ICountryRepository
    {
        ICollection<Country> GetAllCountries();

        Country GetCountryById (int id);

        Country GetCountryByOwner (int ownerId);

        ICollection<Owner> GetOwnersFromCountry (int countryId);

        bool CountryExists (int id);

        bool CreateCountry(Country country);

        bool UpdateCountry (Country country);

        bool DeleteCountry (Country country);

        bool Save();
    }
}
