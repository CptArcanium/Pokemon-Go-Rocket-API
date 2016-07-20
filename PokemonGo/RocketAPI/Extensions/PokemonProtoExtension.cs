using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PokemonGo.RocketAPI.GeneratedCode.InventoryResponse.Types;

namespace PokemonGo.RocketAPI.Extensions
{
    public static class PokemonProtoExtensions
    {
        public static double GetPowerQuotient(this PokemonProto pokemon)
        {
            // PowerQuotient %
            double powerQuotient = Math.Round(((double)pokemon.IndividualAttack + (double)pokemon.IndividualDefense + (double)pokemon.IndividualStamina)/45*100, 2);
            return powerQuotient;
        }
    }
}
