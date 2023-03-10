using _Utilities.Application;
using _Utilities.Infrastructure;
using PostModule.Application.Contract.PostApplication;
using PostModule.Domain.PostEntity;
using PostModule.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostModule.Infrastracture.EF.Repositories
{
    internal class PostRepository : Repository<int,Post> , IPostRepository
    {
        private readonly Post_Context _context;
        public PostRepository(Post_Context context) : base(context)
        {
            _context = context;
        }

        public List<PostModel> GetAllPosts()
        {
            return GetAllQuery().Select(p => new PostModel
            {
                CityPricePlus=p.CityPricePlus,
                CreationDate=p.CreateDate.ToPersainDate(),
                Id=p.Id,
                InsideStatePricePlus = p.InsideStatePricePlus,
                StateCenterPricePlus = p.StateCenterPricePlus,
                StateClosePricePlus=p.StateClosePricePlus,
                StateNonClosePricePlus=p.StateNonClosePricePlus,
                Status=p.Status,
                TehranPricePlus=p.TehranPricePlus,
                Title=p.Title,
                Description = p.Description,
                Active=p.Active,
                InsideCity=p.InsideCity,
                OutsideCity=p.OutSideCity
            }).ToList();
        }

        public EditPost GetForEdit(int id)
        {
            return _context.Posts.Select(p => new EditPost
            {
                CityPricePlus = p.CityPricePlus,
                Id = p.Id,
                InsideStatePricePlus = p.InsideStatePricePlus,
                StateCenterPricePlus = p.StateCenterPricePlus,
                StateClosePricePlus = p.StateClosePricePlus,
                StateNonClosePricePlus = p.StateNonClosePricePlus,
                Status = p.Status,
                TehranPricePlus = p.TehranPricePlus,
                Title = p.Title,
                Description = p.Description
            }).SingleOrDefault(p => p.Id == id);
        }
    }
}
