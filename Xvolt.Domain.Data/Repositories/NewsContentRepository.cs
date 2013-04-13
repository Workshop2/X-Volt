using System.Collections.Generic;
using System.Linq;
using Xvolt.Domain.Models;
using Xvolt.Domain.Repositories;

namespace Xvolt.Domain.Data.Repositories
{
    public class NewsContentRepository : INewsContentRepository
    {
        public NewsContent Get(int id)
        {
            return List().First(x => x.Id == id);
        }

        public IEnumerable<NewsContent> List()
        {
            return new List<NewsContent>
            {
                new NewsContent
                {
                    Id = 1,
                    FullArticle = FullText,
                    TrimmedArticle = TrimmedText
                },
                new NewsContent
                {
                    Id = 2,
                    FullArticle = FullText,
                    TrimmedArticle = TrimmedText
                },
                new NewsContent
                {
                    Id = 3,
                    FullArticle = FullText,
                    TrimmedArticle = TrimmedText
                }
            };
        }

        public void Save(NewsContent user)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(NewsContent user)
        {
            throw new System.NotImplementedException();
        }

        private const string TrimmedText = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam nec congue sapien. Vestibulum eget metus est, a vulputate lacus. In et varius ante. Ut justo justo, tristique id consequat nec, tempor pretium nisl. Aliquam et magna neque. Praesent aliquam sagittis imperdiet. Pellentesque rutrum purus eget enim congue mattis. Sed sagittis aliquet neque, ut vehicula lacus dictum non. Proin sit amet nisl in enim faucibus tincidunt. Vivamus accumsan quam non sapien gravida faucibus. Vestibulum velit nibh, feugiat non luctus ac, cursus sit amet est. Maecenas pulvinar turpis felis. Cras augue eros, vulputate tincidunt tempus nec, eleifend vitae dolor. Praesent ut congue nulla.";
        private const string FullText = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam nec congue sapien. Vestibulum eget metus est, a vulputate lacus. In et varius ante. Ut justo justo, tristique id consequat nec, tempor pretium nisl. Aliquam et magna neque. Praesent aliquam sagittis imperdiet. Pellentesque rutrum purus eget enim congue mattis. Sed sagittis aliquet neque, ut vehicula lacus dictum non. Proin sit amet nisl in enim faucibus tincidunt. Vivamus accumsan quam non sapien gravida faucibus. Vestibulum velit nibh, feugiat non luctus ac, cursus sit amet est. Maecenas pulvinar turpis felis. Cras augue eros, vulputate tincidunt tempus nec, eleifend vitae dolor. Praesent ut congue nulla.

Nulla ac lectus at odio venenatis interdum. Praesent condimentum lobortis lacus, eu sagittis tortor pellentesque vitae. Quisque tincidunt enim et mauris accumsan sodales. Nulla quis sapien non diam placerat gravida. In in purus libero, tempor scelerisque nibh. Aliquam erat volutpat. Phasellus quis nunc lacus. Phasellus ligula felis, posuere quis porta a, adipiscing eget ante. Duis pellentesque vulputate auctor. Duis et odio nunc, pellentesque adipiscing erat. Mauris a feugiat nisi. Sed ut sem augue, et convallis lacus.

Nulla facilisi. Mauris quis neque eget ipsum scelerisque ornare ut et lorem. Praesent erat ligula, scelerisque sed faucibus faucibus, posuere non nunc. Aliquam nec risus non dolor gravida auctor id sed ipsum. Pellentesque nec quam tellus, et congue dolor. Duis non fermentum arcu. Duis fermentum ornare sem, sit amet mollis orci bibendum ac. Cras lobortis lectus eget massa faucibus bibendum.

Suspendisse potenti. Quisque tincidunt molestie odio, ut fermentum magna malesuada sit amet. Nunc erat purus, faucibus et feugiat eu, pharetra vel eros. Pellentesque non tortor sed mi aliquet gravida. Vivamus et nibh id sapien pulvinar venenatis at eu sem. Nunc erat diam, convallis vitae suscipit in, semper ut massa. Integer porta dictum tristique. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Donec posuere neque ac magna sodales id eleifend urna commodo. Cras eu facilisis ante. In lorem augue, mattis et ullamcorper eget, imperdiet eu lectus. Nulla neque sem, volutpat sit amet vehicula at, pellentesque a velit.

Phasellus tristique sem eget nisi iaculis dignissim. Nam ultrices est non mauris venenatis tempor. Nullam suscipit dolor a ligula suscipit molestie. Integer sit amet dolor leo. Fusce commodo felis pretium ante sodales eu scelerisque felis convallis. Phasellus ultrices arcu eget est tristique nec vulputate libero dapibus. In hac habitasse platea dictumst. Etiam et tortor nec ligula mollis tempus vitae vitae libero. Praesent eros urna, mollis id egestas ut, auctor nec justo. Vivamus at dui mi, at mattis mauris. Morbi ante orci, lacinia quis bibendum eget, eleifend non nisl.";
    }
}