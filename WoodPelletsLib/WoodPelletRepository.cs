using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoodPelletsLib
{
    public class WoodPelletRepository
    {

        public List<WoodPellet> woodpellets = new List<WoodPellet>()
        {
            new WoodPellet(1, "BioWood", 4995, 4),
            new WoodPellet(2, "BioWood", 5195, 4),
            new WoodPellet(3, "BilligPille", 4125, 1),
            new WoodPellet(4, "GoldenWoodPellet", 5995, 5),
            new WoodPellet(5, "GoldenWoodPellet", 5795, 5)
        };

        public WoodPellet Add(WoodPellet woodpellet)
        {
            int newId = woodpellets.Count > 0 ? woodpellets.Max(p => p.Id) + 1 : 1;
            woodpellet.Id = newId;
            woodpellets.Add(woodpellet);
            return woodpellet;
        }


        public List<WoodPellet> GetAllPellets()
        {
            return new List<WoodPellet>(woodpellets);
        }
        

        public WoodPellet GetById(int id)
        {
            foreach (WoodPellet woodPellet in woodpellets)
            {
                if (woodPellet.Id == id)
                    return woodPellet;
            }
            throw new ArgumentException("Det søgte Id findes ikke");
        }

        public WoodPellet? Update(int id, WoodPellet updatedPellet)
        {
            WoodPellet? existingPellet = woodpellets.Find(p => p.Id == id);
            if (existingPellet != null)
            {
                existingPellet.Brand = updatedPellet.Brand;
                existingPellet.Price = updatedPellet.Price;
                existingPellet.Quality = updatedPellet.Quality;

                return existingPellet;
            }
            throw new ArgumentException("Palle findes ikke");

        }








    }
}
