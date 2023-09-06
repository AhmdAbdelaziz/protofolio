using Serenity.Navigation;
using MyPages = AdminArea.onlinestore.Pages;

[assembly: NavigationLink(int.MaxValue, "onlinestore/Cart", typeof(MyPages.cartPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "onlinestore/Category", typeof(MyPages.categoryPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "onlinestore/Productimage", typeof(MyPages.productimagePage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "onlinestore/Products", typeof(MyPages.productsPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "onlinestore/Review", typeof(MyPages.reviewPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "onlinestore/Diagram", typeof(MyPages.diagramPage), icon: null)]