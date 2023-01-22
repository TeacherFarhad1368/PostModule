using _Utilities.Infrastructure;
using PostModule.Domain.PostEntity;
using PostModule.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostModule.Infrastracture.EF.Repositories
{
    internal class PostPriceRepository : Repository<int,PostPrice> , IPostPriceRepository
    {
        private readonly Post_Context _context;
        public PostPriceRepository(Post_Context context) : base(context)
        {
            _context = context;
        }
    }
}
