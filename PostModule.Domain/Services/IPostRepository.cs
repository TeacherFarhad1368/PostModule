using _Utilities.Domain;
using PostModule.Domain.PostEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostModule.Domain.Services
{
    public interface IPostRepository : IRepository<int,Post>
    {
    }
}
