namespace eForm.Data
{
    public class Product: BaseEntity
    {
        public string Name { get; set; }
        
        //foreign key
        public int ProductGroupId { get; set; }

        //relationship
        public virtual ProductGroup ProductGroup { get; set; }
    }
}
