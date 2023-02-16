using dotNet_rpg.Dtos.Character;

namespace dotNet_rpg.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();

        Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);

        Task<ServiceResponse<List<AddCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);
    }
}