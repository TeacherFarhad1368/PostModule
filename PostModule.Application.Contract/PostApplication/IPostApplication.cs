using _Utilities.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostModule.Application.Contract.PostApplication
{
    public interface IPostApplication
    {
        OperationResult Create(CreatePost command);
        OperationResult Edit(EditPost command);
        EditPost GetForEdit(int id);
        List<PostModel> GetAll();
        bool ActivationChange(int id);
    }
}
