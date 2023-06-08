using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ctrlspec.Models;

namespace ctrlspec.Repository
{
    public interface ISpec
    {
          Task<IEnumerable<Spec_Option>> GetQuestions();
        Task<Spec_Option> AddSpec_Option (Spec_Option spec_Option);
        Task<Spec_Option> EditSpec_Option(double id, Spec_Option spec);
    }
}