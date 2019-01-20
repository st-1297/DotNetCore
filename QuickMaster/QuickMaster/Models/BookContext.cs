using Microsoft.EntityFrameworkCore;

namespace QuickMaster.Models
{
    // DbContextクラスを継承
    public class BookContext : DbContext
    {
        // コンストラクタ
        public BookContext(DbContextOptions<BookContext> options)
            : base(options) { }

        // モデルクラスへのアクセサ
        public DbSet<Book> Books { get; set; }
    }
}
