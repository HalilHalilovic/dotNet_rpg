namespace dotNet_rpg.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private static List<Character> characters = new List<Character>{
            new Character(),
            new Character {Id =1 ,Name = "Invoker"}
        };

        public async Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter)
        {
            var servicesResponse = new ServiceResponse<List<Character>>();

            characters.Add(newCharacter);
            servicesResponse.Data = characters;
            return servicesResponse;
        }

        public async Task<ServiceResponse<List<Character>>> GetAllCharacters()
        {
            var servicesResponse = new ServiceResponse<List<Character>>();
            servicesResponse.Data = characters;
            return servicesResponse;
        }

        public async Task<ServiceResponse<Character>> GetCharacterById(int id)
        {

            var servicesResponse = new ServiceResponse<Character>();
            var character = characters.FirstOrDefault(c => c.Id == id);
            servicesResponse.Data = character;
            return servicesResponse;
        }
    }
}