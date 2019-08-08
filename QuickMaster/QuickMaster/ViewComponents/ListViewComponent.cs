using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuickMaster.Models;
using System.Linq;
using System.Threading.Tasks;

namespace QuickMaster.ViewComponents
{
    public class ListViewComponent : ViewComponent
    {
        private readonly BookContext _bookContext;

        // コンテキストクラスを有効化
        public ListViewComponent(BookContext context)
        {
            this._bookContext = context;
        }

        // ビューコンポーネントの実処理
        public async Task<IViewComponentResult>InvokeAsync(int price)
        {
            // price円以上の書籍を取得
            var reult = await _bookContext.Books.Where(b => b.Price >= price).ToListAsync();
            return View(reult);
        }

    }
}
