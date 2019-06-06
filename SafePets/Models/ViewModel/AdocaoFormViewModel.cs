using System.Collections.Generic;


namespace SafePets.Models.ViewModel
{
    public class AdocaoFormViewModel
    {
        public Adocao Adocao { get; set; }
        public ICollection<Pessoa> Pessoas { get; set; }
        public ICollection<Pet> Pets { get; set; }
    }
}
