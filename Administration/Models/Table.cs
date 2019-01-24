namespace Administration.Models
{
    public class Table
    {
        public int TableId { get; set; }

        public string TableNumber { get; set; }

        public static Table MapFromEntity(Infrastructure.Entities.Table entity)
        {
            return new Table
            {
                TableId = entity.Id,
                TableNumber = entity.TableNumber
            };
        }
    }
}