using Microsoft.EntityFrameworkCore;

namespace NguyenTranHoangPhat_Dl1.Data
{
    public class CategoryContext : DbContext
    {
        public CategoryContext(DbContextOptions<CategoryContext> opt): base(opt) { 

        }

        #region DbSet
        public DbSet<Category>? Categories { get; set; }
        #endregion
    }
}
