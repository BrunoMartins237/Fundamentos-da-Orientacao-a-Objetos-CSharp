using System.Collections.Generic;
using SUPERMARKET1.Products.CleaningProduct;

namespace SUPERMARKET1.Sections.CleaningSection
{
    public class CleaningSection : GeneralSection
    {
        public CleaningSection(int lotNumber, 
        string sectionName, 
        string nameOfProduct) 
        : base(lotNumber, sectionName, nameOfProduct)
        {
            CleaningProducts = new List<CleaningProduct>();
        }
        public IList<CleaningProduct> CleaningProducts { get; set; }
    }
}