using System;
using System.Collections.Generic;

namespace Pokedex
{
    class Pokedex
    {
        public List<RegistroPokemon> pokemon;

        public Pokedex()
        {
            pokemon = new List<RegistroPokemon>();
            //pokemon.Add(new RegistroPokemon("Charmander", 4));
            //pokemon.Add(new RegistroPokemon("Squirtle", 7));
            //pokemon.Add(new RegistroPokemon("Caterpie", 10));
            //pokemon.Add(new RegistroPokemon("Metapod", 11));
            //pokemon.Add(new RegistroPokemon("Charmeleon", 5));
            //pokemon.Add(new RegistroPokemon("Wartortle", 8));
            //pokemon.Add(new RegistroPokemon("Blastoise", 9));
            //pokemon.Add(new RegistroPokemon("Butterfree", 12));
            //pokemon.Add(new RegistroPokemon("Pikachu", 25));
            //pokemon.Add(new RegistroPokemon("Charizard", 6));
        
            
        }    
        public RegistroPokemon ConsultarPorId(int id)
        {
            for (int i = 0; i < pokemon.Count; i++)
            {
                Console.WriteLine("Buscando Pokemon...");

                if (pokemon[i].id == id)
                {
                    // Resultado encontrado!
                    return pokemon[i];
                }
            }

            return null;

        

        } 
    }
}        
