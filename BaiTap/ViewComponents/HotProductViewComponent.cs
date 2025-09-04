using Microsoft.AspNetCore.Mvc;

namespace BaiTap.ViewComponents;

public class HotProductViewComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        var hotProducts = new List<string>
        {
            "Nồi cơm điện cao tần nagakawa ng1",
            "Nồi cơm điện cao tần nagakawa ng12",
            "Nồi cơm điện cao tần nagakawa ng13",
            "Nồi cơm điện cao tần nagakawa ng13"
        };

        return View(hotProducts);
    }
}
