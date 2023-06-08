using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ctrlspec.Data;
using ctrlspec.Models;
using Microsoft.EntityFrameworkCore;

namespace ctrlspec.Repository
{
    public class SpecRepository: ISpec
    {
       private CtrlSpecDbContext _context;

        public SpecRepository(CtrlSpecDbContext context)
        {
            _context = context;
        }

        public async Task<Spec_Option> GetSpec_Option(string questions)
        {
            var user = await _context.spec_Options.FirstOrDefaultAsync(x => x.Questions == questions);
            return user;
        }
     
        public async Task<Spec_Option> AddSpec_Option(Spec_Option spec)
        {
            await _context.spec_Options.AddAsync(spec);
            await _context.SaveChangesAsync();
            return spec;
        }

        public async Task<IEnumerable<Spec_Option>> GetQuestions()
        {
            try
            {
                return await _context.spec_Options.ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<Spec_Option> EditSpec_Option(double id, Spec_Option spec)
        {
            var formDetail = await _context.spec_Options.FirstOrDefaultAsync(x => x.Id == id);
            formDetail.Status = spec.Status;
            await _context.SaveChangesAsync();
            return formDetail;
            //  _context.Update(spec);
            // _context.SaveChanges();
            // return (spec);
        }

    }
}