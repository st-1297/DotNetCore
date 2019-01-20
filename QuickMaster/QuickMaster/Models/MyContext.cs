using Microsoft.EntityFrameworkCore;

namespace QuickMaster.Models
{
    // DbContextクラスを継承
    public class MyContext : DbContext
    {
        // コンストラクタ
        public MyContext (DbContextOptions<MyContext> options)
            :base(options) { }

        // モデルクラスへのアクセサ
        public DbSet<Book>Book { get; set; }
    }
}
