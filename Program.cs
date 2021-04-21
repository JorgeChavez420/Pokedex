using System;

namespace Pokedex
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokedex pokedex = new Pokedex();

            RegistroPokemon charmander = new RegistroPokemon("Charmander", 4);
            RegistroPokemon squirtle = new RegistroPokemon("Squirtle", 7);

            pokedex.pokemon.Add(charmander);
            pokedex.pokemon.Add(squirtle);

            pokedex.pokemon.Add(new RegistroPokemon("Caterpie", 10));
            pokedex.pokemon.Add(new RegistroPokemon("Metapod", 11));
            pokedex.pokemon.Add(new RegistroPokemon("Charmeleon", 5));
            pokedex.pokemon.Add(new RegistroPokemon("Wartortle", 8));
            pokedex.pokemon.Add(new RegistroPokemon("Blastoise", 9));
            pokedex.pokemon.Add(new RegistroPokemon("Butterfree", 12));
            pokedex.pokemon.Add(new RegistroPokemon("Pikachu", 25));
            pokedex.pokemon.Add(new RegistroPokemon("Charizard", 6));


            RegistroPokemon resultadoBusquedaPorId = pokedex.ConsultarPorId(11);
            Console.WriteLine("Resultado de la búsqueda: " + resultadoBusquedaPorId.nombre);
            Console.WriteLine("------------------");
            
        }
    }
}
