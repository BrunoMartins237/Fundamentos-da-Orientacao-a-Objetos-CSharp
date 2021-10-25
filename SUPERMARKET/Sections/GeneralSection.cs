namespace SUPERMARKET1.Sections
{
    public abstract class GeneralSection
    {
        protected GeneralSection(int lotNumber, 
        string sectionName, 
        string nameOfProduct)
        {
            LotNumber = lotNumber;
            SectionName = sectionName;
            NameOfProduct = nameOfProduct;
        }

        public int LotNumber { get; set; }
        public string SectionName { get; set; }
        public string NameOfProduct { get; set; }
    }
}