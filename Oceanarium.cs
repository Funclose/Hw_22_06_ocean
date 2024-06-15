using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_22_06_ocean
{
    internal class Oceanarium : IEnumerable<SeaCreature>
    {
        public string Name { get; set; }
        public List<SeaCreature> SeaCreatures { get; set; }
        public Oceanarium(string name, List<SeaCreature> seaCreatures)
        {
            Name = name;
            SeaCreatures = seaCreatures;
        }
        public IEnumerator<SeaCreature> GetEnumerator()
        {
            foreach (var sea in SeaCreatures)
            {
                yield return sea;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
